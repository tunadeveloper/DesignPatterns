# 🎯 ASP.NET Core Design Patterns

<p align="center"> 
  <img src="https://img.shields.io/badge/.NET-3.1%2C%205.0%2C%206.0%2C%207.0%2C%208.0%2C%209.0-purple?style=flat-square&logo=dotnet" /> 
  <img src="https://img.shields.io/badge/architecture-clean--code-blue?style=flat-square" /> 
  <img src="https://img.shields.io/badge/layered--architecture-✔️-green?style=flat-square" /> 
</p>

Bu proje, ASP.NET Core kullanılarak geliştirilmiş, yazılım mimarisinde sıkça karşılaşılan 11 farklı tasarım deseninin (Design Patterns) nasıl uygulanabileceğini gösteren kapsamlı örnekleri içermektedir. Her desen, gerçek dünyadan ilham alınmış senaryolarla birlikte yapılandırılmış ve ilgili .NET sürümüne göre ayrı ayrı projelendirilmiştir.


## 🧩 Uygulanan Tasarım Desenleri

| 🔢 #  | 🎨 Pattern Adı             | 💡 Kısa Açıklama                                                         | 🧪 .NET Sürümü |
|-------|---------------------------|---------------------------------------------------------------------------|----------------|
| 1     | 🔗 Chain of Responsibility | İstekleri zincir halinde nesneler arasında yönlendirerek işlenmesini sağlar. | .NET 5.0       |
| 2     | ⚔️ CQRS                   | Veri okuma ve yazma işlemlerini ayırarak daha esnek yapı sunar.             | .NET Core 3.1  |
| 3     | 📄 Template Method        | Algoritmanın iskeletini sabit tutarken, alt adımları alt sınıflara bırakır. | .NET 5.0       |
| 4     | 👁️ Observer               | Bir nesnedeki değişiklikleri bağlı nesnelere otomatik bildirir.            | .NET 5.0       |
| 5     | 💼 Unit of Work           | Transaction işlemlerini gruplar, veritabanı tutarlılığı sağlar.             | .NET 5.0       |
| 6     | 📦 Repository             | Veri erişim katmanını soyutlayarak kolay test edilebilir yapı sunar.        | .NET 8.0       |
| 7     | 🌳 Composite              | Nesneleri hiyerarşik (ağaç) yapıda işler, tekil ve grup nesneleri aynı şekilde ele alır. | .NET 6.0 |
| 8     | 🧭 Mediator               | Nesneler arası iletişimi merkezi bir arabulucu nesne ile yönetir (örnek: MediatR). | .NET 7.0 |
| 9     | 🔁 Iterator               | Koleksiyon elemanlarına sıralı erişim sağlar.                               | .NET 9.0       |
| 10    | 🏛️ Facade                 | Alt sistemlerin karmaşıklığını sadeleştirip tek bir arabirim sağlar.        | .NET 6.0       |
| 11    | 🎨 Decorator              | Nesnelere çalışma zamanında dinamik olarak yeni yetenekler kazandırır.     | .NET 5.0       |

## 📌 Senaryo Bazlı Uygulamalar
- 🧑‍💼 **Chain of Responsibility**: Farklı yetki seviyelerine sahip çalışanlar tarafından müşteri işlemlerinin onaylanması.
- 📊 **CQRS**: Veritabanı işlemleri için ayrı komut ve sorgu modelleri kullanımı.
- 💳 **Template Method**: Netflix abonelik planlarının farklı kurallar ile uygulanması.
- 📬 **Observer**: Kullanıcı kayıt olduğunda otomatik hoş geldin e-postası gönderilmesi.
- 📁 **Unit of Work**: Müşteri ve işlem verilerinin tek bir transaction ile kaydedilmesi.
- 📚 **Repository**: Kategori verilerinin yönetimi ve erişiminin soyutlanması.
- 🌲 **Composite**: Ürün kategorilerinin hiyerarşik olarak gösterilmesi.
- 📡 **Mediator**: Komutlar ve sorguların MediatR ile yönetilmesi.
- 🔍 **Iterator**: Koleksiyonlardaki ürünlerin sıralı listelenmesi.
- 🧾 **Facade**: Veritabanı işlemleri için sadeleştirilmiş servis arayüzü.
- 🧪 **Decorator**: Mesaj gönderme işlemine dinamik davranış (loglama, doğrulama) eklenmesi.

## 🛠️ Kullanılan Teknolojiler
- ✅ **ASP.NET Core**
- ✅ **Entity Framework Core**
- ✅ **PostgreSQL / SQL Server**
- ✅ **Identity Framework (Observer Pattern)**
- ✅ **Clean Architecture yaklaşımı**
