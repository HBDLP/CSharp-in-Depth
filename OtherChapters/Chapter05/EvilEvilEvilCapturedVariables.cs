using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chapter05
{
    [Description("Listing 5.14")]
    class EvilEvilEvilCapturedVariables
    {
        static void Main()
        {
            MethodInvoker[] delegates = new MethodInvoker[2];

            int outside = 0;                                       

            for (int i=0; i < 2; i++)
            {
                int inside = 0;                                    

                delegates[i] = delegate                            
                {
                    Console.WriteLine ("({0},{1})",
                                       outside, inside);
                    outside++;
                    inside++;
                };
            }

            MethodInvoker first = delegates[0];
            MethodInvoker second = delegates[1];

            first();
            first();
            first();

            second();
            second();
        }
    }
}
