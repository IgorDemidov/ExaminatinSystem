using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL.Entities
{
    public class Theme: IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Question> Questions { get; set; }
    }
}
