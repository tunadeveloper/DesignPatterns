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
![Image](https://github.com/user-attachments/assets/026480cb-6c5d-41bd-a741-7c944f8abd26)

---

- 💳 **Template Method**: Netflix abonelik planlarının farklı kurallar ile uygulanması.

![Image](https://github.com/user-attachments/assets/dc42c1b5-09bd-40c6-8717-4b8f19e71a4d)

---

- 📬 **Observer**: Kullanıcı kayıt olduğunda otomatik hoş geldin e-postası gönderilmesi.

![Image](https://github.com/user-attachments/assets/48faf75b-c6b9-42ca-846d-771774990af9)

---

- 📁 **Unit of Work**: Müşteri ve işlem verilerinin tek bir transaction ile kaydedilmesi.

![Image](https://github.com/user-attachments/assets/e40314a8-6e31-4c19-b189-ffb0b88703a5)

---

- 📚 **Repository**: Kategori verilerinin yönetimi ve erişiminin soyutlanması.
  
![Image](https://github.com/user-attachments/assets/4d065f62-0943-4211-b081-39e20f873808)

---

- 🌲 **Composite**: Ürün kategorilerinin hiyerarşik olarak gösterilmesi.
  
![Image](https://github.com/user-attachments/assets/94aaa893-9193-4782-b4c8-db0fc760a728)

  ---

- 📡 **Mediator**: Komutlar ve sorguların MediatR ile yönetilmesi.

![Image](https://github.com/user-attachments/assets/38de0b39-ba78-45b2-8a04-cbf93960603c)

---

- 🔍 **Iterator**: Koleksiyonlardaki ürünlerin sıralı listelenmesi.

![Image](https://github.com/user-attachments/assets/790753a7-7ae4-4b31-8156-b04baca4a4fe)

---

- 🧾 **Facade**: Veritabanı işlemleri için sadeleştirilmiş servis arayüzü.

![Image](https://github.com/user-attachments/assets/bf70058e-b8f9-4c2e-b146-556312b53752)

  ---

- 🧪 **Decorator**: Mesaj gönderme işlemine dinamik davranış (loglama, doğrulama) eklenmesi.

![Image](https://github.com/user-attachments/assets/37a0241f-7b6f-4090-89f7-833f44d0a4eb)

## 🛠️ Kullanılan Teknolojiler
- ✅ **ASP.NET Core**
- ✅ **Entity Framework Core**
- ✅ **PostgreSQL / SQL Server**
- ✅ **Identity Framework (Observer Pattern)**
- ✅ **Clean Architecture yaklaşımı**
