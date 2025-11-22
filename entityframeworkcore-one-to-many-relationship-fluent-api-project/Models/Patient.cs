namespace entityframeworkcore_one_to_many_relationship_project.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        // One-to-Many Relationship: Many Patients belong to one Doctor
        public Doctor? Doctor { get; set; } // navigation property
        public int DoctorID { get; set; } // foreign key
    }
}