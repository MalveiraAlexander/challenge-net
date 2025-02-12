﻿namespace Megapix.Responses
{
    public class CountryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FlagImg { get; set; }
        public string? CapitalName { get; set; }
        public double? Area { get; set; }
        public int? PopulationCount { get; set; }
        public string? AllTimezones { get; set; }
        public string? ContinentName { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class CountryInternalResponse
    {
        public Flags flags { get; set; }
        public Name name { get; set; }
        public string[] capital { get; set; }
        public float[] latlng { get; set; }
        public float area { get; set; }
        public int population { get; set; }
        public string[] timezones { get; set; }
        public string[] continents { get; set; }
    }

    public class Flags
    {
        public string png { get; set; }
        public string svg { get; set; }
        public string alt { get; set; }
    }

    public class Name
    {
        public string common { get; set; }
        public string official { get; set; }
        public Nativename nativeName { get; set; }
    }

    public class Nativename
    {
        public Eng eng { get; set; }
        public Fra fra { get; set; }
        public Gsw gsw { get; set; }
        public Ita ita { get; set; }
        public Roh roh { get; set; }
        public Hun hun { get; set; }
        public Zho zho { get; set; }
        public Ara ara { get; set; }
        public Ind ind { get; set; }
        public Por por { get; set; }
        public Lao lao { get; set; }
        public Nld nld { get; set; }
        public Pap pap { get; set; }
        public Swa swa { get; set; }
        public Cat cat { get; set; }
        public Run run { get; set; }
        public Afr afr { get; set; }
        public Nbl nbl { get; set; }
        public Nso nso { get; set; }
        public Sot sot { get; set; }
        public Ssw ssw { get; set; }
        public Tsn tsn { get; set; }
        public Tso tso { get; set; }
        public Ven ven { get; set; }
        public Xho xho { get; set; }
        public Zul zul { get; set; }
        public Spa spa { get; set; }
        public Cal cal { get; set; }
        public Cha cha { get; set; }
        public Mkd mkd { get; set; }
        public Nfr nfr { get; set; }
        public Nor nor { get; set; }
        public Dan dan { get; set; }
        public Fao fao { get; set; }
        public Rus rus { get; set; }
        public Uzb uzb { get; set; }
        public Sin sin { get; set; }
        public Tam tam { get; set; }
        public Ben ben { get; set; }
        public Aym aym { get; set; }
        public Que que { get; set; }
        public Msa msa { get; set; }
        public Tur tur { get; set; }
        public Prs prs { get; set; }
        public Pus pus { get; set; }
        public Tuk tuk { get; set; }
        public Rar rar { get; set; }
        public Fin fin { get; set; }
        public Swe swe { get; set; }
        public Smo smo { get; set; }
        public Tkl tkl { get; set; }
        public Pov pov { get; set; }
        public Aze aze { get; set; }
        public Kor kor { get; set; }
        public Mfe mfe { get; set; }
        public Ell ell { get; set; }
        public Hrv hrv { get; set; }
        public Ber ber { get; set; }
        public Fij fij { get; set; }
        public Hif hif { get; set; }
        public Deu deu { get; set; }
        public Nep nep { get; set; }
        public Kat kat { get; set; }
        public Urd urd { get; set; }
        public Hmo hmo { get; set; }
        public Tpi tpi { get; set; }
        public Pih pih { get; set; }
        public Mlg mlg { get; set; }
        public Hin hin { get; set; }
        public Cnr cnr { get; set; }
        public Grn grn { get; set; }
        public Ukr ukr { get; set; }
        public Glv glv { get; set; }
        public Her her { get; set; }
        public Hgm hgm { get; set; }
        public Kwn kwn { get; set; }
        public Loz loz { get; set; }
        public Ndo ndo { get; set; }
        public Bul bul { get; set; }
        public Kal kal { get; set; }
        public Khm khm { get; set; }
        public Arc arc { get; set; }
        public Ckb ckb { get; set; }
        public Kir kir { get; set; }
        public Nya nya { get; set; }
        public Bos bos { get; set; }
        public Srp srp { get; set; }
        public Amh amh { get; set; }
        public Slv slv { get; set; }
        public Mah mah { get; set; }
        public Isl isl { get; set; }
        public Ltz ltz { get; set; }
        public Nau nau { get; set; }
        public Mey mey { get; set; }
        public Tha tha { get; set; }
        public Hat hat { get; set; }
        public Tvl tvl { get; set; }
        public Bel bel { get; set; }
        public Lav lav { get; set; }
        public Pau pau { get; set; }
        public Fil fil { get; set; }
        public Kon kon { get; set; }
        public Lin lin { get; set; }
        public Lua lua { get; set; }
        public Som som { get; set; }
        public Ces ces { get; set; }
        public Slk slk { get; set; }
        public Bis bis { get; set; }
        public Niu niu { get; set; }
        public Kin kin { get; set; }
        public Est est { get; set; }
        public Ron ron { get; set; }
        public Tet tet { get; set; }
        public Vie vie { get; set; }
        public Lat lat { get; set; }
        public Bar bar { get; set; }
        public Gle gle { get; set; }
        public Nno nno { get; set; }
        public Nob nob { get; set; }
        public Smi smi { get; set; }
        public Sag sag { get; set; }
        public Tir tir { get; set; }
        public Lit lit { get; set; }
        public Kaz kaz { get; set; }
        public Hye hye { get; set; }
        public Nrf nrf { get; set; }
        public Jpn jpn { get; set; }
        public Crs crs { get; set; }
        public Tgk tgk { get; set; }
        public Mlt mlt { get; set; }
        public Sqi sqi { get; set; }
        public Div div { get; set; }
        public Fas fas { get; set; }
        public Bjz bjz { get; set; }
        public Mya mya { get; set; }
        public Dzo dzo { get; set; }
        public Jam jam { get; set; }
        public Pol pol { get; set; }
        public Zdj zdj { get; set; }
        public Ton ton { get; set; }
        public Gil gil { get; set; }
        public Bwg bwg { get; set; }
        public Kck kck { get; set; }
        public Khi khi { get; set; }
        public Ndc ndc { get; set; }
        public Nde nde { get; set; }
        public Sna sna { get; set; }
        public Toi toi { get; set; }
        public Zib zib { get; set; }
        public Mon mon { get; set; }
        public Heb heb { get; set; }
        public Mri mri { get; set; }
        public Nzs nzs { get; set; }
    }

    public class Eng
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fra
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Gsw
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ita
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Roh
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hun
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zho
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ara
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ind
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Por
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lao
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nld
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pap
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Swa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Run
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Afr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nbl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nso
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sot
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ssw
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tsn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tso
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ven
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Xho
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zul
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Spa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cal
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cha
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mkd
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nfr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nor
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Dan
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fao
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Rus
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Uzb
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tam
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ben
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Aym
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Que
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Msa
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tur
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Prs
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pus
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tuk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Rar
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Swe
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Smo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tkl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pov
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Aze
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kor
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mfe
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ell
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hrv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ber
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fij
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hif
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Deu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nep
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Urd
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hmo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tpi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pih
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mlg
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Cnr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Grn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ukr
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Glv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Her
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hgm
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kwn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Loz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ndo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bul
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kal
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Khm
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Arc
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ckb
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kir
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nya
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bos
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Srp
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Amh
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Slv
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mah
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Isl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ltz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nau
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mey
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tha
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tvl
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bel
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lav
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pau
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fil
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kon
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lua
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Som
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ces
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Slk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bis
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Niu
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kin
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Est
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ron
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tet
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Vie
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lat
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bar
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Gle
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nno
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nob
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Smi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sag
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tir
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Lit
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kaz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Hye
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nrf
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jpn
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Crs
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Tgk
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mlt
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sqi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Div
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Fas
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bjz
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mya
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Dzo
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Jam
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Pol
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zdj
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ton
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Gil
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Bwg
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Kck
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Khi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Ndc
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nde
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Sna
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Toi
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Zib
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mon
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Heb
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Mri
    {
        public string official { get; set; }
        public string common { get; set; }
    }

    public class Nzs
    {
        public string official { get; set; }
        public string common { get; set; }
    }

}
