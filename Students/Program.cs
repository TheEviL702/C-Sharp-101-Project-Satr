using System;
using System.Collections;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool Edit = false;

                var Student = new ArrayList();
                int[] INDEX = new int[90];
                var Degree = new ArrayList();

                Console.WriteLine("Hello !!\nThis program allows you to add and edit students' Names and Marks \nPress any button to start...");
                Console.ReadKey();


                while (true)
                {


                    for (int i = 0; i <= Student.Count; i++)
                    {




                        Edit = false;

                        Console.Write("------------------------\nPlease enter student name : ");
                        Student.Add(Console.ReadLine());
                        Console.Write("------------------------\nPlease enter student degree : ");
                        Degree.Add(Console.ReadLine());

                        Console.WriteLine("----------------------------\nStudent added successfully!!");

                        Console.Write("Prees (Enter) to Add more Students. Press (e) To Show and Edit Students.");

                        var EditButton = Console.ReadLine();
                        if (EditButton == "a" || EditButton == "A")
                        {

                        }
                        else if (EditButton == "e" || EditButton == "E")
                        {
                            while (Edit == false)
                            {
                                Console.WriteLine("\n#" + "\tStudent Name" + "\tDegree" + "\tResult" + "\n----------------------------------------------------");
                                for (int e = 0; e < Student.Count; e++)
                                {



                                    Console.WriteLine(e + 1 + "\t" + Student[e] + "\t\t" + Degree[e] + "\t" + GetResult(Convert.ToInt32(Degree[e])) + "\n----------------------------------------------------");


                                }
                                Console.Write("Prees (b) to back to adding students. Press (e) to edit.");
                                EditButton = Console.ReadLine();
                                if (EditButton == "b" || EditButton == "B")
                                {
                                    Edit = true;
                                }

                                else if (EditButton == "e" || EditButton == "E")
                                {
                                    Console.Write("Choose which # of data entry would you like to edit");
                                    var IndexofArray = Convert.ToInt32(Console.ReadLine()) - 1;


                                    Console.WriteLine("------------------------------------------------\n" + "\t" + Student[IndexofArray] + "\t\t" + Degree[IndexofArray] + "\t" + GetResult(Convert.ToInt32(Degree[IndexofArray])) + "\t\tSELECTED !!");
                                    Console.WriteLine("------------------------------------------------\nPlease select the data you would like to modify. Press (n) to change the name. Press (d) to change the degree");

                                    var UserSelection = Console.ReadLine();

                                    if (UserSelection == "n" || UserSelection == "N")
                                    {
                                        Console.Write("Rename " + Student[IndexofArray] + " to : ");
                                        Student[IndexofArray] = Console.ReadLine();
                                        Console.Write("Name Changed successfully!!");
                                    }
                                    else if (UserSelection == "d" || UserSelection == "D")
                                    {

                                        Console.Write("Change the current degree (" + Degree[IndexofArray] + ") to : ");
                                        Degree[IndexofArray] = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Degree Changed successfully!!");

                                    }



                                }
                            }
                        }

                    }






                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Please reopen the program and make sure you are selecting the right data type !!");
            }
             static string GetResult(int Degr)
            { 
                string result;
                

                try
                { 
                    

                    if (Degr > 60)
                    {
                        result = "Passed";
                    }
                    else
                    {
                        result = "Failed";
                    }

                }
                catch(Exception a)
                {
                    return "Please reopen the program and make sure you are selecting the right data type !!";
                }

                return result;
            }


        }
    }
}
    
