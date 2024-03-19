namespace ahshitherewegoagain.Model
{
    public class Component
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public int StorageId { get; set; }
        public int Count { get; set; }
        public int MinCount { get; set; } 
    }
}
