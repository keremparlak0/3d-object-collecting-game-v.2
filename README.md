## Oynanış:

- Karakterimiz bir platforma iniyor ve indiği yüzeye -rastgele konumlarda- kutucuklar iniyor. İki tür kutucuk iniyor; birisi puan toplamamıza yarayan sarı kutucuklar,
 diğeri ise toplamamızın yasak olduğu kırmızı kutucuklar. Sarı kutucuk bize +1 puan sağlarken, kırmızı kutucuklar 1 puan düşürüyor. Eğer puanımız 0'ın altına düşecek olursa oyun tekrardan
başlatılıyor.
- İlk seviyede 2 kutucuk toplandığında ikiye, toplam 4 kutucuk olduğunda ise son seviyeye geliyor.
- Platformumuz sonlu bir yüzeye sahip. Bu yüzden karakterin hareket alanı sınırlı ve eğer platformdan düşecek olursa oyun tekrar başlatılıyor.
- Oyunu durdurmak veya yeniden başlatmak istersek, 'esc' tuşuna basmamız yeterli. Bu bize içinde 'Devam Et', 'Yeniden Başlat' ve 'Ana Menü' butonları bulunan bir duraklat menüsü açacak ve işlemlerimizi buradan gerçekleştirebiliriz.
Tekrar 'esc' tuşuna basarak devam edebiliriz.(Oyuna başlamadan oyun ekranına mause'un sol tuşuyla tıklamamız gerekiyor.)

### Tuşlar:

 > w: Karakteri ileri hareket ettirir.
 > s: Karakteri geri hareket ettirir.
 > a: Karakteri sola hareket ettirir.
 > d: Karakteri sağa hareket ettirir.

![alt text](https://i.hizliresim.com/dgsim79.png)

## [Oyunu oynamak için tıklayınız...](https://receponur07.itch.io/3d-advanced-object-collecting-game)

>Önceki Projeye Ek Olarak:
### Kazandırdığım mekanikler:

- Ana Menü ekledim.
- 2 tane daha sahne ekleyip bunları level şeklinde formatladım ve bu sahneler arasında asenkron geçiş sağladım. Hedef tamamlandığında ikici sahneye asenkron geçiş özelliğini sağladım.
- Durdur Menü'sünden Ana Menü'ye asenkron geçiş sağladım ve ilgili butonları ekledim.
- Sayaç kısmında ise "PlayerPrefs" fonksiyonunu kullanarak verilerin kaydedilmesini sağladım. Bu sayede oyuna kadlığımız seviyeden devam etme ve topladığımız kutucuk sayılarının sabit kalması özelliğini getidim.
- Ana Menüdeki "Devam Et" butonunu güncelledim.(Veri yokken "reject" olacak ve eğer oyunda yeni seviyeye geçilecekse oradan tekrar kayıt alacak.)

### Ekip arkadaşım Recep Onur OKAN'ın Projeye Kazandırdıkları:
- Oyuncuya animasyon atama ve gerekli hareket kombinasyonlarını düzenleme,
- Projeye ses ekleme,
- Eklenen sesi tüm sahnelerde tek bir şekilde çalma ve yasaklı kutucuğa çarptığında ses çıkarması ekip arkadaşımın projeye genel hatlarıyla kazandırdıklarıdır.
