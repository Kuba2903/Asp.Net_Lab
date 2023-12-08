
using Data___App.Entities;
using Lab3.Models;

namespace Lab3.Mappers
{
    public class CarMapper
    {
        public static Car MapToModel(CarEntity entity)
        {
            return new Car()
            {
                Id = entity.Id,
                Model = entity.Model,
                Producent = entity.Producent,
                PojemmoscSilnika = entity.PojemnoscSilnika,
                Moc = entity.Moc,
                RodzajSilnika = entity.RodzajSilnika,
                NrRejestracyjny = entity.NrRejestracyjny,
                Wlasciciel = entity.Wlasciciel,
                Priority = (Priority)entity.Priorytet,
                OrganizationId = entity.OrganizationId
            };
        }

        public static CarEntity MapToEntity(Car model)
        {
            return new CarEntity()
            {
                Id = model.Id,
                Model = model.Model,
                Producent = model.Producent,
                PojemnoscSilnika = model.PojemmoscSilnika,
                Moc = model.Moc,
                RodzajSilnika = model.RodzajSilnika,
                NrRejestracyjny = model.NrRejestracyjny,
                Wlasciciel = model.Wlasciciel,
                Priorytet = (byte)model.Priority,
                OrganizationId = model.OrganizationId,
            };
        }
    }
}