using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Requests.Commands
{
    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
