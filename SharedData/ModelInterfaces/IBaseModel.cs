using BeesData.SharedData.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeesData.SharedData.ModelInterfaces
{
    public interface IBaseModel<TModelInterface> : IValidatable
    {
        void CopyFrom(TModelInterface other);
        bool HasChanged();
    }
}
