﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.TesisData.TesisModels
{
    public partial class Fornitori
    {
        public long IdFornitore { get; set; }
        public string CodFornitore { get; set; }
        public string RagioneSociale { get; set; }
        public string Indirizzo { get; set; }
        public string Localita { get; set; }
        public string Provincia { get; set; }
        public string Cap { get; set; }
        public string PartitaIva { get; set; }
        public string CodiceFiscale { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string Note { get; set; }
        public string CodiceEsterno { get; set; }
        public bool? Valido { get; set; }
        public long? FirstUser { get; set; }
        public DateTime? FirstDate { get; set; }
        public long? LastUser { get; set; }
        public DateTime? LastDate { get; set; }
        public byte[] LastUp { get; set; }
    }
}