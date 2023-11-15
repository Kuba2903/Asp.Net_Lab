using Data.Entities;
using Lab4.Models;

namespace Lab4.Mappers
{
    public class ContactMapper
    {
        public static Contact FromEntity(ContactEntity entity)
        {
            return new Contact()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Subject = entity.Subject,
                Message = entity.Message,
                Priority = (Priority)entity.Priority,
                Date = entity.Date,
            };
        }

        public static ContactEntity ToEntity(Contact model)
        {
            return new ContactEntity()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Subject = model.Subject,
                Message = model.Message,
                Priority = (byte)model.Priority,
                Date = model.Date,
            };
        }
    }
}
