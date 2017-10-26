using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Good
    {
        public static void PublicMethod()
        {
            try
            {
                PrivateMethod();
            }
            catch (Exception ex)
            {
                ExceptionDispatchInfo.Capture(ex).Throw();
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
                ExceptionDispatchInfo.Capture(ex).Throw();
            }
        }
    }
}
