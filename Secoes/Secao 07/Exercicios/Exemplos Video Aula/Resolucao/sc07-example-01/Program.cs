using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int in_switch = int.Parse(Console.ReadLine());
            string day;
            if (in_switch == 1)
            {
                day = "Sunday";
            }
            else if (in_switch == 2)
            {
                day = "Monday";
            }
            else if (in_switch == 3)
            {
                day = "Tuesday";
            }
            else if (in_switch == 4)
            {
                day = "Wednesday";
            }
            else if (in_switch == 5)
            {
                day = "Thursday";
            }
            else if (in_switch == 6)
            {
                day = "Friday";
            }
            else if (in_switch == 7)
            {
                day = "Saturday";
            }
            else
            {
                day = "Invalid value";
            }
            Console.WriteLine("Day: " + day);

            switch (in_switch)
            {
                case 1:
                    day = "Sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;
            }
            Console.WriteLine("Day: " + day);

            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine("desconto: " + desconto);

            double desconto_ternario = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine("desconto_ternario: " + desconto_ternario);

            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            DateTime dnow = DateTime.Now;
            Console.WriteLine(dnow);
            Console.WriteLine(dnow.Ticks);

            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.UtcNow;
            DateTime d6 = DateTime.Today;
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime d7 = DateTime.Parse("2000-08-15");
            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d9 = DateTime.Parse("15/08/2000");
            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d11);
            Console.WriteLine(d12);

            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine(t12);

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            string s8 = d.ToLongDateString();
            string s9 = d.ToLongTimeString();
            string s10 = d.ToShortDateString();
            string s11 = d.ToShortTimeString();
            string s12 = d.ToString();
            string s13 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s14 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s8);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine(s11);
            Console.WriteLine(s12);
            Console.WriteLine(s13);
            Console.WriteLine(s14);

            TimeSpan tMax = TimeSpan.MaxValue;
            TimeSpan tMin = TimeSpan.MinValue;
            TimeSpan tZero = TimeSpan.Zero;
            Console.WriteLine(tMax);
            Console.WriteLine(tMin);
            Console.WriteLine(tZero);

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            TimeSpan tOp1 = new TimeSpan(1, 30, 10);
            TimeSpan tOp2 = new TimeSpan(0, 10, 5);
            TimeSpan sum = tOp1.Add(tOp2);
            TimeSpan dif = tOp1.Subtract(tOp2);
            TimeSpan mult = tOp2.Multiply(2.0);
            TimeSpan div = tOp2.Divide(2.0);
            Console.WriteLine(tOp1);
            Console.WriteLine(t2);
            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

            DateTime dtk1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime dtk2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime dtk3 = new DateTime(2000, 8, 15, 13, 5, 58);
            Console.WriteLine("d1: " + dtk1);
            Console.WriteLine("d1 Kind: " + dtk1.Kind);
            Console.WriteLine("d1 to Local: " + dtk1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + dtk1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + dtk2);
            Console.WriteLine("d2 Kind: " + dtk2.Kind);
            Console.WriteLine("d2 to Local: " + dtk2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + dtk2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + dtk3);
            Console.WriteLine("d3 Kind: " + dtk3.Kind);
            Console.WriteLine("d3 to Local: " + dtk3.ToLocalTime());
            Console.WriteLine("d3 to Utc: " + dtk3.ToUniversalTime());

            DateTime dIso1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dIso2 = DateTime.Parse("2000-08-15T13:05:58Z"); // cria local DateTime
            Console.WriteLine("d1: " + dIso1);
            Console.WriteLine("d1 Kind: " + dIso1.Kind);
            Console.WriteLine("d1 to Local: " + dIso1.ToLocalTime());
            Console.WriteLine("d1 to Utc: " + dIso1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + dIso2);
            Console.WriteLine("d2 Kind: " + dIso2.Kind);
            Console.WriteLine("d2 to Local: " + dIso2.ToLocalTime());
            Console.WriteLine("d2 to Utc: " + dIso2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(dIso2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(dIso2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}