using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Attributes
{
    /// <summary>
    /// 一个自定义特性：实体类的表格别名
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Class
                            , AllowMultiple = false)  // Multiuse attribute.  
    ]
    class TableAliasAttribute : Attribute
    {
        private string alias;

        public TableAliasAttribute(string alias)
        {
            this.Alias = alias;
        }


        public string Alias
        {
            get
            {
                return alias;
            }

            set
            {
                alias = value;
            }
        }
    }

      
}
