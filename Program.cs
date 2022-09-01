internal class Program
{
    private static void Main(string[] args)
    {   
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {  
            Console.WriteLine(new String(' ',n-i)+new String('#',i));
        }
    }
}