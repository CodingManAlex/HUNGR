using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HUNGR.WebApp.Models
{
    public static class FoodEnum
    {

        public enum FoodCat : int
        {
            [Display(Name = "Sea Food")]
            SeaFood = 1,
            [Display(Name = "Fried Food")]
            FriedFood = 2,
            [Display(Name = "Sandwiches")]
            Sandwich = 3,
            Mexican = 4,
            Italian = 5,
            Burgers = 6,
            Japanese = 7


        }
        public static string GetDisplayName(this Enum enu)
        {
            var attr = GetDisplayAttribute(enu);
            return attr != null ? attr.Name : enu.ToString();
        }
        private static DisplayAttribute GetDisplayAttribute(object value)
        {
            Type type = value.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException(string.Format("Type {0} is not an enum", type));
            }

            // Get the enum field.
            var field = type.GetField(value.ToString());
            return field == null ? null : field.GetCustomAttribute<DisplayAttribute>();
        }
    }
    
}
