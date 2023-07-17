namespace MyEmpresa.DTOs.Contribuyente
{
    public readonly record struct EditContribuyenteDTO
    {
        public string RUC { get; init; }
        public string RazonSocial { get; init; }
        public string ActividadEconomicaPrincipal { get; init; }
        public string NombreRepresentanteLegal { get; init; }
        public string IdentificacionRepresentanteLegal { get; init; }
        public IList<EstablecimientoDTO> Establecimientos { get; init; }
    }
}
