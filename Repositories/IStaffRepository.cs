using l04_assignment.Models;

namespace l04_assignment.Repositories;

public interface IStaffRepository
{
    IEnumerable<Staff> GetAllStaff();
}
