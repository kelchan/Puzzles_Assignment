
// Random Array
static int[] RandomArray()
{
    Random rand = new Random();
    int[] arr = new int[ 10 ];
    for( int i = 0; i < arr.Length; i++ )
    {
        int randomNum = rand.Next( 5, 26 );
        arr[ i ] = randomNum;
    }
    return arr;
}
int[] randArr = RandomArray();
int min = randArr.Min();
int max = randArr.Max();
int sum = 0;
foreach( int num in randArr )
{
    sum += num;
}
Console.WriteLine( $"Min: {min}, Max: {max}, Sum: {sum}" );


Console.WriteLine( "-------------------------------------------");


// Coin Flip
int headsTotal = 0;
int tossTotal = 0;
string CoinFlip()
{
    Random rand = new Random();
    int randomNum = rand.Next( 0, 2 );
    string result;
    if( randomNum == 0 )
    {
        result = "Heads";
        headsTotal++;
    }
    else{
        result = "Tails";
    }
    Console.WriteLine( result );
    return result;
}
// Console.WriteLine( CoinFlip() );



// Toss Multiple Coins
void TossMultipleCoins( int num )
{
    tossTotal = num;
    for( int i = 0; i < num; i++ )
    {
        CoinFlip();
    }
}
TossMultipleCoins( 3 );



// Return Double
double CoinTossAvg()
{
    double doubleHeads = headsTotal;
    double doubleToss = tossTotal;
    double average;
    average = doubleHeads / doubleToss;
    return average;
}
Console.WriteLine( $"Heads total: {headsTotal}, Toss total: {tossTotal}, Average: {CoinTossAvg()}" );


Console.WriteLine( "-------------------------------------------");


// Names 
static List<string> Names()
{
    List<string> namesList = new List<string>()
    { 
        "Todd", 
        "Tiffany", 
        "Charlie",
        "Geneva", 
        "Sydney" 
    };
    List<string> greaterThanFive = new List<string>();
    for( int i = 0; i < namesList.Count; i++ )
    {
        if( namesList[i].Length > 5 )
        {
            greaterThanFive.Add( namesList[i] );
        }
    }
    return greaterThanFive;
}
List<string> namesLongerThan5 = Names();
foreach( string name in namesLongerThan5 )
{
    Console.WriteLine( name );
}


Console.WriteLine( "-------------------------------------------");


// Shuffle Names
List<string> shuffled = new List<string>();
Random rand = new Random();
while( namesLongerThan5.Count > 0 )
{
    int randomIndex = rand.Next( 0, namesLongerThan5.Count );
    shuffled.Add( namesLongerThan5[ randomIndex ] );
    namesLongerThan5.RemoveAt( randomIndex );
}
foreach( string name in shuffled )
{
    Console.WriteLine( name );
}

