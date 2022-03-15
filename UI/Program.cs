using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Repositories;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new TestEntityContext();

            bool exit = false;
            bool exit2 = false;

            Regex rg = new Regex(@"[a-z]");

            Land gekozeland = null;

            while (exit == false)
            {
                exit2 = false;

                Console.WriteLine("");
                Console.WriteLine("l:landlijst");
                Console.WriteLine("x:exit");
                Console.WriteLine("geef je keuze:");
                string keuze = Console.ReadLine();

                switch (keuze)
                {

                    case "l":

                        var landen = from land in context.Land orderby land.Naam select land;

                        foreach (var land in landen)
                        {
                            Console.WriteLine($"{land.ISOLandCode} \t\t {land.Naam} \t\t {land.Oppervlakte} \t\t {land.AantalInwoners}");
                        }

                        //land keuze
                        gekozeland = null;
                        while (gekozeland == null)
                        {

                            Console.WriteLine("geef een landcode in:");
                            string landcode = Console.ReadLine();

                            gekozeland = context.Land.Find(landcode);
                        }



                        //menu land

                        while (exit2 == false)
                        {

                            Console.WriteLine("-------------------------");
                            Console.WriteLine($"je hebt {gekozeland.Naam} gekozen");
                            Console.WriteLine("-------------------------");

                            Console.WriteLine("w: wijzig land");
                            Console.WriteLine("s: lijst steden");
                            Console.WriteLine("a: lijst talen");
                            Console.WriteLine("t: stad toevoegen");
                            Console.WriteLine("v: stad verwijderen");
                            Console.WriteLine("x: exit");

                            Console.WriteLine("geef je keuze:");
                            string keuze1 = Console.ReadLine();

                            switch (keuze1)
                            {
                                case "w":

                                    Console.WriteLine($"aantal inwooners {gekozeland.AantalInwoners}");
                                    Console.WriteLine($"oppervlakte {gekozeland.Oppervlakte}");
                                    Console.WriteLine("");
                                error1:
                                    Console.WriteLine("nieuw aantal inwoners:");
                                    try
                                    {
                                        gekozeland.AantalInwoners = int.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("moet een int zijn");
                                        goto error1;
                                    }
                                error2:
                                    Console.WriteLine("nieuw oppervlakte:");
                                    try
                                    {
                                        gekozeland.Oppervlakte = float.Parse(Console.ReadLine());
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("moet een float zijn");
                                        goto error2;
                                    }
                                    context.SaveChanges();

                                    break;


                                case "s":

                                    var steden = from stad in context.Stad where stad.ISOLandCode == gekozeland.ISOLandCode select stad;

                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("lijst steden");
                                    Console.WriteLine("-------------------------");

                                    foreach (var stad in steden)
                                    {
                                        Console.WriteLine(stad.Naam);
                                    }

                                    break;
                                case "a":
                                    var talenland = from talen in context.LandTaal.Include(t => t.Taal) where talen.ISOLandCode == gekozeland.ISOLandCode select talen;

                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("lijst talen");
                                    Console.WriteLine("-------------------------");

                                    foreach (var taalland in talenland)
                                    {
                                        Console.WriteLine($"{taalland.Taal.ISOTaalCode} {taalland.Taal.NaamTaal}");
                                    }


                                    break;
                                case "t":
                                    Console.WriteLine("geef de stad naam");
                                    string naamStad = Console.ReadLine();

                                    var stedenZelfde = from stad in context.Stad where stad.Naam == naamStad select stad;



                                    if (stedenZelfde.Count() == 0)
                                    {
                                        if (rg.IsMatch(naamStad))
                                        {
                                            gekozeland.Steden.Add(new Stad { Land = gekozeland, Naam = naamStad });

                                            context.SaveChanges();
                                        }
                                        else
                                        {
                                            Console.WriteLine("stad moet een naam hebben");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("deze stad bestaat al");
                                    }

                                    break;
                                case "v":

                                    var steden1 = from stad in context.Stad where stad.ISOLandCode == gekozeland.ISOLandCode select stad;

                                    Console.WriteLine("-------------------------");
                                    Console.WriteLine("lijst steden");
                                    Console.WriteLine("-------------------------");

                                    foreach (var stad in steden1)
                                    {
                                        Console.WriteLine(stad.Naam);
                                    }

                                    Console.WriteLine("");
                                    Console.WriteLine("welke stad wil je verwijderen?");
                                    string gekozenStad = Console.ReadLine();

                                    var stadVer = (from stad in context.Stad where stad.Naam == gekozenStad select stad).FirstOrDefault();
                                    if (stadVer != null)
                                    {
                                        context.Stad.Remove(stadVer);
                                        context.SaveChanges();
                                    }
                                    else
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("deze stad bestaad niet");
                                        Console.WriteLine("");
                                    }

                                    break;




                                case "x":
                                    exit2 = true;
                                    break;

                            }


                        }

                        break;
                    case "x":
                        exit = true;
                        break;
                }



            }
        }
    }
}
