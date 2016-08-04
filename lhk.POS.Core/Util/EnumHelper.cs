using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace lhk.POS.Core.Util
{
    public static class EnumHelper
    {
        /// <summary>
        /// Gets the description from enum.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <returns>The string from the description attribute (if any); otherwise, the enum string value.</returns>
        /// <exception cref="System.ArgumentNullException">value</exception>
        public static string GetDescription(this System.Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }
            string description = value.ToString();
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = ((DescriptionAttribute)attributes[0]).Description;
            }
            return description;
        }

        public static T Parse<T>(this string value)// where T : Enum
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException
                    ("Can't parse an empty string");
            }

            Type enumType = typeof(T);
            if (!enumType.IsEnum)
            {
                throw new InvalidOperationException
                    ("Here's why you need enum constraints!!!");
            }

            // warning, can throw
            return (T)Enum.Parse(enumType, value);
        }

        /// <summary>
        /// Returns the KeyValuePair list of enums with the enum as the key and description as the value.
        /// </summary>
        /// <param name="type">The type of enum.</param>
        /// <returns>IList.</returns>
        /// <exception cref="System.ArgumentNullException">type</exception>
        public static IList ToList(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
            }
            return list;
        }

        public static IList ToList<T>(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (!type.IsEnum)
            {
                throw new ArgumentException("Type provided must be an Enum.", "type");
            }
            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<T, string>((T)Convert.ChangeType(value, typeof(T), System.Globalization.CultureInfo.InvariantCulture), GetDescription(value)));
            }
            return list;
        }
    }
}
