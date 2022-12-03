public class Program2
{
    public static void Main(string[] args)
    {
        // Here I read input and create 4 variables for saving first, second and third elf and current points as well
        string[] input = File.ReadAllLines("C#/Day 1 Calorie Counting/input.txt");

        int points_f = 0;
        int points_s = 0;
        int points_t = 0;
        int points = 0;

        // Here I use foreach to check every backpack to check how many snacks they have
        foreach(string backpack in input){
            // if theere is a number lets add it to the curr points (points)
            if (backpack != ""){
                points += Int32.Parse(backpack);
            }else{
                // if there isnt a number, lets check if its in one of the top Three spots
                // if it is, lets update the top three
                if (points > points_t){
                    if (points > points_s){
                        if (points > points_f){
                            points_t = points_s;
                            points_s = points_f;
                            points_f = points;
                        } else{
                            points_t = points_s;
                            points_s = points;
                        }
                    } else{
                        points_t = points;
                    }
                }
                //Lets reset the curr points (points) and move to the next elf
                points = 0;
            }

        }
        // Here I print the Sum of top Three and Top Three 
        Console.WriteLine("sum:" + points_f+points_s+ points_t);
        Console.WriteLine("first: " +points_f);
        Console.WriteLine("second: " +points_s);
        Console.WriteLine("third: " +points_t);
    }
}