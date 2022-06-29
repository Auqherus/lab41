using lab41.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace lab41.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(string wartosc)
        {
            {

                List<Student> stud = new List<Student>
        {
        new Student { indeks=1, Imie="Patryk", Nazwisko="Romanowski", Adres = "Gdańsk, Morena 16", Wiek = 28 },
        new Student { indeks=2, Imie="Artur", Nazwisko="Januszkiewicz", Adres = "Gdynia, Akacjowa 12" , Wiek = 25 },
        new Student { indeks=3, Imie="Maciej", Nazwisko="Smolak", Adres = "Sopot, Potęgowa 2", Wiek = 27 },
        new Student { indeks=4, Imie="Piotr", Nazwisko="Brosz", Adres = "Gdynia, Armi Krajowej 45", Wiek = 32 },
        new Student { indeks=5, Imie="Jacek", Nazwisko="Leuta", Adres = "Sopot, 1 Maja 56", Wiek = 31 },
        new Student { indeks=6, Imie="Szymon", Nazwisko="Rynkowski", Adres = "Gdańsk, Żabianka 15", Wiek = 29 },
        new Student { indeks=7, Imie="Krzysztof", Nazwisko="Bill", Adres = "Elbląg, 12 lutego", Wiek = 26 }
        };
                ViewData.Model = stud;
                var nazwisko = stud.Where(x => x.Nazwisko == (Convert.ToString(wartosc)) || wartosc == null).ToList();
                if (Request.IsHttps)
                {
                    return PartialView("Detal", nazwisko);
                }
                return View(nazwisko);



            }
        }
    }
}
