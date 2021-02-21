using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdditionalTasks2_SortinganExpression
{
   static class ExtentedSortForStringExpression
    {
        static public string SortExpression(this string expression, TypeSort typeSort)
        {
            MySorterExpression myDitionary = new MySorterExpression(expression);
            string sortExp = myDitionary.InvokSortMethd(typeSort);
            return sortExp;
        }
    }
   
}
