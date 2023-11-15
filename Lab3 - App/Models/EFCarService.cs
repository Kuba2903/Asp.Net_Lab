﻿
using Data___App;
using Lab3.Mappers;
namespace Lab3.Models
{
    public class EFCarService : ICarService
    {
        private AppDbContext _context;

        public EFCarService(AppDbContext context)
        {
            _context = context;
        }
        public int Add(Car car)
        {
            var e = _context.Cars.Add(CarMapper.MapToEntity(car));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            var entity = _context.Cars.Find(id);
            if(entity != null)
            {
                _context.Cars.Remove(entity);
                _context.SaveChanges();
            }
        }

        public List<Car> FindAll() => _context.Cars.Select(x => CarMapper.MapToModel(x)).ToList();

        public Car? FindById(int id) => CarMapper.MapToModel(_context.Cars.Find(id));

        public void Update(Car car)
        {
            _context.Cars.Update(CarMapper.MapToEntity(car));
            _context.SaveChanges();
        }
    }
}
