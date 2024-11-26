﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enviromental_Measurement.Common
{
   public abstract class Entity
    {
        #region Properties
     public Guid Id { get; set; }
        #endregion

     protected Entity()
        {
            Id = Guid.NewGuid();
        }

    protected Entity(Guid id)
    {
        Id = id;
    }
  

    }
}
