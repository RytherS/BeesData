using BeesData.SharedData.ModelInterfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BeesData.SharedData.ModelInterfaces
{
    public abstract class BaseModel<TModelInterface> : IBaseModel<TModelInterface>
    {
        protected BaseModel<TModelInterface> _original;
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
            foreach(var prop in _properties)
            {
                prop.SetValue(this, prop.GetValue(other));
            }
        }

        /// <summary>
        /// Determines whether the object has changed based off of the original values.
        /// </summary>
        /// <returns>True if any values of the underlying TModelInterface have changed, otherwise false.</returns>
        public bool HasChanged()
        {
            foreach(var prop in _properties)
            {
                if (prop.GetValue(this) != prop.GetValue(_original)) return true;
            }

            return false;
        }

        public abstract bool Validate();
    }
}
