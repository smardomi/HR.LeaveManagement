namespace HR.LeaveManagement.Domain.Common
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }
    }

    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}
