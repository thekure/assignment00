namespace MyApp;

public class Year
{
    public static bool isLeapYear(int year){
        if(year < 1582) throw new Exception("Does not support years before 1582");
        if(year % 100 == 0) return (year % 400 == 0);
        return (year % 4 == 0);
    
    } 

    public static string isLeapYear(bool year){
        if(year) return "yay";
        else return "nay";
    } 

    public static void printIsLeapYear(string input){
        try{
            var parsed = int.Parse(input);
            try{
                if(isLeapYear(parsed)){
                Console.WriteLine("yay");
                } else {
                Console.WriteLine("nay");
                }
            } catch (Exception) {
                Console.WriteLine("Does not support years before 1582");
            }
        } catch {
            Console.WriteLine("Cannot be parsed to an integer.");
        }
        
    }
}