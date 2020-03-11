using System.Data.Entity;

namespace CalifornianHealthMonolithic
{
    public class PatientsInitializer : DropCreateDatabaseIfModelChanges<CHEntities>
    {

    }
}