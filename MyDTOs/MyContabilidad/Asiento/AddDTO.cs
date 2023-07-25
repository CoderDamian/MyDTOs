namespace MyDTOs.MyContabilidad.Asiento
{
    public record class AddAsientoContableDTO
    {
        public DateTime Fecha { get; set; }
        public string Glosa { get; set; } = string.Empty;
        public int TipoAsientoId { get; set; }
        public IList<PartidaDTO>? PartidaDTOs { get; private set; }
        public string UserName { get; set; } = string.Empty;
    }
}