namespace MyContabilidad.DTOs.Periodo
{
    public readonly record struct PeriodoDTO
    {
        public DateTime FechaInicial { get; init; }
        public string Nombre { get; init; }
        public bool EsCerrado { get; init; }
    }
}