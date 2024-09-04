


Console.ReadLine();



// Demo Filhantering

//string file = @"C:\Users\Birca\Desktop\Namnlista.txt";

//using (StreamWriter sw = new StreamWriter(file, true))
//{
//    sw.WriteLine("Olle,olle@gmail.com,070-12345");
//    sw.WriteLine("Simon,simon@gmail.com,070-12345");
//    sw.WriteLine("Kent");
//    sw.WriteLine("Kalle");
//}
//using (StreamReader sr = new StreamReader(file))
//{
//    string row;
//    while ((row = sr.ReadLine()) != null)
//    {
//        Console.WriteLine(row);
//    }
//}

//Console.ReadLine();
////list

////Nackdelen men en array är när man vill öka antalet positioner.
//int[] numberArray = new int[] {1,2,3,4};

//List<int> numberList = new List<int>() {1,2,3,4};
////I en lista kan man öka anatalet positioner och minska.
//numberList.Add(1);
//numberList.RemoveAt(1);

//// En list mycket mer flexibel och mycket mer funktionalltet än en array.
//Console.WriteLine($"Detta är några värden från listan. Medelvärde av alla tal: {numberList.Average()}. Och Summan; {numberList.Sum()}" +
//    $" och antalet tal: {numberList.Count()} " );

//foreach (var number in numberList)
//{
//    Console.WriteLine(number);
//}

//List<int> result = GetNumbers();

//// Mycket vanligt att en metod retunern en lista med värden
//List<int> GetNumbers()
//{
//    return new List<int>() {1,2,3,4,5,6,7,8,9};
//}

//Console.ReadLine();

//DateTime TimeSpan

//DateTime date1 = DateTime.Now;
//DateTime date2 = date1.AddDays(1);

//Console.WriteLine(date1 + " " + date2);




//strängar
//string emailAddress = "Lisa.Lind@nackademin.se";
//int seperator = emailAddress.IndexOf("@");

//string name = emailAddress.Substring(0, seperator);
//string domain = emailAddress.Substring(seperator + 1);

//string nameList = "Lisa Lind,Anna Karlberg,Emma Svensson";
//string[] nameArray = nameList.Split(',');

//foreach (string names in nameArray)
//{
//    Console.WriteLine(names);
//}

//Console.WriteLine(name);
//Console.WriteLine(domain);




//Arrayer

//int number = 0;
//int[] numberArray = new int[5];
//numberArray[0] = 1;
//numberArray[1] = 2;
//numberArray[2] = 3;
//numberArray[3] = 5;
//numberArray[4] = 6;
// Första positionen i en array har index 0
// Arrayen är viktig för den är grunden för andra datastrukturer.

//for (int i = 0; i < numberArray.Length; i++)
//{
//    Console.WriteLine(numberArray[i]);
//}

//foreach (int numbers in numberArray)
//{
//    Console.WriteLine(numbers);
//}


//int x = 3;
//Assign3(ref x);
//Console.WriteLine(x);
//void Assign3(ref int x)
//{
//    x = x + 3;
//}


//int y;
//Out3(out y);
//Console.WriteLine(y);
//void Out3(out int y)
//{
//    y = 3;
//}


//Console.ReadLine();