namespace MyContabilidad.DTOs.Secuencial
{
    public readonly record struct ListSecuencialDTO
    {
        public string NombrePeriodo { get; init; }
        public string TipoAsiento { get; init; }
        public int Secuencia { get; init; }
    }
}