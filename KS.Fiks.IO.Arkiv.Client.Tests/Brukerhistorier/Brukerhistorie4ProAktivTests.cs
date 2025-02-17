﻿using System;
using System.Collections.Generic;
using KS.Fiks.IO.Arkiv.Client.ForenkletArkivering;
using KS.Fiks.IO.Arkiv.Client.Models.Arkivstruktur;
using KS.Fiks.IO.Arkiv.Client.Models.Innsyn.Sok;
using NUnit.Framework;

namespace KS.Fiks.IO.Arkiv.Client.Tests.Brukerhistorier
{
    class Brukerhistorie4ProAktivTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        // Bruker en ekisterende sak dersom det finnes en sak av rett type hvis ikke opprettes ny sak
        [Test]
        public void TestNyttDokumentBrukEksisterendeSak()
        {
            SaksmappeForenklet[] saker = FinnSakerMedMatrikkelnummer("21/400");
            SaksmappeForenklet sak = null;
            //TODO Hva er meningen her?
            //foreach (Saksmappe testSak in saker)
            //{
                // sjekk om testSak er av rett type i tilfelle sett sak til testSak
            //}

            if (sak == null)
            {
                sak = OpprettNySak();
            }

            var jp = OpprettJournalpostMedDokument(sak);

            Assert.Pass();
        }
       
        private object OpprettJournalpostMedDokument(SaksmappeForenklet saksmappeForenklet)
        {
            //var messageRequest = new MeldingRequest(
            //                         mottakerKontoId: receiverId,
            //                         avsenderKontoId: senderId,
            //                         meldingType: "no.geointegrasjon.arkiv.oppdatering.arkivmeldingforenkletUtgaaende.v1"); // Message type as string
            //                                                                                                                //Se oversikt over meldingstyper på https://github.com/ks-no/fiks-io-meldingstype-katalog/tree/test/schema

            //Fagsystem definerer ønsket struktur
            var utg = new ArkivmeldingForenkletUtgaaende
            {
                sluttbrukerIdentifikator = "ABC",
                nyUtgaaendeJournalpost = new UtgaaendeJournalpost(),
                referanseSaksmappeForenklet = saksmappeForenklet
            };

            utg.nyUtgaaendeJournalpost.tittel = "Vedtak etter tilsyn";
            utg.nyUtgaaendeJournalpost.referanseEksternNoekkelForenklet = new EksternNoekkelForenklet
            {
                fagsystem = "Fagsystem X",
                noekkel = new Guid().ToString()
            };

            utg.nyUtgaaendeJournalpost.internAvsender = new List<KorrespondansepartIntern>
            {
                new KorrespondansepartIntern() {
                    saksbehandler = "Birger Brannmann",
                    referanseSaksbehandler = "60577438-1f97-4c5f-b254-aa758c8786c4"
                }
            };

            utg.nyUtgaaendeJournalpost.mottaker = new List<KorrespondansepartForenklet>
            {
                new KorrespondansepartForenklet() {
                    navn = "Mons Mottaker",
                    personid = new Personidentifikator() { personidentifikatorType = "F",  personidentifikatorNr = "12345678901"},
                    postadresse = new EnkelAdresse() {
                        adresselinje1 = "Gate 1",
                        adresselinje2 = "Andre adresselinje",
                        adresselinje3 = "Tredje adresselinje",
                        postnr = "3801",
                        poststed = "Bø" },
                    forsendelsemåte = "SvarUt"
                }
            };

            utg.nyUtgaaendeJournalpost.hoveddokument = new ForenkletDokument
            {
                tittel = "Vedtak",
                filnavn = "vedtak.pdf"
            };

            //Konverterer til arkivmelding xml
            var arkivmelding = ArkivmeldingFactory.GetArkivmelding(utg);
            var payload = ArkivmeldingSerializeHelper.Serialize(arkivmelding);

            ////Lager FIKS IO melding
            //List<IPayload> payloads = new List<IPayload>();
            //payloads.Add(new StringPayload(payload, "utgaaendejournalpost.xml"));
            //payloads.Add(new FilePayload(@"samples\vedtak.pdf"));
            //payloads.Add(new FilePayload(@"samples\vedlegg.pdf"));

            ////Sender til FIKS IO (arkiv løsning)
            //var msg = client.Send(messageRequest, payloads).Result;
            
            //TODO Dette gir ingen mening. Hvorfor return null? Er dette egentlig en integrasjonstest gitt det som er utkommentert over?

            return null;
        }

        private SaksmappeForenklet OpprettNySak()
        {
            var utg = new SaksmappeForenklet
            {
                tittel ="Tilsyn eiendom 21/400"
            };

            //Konverterer til arkivmelding xml
            //var arkivmelding = Arkivintegrasjon.ConvertSaksmappe(utg);
            //string payload = Arkivintegrasjon.Serialize(arkivmelding);

            //TODO returner saken som ble opprettet
            return null;
        }

        private SaksmappeForenklet[] FinnSakerMedMatrikkelnummer(string matrikkelnummer)
        {
            var arkivmeldingsok = new Sok
            {
                Respons = Respons.Mappe,
                MeldingId = Guid.NewGuid().ToString(),
                System = "Fagsystem X",
                Tidspunkt = DateTime.Now,
                Skip = 0,
                Take = 100
            };

            arkivmeldingsok.Parameter.Add(
            new Parameter
                {
                    Felt = SokFelt.MappePeriodTittel, // Aba kan dette være rett?
                    Operator = OperatorType.Equal,
                    Parameterverdier = new Parameterverdier
                    {
                        Klassifikasjonvalues = new Klassifikasjonvalues
                        {
                            Klassifikasjonssystem = { "GBNR" },
                            Klasse = { matrikkelnummer }
                        }
                    }
                });
            
            var payload = ArkivmeldingSerializeHelper.Serialize(arkivmeldingsok);
            
            //TODO returner saker
            return null;
        }
    }
}
