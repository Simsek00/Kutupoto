using System;
using System.Security.Cryptography;
using System.Text;

namespace Kutupoto.Model
{
    // Şifreleri PBKDF2 (SHA-256, rastgele salt) ile hashler ve doğrular.
    // Kayıt formatı: PBKDF2$<iterasyon>$<salt base64>$<hash base64>  (en fazla ~85 karakter, Sifre sütunu 100)
    internal static class SifreHash
    {
        const string Onek = "PBKDF2";
        const int Iterasyon = 100_000;
        const int SaltBoyutu = 16;
        const int HashBoyutu = 32;

        public static string Olustur(string sifre)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltBoyutu);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(sifre), salt, Iterasyon, HashAlgorithmName.SHA256, HashBoyutu);

            return string.Join("$", Onek, Iterasyon, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public static bool Dogrula(string sifre, string kayitliHash)
        {
            if (string.IsNullOrEmpty(kayitliHash)) return false;

            if (EskiFormatMi(kayitliHash))
            {
                // Eski kayıtlar tuzsuz SHA-256 hex olarak tutuluyordu.
                return string.Equals(EskiSha256(sifre), kayitliHash, StringComparison.OrdinalIgnoreCase);
            }

            string[] parcalar = kayitliHash.Split('$');
            if (parcalar.Length != 4 || parcalar[0] != Onek || !int.TryParse(parcalar[1], out int iterasyon)) return false;

            try
            {
                byte[] salt = Convert.FromBase64String(parcalar[2]);
                byte[] beklenen = Convert.FromBase64String(parcalar[3]);
                byte[] hesaplanan = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(sifre), salt, iterasyon, HashAlgorithmName.SHA256, beklenen.Length);

                return CryptographicOperations.FixedTimeEquals(hesaplanan, beklenen);
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // Eski SHA-256 kaydı mı? Öyleyse girişten sonra yeni formata yükseltilmelidir.
        public static bool EskiFormatMi(string kayitliHash)
        {
            return !kayitliHash.StartsWith(Onek + "$");
        }

        static string EskiSha256(string sifre)
        {
            return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(sifre)));
        }
    }
}
