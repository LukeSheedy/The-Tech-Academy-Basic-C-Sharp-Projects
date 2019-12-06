using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            ////TRUE AND FALSE will == false beacuse both arnt true
            //Console.WriteLine(true && false);

            //// TRUE AND TRUE will == true beacuse both are true
            //Console.WriteLine(true && true);

            //// FALSE AND FALSEwill == false beacuse both are false
            //Console.WriteLine(false && false);



            ////TRUE OR TRUE will == true 
            //Console.WriteLine(true || true);

            ////TRUE OR TRUE will == true (need only one true)
            //Console.WriteLine(true || false);

            ////FALSE OR FALSE will == false
            //Console.WriteLine(false || false);
            //Console.ReadLine();



            //// does TRUE EQUEAL TRUE == TRUE
            //Console.WriteLine(true == true);

            //// does TRUE EQUEAL FALSE== FALSE
            //Console.WriteLine(true == false);

            //// does FALSE EQUEAL FALSE== TRUE
            //Console.WriteLine(false== false);

            //TRUE DOES NOT EQUEAL TRUE == FALSE
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false); //== TRUE
            //Console.WriteLine(false != false); //== FALSE


            Console.WriteLine(true ^ true); //== false
            Console.WriteLine(true ^ false);//== true
            Console.WriteLine(false ^ false);// == false


            Console.ReadLine();

        }
    }
}
