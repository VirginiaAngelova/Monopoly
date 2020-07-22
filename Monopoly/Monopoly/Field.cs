using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public abstract class Field
    {
        protected string _field;

        public Field(string fieldName)
        {
            this._field = fieldName;
        }
        public string FieldName{
            get
            {
                return this._field;
            }
            set
            {
                this._field = value;
            }
        }
    }
}
