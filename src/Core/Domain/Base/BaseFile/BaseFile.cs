namespace Domain.Base.BaseFile
{
    public abstract class BaseFile : Entity
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public string Storage { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
