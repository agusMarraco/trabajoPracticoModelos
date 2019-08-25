using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webServiceModelos.BLL
{
    public class GenerateData
    {
        public static List<BusinessObject> execute()
        {
            int iterations = 10;

            List<BusinessObject> result = new List<BusinessObject>();
            for (int i = 0; i < iterations; i++)
            {
                result.Add(new BusinessObject("nombre" + i, "apellido" + i, 20 + i, "address" + i, "city" + i, new DateTime().AddDays((i))));
            }
            return result;
        }
    }
}
