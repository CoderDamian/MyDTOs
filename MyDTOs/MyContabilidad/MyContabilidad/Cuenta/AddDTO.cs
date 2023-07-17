﻿namespace MyContabilidad.DTOs.Cuenta
{
    public readonly record struct AddDTO
    {
        public string CodigoContablePadre { get; init; }
        public string Nombre { get; init; }
        public string CreatedBy { get; init; }
    }
}