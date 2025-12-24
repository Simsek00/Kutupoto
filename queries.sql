--Mehmet Okur 21118080088     Muhammed Çaðlar 21118080021
--Oluþturulan tablolar KOSDB.sql dosyasýnýn içindedir. Burada sadece queryler listelenecektir.
--Projenin içinde kullandýðýmýz tüm queryler burda listelenmiþtir

--Queries in Giris.cs
select * from kullanicilar where KullaniciAdi = @KullaniciAdi and Sifre = @Sifre


--Queries in Kayýt.cs
insert into kullanicilar (adi, soyadi, KullaniciAdi, Sifre) values (@adi, @soyadi, @KullaniciAdi, @Sifre)


--Queries in AnaSayfa.cs
                
                select 
                    emanetler.id, 
                    kitaplar.kitapAdi as 'Kitap Adý', 
                    (okuyucular.adi + ' ' + okuyucular.soyadi) as 'Okuyucu', 
                    emanetVerilisTarihi as 'Veriliþ Tarihi', 
                    emanetGeriAlmaTarihi as 'Geri Alýnacak Tarih' 
                from emanetler 
                join kitaplar on emanetler.kitapId = kitaplar.id 
                join okuyucular on emanetler.okuyucuId = okuyucular.id 
                where emanetler.aktif = 1 and emanetler.durum = 0;

select * from kitaplar where aktif = 1 and durum = 1;
select * from okuyucular where aktif = 1;
(kitapAdi LIKE '%{0}%' OR yazarAdi LIKE '%{0}%' OR Convert(kayitNo, 'System.String') LIKE '%{0}%');


--Queries in Kiralama.cs
select * from okuyucular where aktif = 1 and id = @id;
select * from kitaplar where aktif = 1 and id = @id;
select * from okuyucular where aktif = 1;
select * from kitaplar where aktif = 1 and durum = 1;

"update kitaplar set durum = 0 where id = @kitapId"  +
                "insert into emanetler (kitapId, okuyucuId, emanetVerilisTarihi, emanetGeriAlmaTarihi) values (@kitapId, @okuyucuId, @emanetVerilisTarihi, @emanetGeriAlmaTarihi)"

UPDATE emanetler SET emanetGeriAlmaTarihi = DATEADD(day, 30, emanetGeriAlmaTarihi) WHERE id = @emanetId;

"update kitaplar set durum = 1 where id = @kitapId " +
                "update emanetler set emanetIslemTarihi = @emanetIslemTarihi, durum = 1 where kitapId = @kitapId"

select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1;
select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1;
select * from emanetler where okuyucuId = @id and durum = 0 and aktif = 1;


--Queries in KitapEkle.cs
select * from kitaplar where aktif = 1 ORDER BY kayitNo ASC;
SELECT ISNULL(MAX(kayitNo), 0) FROM kitaplar;
insert into kitaplar (kayitNo, kitapAdi, yazarAdi, sayfaSayisi, tur, yayinevi, basimYili, dolapNo, rafNo) values (@kayitNo, @kitapAdi, @yazarAdi, @sayfaSayisi, @tur, @yayinevi, @basimYili, @dolapNo, @rafNo);
update kitaplar set kitapAdi = @kitapAdi, yazarAdi = @yazarAdi, sayfaSayisi = @sayfaSayisi, tur = @tur, yayinevi = @yayinevi, basimYili = @basimYili, dolapNo = @dolapNo, rafNo = @rafNo where id = @id;
delete from kitaplar where id = @id;
UPDATE kitaplar SET kayitNo = kayitNo - 1 WHERE kayitNo > @silinenNo;

--Queries in OkuyucuEkle.cs
insert into okuyucular (adi, soyadi, cinsiyeti, sinifi, okulNo, cepTel, adres) values (@adi, @soyadi, @cinsiyeti, @sinifi, @okulNo, @cepTel, @adres) select @@IDENTITY;
update okuyucular set adi = @adi, soyadi = @soyadi, cinsiyeti = @cinsiyeti, sinifi = @sinifi, okulNo = @okulNo, cepTel = @cepTel, adres = @adres where id = @id;
select * from okuyucular where aktif = 1;
update okuyucular set aktif = 0 where id = @id;
select * from okuyucular where aktif = 1 and id = @id;
