
// See https://aka.ms/new-console-template for more information
using RettangoliVari;
using System;

Console.WriteLine("Hello, World!");



//Rettangoli
Console.WriteLine("Inserisci la base: ");
int baseR = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza: ");
int altezzaR = int.Parse(Console.ReadLine());
Rettangolo rettangoloUser = new Rettangolo(baseR, altezzaR);
rettangoloUser.stampaRettangolo();

Console.WriteLine("--------------");
Console.WriteLine("--------------");
Console.WriteLine("--------------");
Console.WriteLine("--------------");
Console.WriteLine("--------------");
Console.WriteLine("--------------");



Rettangolo rettangoloClassico = new Rettangolo(20, 10);
Console.WriteLine("ATTRIBUTI DEL RETTANGOLO CLASSICO: ");
Console.WriteLine("La Base del rettangolo classico è di: " + rettangoloClassico.baseRettangolo + " Cm");
Console.WriteLine("L'altezza del rettangolo classico è di: " + rettangoloClassico.altezzaRettangolo + " Cm");

Console.WriteLine("Il perimetro del rettangolo classico è di: " + rettangoloClassico.calcolaPerimetro());
Console.WriteLine("L'area del rettangolo classico è di: " + rettangoloClassico.calcolaArea());

Rettangolo rettangoloGrande = new Rettangolo(30, 15);
Console.WriteLine("ATTRIBUTI DEL RETTANGOLO GRANDE: ");
Console.WriteLine("La Base del rettangolo piccolo è di: " + rettangoloGrande.baseRettangolo + " Cm");
Console.WriteLine("L'altezza del rettangolo classico è di: " + rettangoloGrande.altezzaRettangolo + " Cm");

Console.WriteLine("Il perimetro del rettangolo grande è di: " + rettangoloGrande.calcolaPerimetro());
Console.WriteLine("L'area del rettangolo grande è di: " + rettangoloGrande.calcolaArea());

Rettangolo rettangoloPiccolo = new Rettangolo(10, 5);
Console.WriteLine("ATTRIBUTI DEL RETTANGOLO PICCOLO: ");
Console.WriteLine("La base del rettangolo piccolo è di: " + rettangoloPiccolo.baseRettangolo + " Cm");
Console.WriteLine("L'altezza del rettangolo piccolo è di: " + rettangoloPiccolo.altezzaRettangolo + " Cm");

Console.WriteLine("Il perimetro del rettangolo piccolo è di: " + rettangoloPiccolo.calcolaPerimetro());
Console.WriteLine("L'area del rettangolo piccolo è di: " + rettangoloPiccolo.calcolaArea());


rettangoloClassico.stampaRettangolo();

rettangoloGrande.stampaRettangolo();

rettangoloPiccolo.stampaRettangolo();
