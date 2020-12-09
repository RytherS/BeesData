using BeesData.SharedData.Interfaces;
using BeesData.SharedData.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BeesData.SharedData.ModelInterfaces
{
    public abstract class BaseModel<TModelInterface>
    {
        private PropertyInfo[] _properties => typeof(TModelInterface).GetProperties();

        public BaseModel()
        {
            if (!typeof(TModelInterface).IsInstanceOfType(this)) throw new Exception($"{GetType().FullName} must also implement {typeof(TModelInterface).FullName}.");
        }

        /// <summary>
        /// Copies property values from equivalent model interface.
        /// </summary>
        public void CopyFrom(TModelInterface other)
        {
            if (other != null)
            {
                foreach(var prop in _properties)
                {
                    prop.SetValue(this, prop.GetValue(other));
                }
            }
        }

        public abstract bool IsValid();
    }
}
