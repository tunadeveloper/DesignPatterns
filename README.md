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

## 🛠️ Kullanılan Teknolojiler
- ✅ **ASP.NET Core**
- ✅ **Entity Framework Core**
- ✅ **PostgreSQL / SQL Server**
- ✅ **Identity Framework (Observer Pattern)**
- ✅ **Clean Architecture yaklaşımı**

## 📌 Senaryo Bazlı Uygulamalar
- 1️⃣ **Chain of Responsibility**: Farklı yetki seviyelerine sahip çalışanlar tarafından müşteri işlemlerinin onaylanması.

  https://github.com/user-attachments/assets/a6b8d936-fbe9-4de0-aeff-5f09af74c89f
  
  ---
  
- 2️⃣ **CQRS**: Veritabanı işlemleri için ayrı komut ve sorgu modelleri kullanımı.

  https://github.com/user-attachments/assets/79d6024a-cd21-4f43-ab6c-81fbad2e71dd

---

- 3️⃣ **Template Method**: Netflix abonelik planlarının farklı kurallar ile uygulanması.

  https://github.com/user-attachments/assets/de0b297b-ff4e-4ddb-b5a6-c302815877ed

---

- 4️⃣ **Observer**: Kullanıcı kayıt olduğunda otomatik hoş geldin e-postası gönderilmesi.

  https://github.com/user-attachments/assets/5011467c-b036-4d53-b2df-fffdc7ecefc7

---

- 5️⃣ **Unit of Work**: Müşteri ve işlem verilerinin tek bir transaction ile kaydedilmesi.

  https://github.com/user-attachments/assets/9b4ac938-b940-4ff9-bc3b-fd086a04f742

---

- 6️⃣ **Repository**: Kategori verilerinin yönetimi ve erişiminin soyutlanması.
  
  https://github.com/user-attachments/assets/8eeadf25-34a4-4615-981f-85662f20c03b

---

- 7️⃣ **Composite**: Ürün kategorilerinin hiyerarşik olarak gösterilmesi.
  
  ![Image](https://github.com/user-attachments/assets/a7886aa9-f020-4860-8c37-67db165eaf5e)

  ---

- 8️⃣ **Mediator**: Komutlar ve sorguların MediatR ile yönetilmesi.

  https://github.com/user-attachments/assets/921bf771-f49a-405c-b7af-ad83e8a5f830

---

- 9️⃣ **Iterator**: Koleksiyonlardaki ürünlerin sıralı listelenmesi.

  ![Image](https://github.com/user-attachments/assets/4982ffe1-7bfd-46ca-a6d1-bffcd335f178)

---

- 🔟 **Facade**: Veritabanı işlemleri için sadeleştirilmiş servis arayüzü.

  https://github.com/user-attachments/assets/e75640c8-f99d-4c86-aa23-aadc2f504b1c

  ---

- 1️⃣1️⃣ **Decorator**: Mesaj gönderme işlemine dinamik davranış (loglama, doğrulama) eklenmesi.

  https://github.com/user-attachments/assets/26f34be9-8191-4eed-8f05-d1689540e7dd
