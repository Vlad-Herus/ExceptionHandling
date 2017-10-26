using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Bad
    {
        public static void PublicMethod()
        {
            try
            {
                PrivateMethod();
            }
            catch (Exception)
            {
                throw;
            }
        }


        static void PrivateMethod()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
