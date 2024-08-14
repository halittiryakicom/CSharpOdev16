# InheritanceExample
Bu projede patika dev .net-core eðitimi için C# dili kullanarak bir miras alma örneði yapýlmýþtýr.
## Ýçerik


- [Kullaným](#kullaným-(usage))
- [Kod Açýklamasý](#kod-açýklamasý)

## Kullaným (Usage)

using System;
namespace InheritanceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student ogrenci1 = new Student();
            ogrenci1.Name = "Halit";
            ogrenci1.LastName = "Tiryaki";
            ogrenci1.StudentNumber = "432";
            ogrenci1.StudentInformation();


            Teacher ogretmen1 = new Teacher();
            ogretmen1.Name = "Halit";
            ogretmen1.LastName = "Tiryaki";
            ogretmen1.Salary = 30000;
            ogretmen1.TeacherInformation();
        }
    }
}

Yukarýdaki kod bloðu BaseKisi sýnýfýndan referans almýþ Ogretmen ve Ogrenci sýnýflarýnýn base sýnýfta bulunan  ad , soyad kavramlarýnda eriþebileceðini göstermiþtir.

## Kod Açýklamasý
BaseKisi Class
Ad, Soyad: BaseKisi sýnýfý için belirlenmiþ property
Information(): Ad, Soyad bilgilerini yazdýrmak için kullanýlmýþ bir sýnýf.

Ogrenci Class
BaseKisi'den kalýtým alýnmýþ bir sýnýf.
StudentNumber: Öðrenci için belirlenmiþ bir property
StudentInformation(): Öðrenci bilgilerini yazdýrmak için içerisinde Information() metodunu çaðýrýyor.

Ogretmen Class
BaseKisi'den kalýtým alýnmýþ bir sýnýf.
Salary: Öðretmen maaþ property'si.
TeacherInformation(): Öðretmen bilgilerini yazdýrmak için içerisinde Information() metodunu çaðýrýyor.
