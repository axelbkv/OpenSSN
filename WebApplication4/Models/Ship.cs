using System;
using System.Collections.Generic;

namespace OSSN.Models
{
    public partial class Ship
    {
        public int Shipid { get; set; }
        public int ShiphulltypeShiphulltypeid { get; set; }
        public int ShippowertypeShippowertypeid { get; set; }
        public int ShipbreadthtypeShipbreadthtypeid { get; set; }
        public int ShiplengthtypeShiplengthtypeid { get; set; }
        public int ShipflagcodeShipflagcodeid { get; set; }
        public int CountryCountryid { get; set; }
        public int ShipsourceShipsourceid { get; set; }
        public int ShipstatusShipstatusid { get; set; }
        public int CompanyCompanyid { get; set; }
        public int ShiptypeShiptypeid { get; set; }
        public int? Imono { get; set; }
        public int? Yearofbuild { get; set; }
        public int? Mmsino { get; set; }
        public string Shipname { get; set; }
        public string Callsign { get; set; }
        public int? Dwt { get; set; }
        public int? Grosstonnage { get; set; }
        public float? Shiplength { get; set; }
        public float? Breadth { get; set; }
        public float? Speed { get; set; }
        public int? Power { get; set; }
        public float? Height { get; set; }
        public float? Draught { get; set; }
        public bool? Hassidethrusters { get; set; }
        public bool? Hassidethrustersfront { get; set; }
        public bool? Hassidethrustersback { get; set; }
        public string Remark { get; set; }

        public Company CompanyCompany { get; set; }
        public Country CountryCountry { get; set; }
        public Shipbreadthtype ShipbreadthtypeShipbreadthtype { get; set; }
        public Shipflagcode ShipflagcodeShipflagcode { get; set; }
        public Shiphulltype ShiphulltypeShiphulltype { get; set; }
        public Shiplengthtype ShiplengthtypeShiplengthtype { get; set; }
        public Shippowertype ShippowertypeShippowertype { get; set; }
        public Shipsource ShipsourceShipsource { get; set; }
        public Shipstatus ShipstatusShipstatus { get; set; }
        public Shiptype ShiptypeShiptype { get; set; }
    }
}
