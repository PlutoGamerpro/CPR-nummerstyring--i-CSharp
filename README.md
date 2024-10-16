# Håndtering-af-CPR-numre-i-C# 🧑‍💻
 I denne vejledning 📖 vil vi udforske, hvordan man effektivt kan håndtere CPR-numre (Det Centrale Personregister) 🔍 i C#. Vi dækker emner som validering, oprettelse og manipulation af CPR-numre i overensstemmelse med danske standarder.
# 🎉 Afsluttende Opgave - CPR Nummer

## 📚 Indholdsfortegnelse
- [Beskrivelse](#-beskrivelse)
- [Funktioner](#-funktioner)
- [Sådan Bruger Du Programmet](#-sådan-bruger-du-programmet)


## ✍️ Beskrivelse
Dette program er designet til at **analysere CPR-numre**. Det tjekker gyldigheden af CPR-numre, identificerer fødselsdato og bestemmer køn baseret på det indtastede CPR-nummer. 🎂👦👧

## 🛠️ Funktioner
- ✅ Validering af CPR-nummerets format
- 🗓️ Ekstrahering af fødselsdato og køn
- 🔍 Tjek for gyldighed baseret på CPR-reglerne





## 📜 Kodeforklaring

## ✍️ Input fra Brugeren
- Input: Programmet beder brugeren om at indtaste et CPR-nummer ✍️.
```csharp
Console.Write("Input CPR fx 220805-3434 (eller skriv 'exit' for at afslutte): ");
string dato_Time = Console.ReadLine();
```
## ❌ Afslutning af Programmet
- Exit: Brugeren kan skrive "exit" for at afslutte programmet ❌.
```csharp
if (dato_Time.ToLower() == "exit")
{
    keepRunning = false; // Sætter keepRunning til false for at afslutte løkken
    continue; // Går tilbage til starten af løkken
}
```

## ✅ Formatkontrol
- Format: Programmet fjerner mellemrum og tjekker, om formatet er korrekt (fx ddmmyy-xxxx).✅
```csharp
dato_Time = dato_Time.Replace(" ", "");

if (dato_Time.Length >= 11 && dato_Time[6] == '-' && dato_Time.Length <= 11)
{
    // Kode til videre behandling...
}
```
## 🔍 Ekstrahering af Dato og Køn
- Parsing: Programmet fjerner bindestreger og forsøger at konvertere indholdet til en double for validering 🔍.
```csharp
dato_Time = dato_Time.Replace("-", "");

if (double.TryParse(dato_Time, out double datoTime))
{
    // Ekstraher dag, måned og køn...
}
```
## 📅 Validering af Dag og Måned
- Validering: Tjekker, om dag og måned er gyldige 📅.
 ```csharp
int day = int.Parse(dagIndex);
int month = int.Parse(månedIndex);

if (month <= 12 && month >= 1 && day >= 1 && day <= 31)
{
    // Kode til output...
}
```
## 🚺🚹 Bestemmelse af Køn
- Køn: Køn bestemmes ud fra det sidste CPR-ciffer (lige = kvinde, ulige = mand) 🚺🚹.
```csharp
if (lastCprtal % 2 == 0) { Console.WriteLine("Du er en kvinde"); }
else { Console.WriteLine("Du er en mand"); }
```
## ⚖️ Beregning af Vægtsum
- Vægtsum: CPR-cifre konverteres til et array for at beregne vægtsummen ifølge danske CPR-regler ⚖️.
```csharp
int[] CprIndex = new int[10];
for (int i = 0; i < 10; i++)
{
    CprIndex[i] = int.Parse(dato_Time.Substring(i, 1));
}

// Beregn vægtsum...

```
## 📣 Udsendelse af Resultater
- Output: Programmet informerer brugeren om gyldigheden af CPR-nummeret 📣.
```csharp
if (Vægtsum % 11 == 0) 
{
    Console.WriteLine("Gyldigt CPR-nummer");
}
else 
{
    Console.WriteLine("Ugyldigt CPR-nummer");
}

```

## 🚀 Sådan bruger du programmet
1. Klon eller download dette repository. 📥
2. Åbn det i din foretrukne C#-udviklingsmiljø. 🖥️
3. Kør programmet. ▶️
4. Indtast et CPR-nummer i formatet ddmmyy-xxxx, og tryk på Enter. ⌨️
5. Programmet vil analysere dit input og give dig oplysninger om fødselsdato, køn og gyldigheden af CPR-nummeret. 📊

## 🙌 Tak for din tid!

Jeg håber, du fandt denne gennemgang nyttig! Hvis du er interesseret i at se flere af mine projekter, kan du tjekke dem ud [here](https://github.com/PlutoGamerpro?tab=stars).
