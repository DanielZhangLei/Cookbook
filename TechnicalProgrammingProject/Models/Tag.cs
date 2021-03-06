﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalProgrammingProject.Models
{
    public class Tag
    {
        public Tag()
        {
            Recipes = new HashSet<Recipe>();
        }
        //PK
        public int ID { get; set; }
        public string Name { get; set; }

        //return recipes
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}