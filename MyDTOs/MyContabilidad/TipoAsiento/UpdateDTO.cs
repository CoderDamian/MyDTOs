namespace MyDTOs.MyContabilidad.TipoAsiento
{
    public record class UpdateTipoAsientoDTO
    {
        public string Nombre { get; set; } = string.Empty;
        public string Abreviatura { get; set; } = string.Empty;
        public bool EsActiva { get; set; }
        public string UserName { get; set; } = string.Empty;
    }
}