namespace MyContabilidad.DTOs.CentroCoste
{
    public readonly record struct UpdateCentroCostoDTO
    {
        public string Nombre { get; init; }
        public string UserName { get; init; }
    }
}
