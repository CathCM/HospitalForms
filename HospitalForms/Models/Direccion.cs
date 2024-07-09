using System;
using System.Text;

namespace Hospital
{
    public class Direccion
    {
        public string TipoVia { get; set; }
        public string NombreVia { get; set; }
        public string NumeroDeCalle { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string CodigoPostal { get; set; }
        public string OtraInformacion { get; set; }

        public Direccion(string tipoVia, string nombreVia, string numeroDeCalle, string ciudad, string pais, string codigoPostal, string otraInformacion)
        {
            TipoVia = tipoVia;
            NombreVia = nombreVia;
            NumeroDeCalle = numeroDeCalle;
            Ciudad = ciudad;
            Pais = pais;
            CodigoPostal = codigoPostal;
            OtraInformacion = otraInformacion;
        }
        
        // public override string ToString()
        // {
        //     StringBuilder stringBuilder = new StringBuilder();
        //
        //     stringBuilder.AppendLine($"Tipo de vía: {TipoVia}");
        //     stringBuilder.AppendLine($"Nombre vía: {NombreVia}");
        //     stringBuilder.AppendLine($"Número de calle: {NumeroDeCalle}");
        //     stringBuilder.AppendLine($"Ciudad: {Ciudad}");
        //     stringBuilder.AppendLine($"País: {Pais}");
        //     stringBuilder.AppendLine($"Código postal: {CodigoPostal}");
        //     stringBuilder.AppendLine($"Otra información: {OtraInformacion}");
        //
        //     return stringBuilder.ToString();
        // }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{TipoVia} {NombreVia} {NumeroDeCalle}, {CodigoPostal}, {Ciudad}, {Pais}");
            stringBuilder.Append($"Informacion adicional: {OtraInformacion}");

            return stringBuilder.ToString();
        }
    }
}