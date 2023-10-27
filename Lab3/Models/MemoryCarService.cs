namespace Lab3.Models
{
    public class MemoryCarService : ICarService
    {
        static Dictionary<int, Car> _cars = new Dictionary<int, Car>();
        public int Add(Car car)
        {
            int id = _cars.Keys.Count != 0 ? _cars.Keys.Max() : 0;
            car.Id = id + 1;
            _cars.Add(car.Id, car);
            return car.Id;
        }

        public void Delete(int id) => _cars.Remove(id);

        public List<Car> FindAll() => _cars.Values.ToList();

        public Car? FindById(int id) => _cars[id];

        public void Update(Car car) => _cars[car.Id] = car;
    }
}
