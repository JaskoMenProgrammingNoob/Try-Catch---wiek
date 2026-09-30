class Program
{


    static void Main(string[] args)
    {
        
        
        
        Console.WriteLine("Podaj wiek: ");
       try
        { 
        int wiek = int.Parse(Console.ReadLine());
        if ( wiek >= 18)
        {
            Console.WriteLine("Jesteś pełnoletni!");
            return;
                
        } else
        {
            Console.WriteLine("Jesteś niepełnoletni! ");
            return;

        }
        }
        catch(Exception)
        {
            Console.WriteLine("Podano nieprawidłowy wiek!");
            return;
        }
        
        
            
            

    }
}