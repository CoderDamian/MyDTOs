namespace MyContabilidad.DTOs.Periodo
{
    //https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/enumeration-classes-over-enum-types
    //https://www.youtube.com/watch?v=-imbCoyINwA&ab_channel=PlainConcepts
    public readonly record struct AddPeriodoDTO
    {
        public string Nombre { get; init; }
        public DateTime FechaInicial { get; init; }
        public Int16 NumeroPeridos { get; init; }
        public char Longitud { get; init; }
        public string UserName { get; init; }
    }
}