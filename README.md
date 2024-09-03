<!DOCTYPE html>
<html lang="tr">
<body>

 <h1>CarRental Projesi</h1>
 <p>MY Yazılım Akademi bünyesinde Murat Yücedağ hocamız tarafından gerçekleştirilen ASP.NET Core eğitimine ait bir Araç Kiralama projesidir. Yapılan bu proje, akademi bünyesindeki 7.projedir.</p>
 <h2>Projeye Genel Bakış</h2>
<p>Kullanıcının belirli kriterlere göre yaptığı seçimlerin filtrelenerek uygun araçların listelendiği bir site tasarımı oluşturulmuştur. Tasarımda CQRS ve Mediator tasarım desenleri kullanılmıştır. CQRS tasarım
    deseni, yazma ve okuma işlemlerini birbirinden ayırarak modüler bir yapı sağlar, ayrıca okuma ve yazma işlemleri ayrı modellerde yer aldığı için performans optimizasyonu sağlanır. Mediator tasarım deseni ise
    iletişimin merkezi bir yapı üzerinden kontrol edilmesini sağlar, böylece bağımlılıklar azaltılarak esnek bir yapı oluşturulur. Marka ve Lokasyon modülleri CQRS tasarım deseniyle, Araç modülü ise Mediator tasarım
    deseniyle oluşturulmuştur. Basit bir admin paneliyle araç, lokasyon ve marka bilgileri yönetilmiştir.
</p>
<h2>Kullanılan Teknolojiler</h2>
<p>🟢 <b>ASP.NET Core 6.0 :</b> Platform bağımsız bir seçenek sunmasıyla öne çıkan .Net Core geliştirme ortamı, performans, modülerlik ve yenilikçi olması nedeniyle tercih edilmiştir.</p>
<p>🟢 <b>Entity Framework 6.0 :</b> Veritabanı ilişkisi için Object Relation Mapping(ORM) araçlarından biri olan Entity Framework kullanılmıştır.</p>
<p>🟢 <b>Code First Yaklaşımı :</b> Entityler ve diğer tüm yapılar, ORM Modelleme yöntemlerinden biri olan <b>Code First Yaklaşımı</b> ile oluşturulmuştur.</p>
<p>🟢 <b>Microsoft SQL Server :</b> Veritabanı yönetim sistemi olarak MSSQL kullanılmıştır.</p>
<p>🟢 <b>CQRS Tasarım Deseni :</b> Okuma ve yazma işlemlerinin ayrı modüller halinde yönetilmesini sağlayan ve sistem performansını iyileştiren bir tasarım desenidir.</p>
<p>🟢 <b>Mediator Tasarım Deseni :</b> İletişimin merkezi bir yapıyla sağlandığı, CQRS'teki kod yoğunluğunun azaltıldığı, esnek ve sürdürülebilir bir tasarım desenidir.</p>
<p>🟢 <b>Identity :</b> Projede, kullanıcı kimlik doğrulama ve yetkinlendirme yapmak için login ve register işlemlerinde kullanılmıştır.</p>
<p>🟢 <b>HTML-CSS-Bootstrap :</b> Frontend tarafındaki tasarımlar için HTML, CSS ve Bootstrap kullanılmıştır.</p>

<h2>Projeden Görüntüler</h2>

<h3>Veritabanı</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/Database_Diagram.jpg">

<h3>Login Sayfası</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/Login_Page.jpg">

<h3>Register Sayfası</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/Register_Page.jpg">

<h3>Anasayfa</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/Main_Page.jpeg">

<h3>Arama Kriteri</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/ExistCar.jpg">

<h3>Araç Bulunamadı Durumu</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/NotFound.jpeg">

<h3>Araç Bulundu Durumu</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/CarFounded.jpeg">

<h3>Araç Detay</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/CarModal.jpeg">

<h3>Admin - Araç Listesi</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/CarList.jpg">

<h3>Admin - Lokasyon Listesi</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/LocationList.jpg">

<h3>Admin - Marka Listesi</h3>
<img src="https://github.com/turkay-sagir/CarRental/blob/master/CarRental/wwwroot/ProjectImages/BrandList.jpg">

</body>
</html>
