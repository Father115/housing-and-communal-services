using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard1.Сlasses
{
    public class DataTransmission
    {
        public static bool RateType(int id, string secondName, string name, string lastName,
         int id_rateType, string symma, Housing_officeEntities db)
        {
            try
            {
                Rate rate = db.Rate.Where(s => s.ID_Тариф == id).FirstOrDefault();
                rate.ID_Тип_ресурса = id_rateType;
                rate.Значение = symma;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
