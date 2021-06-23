﻿namespace KS.Fiks.IO.Arkivintegrasjon.Client.ForenkletArkivering {
	/// <summary>
	/// Da de fleste fagsystemer har egne nøkler for identifisering av objekter, er det
	/// lagt til mulighet for at denne kan benyttes for identifisering overfor arkivet
	/// også. Typen har to felt:
	/// <ol>
	/// 	<li>eksternSystem: Identifikator for fagsystemet eller nøkkeltype i dette. Det
	/// forutsettes at denne kan konfigureres både i fagsystemet og i arkivsystemet.
	/// Lengden er tilpasset feltet Informasjonstype i Tilleggsinformasjon.</li>
	/// 	<li>nokkel: Nøkkel i fagsystemet, for eksempel kundenummer eller ansattnummer.
	/// Lengden er tilpasset feltet Tekst i Tilleggsinformasjon. <font
	/// color="#ff0000">Når eksternnokkel benyttes for å angi fagsystem, angir nokkel
	/// for eksempel type sak og benyttes da for å finne riktige standardverdier for
	/// den aktuelle saken.</font></li>
	/// </ol>
	/// </summary>
	public class EksternNoekkel {

		/// <summary>
		/// eksternSystem i n4
		/// </summary>
		public string fagsystem;
		public string noekkel;

		public EksternNoekkel(){

		}
	}
}