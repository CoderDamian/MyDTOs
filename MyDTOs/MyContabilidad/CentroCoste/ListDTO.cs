namespace MyDTOs.MyContabilidad.CentroCoste
{
    public readonly record struct ListCentrosCostosDTO
    {
        public int Id { get; init; }
        public string CentroCostoPadre { get; init; }
        public string Nombre { get; init; }
    }
}
