namespace MyDTOs.MyContabilidad.TipoAsiento
{
    public readonly record struct AddTipoAsientoDTO
    {
        public string Descripcion { get; init; }
        public string Abreviatura { get; init; }
        public string UserName { get; init; }
    }
}