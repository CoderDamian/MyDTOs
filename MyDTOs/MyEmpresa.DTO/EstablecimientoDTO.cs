namespace MyEmpresa.DTO
{
    public readonly record struct EstablecimientoDTO
    {
        public string Numero { get; init; } 
        public string NombreComercial { get; init; } 
        public string Direccion { get; init; } 
        public bool EsMatriz { get; init; } 
        public bool EsActivo { get; init; } 
    }
}