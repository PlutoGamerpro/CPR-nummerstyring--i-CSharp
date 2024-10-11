# Håndtering-af-CPR-numre-i-C-
I denne vejledning vil vi udforske, hvordan man effektivt kan håndtere CPR-numre (Det Centrale Personregister) i C#. Vi dækker emner som validering, oprettelse og manipulation af CPR-numre i overensstemmelse med danske standarder.
# 🎉 Afsluttende Opgave - CPR Nummer

## 📚 Indholdsfortegnelse
- [Beskrivelse](#beskrivelse)
- [Funktioner](#funktioner)
- [Sådan Bruger Du Programmet](#-sådan-bruger-du-programmet)


## ✍️ Beskrivelse
Dette program er designet til at **analysere CPR-numre**. Det tjekker gyldigheden af CPR-numre, identificerer fødselsdato og bestemmer køn baseret på det indtastede CPR-nummer. 

## 🛠️ Funktioner
- ✅ Validering af CPR-nummerets format
- 🗓️ Ekstrahering af fødselsdato og køn
- ✅ Tjek for gyldighed baseret på CPR-reglerne





## 📜 Kodeforklaring
```csharp
using System.Runtime.CompilerServices;
using System.Text;
using System;

namespace Afsluttende_opgave___Cpr__nummer
{
    internal class Program
    {
      static void Main()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Write("Input CPR fx 220805-3434 (eller skriv 'exit' for at afslutte): ");
                string dato_Time = Console.ReadLine();

                // Tjek for afslutning af programmet
                if (dato_Time.ToLower() == "exit")
                {
                    keepRunning = false; // Sætter keepRunning til false for at afslutte løkken
                    continue; // Går tilbage til starten af løkken
                }

                // Fjern eventuelle mellemrum
                dato_Time = dato_Time.Replace(" ", "");

                // Tjek om input længden er gyldig og indeholder en bindestreg på den korrekte position
                if (dato_Time.Length >= 11 && dato_Time[6] == '-' && dato_Time.Length <= 11)
                {
                    // Fjern bindestregen
                    dato_Time = dato_Time.Replace("-", "");

                    if (double.TryParse(dato_Time, out double datoTime))
                    {
                        // Ekstraher dag, måned og sidste CPR cifre
                        string dagIndex = dato_Time.Substring(0, 2);
                        string månedIndex = dato_Time.Substring(2, 2);
                        string lastCprDigits = dato_Time.Substring(9, 1);

                        int day = int.Parse(dagIndex);
                        int month = int.Parse(månedIndex);
                        int lastCprtal = int.Parse(lastCprDigits);

                        // Tjek om måned og dag er gyldige
                        if (month <= 12 && month >= 1)
                        {
                            if (day >= 1 && day <= 31)
                            {
                                Console.WriteLine("Dag: " + dagIndex);
                                Console.WriteLine("Måned: " + månedIndex);
                                Console.WriteLine("Sidste CPR cifre: " + lastCprDigits);

                                // Bestem køn baseret på de sidste CPR cifre
                                if (lastCprtal % 2 == 0) { Console.WriteLine("Du er en kvinde"); }
                                else { Console.WriteLine("Du er en mand"); }

                                // Tjek vægtsummen
                                int[] CprIndex = new int[10];
                                for (int i = 0; i < 10; i++)
                                {
                                    CprIndex[i] = int.Parse(dato_Time.Substring(i, 1));
                                }

                                // Beregn vægtsummen
                                double Vægtsum = CprIndex[0] * 4 +
                                                 CprIndex[1] * 3 +
                                                 CprIndex[2] * 2 +
                                                 CprIndex[3] * 7 +
                                                 CprIndex[4] * 6 +
                                                 CprIndex[5] * 5 +
                                                 CprIndex[6] * 4 +
                                                 CprIndex[7] * 3 +
                                                 CprIndex[8] * 2 +
                                                 CprIndex[9] * 1;

                                if (Vægtsum % 11 == 0) 
                                {
                                    Console.WriteLine("Gyldigt CPR-nummer");
                                    Console.WriteLine("Vægtsum: " + Vægtsum);
                                }
                                else 
                                {
                                    Console.WriteLine("Ugyldigt CPR-nummer");
                                }
                            }
                            else { Console.WriteLine("Ugyldig dag"); }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldig måned");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kunne ikke parse: " + dato_Time);
                    }
                }
                else
                {
                    Console.WriteLine("Ugyldigt inputformat. Indtast venligst i formatet 'ddmmyy-xxxx'.");
                }
                Console.WriteLine(); // Ny linje for bedre læsbarhed
            }
        }
    }
}
```
## 🚀 Sådan bruger du programmet
1. Klon eller download dette repository.
2. Åbn det i din foretrukne C#-udviklingsmiljø.
3. Kør programmet.
4. Indtast et CPR-nummer i formatet ddmmyy-xxxx, og tryk på Enter.
5. Programmet vil analysere dit input og give dig oplysninger om fødselsdato, køn og gyldigheden af CPR-nummeret.
