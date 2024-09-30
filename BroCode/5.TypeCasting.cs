namespace BroCode
{
    internal class TypeCasting
    {
        public TypeCasting()
        {
            /*
                Typecasting is the process of converting a
             variable from one data type to another. 
            */

            double a = 3.14;
            int b = Convert.ToInt32(a);
            Console.WriteLine(b + " - " + b.GetType());

            int c = 134;
            double d = Convert.ToDouble(c) + 0.309;
            Console.WriteLine(d + " - " + d.GetType());

            int e = 123;
            string f = Convert.ToString(d);
            Console.WriteLine(f + " - " + f.GetType());

            string g = "@";
            char h = Convert.ToChar(g);
            Console.WriteLine(h + " - " + h.GetType());

            string i = "false";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j + " - " + j.GetType());

            Console.ReadKey();
        }
    }
}
