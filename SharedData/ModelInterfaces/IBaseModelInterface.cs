using BeesData.SharedData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeesData.SharedData.ModelInterfaces
{
    public interface IBaseModelInterface<TModelInderface> : IValidatable
    {
        void CopyFrom(TModelInderface other);
    }
}
