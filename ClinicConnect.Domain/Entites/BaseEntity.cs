namespace ClinicConnect.Domain.Entites
{
    abstract public class BaseEntity
    {
        public Guid Id { get; private set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}