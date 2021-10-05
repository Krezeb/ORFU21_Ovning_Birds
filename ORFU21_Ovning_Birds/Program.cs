using System;

namespace ORFU21_Ovning_Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird b1 = new Sparrow();
            b1.Fly();

            Bird b2 = new Hawk();
            b2.Fly();

            Bird b3 = new Ostrich();
            b3.Fly();
        }
    }
}

/*
 *  Övning fåglar
•	Skapa en klass som heter Bird. Klassen ska inte gå att instansiera (abstract).
•	Skapa en property på Bird-klassen som heter Species som är av typen sträng.
•	Skapa en metod som heter Fly som till konsolen skriver ”The { } flies!”. Där måsvingarna byts ut mot species-propertyn. 
•	Skapa en klass som heter Sparrow som ärver av klassen Bird.
•	I konstruktorn för klassen Sparrow ska propertyn species sättas till ”Sparrow”
•	Instansiera ett objekt av klassen Sparrow i din huvudexekvering och kalla på metoden Fly.
•	Skapa en klass som heter Hawk som ärver av klassen Bird.
•	I konstruktorn för klassen Hawk ska propertyn species sättas till ”Hawk”
•	Instansiera ett objekt av klassen Hawk i din huvudexekvering och kalla på metoden Fly.
•	Skapa en klass som heter Ostrich som ärver av klassen Bird.
•	I konstruktorn för klassen Ostrich ska propertyn species sättas till ”Ostrich”.
•	När metoden Fly kallas på ett objekt av typen Ostrich ska det i stället skrivas 
    ut till konsolen: ”The ostrich can not fly!”. För att uppnå detta behöver Fly-metoden på basklassen skrivas över (override).
•	Skapa ett objekt av klassen Ostrich och kalla på metoden Fly från din huvudexekvering.
 */