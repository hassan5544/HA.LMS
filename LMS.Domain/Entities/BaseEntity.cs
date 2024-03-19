namespace LMS.Domain.Entities
{
    public class BaseEntity<T>
    {
        public T? Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public int CreateUser { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public int UpdateUser { get; protected set; }
        public bool IsDeleted { get; protected set; }
        public DateTime DeleteDate { get; protected set; }
        public int DeleteUser { get; protected set; }

        public void SetDeleted(int DeletedBy)
        {
            DeleteDate = DateTime.Now;
            DeleteUser = DeletedBy;
            IsDeleted = true;
        }

        public void
    }
}
