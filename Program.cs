using System;

namespace Classes
{
    class Program
    {
        class age{
            public int age_of_dad;
            public int age_of_mom;
            public int age_of_child;

            public void child(){
                Console.WriteLine("The child is {0} years younger than his father and {1} years younger than his mother.", age_of_dad-age_of_child, age_of_mom-age_of_child);
            }

        }
        static void Main(string[] args)
        {
           age Child=new age();
           do{
                do{
                    Console.WriteLine("Please type the age of the father");
                }while(!int.TryParse(Console.ReadLine(), out Child.age_of_dad));
           }while(Child.age_of_dad<13);
           do{
                do{
                    Console.WriteLine("Please type the age of the mother");
                }while(!int.TryParse(Console.ReadLine(), out Child.age_of_mom));
           }while(Child.age_of_mom<13);
           do{
                do{
                    Console.WriteLine("Please type the age of the child");
                }while(!int.TryParse(Console.ReadLine(), out Child.age_of_child));
           }while(Child.age_of_child>Child.age_of_mom-13);

           Child.child();

           Console.ReadKey();
        }
    }
}
