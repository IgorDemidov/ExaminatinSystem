using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.DAL.Entities
{
    public class ExamContext: DbContext
    {
        public ExamContext() : base("DBExamination")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theme>().HasMany<Question>(e => e.Questions)
                .WithRequired(e => e.Theme)
                .HasForeignKey(s => s.ThemeId);
                
            //modelBuilder.Entity<Question>().HasRequired<Theme>(e => e.Theme).WithMany(e => e.Questions);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}
