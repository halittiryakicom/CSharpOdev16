# InheritanceExample
Bu projede patika dev .net-core e�itimi i�in C# dili kullanarak bir miras alma �rne�i yap�lm��t�r.
## ��erik


- [Kullan�m](#kullan�m-(usage))
- [Kod A��klamas�](#kod-a��klamas�)

## Kullan�m (Usage)

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

Yukar�daki kod blo�u BaseKisi s�n�f�ndan referans alm�� Ogretmen ve Ogrenci s�n�flar�n�n base s�n�fta bulunan  ad , soyad kavramlar�nda eri�ebilece�ini g�stermi�tir.

## Kod A��klamas�
BaseKisi Class
Ad, Soyad: BaseKisi s�n�f� i�in belirlenmi� property
Information(): Ad, Soyad bilgilerini yazd�rmak i�in kullan�lm�� bir s�n�f.

Ogrenci Class
BaseKisi'den kal�t�m al�nm�� bir s�n�f.
StudentNumber: ��renci i�in belirlenmi� bir property
StudentInformation(): ��renci bilgilerini yazd�rmak i�in i�erisinde Information() metodunu �a��r�yor.

Ogretmen Class
BaseKisi'den kal�t�m al�nm�� bir s�n�f.
Salary: ��retmen maa� property'si.
TeacherInformation(): ��retmen bilgilerini yazd�rmak i�in i�erisinde Information() metodunu �a��r�yor.
