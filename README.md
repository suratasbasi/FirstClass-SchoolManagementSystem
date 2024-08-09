# FirstClass-SchoolManagementSystem

Bu proje, bir okul yönetim sistemi oluşturmayı amaçlamaktadır. Proje kapsamında, `Person` adında bir genel sınıf tanımlanmış ve bu sınıf öğretmenler ve öğrenciler için kullanılmıştır. Öğretmen ve öğrencilerin ad, soyad ve doğum tarihi bilgileri yönetilmektedir.


## Özellikler

- **Person Sınıfı**:
  - `name`: Kişinin adı.
  - `surname`: Kişinin soyadı.
  - `dateOfBirth`: Kişinin doğum tarihi (`DateTime` türünde).
  - `Name`: Ad property (get/set).
  - `Surname`: Soyad property (get/set).
  - `DateOfBirth`: Doğum tarihi property (get/set).
  - `TeacherInformation`: Öğretmen bilgilerini konsola yazdıran metot.
  - `StudentInformation`: Öğrenci bilgilerini konsola yazdıran metot.

## Kullanılan Teknolojiler

- **C#**
- **.NET Core**
- **Visual Studio/Visual Studio Code**

## Kullanım

Projede, `Main` metodu içinde birkaç öğretmen ve öğrenci nesnesi oluşturulmuş ve bu nesnelerin bilgileri konsola yazdırılmıştır.

## Nasıl Çalıştırılır?

1. Projeyi yerel makinenize klonlayın veya indirin.
2. Visual Studio veya Visual Studio Code gibi bir C# geliştirme ortamında projeyi açın.
3. `Program.cs` dosyasını çalıştırarak öğretmen ve öğrenci bilgilerini konsola yazdırın.

## Çıktı

**Program çalıştırıldığında, aşağıdaki çıktı elde edilecektir:**

Öğretmenin adı ve soyadı: Hürrem Sultan
Doğum tarihi: 27.08.1510

Öğretmenin adı ve soyadı: Mahidevran Sultan
Doğum tarihi: 13.03.1505

Öğrencinin adı ve soyadı: Mihrimah Sultan
Doğum tarihi: 03.11.1530

Öğrencinin adı ve soyadı: Şehzade Mustafa
Doğum tarihi: 22.02.1525
