using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingLambda
{
    public class LambdaExpression
    {
        public void Validate()
        { 
            string[] Regex_Pattern = new string[6];

            Regex_Pattern[0] = "^[A-Z][A-Za-z]{2,}$";  //Firstname

            Regex_Pattern[1] = "^[A-Z][A-Za-z]{2,}$";  //LastName

            Regex_Pattern[2] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";  //EmailId

            Regex_Pattern[3] = "^[1-9]{2}[ ][0-9]{10}$";  //phonenumber

            Regex_Pattern[4] = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";  //password

            Regex_Pattern[5] = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$"; //sampleEmailId

            string[] User_Input = new string[6];

            Console.Write("Enter First Name :");
            User_Input[0] = Console.ReadLine();


            Console.Write("Enter Last Name :");
            User_Input[1] = Console.ReadLine();


            Console.Write("Enter  Email Id : ");
            User_Input[2] = Console.ReadLine();


            Console.Write("Enter the Phone Number : ");
            User_Input[3] = Console.ReadLine();


            Console.WriteLine("Enter Password : ");
            User_Input[4] = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter Sample Email Id : ");
            User_Input[5] = Console.ReadLine();




            for (int i = 0; i < 6; i++)
            {

                Func<string, bool> nameValidater = User_Input_Array => Regex.IsMatch(User_Input_Array, Regex_Pattern[i]);
                bool result = nameValidater(User_Input[i]);
                Console.WriteLine(($"{i + 1} {User_Input[i]} : {result}"));

            }
        }
    }
}



      
       



   
