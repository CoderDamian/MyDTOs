namespace MyEmpresa.DTOs.Contribuyente
{
    // DDD and CQRS patterns comment: Note that it is recommended to implement immutable Commands
    // In this case, its immutability is achieved by having all the setters as init
    // References on Immutable Commands:  
    // http://cqrs.nu/Faq
    // https://docs.spine3.org/motivation/immutability.html 
    // http://blog.gauffin.org/2012/06/griffin-container-introducing-command-support/
    // https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-a-lightweight-class-with-auto-implemented-properties
    public readonly record struct GetContribuyenteDTO
    {
        public string RUC { get; init; } 
        public string RazonSocial { get; init; } 
        public string ActividadEconomicaPrincipal { get; init; } 
        public string NombreRepresentanteLegal { get; init; } 
        public string IdentificacionRepresentanteLegal { get; init; } 
        public IList<EstablecimientoDTO> Establecimientos { get; init; } 
    }
}