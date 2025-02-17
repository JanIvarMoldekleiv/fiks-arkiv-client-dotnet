using System.Collections.Generic;

namespace KS.Fiks.IO.Arkiv.Client.Models
{
    public static class ArkivintegrasjonMeldingTypeV1
    {
        // Arkivering
        public const string Arkivmelding = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding";
        public const string ArkivmeldingMottatt = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.mottatt";
        public const string ArkivmeldingKvittering = "no.ks.fiks.arkiv.v1.arkivering.arkivmelding.kvittering";
        
        // Innsyn Hent
        public const string MappeHent = "no.ks.fiks.arkiv.v1.innsyn.mappe.hent";
        public const string MappeHentResultat = "no.ks.fiks.arkiv.v1.innsyn.mappe.hent.resultat";
        public const string JournalpostHent = "no.ks.fiks.arkiv.v1.innsyn.journalpost.hent";
        public const string JournalpostHentResultat = "no.ks.fiks.arkiv.v1.innsyn.journalpost.hent.resultat";
        public const string DokumentfilHent = "no.ks.fiks.arkiv.v1.innsyn.dokumentfil.hent";
        public const string DokumentfilHentResultat = "no.ks.fiks.arkiv.v1.innsyn.dokumentfil.hent.resultat";
        
        // Innsyn Søk
        public const string Sok = "no.ks.fiks.arkiv.v1.innsyn.sok";
        public const string SokResultatUtvidet = "no.ks.fiks.arkiv.v1.innsyn.sok.resultat.utvidet";
        public const string SokResultatMinimum = "no.ks.fiks.arkiv.v1.innsyn.sok.resultat.minimum";
        public const string SokResultatNoekler = "no.ks.fiks.arkiv.v1.innsyn.sok.resultat.noekler";
          
        public static readonly List<string> ArkiveringTyper = new List<string>()
        {
            Arkivmelding,
            ArkivmeldingMottatt,
            ArkivmeldingKvittering
        };
            
        public static readonly List<string> InnsynTyper = new List<string>()
        {
            Sok,
            SokResultatUtvidet,
            SokResultatMinimum,
            SokResultatNoekler,
            MappeHent,
            MappeHentResultat,
            JournalpostHent,
            JournalpostHentResultat,
            DokumentfilHent,
            DokumentfilHentResultat
            
        };

        public static bool IsArkiveringType(string meldingsType)
        {
            return ArkiveringTyper.Contains(meldingsType);
        }

        public static bool IsInnsynType(string meldingsType)
        {
            return InnsynTyper.Contains(meldingsType);
        }
    }
}