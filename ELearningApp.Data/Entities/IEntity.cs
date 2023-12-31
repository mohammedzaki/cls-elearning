﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearningApp.Data.Entities
{
    public interface IEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime DeletedAt { get; set; }
    }
}
