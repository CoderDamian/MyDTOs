namespace MyDTOs.MyContabilidad.Asiento
{
    public record class PartidaDTO
    {
        public int OrdenIngreso { get; set; }
        public int CentroCosto_ID { get; set; }
        public int CodigoContable_ID { get; set; }
        public string Glosa { get; set; } = string.Empty;
        public double Debe { get; set; }
        public double Haber { get; set; }
    }
}