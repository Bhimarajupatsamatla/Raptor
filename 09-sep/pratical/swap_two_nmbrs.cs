using System;
using System.IO;
using System.Text;

namespace swap_two_nmbrs
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? b;
         ?? temp;
         ?? a;
      
         raptor_prompt_variable_zzyz ="enter first number";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         a= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="enter second number";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         b= Double.Parse(Console.ReadLine());
         Console.WriteLine("before swap a"+a+"before swap b"+b);
         temp =a;
         a =b;
         b =temp;
         Console.WriteLine("a value"+a+"b value"+b);
      }
   }
}
