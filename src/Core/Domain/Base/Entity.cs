namespace Domain.Base
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Entity()
        {
        }

        public Entity(Guid id) : this()
        {
            Id = id;
        }
    }
}
