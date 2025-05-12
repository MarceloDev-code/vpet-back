namespace VPetBackend.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; } = "NuevoPet";
        public required string Species { get; set; }
        public PetStats Stats { get; set; } = new PetStats
        {
            Strength = 10,
            Intelligence = 10,
            Dexterity = 10,
            Speed = 10,
            Endurance = 10,
            Charisma = 10
        };
    }

    public class PetStats
    {
        public required int Strength { get; set; }
        public required int Intelligence { get; set; }
        public required int Dexterity { get; set; }
        public required int Speed { get; set; }
        public required int Endurance { get; set; }
        public required int Charisma { get; set; }
    }
}
