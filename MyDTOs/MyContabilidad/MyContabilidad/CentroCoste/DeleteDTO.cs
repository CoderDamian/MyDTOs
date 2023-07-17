namespace MyContabilidad.DTOs.CentroCoste
{
    public readonly record struct DeleteCentroCostoDTO
    {
        public string UserName { get; init; }
        public DateTime? LastUpdatedDate { get; init; }
    }
}
