﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PersonType : EntityHelper.Entity
    {
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
