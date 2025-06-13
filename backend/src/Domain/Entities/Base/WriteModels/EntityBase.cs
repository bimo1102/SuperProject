using Domain.Entities.Base.ReadModels;

namespace Domain.Entities.Base.WriteModels
{
    public abstract class EntityBase : IDocument<Guid>
{
        public Guid Id { get; set; }
        public DateTime Created { get; set; } = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Utc);
        public DateTime? Updated { get; set; }
        public DateTime? DeleteAt { get; set; }
        public Guid UserCreated { get; set; }
        public Guid? UserModified { get; set; } = null;
    }

}
