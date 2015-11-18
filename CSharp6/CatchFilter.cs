using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class CatchFilter
    {
        public void ExceptionFilter()
        {
            try
            {
                // Do something
            }
            catch (ArgumentException ex) when (ex.ParamName == "date")
            {
                // Anything
            }
        }

        public void ExceptionFilterOld()
        {
            try
            {
                // Do something
            }
            catch (ArgumentException ex)
            {
                if (ex.ParamName == "date")
                {
                    // Anything
                }
                else
                {
                    throw;
                }
            }
        }

        public void UseMethodExceptionFilter()
        {
            try
            {
                // Do something
            }
            catch (ArgumentException ex) when (FilterCondition(ex))
            {
                // Anything
            }
        }

        public bool FilterCondition(ArgumentException ex)
        {
            // return false; // false 를 반환하면 catch 블록 내로 진입하지 않습니다.
            return true; // true 를 반환하면 catch 블록 내로 진입합니다.
        }
    }
}
