using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Superbad.PublicMethod();
                //Bad.PublicMethod();
                //Good.PublicMethod();
            }
            catch (Exception ex)
            {
                var r = ex.StackTrace;
                System.Diagnostics.Trace.WriteLine(r);
            }
        }
    }
}
