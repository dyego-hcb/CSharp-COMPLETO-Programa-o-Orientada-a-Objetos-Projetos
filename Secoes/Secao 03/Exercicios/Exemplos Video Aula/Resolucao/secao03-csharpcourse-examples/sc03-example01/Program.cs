using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte var_sbyte1 = 100;
            SByte var_sbyte2 = 100;
            Console.WriteLine("Value of variable var_sbyte1 = " + var_sbyte1);
            Console.WriteLine("Value of variable var_sbyte2 = " + var_sbyte2);

            byte var_byte1 = 126;
            Console.WriteLine("Value of variable var_byte1 = " + var_byte1);

            byte var_byte2 = 254;
            Console.WriteLine("Value of variable var_byte2 = " + var_byte2);

            var_byte2++;
            Console.WriteLine("Value of variable var_byte2 = " + var_byte2);

            var_byte2++;
            Console.WriteLine("Value of variable var_byte2 = " + var_byte2);

            int var_int1 = 1000;
            Console.WriteLine("Value of variable var_int1 = " + var_int1);

            int var_int2 = 2147483647;
            Console.WriteLine("Value of variable var_int2 = " + var_int2);

            long var_long1 = 2147483648L;
            Console.WriteLine("Value of variable var_long1 = " + var_long1);

            bool var_boo1 = false;
            Console.WriteLine("Value of variable var_boo1 = " + var_boo1);

            char var_char1 = 'f';
            Console.WriteLine("Value of variable var_char1 = " + var_char1);

            char var_char2 = '\u0041';
            Console.WriteLine("Value of variable var_char1 = " + var_char2);

            float var_float1 = 4.5f;
            Console.WriteLine("Value of variable var_float1 = " + var_float1);

            double var_double1 = 4.5;
            Console.WriteLine("Value of variable var_double1 = " + var_double1);

            string var_string1 = "Dyego";
            Console.WriteLine("Value of variable var_string1 = " + var_string1);

            Object var_object1 = "Dyego H";
            Console.WriteLine("Value of variable var_object1 = " + var_object1);

            Object var_object2 = 22.5;
            Console.WriteLine("Value of variable var_object2 = " + var_object2);

            int min_value_int = int.MinValue;
            Console.WriteLine("Value of variable min_value_int = " + min_value_int);

            int max_value_int = int.MaxValue;
            Console.WriteLine("Value of variable max_value_int = " + max_value_int);

            sbyte min_value_sbyte = sbyte.MinValue;
            Console.WriteLine("Value of variable min_value_sbyte = " + min_value_sbyte);

            decimal max_value_decimal = decimal.MaxValue;
            Console.WriteLine("Value of variable max_value_decimal = " + max_value_decimal);

            Console.Write("Bom Dia !!");
            Console.WriteLine("Boa Tarde !!");
            Console.WriteLine("Boa Noite !!");

            char genero = 'M';
            int idade = 24;
            double saldo = 10.23332;
            string nome = "Dyego Henrique";

            Console.WriteLine("genero: " + genero);
            Console.WriteLine("idade: " + idade);
            Console.WriteLine("saldo: " + saldo);
            Console.WriteLine("saldo.toString(F2): " + saldo.ToString("F2"));
            Console.WriteLine("saldo.toString(F4): " + saldo.ToString("F4"));
            Console.WriteLine("saldo.ToString(F4, new CultureInfo(pt-BR)): " + saldo.ToString("F4", new CultureInfo("pt-BR")));
            Console.WriteLine("nome: " + nome);

            int age = 32;
            double amount = 10.35784;
            String name = "Maria";
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", name, age, amount);
            Console.WriteLine($"{name} tem {age} anos e tem saldo igual a {amount:F2} reais");
            Console.WriteLine(name + " tem " + age + " anos e tem saldo igual a " + amount.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            int a = 10;
            Console.WriteLine("a: " + a);
            Console.WriteLine("a+=2: " + (a+=2));
            Console.WriteLine("a-=2: " + (a-=2));
            Console.WriteLine("a*=2: " + (a*=2));
            Console.WriteLine("a/=2;: " + (a/=2));
            Console.WriteLine("a%=2;: " + (a%=2));
            
            string s = "ABN";
            Console.WriteLine("s: " + s);
            Console.WriteLine("s: " + (s+=" CSA"));

            int a1 = 10;
            a1++;
            Console.WriteLine("a1: " + a1);

            int a2 = 10;
            int b1 = a2++;

            Console.WriteLine("a2: " + a2);
            Console.WriteLine("b1: " + b1);

            int a3 = 10;
            int b2 = a3++;

            Console.WriteLine("a3: " + a3);
            Console.WriteLine("b2: " + b2);

            float var_conversao_implicita_float = 30.32f;
            double var_conversao_implicita_double = var_conversao_implicita_float;
            Console.WriteLine("var_conversao_implicita_double: " + var_conversao_implicita_double);

            double a_casting;
            float b_casting;
            a_casting = 5.1;
            b_casting = (float)a_casting;
            Console.WriteLine("b_casting: " + b_casting);

            double a1_casting;
            int b1_casting;
            a1_casting = 5.1;
            b1_casting = (int)a1_casting;
            Console.WriteLine("b1_casting: " + b1_casting);

            int a2_casting = 5;
            int b2_casting = 2;
            double resultado = (double) a / b;
            Console.WriteLine("resultado: " + resultado);

            int n1 = 3 + 4 * 2;
            Console.WriteLine("n1: " + n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine("n2: " + n2);

            int n3 = 17 % 3;
            Console.WriteLine("n3: " + n3);

            double n4 = 10.0 / 8.0;
            Console.WriteLine("n4: " + n4);

            double val_a = 1.0, val_b = -3.0, val_c = -4.0;
            double delta = Math.Pow(val_b, 2.0) - 4.0 * val_a * val_c;
            Console.WriteLine("delta: " + delta);

            double x1 = (-val_b + Math.Sqrt(delta)) / (2.0 * val_a);
            Console.WriteLine("x1: " + x1);

            double x2 = (-val_b - Math.Sqrt(delta)) / (2.0 * val_a);
            Console.WriteLine("x2: " + x2);

            string frase = Console.ReadLine();
            Console.WriteLine("frase: " + frase);

            string frase1 = Console.ReadLine();
            string frase2 = Console.ReadLine();
            string frase3 = Console.ReadLine();
            Console.WriteLine("frase1: " + frase1);
            Console.WriteLine("frase2: " + frase2);
            Console.WriteLine("frase3: " + frase3);

            string frase4 = Console.ReadLine();
            Console.WriteLine("frase4: " + frase4);

            string[] vet_split = frase4.Split(' ');
            string frase5 = char.Parse(vet_split[0]);
            string frase6 = char.Parse(vet_split[1]);
            string frase7 = char.Parse(vet_split[2]);
            Console.WriteLine("frase5: " + frase5);
            Console.WriteLine("frase6: " + frase6);
            Console.WriteLine("frase7: " + frase7);

            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
            string x_read;
            int y_read;
            double z_read;
            char w_read;            

            x_read = Console.ReadLine();
            y_read = int.Parse(Console.ReadLine());
            z_read = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w_read = char.Parse(Console.ReadLine());

            Console.WriteLine("x_read: " + x_read);
            Console.WriteLine("y_read: " + y_read);
            Console.WriteLine("z_read: " + z_read);
            Console.WriteLine("w_read: " + w_read);

            Console.ReadLine();

            double x_out = 10.35784;
            int y_out = 32;
            string z_out = "Maria";
            char w_out = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais.");

            Console.WriteLine();
            Console.WriteLine("x_out: " + x_out);
            Console.WriteLine("x_out.ToString(F2): " + x_out.ToString("F2"));
            Console.WriteLine("x_out.ToString(F4): " + x_out.ToString("F4"));
            Console.WriteLine("x_out.ToString(F2, CultureInfo.InvariantCulture): " + x_out.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x_out);
            Console.WriteLine("O valor do troco é " + x_out + " reais");
            Console.WriteLine("O valor do troco é " + xx_out.ToString("F2") + " reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + z_out + " tem " + y_out + " anos e seu sexo é: " + w_out);

            Console.ReadLine();

            int var_a1 = 10;
            bool bool_var1 = var_a1 < 10;
            bool bool_var2 = var_a1 < 20;
            bool bool_var3 = var_a1 > 10;
            bool bool_var4 = var_a1 > 5;
            Console.WriteLine("bool_var1: " + bool_var1);
            Console.WriteLine("bool_var2: " + bool_var2);
            Console.WriteLine("bool_var3: " + bool_var3);
            Console.WriteLine("bool_var4: " + bool_var4);
            Console.WriteLine("------------");
            bool bool_var5 = var_a1 <= 10;
            bool bool_var6 = var_a1 >= 10;
            bool bool_var7 = var_a1 == 10;
            bool bool_var8 = var_a1 != 10;
            Console.WriteLine("bool_var5: " + bool_var5);
            Console.WriteLine("bool_var6: " + bool_var6);
            Console.WriteLine("bool_var7: " + bool_var7);
            Console.WriteLine("bool_var8: " + bool_var8);

            bool c1 = 2 > 3 || 4 != 5; // true
            bool c2 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine("--------------");
            bool c3 = 10 < 5; // false
            bool c4 = c1 || c2 && c3; // true
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0) {
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Impar");
            }

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            if (preco > 100.0) {
                double desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);

            Console.WriteLine("Digite três números:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            double resultado_maior = Maior(num1, num2, num3);
            Console.WriteLine("Maior = " + resultado_maior);

            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0.0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo!");

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine("Soma = " + soma);
        }

        static int Maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
    }
}