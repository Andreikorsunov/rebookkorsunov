﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace rebookkorsunov
{
    public partial class ktotenjPage
    {
        public ktotenjPage()
        {
            InitializeComponent();
            var lehtPage1 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Kes sa oled, Vari?  Peatükk 1." +
                    " Vanya  Korneev. leitnant ulatab mulle käe. Sa oled õigel ajal.  Kükitan üle keha. Pole kahtlust, meie ees on kunstniku töö. Kogu keha kaelast jalatallani on India ornament. Ta nikerdab nahka nagu puitu, kui ohver on veel elus. Tüdruk kadus rohkem kui nädal tagasi, naasis pärast treeningut, kuid ei jõudnud kunagi koju. Ta oli vaid kaheksateist. Surnukeha leidis mees, kes jalutas koeraga, kunstnik ei üritanud seda isegi varjata, istus puu lähedal peaaegu raja ääres.  Kas on midagi? kui ma seda esimest korda nägin, ei suutnud ta okserefleksi ohjeldada, nüüd on närvid tugevamaks muutunud, ehkki magama jääb ainult pillide all.  ─ Ei. Ei mingeid jälgi ega tunnistajaid. Petr Anatoljevitš eemaldab prillid. Oleme taotlenud liikluskaamerate videoid, kuid need hõivavad vaid väikese osa. Ta lihtsalt pilkab meid.  Tema meeleheide on mulle selge. Oleme kännud. Ohvrite vanemad on maruvihased, noored tüdrukud kardavad pärast päikeseloojangut majast lahkuda, kogu linn ootab pingeliselt vähemalt mingit teavet.  ─ Tõepoolest. tähelepanu juhib müra. ─ Ajakirjanik. Jällegi ei pane nad oma nina oma ärisse, linn on juba hirmul ja nad süütavad tule veelgi. ma panen käed taskusse. Võtke keha!  Ma kahtlen, kas ekspertiis leiab vähemalt midagi, kuid tasub proovida. Kolmeteistkümnes ohver ja mitte üks asitõend, mitte üks sõrmejälg või juuksed. Midagi. Tüdruk lihtsalt kaob ja mõne aja pärast leiame keha.  Seal on veel midagi. riigikaitse läheb minuga auto juurde. Seadus sai hommikul uue avalduse, eile ei naasnud üheksateistkümneaastane tüdruk koju, naasis sõbra juurest, helistas, mis saab mõne minuti pärast ja keegi ei näinud teda enam. Sobib kunstniku tüübiga.  Neetud! surun peopesad rusikasse. Me läheme osakonda, peame aru andma ja kohe tema vanematele!  Meie väikelinnas pole kunagi midagi tõeliselt jubedat juhtunud. Oleme nagu abitud lapsed, kes saavad ainult istuda ja oodata. Rohkem kui üks kord tuli süüdistus, rohkem kui üks kord olid vaimselt terved inimesed, väites, et see on nende töö. Kuid nad on uurimise all ja mõrvad jätkuvad.  Oh, sa oled juba tagasi. määrusega panin allkirja valves oleva inimese päevikusse. Vanya, boss ootab sind, kogunemine tema kabinetis kümne minuti pärast!  Kas mind on ka vaja? Petro esitab küsimuse.  Määrust pole, ainult vanemkoosseis.  Kohtuasi ei öelnud põhjust? ma saan aru, et ülemused peavad vähemalt midagi õppima,kuid nüüd on paremaid asju.  Saatja kaldub lähemale.  Riigikaitse on nüüd tema kabinetis pealinnast pärit kindral. Meie ise pole hommikul oma, kahvatum kui seinad. Ütlesin, et olge kõik. Ma arvan, et sa mõistad põhjust. kohtuvaidlus patsutab õlale.  Lõpuks saime aru. Aeg on möödas. Loodan, et nad saadavad meile abi. Kunstniku kohta edastavad ainult meie kohalikud kanalid, ülejäänud on keelatud, et mitte külvata õudust teiste linnade seas. Kõik püüavad hoolikalt varjata.  Kas see on võimalik?  Jah, Ivan, tule sisse! apellatsioonkaebuse kolonel kutsub kabinetti.  Tema asemel istub tundmatu mees, kuid epaulettide järgi on selge, et see on sama kindral. Laua taga on puudu ainult mina. Vaatan poistega ringi, kõik saavad aru, millest jutt käib, kuid keegi ei saa aru, mida külaliselt oodata.  Kolonel tõuseb üles ja läheb akende juurde ruloode sulgemiseks. Kõik jälgivad vaikselt.  Hea päev, härrased! Lubage mul tutvustada ennast, kindralleitnant Trofimov Valentin Jurjevitš. Ma olen siin, et aidata teil seda juhtumit lahendada.  Üks inimene ei aita, ma lootsin, et nad saadavad uurimisrühma.  Kohtuvaidlus pole päris sina. kuulame itsitamist ja veel ühte häält, mis on kindralist palju noorem, kuid samal ajal on arvutitöötlus selgelt jälgitav. Olge nii lahke, pöörake ekraani, et saaksin kohalviibijaid tervitada. see inimene, kes selle välja ütles, on selgelt lõdvestunud ja rahulik.  Jah, muidugi! käsundusohvitser pöörab sülearvuti, kogu selle aja seisab tema ees, ekraan meie poole.  Kuid ekraanil pole kedagi, must ruut. Ma arvan, et nüüd tunnevad kõik, nagu ka mina, hämmeldust.  Kas see on teie parim töötaja, ainult viis inimest? kuulame häält, kuid ei näe kõnelejat.  Nad on tõesti kiir... kolonel soovib seda sisestada.  Kontrollime kohtutäiturit praktikas. hääl segab teda. Sellest hetkest alates olete te mulle allunud. Mul on palju nimesid, võite helistada teile mugavalt või lihtsalt varju.  Vaatame kuttidega üle. See, mis toimub, on nagu pikaleveninud nali.  Alatu Vari? otsustan kõigepealt rääkida. Millega te meid aitate? tundub, et see mees kardab seda, kes on teisel pool ekraani. Ta ei suuda pinget varjata.  Korneev Ivan Vladimirovitš, selle linna noorim uurija, täiuslik maine, kolleegide austus, suurepärane kogemus. ma kuulen muigamist. Ma aitan leida kedagi, keda te ei suuda.  Oleme varjuga pikka aega koostööd teinud, ta suudab lahendada ka kõige hukatuslikuma juhtumi, see maksis meile palju vaeva, et veenda teda Teid aitama. seadusandja kaitseb kindralit. Ma saan aru, et teil on praegu raske toimuvaga leppida, kuid kinnitan teile, et tulemus saab olema.  Kindral, Ma ei vaja abi. seadus peatab mehe. Ivan, võite minu kandidatuuri kahtluse alla seada nii palju kui soovite, Ma ei raiska aega ja tõestan teile midagi. Te töötate kas minu alluvuses või lahkute ja olete teelt Väljas. Muud võimalust pole.  See on esimene kord, kui ma sellest inimesest kuulen, sellist hüüdnime pole kunagi varem ilmunud. On selge, et pealinn teab rohkem, tipp teab rohkem ja nüüd tundub, et ka meie.  Ja mida te kavatsete teha? seadusandja on ühendatud tärnide vestlusega, pilgust on näha, et ta, nagu mina, on toimuva suhtes skeptiline. Meil ei ole tõendeid ega tunnistajaid, oleme ummikus.  Te eksite, kuldnokad, tundub, et ta tunneb kõiki laua taga. teil on tunnistaja, ma olen ühendatud teie osakonna süsteemiga, te olete andmebaasi vastikult kokku pannud, olete paljudest olulistest punktidest ilma jäänud.  Milliseid seadusi näiteks?  See Tüüp hakkab tüütuks, ta räägib rahulikult, kuid seab end selles toas kõigist kõrgemale. Ta pole veel midagi näidanud, lihtsalt tühi lobisemine. Võib-olla näeb kindral temas meie päästet, seni näen ainult inimest, kes peidab end samamoodi nagu kunstnik.  Ma olen peaaegu täiesti kindel, et see, keda me otsime, õpib või töötab justiitsülikoolis.  Ülikool, mille ma lõpetasin, ja nüüd õpib mu õde.  Esimene ohver, selle konkreetse asutuse õpilane. Ma tean, et olete seda versiooni juba harjutanud, kuid te pole sellele eelnenud mõrvu kuidagi sidunud. Ja asjata.  Ma saan aru, mida ta mõtles, mõni kuu enne kunstniku esimest ohvrit oli veel Mõrv, sama ülikooli alamõpilane suri kummalistel asjaoludel ja kuigi ta oli tüübilt sarnane metsalise ohvritega, ei olnud tema kehal nähtavaid kahjustusi.  Lubage mul ... ma tahan esitada vastuväiteid.  ─ Ei. Mul pole aega, ma ütlesin. Nüüd ülikoolis on minu agent, ta läheb salaja, saab teise kursuse õigusteaduskonna üliõpilaseks.  See on teisel õppida õde. Victoria, see on ainus väärtus minu elus, ta on tark tüdruk ja suudab enda eest seista, kuid ma kardan teda ikkagi. Lubasin isal teda igasuguste probleemide eest kaitsta.  Nagu ma ütlesin, on teil tunnistaja, Victoria, kui ma ei eksi. Helistage talle täna. Ma räägin temaga isiklikult.  See on võimatu! ma tõstan häält. Victoria on juba öelnud kõik, mida ta teab. Pole mõtet teda puudutada! Lisaks on ta mu õde ja ma ei taha teda uuesti vigastada!  Ma tean, kelle õde ta on. Tundub, et teieni on raske jõuda, Korneev. Ma tean kõike kõigist selles toas, selles osakonnas. Tean kõiki teie saladusi, mida proovite nii hoolikalt varjata, tean teie hirme. Kuid ma ei küsinud teie arvamust. Ärge segage uurimist, vastasel juhul olen sunnitud teid kõrvaldama.  Ma näen, kuidas kindral näitab mulle žestidega rahunemist.  Ma räägin temaga igal juhul, teie abiga või ilma. Kui ta saabub Helista mulle, see sülearvuti on teie ainus viis suhelda. Näeme varsti! apellatsioonkaebus katkestab kõne.",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center },
                    }
                }
            };
            var lehtPage2 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Kes kurat see on?! hääletan küsimuse, mis muretseb kõiki.  Ivan, rahune maha, kas see inimene sulle meeldib või mitte, ta on professionaal. Shadow ise läks peadirektoraati mitu aastat tagasi. Pakkus abi rahvusvahelise juhtumi uurimine, mille kallal me siis töötasime, ja lahendas selle edukalt. Ma ei tea, kes see inimene on, kas see on mees või naine, suhtlus toimub alati sülearvuti kaudu. Ainus asi, mida võin kindlalt öelda, on see, et ta kogub asjatundlikult teavet ja suudab tungida kohtadesse, millest pelgalt surelik ei tea. Ta teab kõike, isegi salajasi üksusi, kuid see ei puuduta teid enam.  Varju. Jah, see Tüüp pidas end lihtsalt kõikvõimsaks. Kui ta tõesti suudab aidata, oleksin tänulik, kuid see on raske töötada. Mulle ei meeldi loll olla ja mulle ei meeldi olla pimedas ning see inimene ei kiirusta eriti midagi jagama.  Viskan sigareti välja ja saan uue.  See on koht, kus sa oled, kus on starlings istub lähedal. kas kohtled kohtlemist? ma sirutan paki välja. Mida sa otsustad, kas sa kutsud Vici?  Kas mul on valikut?!  Kohtuvaidlusi ei ole. Tead, see mees ajab mind haneks. Meile piisas võrrandis ühest Tundmatust, nüüd ilmus teine.  Peatükk 2. Minevik, mida ei saa muuta  Paar kuud enne  Lyubochka, anna mulle andeks, ma ei arvanud, et ma sind nii kaua kinni hoian. Maria Lvovna vaatas, kuidas ma Jalanõud selga panin. Tänan teid väga abi eest, võtke see tänutäheks. hallikarvaline naine sirutab välja mitu rullitud arvet.  Noh, mida te, Maria Lvovna, eemaldate ja ei paku enam kunagi! Või tahad mind solvata? ma katan tema käed oma kätega. Te teate, kui väga ma armastan teie varjupaika ja teate, et aitan teid südamest! Tulen ülehomme ja valmistan ette kõik vajalikud asjad loomaarsti juurde sõitmiseks. Auto on juba leitud. ma näen naeratust. Ma lähen ja ärge unustage enne magamaminekut ravimeid võtta. Kevadel tuleb rõhku tähelepanelikumalt jälgida.  Tänan teid veel kord! Kas sul on kedagi, kellega kohtuda? On juba hilja.  ─ Tõepoolest. Mu poiss-sõber kohtub minuga bussipeatuses. Sa ei peaks muretsema. Hüvasti! sidun salli kinni ja jälle käega vehkides sulgen välisukse enda taga.  See kevad osutus tõeliselt vastikuks. Lörtsi sajab praktiliselt lakkamatult, tänavatel pole aega tegelikult eemaldada ja peate kandma kummikuid, et mitte jalgu märjaks teha. Samuti tuul, mis hiilib hinge. Sellise ilmaga tahan üksi jääda koju oma lemmiksarja vaatama, põhimõtteliselt on see minu plaan ülejäänud ööks.  Maxim: mind hoiti koolitusel kinni. Ma ei saa sinuga kohtuda. Kirjutage, kuidas kodus olete.»  Mis tahes muus olukorras ei häiriks mind selline tulemus, kuid nüüd on kogu linn kõrvus, viimased sündmused hirmutasid kõiki, sellisel ajal üritavad noored tüdrukud tänaval üksi mitte ilmuda. Kuid mul pole valikut. Hostel, kus me elame koos emaga viimased kümme aastat, on bussipeatusest üsna kaugel ja kuigi ma saan sellest piirkonnast suletud silmadega mööda minna, muutub see ebamugavaks.  Jah, ma jäin täna kuidagi hiljaks. Tavaliselt olen kodus juba kümneks, kuid nüüd on pool kaheteistkümnendat ja ees on halvasti valgustatud tühi tee.  Mis ajast sa selline argpüks oled? kohtutäitur vaatab ringi.  Mitte hinged.  Jah, ma poleks pidanud õpetajatele neid politseiuurimislugusid rääkima. Nüüd keeran ennast üles. Mõte takso kutsumisest vilksatas peas, kuid viskasin selle kohe minema. Hostelini on kiire samm kümme minutit ja ma ootan autot kauem.  Isegi kui meie linn pole pealinn, kuid selles elab palju inimesi, sealhulgas noori, on võimalus, et minuga juhtub midagi 1:300 000.Kuid igaks juhuks vaatan veel kord ringi. Lisaks teatasid uudised, et surnukehad leiti linna põhjaosas asuvast metsavööndist.See on tunni kaugusel siit.Tere, Kas sa pole hõivatud? nii et see on rahulikum.Vika ja mina oleme lasteaiast alates tuttavad, ta on mulle kõige lähemal.Ma jumaldan teda, armastan teda rohkem kui oma ema. Minu parim sõber, keda pean õeks.See inimene on olnud minuga kõige raskemates olukordades, ma usaldan teda kui iseennast.  Kas sa pole veel kodus? kuulen erutatud häält, taustal mängib kerge muusika, tundub, et see hõljub jälle märkmete kohal, ta lülitab sellise muusika alati sisse, see aitab tal keskenduda.  Seadusandja viibis varjupaigas, leidis veel mitu kutsikat, oli vaja aidata neid korda teha.Ma olen peaaegu kodus.  Ja kus on max? Lihtsalt ära ütle, et nad jälle koolitusel kinni pidasid!probleem, mida ma ei suuda lahendada, minu lähedased inimesed ei talu üksteist.  ─ Hiirehernes…  Kõik on selge.Pole vaja seda õigustada. Ma sain piletid homsele etendusele, nii et veedame õhtu koos ja mu vennal on plaan tööl olla, nii et võite minu juurde jääda.see on isegi parim, et ta tõlkis teema.See on suurepärane! Siis luban teha teie lemmikpruunid.Ema pidi just vanaemalt vaarikamoosi tooma ja ka... pöördun järsult tagasi.Mida veel? Ljub, kas kõik on korras?  D - jah... tundus.ma vaatan puid, laternate valgus ei jõua nendeni.Mulle tundus, et keegi tuleb mulle järele. Kõik on korras, lihtsalt paranoia pärast õpetajate lugusid.Luba, ükskõik kui rumal minu ettepanek nüüd ka ei kõlaks, aga kas sa võid kiirendada või veel parem joosta? Kas see tundus või mitte, oleks parem, kui jõuaksite koju kiiremini. Teie naabruskonnas pole mitte niivõrd maniakk, mida peaksite kartma, kuivõrd teie kohalik eliit, kellel on märjukest paistes silmad.Alistamine kõlab tõesti tobedalt. Ma olen peaaegu kohal. Kas sa arvad, et see on tõesti ühe inimese töö? Noh, ma olen selles mõttes, et vend ei öelnud sulle enam midagi? pigistan telefoni tihedamalt käes.Ma ei arvanud, et ma selline argpüks olen.  ─ Ei.Ta käsib mul mitte ronida.Kuid ostsin pipragaasi ja muide ka teile, annan selle homme tagasi. Ütlesin, et võta alati kaasa.  Jah, selline väljavaade. ma pöördun jälle järsult ümber.Ma kuulsin kindlasti samme.  Petlik armastus?!Ära ole vait!Teate, mulle tundub ikkagi, et keegi tuleb mulle järele.Ma kuulsin kindlasti samme. ma neelan selle alla. Kuigi ei, pole kedagi.Tundub, et mul on tõrkeid.  Kuulake, Luba…  Pöördun tagasi ja hüüan üllatusest.T - sina ? Mida sa siin teed ja miks sa hiilid? jumal tänatud, et ma tõesti arvasin, et see sama maniakk järgneb mulle. VIC, kõik on korras, see on…  Löök.Telefon kukub käest välja.  Peatükk 3.Hiirehernes  Minu keha on juba koolitatud ärkama kohe pärast äratuskella helinat, aastaid koolis harjutamist ei saa välja visata. See hommik ei erine 365 - st enne seda: tõstmine, laadimine, mille käigus kuulan kohalikku podcasti, hommikusööki, tasusid.Levitan joogamatti ja lülitan sisse kohaliku veidriku, teooriate ja vandenõude armastaja podcasti, mõnikord kannab see Tüüp otsest jama, kuid ta on ainus, kes räägib kunstnikust, kartmata teda ega politseid.  Jah, jah, te ei kuuletunud, ta tegi seda uuesti. Juba kolmeteistkümnes kunstniku ohver. Ja mida politsei te küsite? Ja ma vastan: see on passiivne! Need võimaldavad teil luua seadusetust, võimaldavad teil linna eemal hoida…  Teine.Seisan baaris ja sulgen silmad.Kolmeteistkümnes.Ma juba tean, kust ta leiti, ja tean, kuidas ta välja näeb.Selle maitset pole raske jälgida.Ajakirjanik nimetas seda metsalist kunstnikuks ja just see Hüüdnimi juurdus rahva seas. Mu vend käsib mul jälle mitte ronida, ütleb, et hoolitse enda eest, aga mul on oma eesmärgid.  Avan silmad ja pööran pea kummuti poole, millel on mitu fotot, mille hulgas ta on.Vend käsib mul minna psühholoogi juurde, kuna ma ei saa kaotusega ise hakkama, kuid keegi ei aita mind, kui metsaline kõnnib vabalt.Ma lähen üles ja lähen korgitahvli juurde, kogusin kogu teabe, mis politseil ja ajakirjanikel selle kohta on.Kleepin punase nupu tühja kohta, varsti on siin foto tema uuest ohvrist.",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center },
                    }
                }
            };
            var lehtPage3 = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Kunstnik ilmus üksteist kuud tagasi, ta on psühho, kes tapab noori tüdrukuid, moonutades nende keha oma joonistustega. Selle ohvriteks on ainult kaheksateist kuni kakskümmend kolm tüdrukut, tingimata õpilased ja tingimata brunettid. Ta tapab nad aeglaselt, valusalt, nikerdades nende kehale oma meistriteoseid, kui nad valust kõverduvad. Politseil pole tõendeid ega tunnistajaid, nad on kännud. Tüdrukud kaovad mahajäetud kohtades üle linna ja nende surnukehad leiavad metsavööndis koerajuhid, skeem on muutumatu.  Oh, Vikusik, sa oled lõpuks kohal! otse ülikooli sissepääsu juures püüab kaasõpilane kinni. Kuule, kas sa suhtled Grymzaga hästi?!  Kriminaalõiguse õpetaja, munadega naine räägib sellest, mitte ainult õpilased, vaid ka ülejäänud pedagoogiline personal kardavad teda. Juba esimesel aastal suutsin tema arvamuse vaidlustada, luua dialoogi nii, et ta nõustuks argumentidega ja tunnistaks oma viga, mis pälvis austuse.  Tere ka teile. Ma ei peatu, sundides tüdrukut minu tempoga kohanema. See sõltub sellest, mida soovite.  Ma keeldusin juhataja rollist, kuid võtan aktiivselt osa oma rühma elust, Mulle meeldib hoida kõike kontrolli all, teada mis tahes detaili, sest kunagi ei tea, millal see detail kasulik on.  Oh, jah, tühiasi! Ma-a-a-scarlet taotlus, kolm sekundit äri! nii et ma uskusin seda.  Ma ei palu tal sulle kolme panna. me jõuame publikuni. Tere hommikust! ma räägin valjusti, et kõik kuuleksid.  Vastuseks kuulen sama soovi. Mul on grupiga suurepärased suhted, kuigi paljud peavad mind liiga tõsiseks.  No palun! Olen juba seitsmendat korda uuesti teinud! Ta peksab mind oma küsimustega nagu hull!  Huh, kostab naaberlaualt itsitamist. seitsmendat korda, beebi, viieteistkümnes! Senya osutab pöidlaga enda poole. Teil on midagi, mille poole püüelda!  See on juba olemas! Ma keeldun! Vikulja, ma palun sind!  Oleme vaid kuu aega õigusteaduskonna teise kursuse üliõpilastena, kuid juba kolm on ette valmistatud väljasaatmiseks, nii et tema hirmud on õigustatud. Kõik tulid õppima, jälitades oma motiive, keegi lihtsalt kooriku pärast, keegi sundis vanemaid, keegi peab juristi ametit prestiižseks, Noh, ma tulin uurijaks. Nagu vend. Nagu ema. Nagu isa.  Las ma räägin temaga, aga ma ei luba midagi.  See on super! Sa oled parim! seadusandja kavatseb kallistada, kuid paneb käe ette.  Mulle ei meeldi, kui keegi, kes pole mulle südamelähedane, rikub isiklikke piire, varem oli mul kaks inimest, keda kallistasin suure rõõmuga, kuid nüüd on jäänud ainult vend.  Seadus ja mis oli nii võimalik?! Kohtuasi Senya taaselustatud. VI…  Kohtuotsus puudub! määrusega panen nimetissõrme ette. Ära isegi mõtle. Teie puhul olen kindlasti jõuetu.  Senya on lahe Tüüp, kuid loll nagu vildist saapad. Tema isa on advokaat, kes töötab pealinnas, soovis, et poeg järgiks tema jälgedes, kuid kogu austusega pole see amet tema jaoks. Paljud õpetajad annavad talle vähemalt kolm, sest ta õpib tasulisel alusel.  Tere kõigile!  Tere hommikust!  Ukse taga kostab kaks meest, keda ma ei tunne, ja see paneb mind ümber pöörama.  Milline kontrast.  Üks, täiuslikult pumbatud kehaga pikk päevitunud brünett, otsustades liiga tiheda t-särgi kaudu väljaulatuvate lahtiste käte ja kuubikute järgi, võin juba öelda, et tema ümber on palju naiselikku tähelepanu või võib-olla võtab ta isegi grupi kõige ilusama kuti tiitli. Sellised on minu maitse järgi, kuigi kibe kogemus näitab, et tegelane pole kaugeltki ideaalne, tõenäoliselt on ta nartsissist ja Egoist.  Teine... tõenäoliselt ei leia ta enamiku rühmaga ühist keelt, olen kindel, et Hüüdnimi nohik saab talle jalga: venitatud kottis kampsun, mis pole ilmastiku järgi, lahtised püksid, mis tunduvad natuke rohkem ja kukuvad temast maha, naeruväärsed suured ümmargused paksude klaasidega klaasid, lakutud Tumedad Juuksed, kummalised paugud. Ta kuidagi küürutab, justkui suruks keegi tema õlgadele. Kutt pole esimese pikkuse poolest halvem, kuid kõiges muus halvem.  Me oleme teie uued õpilased! environment ütleb Brunet. Aplaus on vabatahtlik, kuid teretulnud! Mina Olen Ignat! ta on täpselt enesekindel, mida ei saa öelda teise kohta, kes publikut kuidagi närviliselt uurib.  Peaaegu kõik, kes on nüüd publiku hulgas, tervitasid uusi, mõned kutsusid kohe oma nimed.  Ja sina? seadusandja pöördub teise poole Arthur, kohalik algataja.  Tunnistus Vitya. ta räägib tagasihoidlikult ja vaikselt, meeskonnas on tal kindlasti raske.  Kes teist on Victoria? Dekanaat ütles, et see imeline tüdruk aitab meil mugavaks saada!  Pilk käekellale, loeng algab seitsme minuti pärast, aeg on enam kui piisav, et neile selgitada, mis ja kuidas see töötab.  Ma tõstan oma käe kergelt üles.  Me oleme lihtsalt õnnelikud, Ignati tõeline naeratus muutub laiemaks. alatu on selline iludus.  Registreeri ennast! Sasha kohtub vestlusega, ta veeres minu juurde eelmisel aastal, kuid tegin kiiresti selgeks, et meie maitsed ei lähe kokku. Ta murrab teie käe kiiremini, kui teil on igav, kui ta vastab vastastikku. Tõestatud.  Ärge liialdage. seadus ei jõudnud selleni. Kuid üldiselt on tal õigus, mind saab häirida ainult õppimise osas, palun teil seda meeles pidada. ma seisan nende ees. Me läheme, näitan, mida ja kus, samal ajal räägin teile nüanssidest.  Pööran ringi ja kõnnin enesekindlalt ukse poole, neil pole muud valikut kui mind järgida. Tavaliselt teeb seda juhataja, kuid nüüd on Sveta haiguslehel ja ma olen tema ütlemata asetäitja.  ─ Sekund. telefoni ekraanil sissetulev vend. Kohtule tuleb vastata, oodake siin. ma lähen natuke kõrvale. Jah, Wan, ma kuulan!  Tal oli Öine vahetus, kuid arvestades hommikust juhtumit, ei lubata tal tõenäoliselt koju minna.  Vika hääl on liiga tõsine. pärast õpinguid tulge osakonda, see kehtib Lyuba kohta. selle nimel pingutab mu keha iga rakk.  Kas olete midagi õppinud?  Määrus ei ole telefonivestlus. Ootan osakonnas!  Ma rääkisin neile kõik, mida ma tean, mul pole mõtet, aga kuna ta ütles, et Mind On vaja, siis tulen.  Millega ma peatusin? ma tulen kiiresti meelde. Ah, jah, ma mäletan. Dekaan!  Peatükk 4. Vari / Vika  Kohtuasi Korneeviga tekib probleeme. määrus teeb Makari järelduse.  Eemaldan kõrvaklapid ja sõtkun kaela. Lend oli raske. Nõustusin politseid aitama, sest kunstnik on mulle huvitav. Katastroofiline juhtum, mis lahendatakse lähitulevikus. Teist tulemust pole oodata.  ─ Ei. Ta vajab harjumiseks aega. Ta on parim, kes selles linnas on. Ta mõtleb kiiresti ja teab, kuidas loogilisi ahelaid üles ehitada. See on mulle kasulik.  Shadow independent moniker, mille Interpol andis mulle meie esimesel koostööl. Olin siis veel viieteistaastane Teismeline. Olen selle nimega kokku kasvanud, kuid pole ümbrusega harjunud. Kodus olen rahulikum. Olen valmis aitama ükskõik millist riiki, kui nende äri on minu jaoks huvitav, kuid eelistan jääda enda turvalisuse huvides varju.  Makar on mind juba pikka aega tundnud, ta on mu parem käsi ja kui mul on vaja minu häält. See on ainus inimene, keda ta on valmis enda kõrval nägema. Meie teed tulid kokku juhuslikult, kuid sellest hetkest alates hoiame alati koos.  Lisaks pean ma särgi lahti võtma, pean riided vahetama. ta muretseb oma õe pärast. Ta on tema ainus sugulane, kes selle rünnaku üle elas. Ta tahab kunstniku kinni püüda ja teeb selle nimel kõik endast oleneva. Kas minu juhised on täidetud?  Jah, ekshumeerimise dokumendid on kogutud. Sugulasi teavitati ja nad andsid nõusoleku, neil oli probleeme mitme perega, nad maksid vajaliku summa. kohtualluvus venitab kella. Carle palus veel natuke aega, et koguda teavet iga õpilase ja õppejõu kohta. Teie kate on valmis, teave laaditakse kõikidesse alustesse.  ─ Imeline. käes on kaust, kus on kogu teave Victoria Korneeva kohta, ta rääkis tapetuga, kui ta kinni võeti, tahan sellest hetkest isiklikult kuulda.  Minu heaks töötab palju andekaid spetsialiste, kes on valmis mis tahes ülesandeid täitma, kuid ma pole harjunud eemale hoidma. Ma pean kõike oma silmaga nägema, ma pean mõistma, kellega ja millega ma tegelen. Ma tean, kuidas välimust muuta ja teeselda kõrgeimal tasemel.",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center },
                    }
                }
            };
            Children.Add(lehtPage1);
            Children.Add(lehtPage2);
            Children.Add(lehtPage3);
        }
    }
}