using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using ExerciseSet.Entities;

namespace ExerciseSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the path of file: ");
            string path = Console.ReadLine();
            HashSet<User> hashUser = new HashSet<User>();
            User user;

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        
                        user = new User(name, instant );
                        hashUser.Add(user);

                        Console.WriteLine(user.Name);

                    }

                    Console.WriteLine( $"\nTotal users: {hashUser.Count}"); 
                }
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }
    }
}
