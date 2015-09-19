﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL.Entities
{
    public class Question: IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Theme Theme { get; set; }
        public IList<Answer> Answers { get; set; }
    }
}