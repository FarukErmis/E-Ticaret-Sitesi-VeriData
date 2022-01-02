using System;
using System.Collections.Generic;
using System.Text;

namespace CommercialSite.Core.Entity
{
    public interface IEntity<T>
    {
       T Id { get; set; }
    }
}
