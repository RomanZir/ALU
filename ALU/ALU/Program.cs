
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

class proga
{
    
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Выберите что хотите сделать 1)Математика 2)Логика");
        string f=Console.ReadLine();
        if(f=="1")
        {
            Console.WriteLine("Математика");
            Console.WriteLine("Введите первое число");
            string s = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string s2 = Console.ReadLine();
            int a1 = Convert.ToInt32(s);
            int a2 = Convert.ToInt32(s2);
            string s12 = Convert.ToString(a1);
            string s22 = Convert.ToString(a2);
            Console.WriteLine("Введите действие: 1)Сложение 2)Вычитание 3)Умножение");
            string r = Console.ReadLine();

            if (r == "1")
            {
                Console.WriteLine("К двоичному числу -> " + s12);
                Console.WriteLine("Прибавить двоичное число -> " + s22);
                int b1 = Convert.ToInt32(s12);
                int b2 = Convert.ToInt32(s22);
                int i = 0;
                int rem = 0;
                string str = "";

                while (b1 != 0 || b2 != 0)
                {
                    str += (b1 % 10 + b2 % 10 + rem) % 2;
                    rem = (b1 % 10 + b2 % 10 + rem) / 2;

                    b1 = b1 / 10;
                    b2 = b2 / 10;
                }

                if (rem != 0)
                    str += rem;

                Console.WriteLine($"Полуится двоичное число -> {str} (Читать справа налево, не баг а фича!)");
            }
            if (r == "2")
            {
                Console.WriteLine("ОТ двоичного числа -> " + s12);
                Console.WriteLine("Отнять двоичное число -> " + s22);

                int b1 = Convert.ToInt32(s12);
                int b2 = Convert.ToInt32(s22);
                int i = 0;
                int rem = 0;

                string str = "";

                while (b1 != 0 || b2 != 0)
                {
                    i += (b1 % 10 - b2 % 10 + rem) % 2;
                    rem = (b1 % 10 - b2 % 10 + rem) / 2;
                    if (i < 0)
                    {
                        i = i * -1;
                        str += i;
                    }
                    else str += i;
                    b1 = b1 / 10;
                    b2 = b2 / 10;
                }

                if (rem != 0)
                    str += rem;
                Console.WriteLine($"Полуится двоичное число -> {str} (Читать справа налево, не баг а фича!)");
            }
            if (r == "3")
            {

                Console.WriteLine("ОТ двоичного числа -> " + s);
                Console.WriteLine("Отнять двоичное число -> " + s2);
                char[] num1Bits = s.ToCharArray();
                char[] num2Bits = s2.ToCharArray();
                int lenght1 = num1Bits.Length;
                int lenght2 = num2Bits.Length;
                int[] temp = new int[lenght1 + lenght2];
                for (int i = lenght1 - 1; i >= 0; i--)
                {
                    for (int j = lenght2 - 1; j >= 0; j--)
                    {
                        int bit1 = num1Bits[i] - '0';
                        int bit2 = num2Bits[j] - '0';
                        temp[i + j] += bit1 * bit2;
                    }
                }
                string str = string.Join("", temp);

                Console.WriteLine($"Полуится двоичное число ->  {str.TrimStart('0')}");//Я больше никогда не буду умножать двоичные числа так

            }
        }
        else
        {
            Console.WriteLine("Логика");
            Console.WriteLine("Введите true или false с которыми будет выполняться логические операции");
            bool l1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введите true или false с которым будет выполняться логические операции");
            bool l2 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Логическое И: {l1 & l2}");
            Console.WriteLine($"Логическое ИЛИ: {l1 | l2}");
            Console.WriteLine($"Логическое НЕ: НЕ {l1} = {!l1}; НЕ {l2} = {!l2}  ");
        }
        
        Console.ReadKey();
    }
    
}