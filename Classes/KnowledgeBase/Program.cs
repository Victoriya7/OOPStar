using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase
{
    class Program
    {
        static void Main(string[] args)
        {

            //int Number, Number2 = 24, Number3;
            //Number = Number2;

            //Number2 = 15;

            //Number = 25 + ( 25 * 5 );

            //string Result = "Hello " + " World";

            //bool isUserHaveKey = true;
            //bool isUserSeeDoor = false;
            //bool isDoorOpen = isUserHaveKey || isUserSeeDoor;

            //isDoorOpen = !isUserSeeDoor;

            //Number += 10;

            //Number = 10;
            //Number2 = 0;


            //Number = ++Number2;
            //Number--;
            //++Number;
            //--Number;

            //Console.WriteLine(isDoorOpen);

            string message = "Результат: ";

            int Number = 8 * 2 + 5;

            Console.Write(message);

            Console.WriteLine(Number);

            int total = 52;
            int Row = total / 3;
            int balance = total % 3;
            Console.WriteLine("Всего заполненных рядов:" + Row);
            Console.WriteLine("Картинок сверх меры:" + balance);

        }
    }
}
