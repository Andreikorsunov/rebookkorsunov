﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rebookkorsunov
{
    public partial class VanilPage
    {
        public VanilPage()
        {
            InitializeComponent();
            var lehtPage1 = new ContentPage
            {
                Content = new ScrollView
                {
                    Content =  new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "See oli juba pime... esimene hämarus langes soojale, päevas soojendatud maale. Ja ere, juuni päike kogunes puhkama, värvides samal ajal kohevaid ja kergeid pilvi kõikvõimalikes värvides. Küla kohal rippus maalitud Pilvede värviskeem. Ümberringi polnud heli, vaid aeg-ajalt krõpsud kuldsel suveväljal pragunesid. Kerge tuuleke raputas veel valmimata rukkikõrvu, kuid nii vaikselt, et oli kuulda väikese ja tüütu sääse kriuksumist. Kogu see omapärane ja väike maailm läks pensionile järgmise hommikuni; päike hääbus aeglaselt ja koos sellega ka pilvedest värviline vatt. Pärast rasket tööpäeva oli vaikus. Kõik vajus magama.  Järsku murdis vaikuse kellegi kõlav naer. Ärganud tuul, justkui protestiks, hakkas rukki kõrvu, aga ka pimendatud puuoksi tugevalt kõigutama. Tüdruk jooksis mööda kuldset lagendikku, hellitades jooksu ajal oma kätega spikelette. Tema kõlav naer voolas näiliselt üle kogu väikese küla. Noormees jooksis talle järele, püüdes kaaslasele järele jõuda, kuid tüdruk oli liiga kiire.  Tanya! kutt karjus oma hääle tipus ja lisas veelgi rohkem jõudu.  Sa ei jõua järele! tüdruk nimega Tanya vastas kõlava häälega.  Vaatame! noormees karjus talle ja haaras kiirust lisades oma kallima väikese õrna käepideme. Tanya pöördus järsult ümber ja ujutas taas ülemeeliku naeruga. Ma olen sulle järele jõudnud ja ma ei lase sul kuhugi minna, sa oled minu oma! poiss hingas talle näkku.  Nikita, sosistas Tanya õrnalt ja silitas käega tumedaid juukseid – ma ise ei lähe kuhugi, sa oled mu igavesti  Nikita võttis oma armastatud lapse näo peopesasse ja suudles teda õrnalt huultele. Tanya vastas suudlusele ja kallistas soojalt tema õlgu. Järsku rebis Nikita oma magusad huuled maha ja, tõstes oma armastatud sülle, hakkas temaga kuldsel väljal ringi käima.  Ma armastan sind, Tanyusha! Nikita karjus nii, et kogu maailm kuulis teda.  Ja mina sind! Tanya vastas talle samamoodi. Nikita pani oma armastatud tagasi maa peale.  Jookseme oma kohale? järsku soovitas Tanya. Nikita pööras silmi.  Võib-olla on juba õhtu, lähme koju? mees keeldus. Tanya puhus käsnad.  Sa pole minu romantiline! Tule palun Nikita vaatas mõtlikult oma valitud silmi siniseks nagu meri. Millised silmad Need olid! Tema lemmikud ... nende jaoks oli ta valmis andma kõik ja nõustuma kõigega.  Jookse! Tanyusha kriuksus ja tormas kiiremini kui tuul väikese jõeni viiva tee poole. Nikita jooksis järele, püüdes kinni oma valitud kerge rongi, kellega tundus, et ta tahaks veeta terve igaviku... Jah, ta on tema ja ainult tema. Ja rohkem viiki. Tohutu saatuse kingitus, mille eest ta annaks oma elu, nagu ka tema tema jaoks…  Nad olid lapsepõlvest saadik lahutamatud. Vaikne tagasihoidlik Tanya Ilyina ja rõõmsameelne mees ning nägus Nikita Klevtsov. Nende elu kulges väikeses külas, neli tundi Moskvast. Siin elasid nad osa oma elust 17-aastaselt.  Tatjana Ilyina sündis selles külas ja elas tänapäevani 17 aastat. Tanya ema suri, kui laps polnud isegi kahepäevane. Tal polnud isa. Või õigemini, ta oli, kuid hülgas ema Svetlana, isegi enne lapse sündi. Tanya õppis selle kurva loo oma vanemate kohta vanaemalt. Svetlana oli ärritunud, et tüdruk jääb ilma isata. Ta oli pidevalt mures, oli depressioonis ja sünnitus oli väga keeruline, pärast mida Tanya ema suri. Väike Tanyusha jäi orvuks ja vanaema Pelagia Ivanovna, ainus kallis inimene, viis tüdruku enda juurde ja kasvatas ta nutikaks ja ilusaks.  Jah, Tanya oli erakordselt ilus. Alates lapsepõlvest puudutati kõiki tänaval olevaid vanaemasid Süütu ja nii ilusa lapse ees. Tanyal oli äärmiselt armas ja valge nägu. Tema sinised silmad nagu meri läksid emalt ning ninaga nina ja tursked huuled isalt. Ta ise oli väike, vaid 160 sentimeetrit pikk, kuid kui ta jalga kõrged kontsad jalga pani, sai temast luksuslik tüdruk. Lisaks oli tema kuju suurepärane: lame kõht, õhuke vöökoht ja väike rind. Noh, ja muidugi, Pikad, kerged nisukarvad täiendasid tema ingellikku ilu. Võib öelda, et Tanyusha iseloom oli praegu rahulik ja Vaikne. Mõnikord võib see süttida, kuid seda juhtus harva. Loomulikult oli tal palju fänne, kuid ta ei hoolinud sellest. Tema süda kuulus igavesti teisele, ainult Nikitale.  Nikita Klevtsov, vastupidi, elas üsna jõukas ja jõukas perekonnas. Tema vanemad Natalja Ivanovna ja Aleksander Egorovitš olid kuulsad ettevõtjad ning nende õed ja vennad, kes olid Nikita tädid ja onud, olid hajutatud kogu Moskva linnas ja neil oli ka oma väikeettevõte. Tädi oli linnahaigla peaarst ja onu oli piirkondliku prokuratuuri uurija. Kuigi Nikita oli jõukas poiss, suhtles ta kõigiga võrdsetel alustel. Seda õpetasid talle vanemad, kes ei unustanud, et ka nemad olid kunagi tavalised inimesed ja seda ei tohiks unustada. Seetõttu kohtlesid nad tagasihoidlikku Tanyushat austusega ega olnud poja valiku Vastu.  Nikita (nii juhtus!) lihtsalt täiuslik harmoonia Tanya kõrval. Ka tema välimus oli kuti jaoks mõnevõrra armas. Kui ta nägi välja nagu Barbie-nukk, siis võis tema kohta julgelt öelda, et ta oli nagu Ken. Nikita oli veidi pikem kui Tanya, tema tumeda šokolaadi värvi silmad ajasid paljud hulluks. Lisaks oli tal šikk kastanivärvi juuksed. Ja Nikita riietus alati maitse ja šikiga. See muutis ta väga seksikaks ja atraktiivseks, nii et tüdrukud olid noore ja nägusa kuti pärast hullud.  Kuid Nikita oli Tanyale pühendunud ja ainult. Nad on olnud koos lapsepõlvest saati, alati ja igal pool. Koos käisime lasteaias, siis ühes klassis koolis. Istusime ühe laua taga. Jah, kurat, neil on isegi veregrupp ja reesusfaktor oli sama! Nad lihtsalt harmoneerusid omavahel. Pole üllatav, et kui nad mõlemad jõudsid hormoonide ja tunnete ärkamise vanusesse, hakkasid noored ametlikult kohtama nagu poiss ja tüdruk. Õrnaid ja kirglikke tundeid, suudlusi, kallistusi lisati koju saatmisele ja abile kohvri kandmisel. See värvis nende igavest hävimatut armastust veelgi erksate värvidega. Kuid seni, kuni nad ei läinud, ehkki mõlemad olid 17-aastased ja kummalgi polnud veel seksuaalset kogemust. Keelatud puuviljad on magusad. Nad tahtsid seda proovida... aga igaüks neist kartis omal moel. Seetõttu ei teadnud nende suhe veel kogu armastuse täielikku kirge.  Neil oli lemmikkoht, nagu paljudel paaridel. Mõne jaoks on see puhas park, kus on roheline rohi ja värske õhk, mõne jaoks lemmik kohvik või koht sillal, kuid Nikita ja Tanya armastasid kõigist oma küla lähedal väikesel jõel pensionile jääda. See on alati olnud ilus ja Vaikne. Suvel eritas peegelvesi jahedust ja püsivad pilliroog varjas poisse kõigi eest. Kuid see polnud mõte. Siin jõe ääres oli suurepärane vaade silmapiiri nägemiseks. Kui õhtul päike kustub, värvides kohevaid pilvi ja koidikul laulsid linnud ning taevas muutus alati erkroosaks või punaseks.",
                        FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center },
                    }
                    }
                }
            };
            var lehtPage2 = new ContentPage
            {
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children =
                    {
                    new Label
                    {   Text = "Kuid täna tundus Tanya silmapiir ebatavaline. Heledad värvid kustusid ja taevas värviti erakordse värviga.  Siin on kõik nii ilus... sosistas Tanya. Nikita kallistas oma kallimat vöökoha tagant ja nautis nisukarvade lõhna.  Täna on kuidagi ebatavaline, eks? küsis Tanya ja pööras pea Nikita poole. Ta suudles teda ninale ja vaatas taeva poole.  Jah, värv on ebatavaliselt ilus lõpetas Nikita.  Nagu vanilje... sosistas Tanyusha. Nikita naeris. Vanilje Horisont? küsis ta naerdes. Jah, ja mis on ilusti öeldud! Kirjuta sellest laul? Mis pole teie jaoks valik? küsis Tanya.  Nikita on alati unistanud olla keegi eriline. Et kogu maailm teda tunneks. Mitte nii, et elaksite kogu oma elu, nagu paljud külas elavad, tahtis ta midagi enamat. Kuulsus, kuulsus. Seetõttu, kui ta avastas endas kunstniku ande, seadis ta endale eesmärgi, et lahkub kindlasti Moskvasse ja saab popstaariks. Võib-olla loob ta isegi oma bändi või saab soololauljaks ja fännid rivistuvad talle autogrammi saamiseks. Ta kirjutas isegi oma laule, laulis pühadel, kuid kõigest sellest ei piisanud talle. Nikita teadis, et ta saab kuulsaks. Jama! Mis on laulu pealkiri? Vanilli silmapiir ... haha! Nikita ütles sarkastiliselt. Tanya lükkas teda õrnalt. Ja mulle meeldib, ma võtan selle ja kirjutan laulu ise! Tanya protesteeris. Palun, võib-olla saab teie laul kuulsaks ja teist saab populaarne laulja, teid kuulatakse raadios...  Mine sina! Tanya lõikas selle ära ja vahtis vaikselt taevasse. Nikita suudles teda pea peal. Vabandust, laps, päikeseloojang on tõesti ilus, vanilje nagu sa ütlesid Ja tõesti. Kerged pilved olid nagu vanilje cappuccino ja päikeseloojang oli suurepärane ja hämmastav. Ja isegi mitte pilvede värvi tõttu. Just täna oli ta mõlema jaoks tõesti eriline…  Tanya seisis peegli lähedal oma väikeses, kuid hubaselt sisustatud toas. Ta kammis selga pikad juuksed ja imetles peeglist peegeldust. Ta ei pidanud kosmeetikat värvima, ta oli juba atraktiivne, kuid kui Tanya pani näole tuhmid ja diskreetsed toonid, muutus ta tõeliselt jumalanna Aphrodite sarnaseks. Tema tualettlaual oli palju erinevaid kosmeetika-ja näohooldustooteid. Kõike seda ei saanud ta endale lubada, Nikita andis talle kogu aeg kõik. Ta teadis, et vanaema pensionipõlves ei saanud Tanya endale lubada elegantsete riiete või kosmeetika ostmist, nii et ta ostis talle kõik ise. Tal polnud keeruline, sest ta ise oli jõukas ja soovis, et tema tüdruksõber ei erineks temast. Tanya oli sellega harjunud, et Nikita tegi alati kõik tema heaks. Ta valis oma riided, sõitis salongidesse ja tegi kõik oma maitse järgi. Nii et ta ei olnud üllatunud, kui Nikita ütles, et ta võtab üle prom-kleidi. Temalt oli vaja ainult mõõtmisi teha ja kõik, siis teeb ta kõik ise.  Täna on see kauaoodatud päev iga õpilase jaoks. Kätte on jõudnud kooli lõpetamise ja hüvastijätmise päev. Nikital ja Tanjal olid selle suhtes erinevad tunded. Nikita jaoks oli see päev kauaoodatud. Ta ei jõudnud ära oodata, millal ta võimalikult kiiresti kooli lõpetab ja Moskvasse lahkub, kus ta hakkab oma karjääri üles ehitama. Tanya ei saanud kuhugi minna. Kodus oli vanaema, kellest ta ei saanud loobuda. Tanyusha oli tema jaoks esimene abiline, pealegi oli vanaema sageli haige. Seetõttu otsustas Tanya pärast külas õppimist jääda ja astuda nende väikesesse tagasihoidlikku meditsiinikooli. Kuid ta ei tahtnud sinna minna. Tanya oli loominguline inimene. Ta unistas kogu aeg astuda pedagoogilisse vene ja kirjanduse õpetajaks. Paraku oli tüdruku jaoks see unistus võimatu. Vanaema veenis Tanjat lahkuma sellest väikesest külast, kes ei andnud mingeid lootusi, ja täitma oma unistust, kuid ta nõudis seda. Vanaema oli ainus sugulane, kes tal oli. Ta asendas oma ema ja isa ning ta ei saanud teda maha jätta.  Tanya oli lõpetamise pärast väga mures. Nikita pidi lahkuma varsti pärast kooli lõpetamist. Esmalt esitage dokumendid ja seejärel alates septembrist õppige Moskvas. See tähendas, et nad pidid kohtuma eemalt. Seda ei suuda iga suhe taluda, eriti kui nad on harjunud alati koos olema. Tanya kartis väga, et linnas võib Nikita kohtuda mõne linna iludusega ja unustada ta. Ta poleks suutnud lahusolekut üle elada, nii arvas ta.  Tundus, et Nikita polnud selle pärast üldse mures. Ta oli enesekindel. Ükski linnanümf ei saanud teda Tanyaga asendada ja ta ei mõelnud sellele. Tema peamine eesmärk oli ainult karjäär. Ta ei saanud oodata ülikooli astumist ja võimalikult kiiresti karjääri kasvu saavutamist.  Täna varahommikul ei suutnud Tanya midagi mõelda, nagu Nikita varsti lahkub ja ta jääb üksi. Ta veetis peaaegu pool tundi peegli lähedal ega suutnud end kuidagi korda teha, külmutades aeg-ajalt oma kohale, mõeldes enda omale. Vanaema lähenes talle märkamatult ja, võttes kammi kätest, hakkas oma pehmeid ja paksu juukseid kammima nagu lapsepõlves. Mida kaunitar mõtles? küsis Pelagia Ivanovna. Tanya vaatas teda peegli peegelduses. Vanaema nägi oma aastatest selgelt vanem välja. Lõputu töö nooruses ja täiskasvanueas, nii et Tanyusha ei vajanud midagi, mõjutas tema välimust suuresti. Kuid silmad, nagu Tanya, on alati õhutanud noorust ja lahkust. Kuidas saaks tüdruk ta üksi jätta? Ma kardan, ba. Nikita lahkub varsti ja ma olen üksi, kuidas ma ilma temata olen? Oleme kogu aeg koos! Ma armastan teda nii väga, bah! Mis siis, kui ta leiab linnast teise? Tanya läks kuumaks. Vanaema jätkas lapselapse juuste kammimist, justkui rahustades teda. Ma tunnen Nikitat sünnist saati ja tean, kuidas ta sind kohtleb. Ärge keerake ennast enne tähtaega. Kuid saate oma suhet eemalt kontrollida, vastas Pelageya Ivanovna.  Tanya ohkas ja langetas pead. Vanaema Pööras lapselapse enda juurde ja kallistas teda. Noh, miks sa päikest kurvastasid? Olen sulle mitu korda öelnud, et mine siit ära. Mine koos Nikitaga linna, ma saan ise hakkama. Ma ei näe, kuidas sa oma unistust rikud Tanya eemaldus vanaemast. Ei, bah! Ma ei jäta sind maha ja sellest piisab Vanaema heitis pilgu lapselapsele ja ajas oma kipitava käe üle põse. Soovin teile ainult õnne . Sa oled kahvatu, peate ilmselt jälle rauda jooma, soovitas ta. Tanya pööras silmi. Esiteks oli tal lapsepõlvest alates rauavaegusaneemia, mis ei tahtnud Tanya kehast lahkuda ja ükski pill ei suutnud seda parandada, ja teiseks kaunistas see kahvatus tema välimust veelgi, arvas Tanya.  Nende tagasihoidlikku majja koputati ja Nikita sisenes tuppa. Tanya naeratas talle päikselise naeratuse. Nikita nägi täiuslik välja nagu alati. Hele triigitud särk, 30-dollarised päikeseprillid ja tumedad teksad, mis sobivad tema figuuriga. Tema juuksed olid räsitud.  Kas olete valmis beebi? küsis Nikita ja uuris oma kallimat. Tanya oli riietatud mitte kallilt, vaid ka maitsekalt. Nagu tõeline linnatüdruk. Valge tuunika Rhinestones ja denim lühikesed lühikesed püksid, mis panid ta tagumiku seksikaks muutuma. Jalgadel otsustas ta kanda kontsadega valgeid sandaale, et olla oma kallimaga sama pikk.",
                        FontSize = Device.GetNamedSize (NamedSize.Small, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center },
                    }
                    }
                }
            };
            Children.Add(lehtPage1);
            Children.Add(lehtPage2);
        }
    }
}