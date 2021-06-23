﻿using System;
using System.Collections.Generic;

namespace KS.Fiks.IO.Arkivintegrasjon.Client.ForenkletArkivering {
	public class UtgaaendeJournalpost {

		
		//public Avskrivning avskrivning;
		public int journalaar;
		public int journalsekvensnummer;
		public int journalpostnummer;
		//public Journalstatus journalstatus;
		public DateTime? dokumentetsDato;
		/// <summary>
		/// Definisjon: Dato et internt produsert dokument ble sendt/ekspedert
		/// 
		/// Kilde: Registreres manuelt eller automatisk av systemet ved elektronisk
		/// kommunikasjon
		/// 
		/// Kommentar: (ingen)
		/// 
		/// M105 sendtDato
		/// </summary>
		public DateTime? sendtDato;
		public ForenkletDokument hoveddokument;
		/// <summary>
		/// jpU1 i n4
		/// </summary>
		public Boolean skjermetTittel;
		/// <summary>
		/// jpOffinnhold i n4
		/// </summary>
		public string offentligTittel;
		/// <summary>
		/// Definisjon: Datoen da offentlighetsvurdering ble foretatt
		/// 
		/// Kilde: Registreres automatisk knyttet til funksjonalitet for skjerming
		/// 
		/// Kommentar: Dato for offentlighetsvurdering kan brukes dersom inngående
		/// dokumenter automatisk blir midlertidig skjermet ved mottak, og
		/// offentlighetsvurderingen skjer på et litt senere tidspunkt.
		/// 
		/// M110 offentlighetsvurdertDato
		/// </summary>
		public DateTime? offentlighetsvurdertDato;
		public EksternNoekkel referanseEksternNoekkel;
		public string tittel;
		public List<ForenkletDokument> vedlegg;
		public List<Korrespondansepart> mottaker;
		public List<Korrespondansepart> avsender;
		public List<KorrespondansepartIntern> internAvsender;

		public UtgaaendeJournalpost(){
			vedlegg = new List<ForenkletDokument>();
			mottaker = new List<Korrespondansepart>();
			avsender = new List<Korrespondansepart>();
			internAvsender = new List<KorrespondansepartIntern>();
		}
	}
}