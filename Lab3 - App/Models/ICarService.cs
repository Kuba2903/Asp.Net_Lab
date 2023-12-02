using Data___App.Entities;

namespace Lab3.Models
{
    public interface ICarService
    {
        int Add(Car car);
        void Delete(int id);
        void Update(Car car);
        List<Car> FindAll();
        Car? FindById(int id);
        List<OrganizationEntity> FindAllOrganizationsForVieModel();
    }
}
