﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.BLL.Models
{
    public class AnswerModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsRight { get; set; }
        public int QuestionId { get; set; }

        public QuestionModel QuestionModel { get; set; }
    }
}
