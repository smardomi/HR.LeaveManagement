namespace HR.LeaveManagement.Application.DTOs.Common
{
    public abstract class BaseDto<TKey>
    {
        public TKey Id { get; set; }
    }

    public abstract class BaseDto : BaseDto<int>
    {
    }
}
