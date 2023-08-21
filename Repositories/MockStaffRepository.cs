using l04_assignment.Models;

namespace l04_assignment.Repositories;

public class MockStaffRepository : IStaffRepository 
{
    private List<Staff> staffList;

    public MockStaffRepository() {
        staffList = new List<Staff>
        {
            new Staff
            {
                Name = "Gordon Ramsey",
                Description = "This lamb is so undercooked, it's following Mary to school!",
                Title = "Big Boss"
            },
            new Staff
            {
                Name = "Jonh Snow",
                Description = "Head cooks oversee the daily process of running a kitchen and managing food preparation at restaurants and other similar establishments.",
                Title = "Head Cook"
            },
            new Staff
            {
                Name = "Tamia Ruffin",
                Description = "Restaurant General Managers are responsible for leading and managing restaurants. They may be responsible for different tasks such as restaurant marketing strategies, recruiting and hiring restaurant staff, training, overseeing food quality, developing menus as well as greeting and serving restaurant guests.",
                Title = "General Manager"
            },
            new Staff
            {
                Name = "Roberto Lombardo",
                Description = "The Head Sommelier ensures the smooth running of the Sommeliers operation on a day-to-day basis, in line with company standards and policies outlined in the operational manuals and in the human resources manual, including familiarizing and training of employees; planning, assigning and directing work.",
                Title = "Head Sommelier"
            }
        };
    }
    
    public IEnumerable<Staff> GetAllStaff()
    {
        return staffList;
    }
}