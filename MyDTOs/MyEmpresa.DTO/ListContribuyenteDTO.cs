namespace MyEmpresa.DTO
{
    public readonly record struct ListContribuyenteDTO
    {
        public byte Id { get; init; }
        public string RUC { get; init; }
        public string RazonSocial { get; init; }
        public string RepresentanteLegal { get; init; }
        public string IdentificacionRepresentanteLegal { get; init; }
    }
}
