Asp.Net(.Net Framework) C# olan app i seçelim.
MVC
Model-View-Controller

Deneme Controller ına view eklemek için 
Deneme Metoduna sağ tık yapıp view i seçiyoruz.
View-Shared klasörü altında
Açılan pencerede layout page i seçiyoruz.
<li>@Html.ActionLink("Iletişim", "Contact", "Home")</li>
1."" Butonun üzerine yazmak istediğim ad
2."" Controller adı
3."" View içerisindeki hangi klasörde olduğunu belirtirim.
Deneme sayfasını navbar a eklemek için Layout sayfasında ilk olarak header kısmına buton ekledim.
<span class="icon-bar"></span>
sonra navbar kısmına satır ekledim.
<li>@Html.ActionLink("Deneme", "Deneme", "Home")</li>
Kendimiz test sayfası ekledik.
Yeni bir layout page yaptık.
Layout Page içine diğer sayfaların hangi alanda görüntüleneceğini belirtmek için @RenderBody() kodunu kullandık.

--Yeni bir LKayout nasıl oluşturduk--
shared folder a yeni bir view ekledik. use a layout page seçili değildi.
oluşan layout page e body içinde @renderBody kodunu yazdık.
homecontroller a yeni bir metod yazdık. bu metodun view ini oluşturduk ve bunu denemelayout a bağladık.

solution - add- new project - class library
projeye 4 katman ekledik.
1)Entity Layer (Tablolar->Class - Sutun->prop )
2)DataAccessLayer ( CRUD İşlemleri)
3)BusinessLayer ()
4)Presentations Layer (UI -UserInterface)

----Entity Layer----
Katmanın içine Concrete klasör oluşturduk.
	Oluşturulacak Tablo
			1.Writer
			2.Category
			3.Heading
			4.Content
			5.About
			6.Contact

---ilişki oluşturma
bire çok ilişkide
bir olan tarafa koleksiyon ekliyoruz.

 public ICollection<Heading> Headings{ get; set; }

 çok tarafına bağlanılacak olan tablonun classı ve sutunu eklenir.

 public int CategoryId { get; set; }//baglanacak sutun eklendi.
 public virtual Category Category { get; set; }

 -----------------------------------------------------------------------
 entityLayer içindeki referance sağ tıklayıp  Nuget e tıklayalım.
 browser a gelip entity freamwork yazıp version : 6.4.4 seçilp yüklenecek.

 -----------------------------------------------------------------------

 DataLayer sağ tıkladık
 Concrete Klasörü ekledik
 Context Class ı ekledik.


 ** katmanlar arası birbirinr referans verme yaptık

 Nuget den EntityFramework son sürümü yüklüyoruz.
 Referanslardan EntityLayer katmanını ekledik.
 DBContext i kalıtım olarak aldık.

 ---------UI--------------------

 Webconfig in içine connectionString ekledik.
 initial catalog içine veritabanına vermek istediğimiz name i verdik.

 Migrations Ekleme İşlemi
 View - Other Windows Package Manager Console a tıklıyoruz.







