// mgr.inż. Piotr Bilski
// Programowanie Obiektowe

using System;

namespace PO_W_501
{
    class Logic
    {
        public int _parX;
        public int _parY;
        public Logic(int parX, int parY)
        {
            _parX = parX;
            _parY = parY;
        }
        public static Logic operator &(Logic x, Logic y)
        {
            return new Logic(x._parX & y._parX, x._parY & y._parY);
        }
        public static Logic operator |(Logic ob1, Logic ob2)
        {
            return new Logic(ob1._parX | ob2._parX, ob1._parY | ob2._parY);
        }
        public static bool operator true(Logic ob1)
        {
            return ob1._parX != 0;
        }
        public static bool operator false(Logic ob1)
        {
            return ob1._parX == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logic testObject1 = new Logic(3, 4);
            Logic testObject2 = new Logic(4, 2);
            Logic testObject3 = new Logic(5, 1);

            // Jaki będzie wynik wykonania tak napisanego przeciążenia z powyższymi wartościami?
            // Podpowiedź - trzeba przeanalizować zasadę zachowania się bramek logicznych AND i OR

            if (testObject1 && testObject2)
                Console.WriteLine("Jakiś komunikat 1");
            if (testObject1 || testObject3)
                Console.WriteLine("Jakiś komunikat 2");
        }
    }

    // Implementacja klasy przykładowej z logiką operatorów
    class LogikaOperatorów
    {
        void OperacjaAND()
        {
            if (false & false)
            {
                //tu jest kod, który się nie wykona
            }
            if (true & false)
            {
                //ten kod, także się nie wykona
            }
            if (true & true)
            {
                //ten kod zostanie wykonany
            }
        }
        void OperacjaOR()
        {
            if (false | false)
            {
                //tu jest kod, który się nie wykona
            }
            if (true | false)
            {
                //ten kod zostanie wykonany
            }
            if (true | true)
            {
                //ten kod także zostanie wykonany
            }
        }
    }
}
