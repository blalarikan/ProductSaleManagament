using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //productmanagerda tanımladığımız ruleları tek bir metod ile çalıştıracağız.
        public static IResult Run(params IResult[] logics) //params kullandığımda istediğim kadar rule ı tek metotta çalıştırabilirim.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            return null;
        }

       
    }
}
