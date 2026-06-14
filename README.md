# Email Validator ✉️

A simple email validation library written in C#.

> 🇹🇷 C#'ta yazılmış basit bir e-posta doğrulama kütüphanesi.

---

## What does it do? / Ne yapar?

It checks whether a given text is a valid email by verifying it contains both "@" and ".".

> 🇹🇷 Verilen bir metnin geçerli bir e-posta olup olmadığını, içinde "@" ve "." olup olmadığını
> kontrol ederek doğrular.

```csharp
var validator = new Validator();
validator.IsValid("test@example.com");  // true
validator.IsValid("invalid");           // false (no @ or .)
```

---

## How does it work? / Nasıl çalışır?

The `IsValid` method uses `string.Contains` to check for the required characters:

> 🇹🇷 `IsValid` metodu, gerekli karakterleri kontrol etmek için `string.Contains` kullanır:

```csharp
public bool IsValid(string email)
{
    return email.Contains("@") && email.Contains(".");
}
```

The `&&` (AND) operator means both conditions must be true.

> 🇹🇷 `&&` (VE) operatörü, iki şartın da doğru olması gerektiği anlamına gelir.

---

## What did I use? / Ne kullandım?

- **C# / .NET 9** — main language / ana dil
- **NUnit** — for tests / testler için
- **Visual Studio** — for writing code / kod yazmak için
- **Git** — for version control / sürüm kontrolü için

---

## Tests / Testler

Written using the AAA pattern (Arrange-Act-Assert):

> 🇹🇷 AAA deseni (Arrange-Act-Assert) ile yazıldı:

```csharp
[Test]
public void IsValid_ValidEmail_ReturnsTrue()
{
    var validator = new Validator();                      // Arrange
    bool result = validator.IsValid("test@example.com");  // Act
    Assert.That(result, Is.True);                         // Assert
}
```

Run tests with / Testleri çalıştır:
```bash
dotnet test
```

---

## What did I learn? / Ne öğrendim?

- **Namespace and class should not share the same name** — naming both "EmailValidator" confused the compiler, so I renamed the class to `Validator`.
  > 🇹🇷 **Namespace ile sınıf aynı adı taşımamalı** — ikisine de "EmailValidator" demek derleyiciyi şaşırttı, sınıfı `Validator` olarak değiştirdim.

- **Combining conditions with `&&`** — both "@" and "." must be present for a valid email.
  > 🇹🇷 **Şartları `&&` ile birleştirmek** — geçerli bir e-posta için hem "@" hem "." olmalı.

- **Writing tests with the AAA pattern** — Arrange, Act, Assert keeps tests clear and readable.
  > 🇹🇷 **AAA deseniyle test yazmak** — Arrange, Act, Assert testleri net ve okunabilir tutar.

- **Reading error messages** — the compiler tells you what's wrong; learning to read it is half the solution.
  > 🇹🇷 **Hata mesajlarını okumak** — derleyici neyin yanlış olduğunu söyler; onu okumayı öğrenmek çözümün yarısıdır.
