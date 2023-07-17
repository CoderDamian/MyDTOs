namespace MyDTOs.MyContabilidad.Secuencial
{
    public readonly record struct AddSecuencialDTO
    {
        public int Periodo_Fk { get; init; }
        public int TipoAsiento_Fk { get; init; }
        public string UserName { get; init; }
    }
}