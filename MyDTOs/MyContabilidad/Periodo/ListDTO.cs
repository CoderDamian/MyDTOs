namespace MyDTOs.MyContabilidad.Periodo
{
    public readonly record struct ListPeriodoDTO
    {
        public int Id { get; init; }
        public DateTime FechaInicial { get; init; }
        public string Nombre { get; init; }
        public bool EsCerrado { get; init; }
    }
}