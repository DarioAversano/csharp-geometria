
// See https://aka.ms/new-console-template for more information
using RettangoliVari;
using System;

Console.WriteLine("Hello, World!");



//Rettangoli

Rettangolo rettangoloClassico = new Rettangolo(20, 10);
Console.WriteLine("ATTRIBUTI DEL RETTANGOLO CLASSICO: ");
Console.WriteLine("La Base del rettangolo classico è di: " + rettangoloClassico.baseRettangolo + " Cm");
Console.WriteLine("L'altezza del rettangolo classico è di: " + rettangoloClassico.altezzaRettangolo + " Cm");

Console.WriteLine("Il perimetro del rettangolo classico è di: " + rettangoloClassico.calcolaPerimetro());

Rettangolo rettangoloGrande = new Rettangolo(30, 15);
Console.WriteLine("ATTRIBUTI DEL RETTANGOLO GRANDE: ");
Console.WriteLine("La Base del rettangolo piccolo è di: " + rettangoloGrande.baseRettangolo + " Cm");
Console.WriteLine("L'altezza del rettangolo classico è di: " + rettangoloGrande.altezzaRettangolo + " Cm");

Console.WriteLine("Il perimetro del rettangolo piccolo è di: " + rettangoloGrande.calcolaPerimetro());

Rettangolo rettangoloPiccolo = new Rettangolo(10, 5);
Console.WriteLine("ATTRIBUTI DEL RETTANGOLO PICCOLO: ");
Console.WriteLine("La base del rettangolo piccolo è di: " + rettangoloPiccolo.baseRettangolo + " Cm");
Console.WriteLine("L'altezza del rettangolo piccolo è di: " + rettangoloPiccolo.altezzaRettangolo + " Cm");

Console.WriteLine("Il perimetro del rettangolo piccolo è di: " + rettangoloPiccolo.calcolaPerimetro());


Console.WriteLine("Rettangolo classico:" + rettangoloClassico.stampaRettangolo());

Console.WriteLine("Rettangolo grande:" + rettangoloGrande.stampaRettangolo());

Console.WriteLine("Rettangolo piccolo:" + rettangoloPiccolo.stampaRettangolo());
