using System.Collections.Generic;
using System.Data.Entity;

namespace CalifornianHealthMonolithic
{
    public class ConsultantsInitializer : DropCreateDatabaseIfModelChanges<CHEntities>
    {
        protected override void Seed(CHEntities context)
        {
            List<Consultant> consultants = new List<Consultant>()
            {
                new Consultant {
                    FName = "Jessica",
                    LName = "Wally",
                    Speciality = "Doctor"
                },
                new Consultant {
                    FName = "Iai",
                    LName = "Donas",
                    Speciality = "Doctor"
                },
                new Consultant {
                    FName = "Amanda",
                    LName = "Denyl",
                    Speciality = "Doctor"
                }
            };

            consultants.ForEach(c => context.Consultants.Add(c));

            context.SaveChanges();

        }

        

        
    }
}