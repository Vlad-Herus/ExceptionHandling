using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Superbad
    {
        public static void PublicMethod()
        {
            try
            {
                PrivateMethod();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        static void PrivateMethod()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
