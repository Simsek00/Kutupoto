--Mehmet Okur 21118080088     Muhammed Çağlar 21118080021
--Oluşturulan tablolar KOSDB.sql dosyasının içindedir. Burada sadece queryler listelenecektir.
--Projenin içinde kullandığımız tüm queryler burda listelenmiştir

--Queries in Giris.cs
select id, Sifre from kullanicilar where KullaniciAdi = @KullaniciAdi;
-- Şifre kodda doğrulanır (Model/SifreHash.cs). Eski SHA-256 hash'li kayıtlar girişten sonra PBKDF2'ye yükseltilir:
update kullanicilar set Sifre = @Sifre where id = @id;


--Queries in Kayıt.cs
select count(*) from kullanicilar where KullaniciAdi = @KullaniciAdi;
insert into kullanicilar (adi, soyadi, KullaniciAdi, Sifre) values (@adi, @soyadi, @KullaniciAdi, @Sifre);


--Queries in AnaSayfa.cs
select 
    emanetler.id, 
    kitaplar.kitapAdi as 'Kitap Adı', 
    (okuyucular.adi + ' ' + okuyucular.soyadi) as 'Okuyucu', 
    emanetVerilisTarihi as 'Veriliş Tarihi', 
    emanetGeriAlmaTarihi as 'Geri Alınacak Tarih' 
from emanetler 
join kitaplar on emanetler.kitapId = kitaplar.id 
join okuyucular on emanetler.okuyucuId = okuyucular.id 
where emanetler.aktif = 1 and emanetler.durum = 0;

select * from kitaplar where aktif = 1 and durum = 1;
select * from okuyucular where aktif = 1;
-- DataView.RowFilter ifadesi (SQL Server'a gitmez, bellekteki tabloda çalışır):
(kitapAdi LIKE '%{0}%' OR yazarAdi LIKE '%{0}%' OR Convert(kayitNo, 'System.String') LIKE '%{0}%') AND tur = '{1}';


--Queries in Kiralama.cs
select * from okuyucular where aktif = 1 and id = @id;
select * from kitaplar where aktif = 1 and id = @id;
select * from okuyucular where aktif = 1;
select * from kitaplar where aktif = 1 and durum = 1;

-- Emanet verme (tek transaction)
set xact_abort on; begin tran;
update kitaplar set durum = 0 where id = @kitapId;
insert into emanetler (kitapId, okuyucuId, emanetVerilisTarihi, emanetGeriAlmaTarihi) values (@kitapId, @okuyucuId, @emanetVerilisTarihi, @emanetGeriAlmaTarihi);
commit tran;

-- Süre uzatma
UPDATE emanetler SET emanetGeriAlmaTarihi = DATEADD(day, 30, emanetGeriAlmaTarihi) WHERE id = @emanetId;

-- İade (tek transaction, sadece açık emanet kapatılır)
set xact_abort on; begin tran;
update kitaplar set durum = 1 where id = @kitapId;
update emanetler set emanetIslemTarihi = @emanetIslemTarihi, durum = 1 where id = @emanetId;
commit tran;

select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1;


--Queries in KitapEkle.cs
select * from kitaplar where aktif = 1 ORDER BY kayitNo ASC;
SELECT ISNULL(MAX(kayitNo), 0) FROM kitaplar;
insert into kitaplar (kayitNo, kitapAdi, yazarAdi, sayfaSayisi, tur, yayinevi, basimYili, dolapNo, rafNo) values (@kayitNo, @kitapAdi, @yazarAdi, @sayfaSayisi, @tur, @yayinevi, @basimYili, @dolapNo, @rafNo);
update kitaplar set kitapAdi = @kitapAdi, yazarAdi = @yazarAdi, sayfaSayisi = @sayfaSayisi, tur = @tur, yayinevi = @yayinevi, basimYili = @basimYili, dolapNo = @dolapNo, rafNo = @rafNo where id = @id;
-- Silme: önce emanette mi kontrol edilir, sonra soft delete yapılır
select count(*) from emanetler where kitapId = @id and durum = 0 and aktif = 1;
update kitaplar set aktif = 0 where id = @id;


--Queries in OkuyucuEkle.cs
insert into okuyucular (adi, soyadi, cinsiyeti, sinifi, okulNo, cepTel, adres) values (@adi, @soyadi, @cinsiyeti, @sinifi, @okulNo, @cepTel, @adres) select @@IDENTITY;
update okuyucular set adi = @adi, soyadi = @soyadi, cinsiyeti = @cinsiyeti, sinifi = @sinifi, okulNo = @okulNo, cepTel = @cepTel, adres = @adres where id = @id;
select * from okuyucular where aktif = 1;
-- Silme: önce iade edilmemiş kitabı var mı kontrol edilir, sonra soft delete yapılır
select count(*) from emanetler where okuyucuId = @id and durum = 0 and aktif = 1;
update okuyucular set aktif = 0 where id = @id;
select * from okuyucular where aktif = 1 and id = @id;
