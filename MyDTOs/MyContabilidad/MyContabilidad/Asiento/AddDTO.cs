namespace MyContabilidad.DTOs.Asiento
{
    public readonly record struct AddAsientoContableDTO
    {
        public DateTime Fecha { get; init; } 
        public string Glosa { get; init; } 
        public int TipoAsientoId { get; init; }
        public ICollection<PartidaDTO>? PartidaDTOs { get; private init; }
        public string UserName { get; init; }
    }
}