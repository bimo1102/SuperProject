namespace Domain.Entities.Base.ReadModels
{
     public interface IDocument { }

    public interface IDocument<TKey> : IDocument
    {
        TKey Id { get; set; }
    }
}