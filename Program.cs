using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionsss
{
 //   create custom exception to handle Age
  //  public class AgeException : Exception
    //{
  //      public AgeException(string message) : base(message)
  //      {

  //      }
  //  }
  //  public class NameException : Exception
   // {
  //      public NameException(string message) : base(message)
  //      {

   //     }
    }
  //  public class User
  //  {
  //      private string name;
   //     public User(string name)
  //      {
    //        if (string.IsNullOrEmpty(name))
   //         {
  //              throw new NameException("name is required");
  //          }
  //          else
  //          {
    //            this.name = name;
  //          }

  //      }
  //      public void AcceptAge(int age)
  //      {
  //          if (age < 18)
   //         {
 //               throw new AgeException("You are not eligible");
 //           }
   //     }
  //  }
    public class Program
    {

        static void Main(string[] args)
        {
            try
            {
  //              User user = new User("test");
  //              //  user.AcceptAge(25);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }