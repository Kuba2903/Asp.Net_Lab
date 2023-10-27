namespace Lab4.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetDate() => DateTime.Now;
    }
}
