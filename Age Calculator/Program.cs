
					
public class Program
{
    public static void Main( string[] args)
    {
        DateTime bday = Convert.ToDateTime("01/01/2002");
        DateTime today = DateTime.Today;
        int age = today.Year - bday.Year;
		
        if(bday > today){
            Console.WriteLine("Incorrect date");
        }
		
        Console.WriteLine("Your age {0}", age);
			
    }
}