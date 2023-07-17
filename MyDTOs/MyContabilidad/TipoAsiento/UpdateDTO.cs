namespace MyDTOs.MyContabilidad.TipoAsiento
{
    public readonly record struct UpdateTipoAsientoDTO
    {
        public string Nombre { get; init; }
        public string Abreviatura { get; init; }
        public bool EsActiva { get; init; }
        public string UserName { get; init; }
    }
}