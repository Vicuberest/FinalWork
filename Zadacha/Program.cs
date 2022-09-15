string [] array = {"Hello" , "hi" , "cat", "pi"};

string [] NewArray = new string[array.Length];
for (int i = 0; i < array.Length; i++)
{
   if (array[i].Length <= 3) 
    NewArray [i] = array [i];
    Console.WriteLine(NewArray[i]);
}
Console.WriteLine();
