// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/*  
Create an empty array that will hold 10 integer values.  
Loop through the array and assign each index a random integer value between 5 and 25. 
Print the min and max values of the array
Print the sum of all the values
*/

static void RandomArray()
{
    Random rand = new Random();
    int[] arr = new int[10];
    int sum = 0;
    for (int idx = 0; idx < arr.Length; idx++)
    {
        arr[idx] = rand.Next(5, 26);
        sum += arr[idx];
    }
    // print min, max, and sum of values
    Console.WriteLine($"Min: {arr.Min()}");
    Console.WriteLine($"Max: {arr.Max()}");
    Console.WriteLine($"Sum: {sum}");
}


/* Have the function print "Tossing a Coin!"
Randomize a coin toss with a result signaling either side of the coin
Have the function print either "Heads" or "Tails"
Finally, return the result */

static string TossCoin()
{
    Random rand = new Random();
    string result = "";
    int coin = rand.Next(1, 3);
    if (coin == 1){
        result = "Heads";
    } else {
        result = "Tails";
    }

    Console.WriteLine("Tossing a Coin!");
    Console.WriteLine(result);
    return result;
}

static double TossMultipleCoins(int num)
{
    int heads = 0;
    int tails = 0;

    for (int i = 0; i<=num; i++)
    {
        string result = TossCoin();
        if (result == "Tails")
        {
            tails += 1;
        }
        else {
            heads += 1;
        }
    }
    double HeadsVal = heads;
    double TotalVal = num;

    Console.WriteLine($"{HeadsVal / TotalVal} is the ratio of heads out of {num} total coin tosses.");
    return HeadsVal / TotalVal;
}


/*  Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
    Return a list that only includes names longer than 5 characters */

static List<string> Names()
{
    List <string> NameList = new List<string>();
    NameList.Add("Todd");
    NameList.Add("Tiffany");
    NameList.Add("Charlie");
    NameList.Add("Geneva");
    NameList.Add("Sydney");

    // shuffle list and print values in the new order
    Random rand = new Random();
    
    // return a list that only includes names with 5+ characters
    for(int i = 0; i<NameList.Count; i++)
    {
        if(NameList[i].Length <= 5)
        {
            NameList.Remove(NameList[i]);
        }
    }
    foreach(string Name in NameList)
    {
        Console.WriteLine(Name);
    }
    return NameList;

}

RandomArray();
TossCoin();
TossMultipleCoins(25);
Names();