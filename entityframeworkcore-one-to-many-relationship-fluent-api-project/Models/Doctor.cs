namespace entityframeworkcore_one_to_many_relationship_project.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        // One-to-Many Relationship: One Doctor can have many Patients
        public List<Patient>? Patients { get; set; } // navigation property
    }
}