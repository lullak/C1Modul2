

//1 Vad är en metod?
//En metod är en funktion eller procedur i C# som utför en specifik uppgift. Den kan ta emot inparametrar, utföra operationer och eventuellt returnera ett värde.

//2 Hur används inparametrar i en metod?
//Inparametrar definieras inom parenteser efter metodens namn. Dessa parametrar tillåter att data skickas in i metoden när den anropas. Exempel: void MyMethod(int x, string y).

//3 Vad innebär nyckelordet "void" i en metod?
//Nyckelordet void indikerar att metoden inte returnerar något värde.

//4 Hur kan man se vad en metod returnerar? Var definieras detta?
//Typen som metoden returnerar definieras precis före metodens namn. Exempel: int Calculate() indikerar att metoden returnerar en int. Om void används, returneras inget värde.

//5 Vad innebär det att en inparameter har nyckelordet ref framför sig?
//När en parameter i en metod har nyckelordet ref framför sig innebär det att parametern skickas in som en referens.
//Det betyder att metoden arbetar med en referens till den ursprungliga variabeln, snarare än en kopia av den.
//Ändringar som görs på denna parameter inuti metoden påverkar alltså direkt den variabel som skickades in.

//public void AddFive(ref int number)
//{
//    number += 5;  // Detta påverkar den ursprungliga variabeln
//}

//int myNumber = 10;
//AddFive(ref myNumber);
//Console.WriteLine(myNumber);  // Skriver ut 15, eftersom myNumber har ändrats i metoden

//Utan ref skulle värdet av myNumber ha varit oförändrat utanför metoden.

//6 Vad innebär det att en inparameter har nyckelordet out framför sig?
//Nyckelordet out används för att skicka in en parameter som är avsedd att returneras från metoden.
//Till skillnad från ref behöver en out-parameter inte tilldelas något värde innan den skickas in i metoden, men metoden är skyldig att tilldela ett värde till denna parameter innan den avslutas.
//public void InitializeValues(out int a, out int b)
//{
//    a = 10;  // Obligatoriskt att tilldela ett värde
//    b = 20;  // Obligatoriskt att tilldela ett värde
//}

//int x, y;
//InitializeValues(out x, out y);
//Console.WriteLine($"{x}, {y}");  // Skriver ut 10, 20

//out är användbart när du behöver returnera flera värden från en metod.

//7 Vad är en control på ett formulär?
//En control är ett användargränssnittselement, som en knapp, textfält eller lista, som används i ett formulär (t.ex. i Windows Forms).

//8 Vad är properties för en control? Vad kan de användas för?
//Properties är inställningar för en control som definierar dess utseende och beteende, som Text, Enabled, Size. De kan användas för att anpassa kontrollens egenskaper.

//9 Vad innebär events? Hur kan events skapas?
//Events är händelser som uppstår, exempelvis när en användare klickar på en knapp. De kan skapas genom att deklarera en delegate och använda nyckelordet event, samt koppla händelsen till en metod.

//10 Hur skapar man en textfil i C#?
//Det finns flera sätt att skapa en textfil i C#. Ett enkelt sätt är att använda File-klassen som finns i System.IO-namnområdet. Med File.Create() kan du skapa en ny fil.

//FileStream fs = File.Create("example.txt");
//fs.Close();  // Stänger filen efter att den har skapats

//Detta skapar en tom fil med namnet example.txt i den aktuella katalogen. Om filen redan existerar kommer den att skrivas över. 
//Alternativt kan du använda StreamWriter (beskrivet i fråga 11) för att skapa och samtidigt skriva till en fil.

//11. Hur skriver man till en textfil i C#? Hur fungerar StreamWriter-klassen?
//StreamWriter-klassen används för att skriva text till en fil rad för rad.
//Den är också kapabel att skriva till en fil i ett sammanhängande flöde, vilket gör den idealisk för att hantera stora mängder textdata.

//using (StreamWriter writer = new StreamWriter("example.txt"))
//{
//    writer.WriteLine("This is the first line.");
//    writer.WriteLine("This is the second line.");
//}
//I detta exempel används StreamWriter för att öppna eller skapa filen example.txt och skriva två rader till den. 
//    Observera att using-blocket automatiskt stänger och frigör resursen (filen) efter att blocket har körts klart, vilket säkerställer att filen inte låses eller lämnas öppen.

//12. Hur läser man en textfil i C#? Hur fungerar StreamReader-klassen?
//StreamReader-klassen används för att läsa text från en fil, antingen rad för rad eller hela filen i en enda operation.
//Den är optimerad för att hantera textströmmar och erbjuder metoder för att läsa textdata effektivt.

//using (StreamReader reader = new StreamReader("example.txt"))
//{
//    string content = reader.ReadToEnd();  // Läser hela filen som en enda sträng
//    Console.WriteLine(content);
//}

//Här öppnas filen example.txt med StreamReader, och hela dess innehåll läses in som en enda sträng med metoden ReadToEnd(). 
//    Precis som med StreamWriter säkerställer using-blocket att filen stängs korrekt efter att operationen har slutförts.

//För att läsa filen rad för rad kan du använda ReadLine()-metoden:
//using (StreamReader reader = new StreamReader("example.txt"))
//{
//    string line;
//    while ((line = reader.ReadLine()) != null)
//    {
//        Console.WriteLine(line);
//    }
//}
//Denna kod läser varje rad i filen och skriver ut den till konsolen tills slutet av filen nås (null).

//13. Vad innebär händelsestyrd (event-based) programmering? Beskriv skillnaden mellan sekventiell och händelsestyrd programmering.
//Händelsestyrd programmering innebär att programmet reagerar på händelser, som användarinteraktioner.
//Sekventiell programmering följer ett förutbestämt flöde av steg. I händelsestyrd programmering avgör händelser ordningen på exekveringen.