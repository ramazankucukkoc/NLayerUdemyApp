namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //Biz burada Ef Core daki Savechanges() ve SaveChangesAsync() metotlarını kontrol edeceğiz.
        Task CommitAsync();
        void Commit();

    }
}
