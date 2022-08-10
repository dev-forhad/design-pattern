using BusinessLayer;
using System;
using System.Collections.Generic;

namespace CustomerFactory
{
    public static class CusFactory // Design Pattern -: Simple Factory Pattern
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();

        public static CustomerBase Create(string TypeCust)
        {
            //Design Pattern -: Lazy Loading
            if (custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            //Design Pattern -: RIP Pattern (Replace If Polymorphism)
            return custs[TypeCust];
        }
    }
}
