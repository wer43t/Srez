using SQLite;

namespace Srez.Model
{
    public class Project
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }

        public string Name { get; set; }

        public int User_id { get; set; }
    }
}
