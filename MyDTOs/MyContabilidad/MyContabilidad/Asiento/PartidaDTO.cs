namespace MyContabilidad.DTOs.Asiento
{
    public readonly record struct PartidaDTO
    {
        public int OrdenIngreso { get; init; }
        public int CentroCosto_ID { get; init; }
        public string CentroCosto { get; init; } 
        public string CodigoContable_ID { get; init; }
        public string NombreCuentaContable { get; init; }
        public string Glosa { get; init; } 
        public double Debe { get; init; }
        public double Haber { get; init; }
    }
}