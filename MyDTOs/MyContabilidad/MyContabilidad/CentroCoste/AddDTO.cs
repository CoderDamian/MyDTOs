namespace MyContabilidad.DTOs.CentroCoste
{
    public readonly record struct AddCentroCostoDTO
    {
        public int CentroCostoPadre { get; init; }
        public string Nombre { get; init; }
        public string UserName { get; init; }
    }
}