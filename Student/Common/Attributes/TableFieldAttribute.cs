using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Common.Attributes
{
    /// <summary>
    /// 一个自定义特性：实体类属性与数据库表字段关联
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Field |
                            System.AttributeTargets.Property
                            ,AllowMultiple = false)  // Multiuse attribute.  
    ]
    class TableFieldAttribute : Attribute
    {
        private string fieldName;
        private string fieldType;
        private bool primaryKey;


        public TableFieldAttribute(string fieldName, string fieldType)
        {
            this.FieldName = fieldName;
            this.FieldType = fieldType;
            this.primaryKey = false;
        }

        public TableFieldAttribute(string fieldName, string fieldType, bool primaryKey)
        {
            this.FieldName = fieldName;
            this.FieldType = fieldType;
            this.PrimaryKey = primaryKey;
        }

        public string FieldName
        {
            get
            {
                return fieldName;
            }

            set
            {
                fieldName = value;
            }
        }

        public string FieldType
        {
            get
            {
                return fieldType;
            }

            set
            {
                fieldType = value;
            }
        }

        public bool PrimaryKey
        {
            get
            {
                return primaryKey;
            }

            set
            {
                primaryKey = value;
            }
        }
    }
}
