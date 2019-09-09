#include <iostream>
#include <string>

using namespace std;
int main()
{
   string raptor_prompt_variable_zzyz;
   ?? b;
   ?? temp;
   ?? a;

   raptor_prompt_variable_zzyz ="enter first number";
   cout << raptor_prompt_variable_zzyz << endl;
   cin >> a;
   raptor_prompt_variable_zzyz ="enter second number";
   cout << raptor_prompt_variable_zzyz << endl;
   cin >> b;
   cout << "before swap a"+a+"before swap b"+b << endl;   temp =a;
   a =b;
   b =temp;
   cout << "a value"+a+"b value"+b << endl;
   return 0;
}
