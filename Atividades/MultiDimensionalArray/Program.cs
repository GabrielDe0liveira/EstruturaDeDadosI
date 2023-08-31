int[,] biNumbers = new int[5,2];

int[,,] triNumbers = new int[5,4,3];

int[,] loadedBiNumber = new int[,]  
{
    {  9,  5, 15},
    { 10,-11, 15},
    {101, 45,  8}
};
    
for(int i = 0; i <loadedBiNumber.GetLength(0); i ++)
{
    for(int j = 0; j < loadedBiNumber.GetLength(1); j++)
    {
        Console.Write($"[{loadedBiNumber[i,j]}]");
    }
    Console.WriteLine("");
}