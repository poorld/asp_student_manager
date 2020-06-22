using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Attributes
{
    /// <summary>
    /// 一个自定义特性：一个属性与枚举类关联
    /// </summary>
    [AttributeUsage(
        AttributeTargets.Property,
        AllowMultiple = false)]
    class EnumFieldAttribute : Attribute
    {
        private Type enumClazz;

        public EnumFieldAttribute(Type EnumClazz)
        {
            this.enumClazz = EnumClazz;
        }

        public Type EnumClazz
        {
            get
            {
                return enumClazz;
            }

            set
            {
                enumClazz = value;
            }
        }

    }
}
