using Session_3_ADV_C__Demo.Dictionary;
using Session_3_ADV_C__Demo.HashTable;
using System.Collections;

namespace Session_3_ADV_C__Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable

            /************************************* Concept of Double Hashing and how it work *************************************/

            //// tab3n el HashTable dah Non-Generic Collection we 3l4an 2st5dmoh lazme 2st5dm el namespace el hya => System.Collections
            //// el HashTable be use el [Double Hashing] 
            //// tab eh hwa el [Double Hashing] ??
            //// dah hwa mechanism beydmanly 2en my7sla4 2zma fe w2t el ta5zen 
            //// tb eh 2sln el 2zma el momken te7sl 2sln ? ha2lok delw2ty
            //// 5aly balk el [bucket's] el anta bet4el feha el data momken te4el or Contain 0 or 1 Element[mean Key] dah el Maximum
            //// matge4 t2oly 2enha hat4el 2ktr men kdah mynfa34 t4el 2ktr men kdah hya 25eha ya t4el 1 key ya ma t4el4  
            //// tab el klam dah by7sl azay ??
            //// baro7 2sy5dm [ 2 Hashing functions ] me4 bast5dm el 2tnene ma3 ba3d l2a tb 2omal bet3ml eh ??
            //// anta delw2ty ba3tly el [Key] we 3ayez te5azn el data deh fe [bucket] 3andy ya3ny 3ayez te7gz bucket t7ot feh el key 
            //// we hat5zen sa3tha el data el hya el value el mkable lel key feh bs lazem el 2wl nel2ay bucket ma3ndha4 key 
            //// l2n law 2detny bucket 3andha key hy7sl b2a mo4kela we hya deh el 2zma el bahrb menha 3l4an ma te7sal4 
            //// fa baro7 2msk el [Key] el anta ba3toh dah we ba3ml 3aleh el 2wl [2wl hash function] el hya law da5lt gwa el HashTable
            //// hal2y 2wl function ba3mlha 3al el [Key] el gya hya ==> h1(key) = GetHash(key); // default implementations calls key.GetHashCode()
            //// fa el mafrod hyrg3l rakm mo3yen el rakm el rag3 dah law el [bucket] el rag3holy 2w el index beta3 el bucket el rag3 dah
            //// ma el rakm el rag3 dah hwa hwa el index beta3 el bucket el hat7ot feh el key 3l4an y7tafez bel data beta3tk fa law kan fady 
            //// ma3n 2enoh fady me4 3al el rakm la2 3al el index of bucket 2enha me4 ma5zena gwaha key 2sln we fady we gahza ly ta5zen key 
            //// fa law kant el bucket me4 ma5zena 7aga we fadya fa
            //// habd2 27ot feh el [Key] beta3k we el donya hateb2a zay el fol we el data beta3tk 2et7at 
            //// tab law kan rag3ly [HashCode] el [HashCode] dah already hywadeny ly [bucket] el [bucket] deh feha data
            //// ya3ny rag3ly index beta3 bucket 2sln hya me5zena key we me5zena el data beta3toh fa hya kdah met5azena fa me4 hynf3 25zen 7aga tany
            //// l2n el bucket el wa7da hya bt4el maximum 1 key bs fa hwa b2a rag3l bucket feh 2sln key 
            //// hwa dah 2sln momken y7asl 2enk te3ml 3amlya 7esabya mo3yna
            //// we ytla3ly el [bucket] marten we 2sln el mafrod el bucket by4el 0 or 1 element[Key] bs  ??
            //// ah dah momken y7asl we law 7asl bensameh [Collision mean tasadom] tb el [collision] dah ben7eloh azay ??
            //// byro7 sa3tha yt Check 3al el [Equals()] w2tha tb hy3ml eh bel [Equals()] ??
            //// yro7 y4of el [Equals()] law el [2 Key's el hwa el Key el already met5azen fe el bucket we el key beta3y el ana ba3toh]
            //// be Equal ba3d yb2a anta bet3ml behavior 8alt fa ana hadrb Exception hadrb error l2n 27na 2olna el Key lazem yb2a Unique
            //// maynfa34 23ml Dupliacte ll Key fa el 8alt men 3ansy ana we ana el lazzem 27eloh lakn
            //// tb law el [2 Key's el hwa el Key el already met5azen fe el bucket we el key beta3y el ana ba3toh]
            //// me4 be equal ba3d anta kdah malk4 zanb el 7asl 2en [2wl hash function] rag3tly nafs el [bucket]
            //// we dah 8alt men 3andha nateget 7esabat mo3yna 
            //// fa ana ha7tag 27l el 2zma deh 
            //// we sa3tha haro7 3al [tany hash function] el hya ==> h2(key) = 1 + (((h1(key) >> 5) +1) % (hashsize - 1));
            //// we hast5dmha we ha4oflk [bucket] gded han2l feh el data beta3tk henak
            //// we dah ana ha3mloh kolo internaly anta me4 hatal7ez 7aga 

            /***********************************************************************************************************************/

            //// el HashTable men Gwa hwa 3obara 3an Array of Bucket we el Bucket mokwan men [hash_col , Key , Value]
            //// tb el Array dah bybd2a be Size kam ??
            //// ya3ny lama test5dm el Patameterless Constructor el hwa [Hashtable()] ana 3arf el Capacity betb2a  = zero [0]
            //// lakn ma 2bd2a b2a 2def 2wl elemnt hyba2a el Capacity =  InitialSize = 3 hwa bybd2a be 3 ma3 2wl element hadefoh 
            //// tab el Capacity deh 2w el size byzed azay ?? ya3na 2bl kdah fe el List kan byzed bel de3f 
            //// tab hena el Capacity hatzeb be 2eh 2w azay ??
            //// lama ba3ml el Paramterless Ctor el hwa kdah men gwa ==> public Hashtable() : this(0 , 1.0f) {}
            //// hwa bybd2a y3ml Constructor Chaning 3al Constructor by5od meny el [Capacity , LoadFactor]
            //// el Capacity 27na 3arfenha el rakm el ana habd2a 27oth 3l4an 2a set el Capacity beta3ty el hwa el Size beta3y 
            //// tb eh hwa b2a el [LoadFactor] ?? 
            //// el [LoadFactor] dah hwa nesba mo3yna ana el babd2 27otha 
            //// LoadFactor
            ///*
            // * Capacity = 10 and LoadFactor = 0.75,
            // * the table will resize once it holds more than 7 items ( 10 * 0.75 = 7.5 ==> hatb2a 7 ba3ml floor (rounded down) )
            // * ya3ny l7ad el element el 7 anta tmam law hatzawed 3anoh hatd5l element tamn sa3tha hatro7 te3ml resize ll size or Capacity
            // */
            //// fa law ba3t el Capacity be 10 we el LoadFactor be 0.75
            //// el loadFactory dah ba2oly 2w hya by3rfny lam ybd2a el HashTable beta3k ytmly be 7 Elements men el Element el 8 b2a 
            //// ana haro7 23ml Resize tb leh we ana lysa m3aya 3 2mkan tanyen ??
            //// el Hashtable men gwah  by7tag memeory Kbera we hwa 4a8al fa hwa bel nesbaloh el 3 2mkan dol me4 kfaya 
            //// l2n el hastable by7tag buckest kter 3l4an y2dr y4ta8l 3aleha 3l4an ymn3 y7sl 2zmt el collision el 4ar7nha fo2
            //// ana ba7dedloh 2emta y3aml resize 3al 7asb el loadFactor el ana ba3toh 
            //// tab3n el LoadFactor dah 2tla8a 5als ba3d kdah fe el nos5a el Generic l2nk el mafrod malk4 ta7kom fe 7aga zay kdah 
            //// fa han3ml method mo3yna hya el hat3ml el Resize benafsaha fe el nos5a el Generic

            /***********************************************************************************************************************/

            //// yala b2a net3aml ma3 el hashtable
            //// tab3n 27na lys fe el bedaya ma7tena4 ay element fa lama hatb3 el Count hyb2a be = zero[0]
            //// l2n el Count hwa el 3add el element el fe3ly el gwa el hashtable we hwa lysa fady fa hwa be 0
            //// tab belnesba ll Capacity ?
            //// l2a anta hena malk4 access 3al el Capacity 2sln ya3ny law ro7t 3amlt kdah ==> phoneBook.Capacity
            //// me4 hatl2eha mawgoda 2sln mafe4 Property 2smha Capacity

            //Hashtable phoneBook = new Hashtable();

            //Console.WriteLine($"Count of HashTable => {phoneBook.Count}");

            #region Add Elements in HashTable using 3 Ways

            //// 3ayzen b2a nebd2a ne add Elements 3andy fe el HashTable 
            //// 3andy 3 tor2 :-

            /*********************************************** use Method [Add()] ***************************************************/

            //// 1] 3andy MEthod 2smha ==> [Add()] ==> beta5od men Key , Value

            //// el Key men type Object [object] l2n el hashtable dah Non-Generic
            //// el key mynfa34 yb2a be null l2n mafe4 hashcode ll null fa mynfa34 yb2a nullable object
            //// el Value men type nullable Object [object?] l2n el hashtable dah Non-Generic
            //// 3ady el value yb2a feha null fa 3l4an kdah hya nullable object 
            //// 27na ben3ml PhoneBook 2w NoteBook el hwa byno7t 2sm el 4a5s we gamboh el phonenumber el 5as beh 

            //phoneBook.Add("Mariam", 123);
            //phoneBook.Add("Omar"  , 456);
            //phoneBook.Add("Amira" , 789);

            //// tab3n ba3d ma deft 3 elements fe el hashtable beta3y kdah el Cout hyb2a be 3 

            //Console.WriteLine($"Count of HashTable => {phoneBook.Count}");

            /**********************************************************************************************************************/

            /******************************************** use [Object Initializer] ************************************************/

            //// 2] tany tare2a 2def beha badl ma kol 4wyay 3amal ba3ml Add Add Add
            //// ah feh el tare2a deh hya ==> [Object Initializer]

            //Hashtable phoneBook2 = new Hashtable()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            /**********************************************************************************************************************/

            /****************************************** use [Indexer in HashTable] ************************************************/

            //// 3] talt tare2a we hya 23rf el data beta3ty 3an tare2 el [indexer]
            //// 3andy [Indexer] gwa el HashTable
            //// 3an tare2 bamsk el Key bel Indexer we ba assign feh el Value zay kdah ==>

            //Hashtable phoneBook3 = new Hashtable()
            //{
            //    ["Mariam"] = 123 ,
            //    ["Omar"]   = 456 ,
            //    ["Amira"]  = 789 
            //};


            /**********************************************************************************************************************/

            //// tab law ro7t deft element kman benafs el Key bs Value mo5talefa ya3ny hadef "Amira" tany bs be value tanya
            //// fa law ro7t ta7t 3ardt el data hydrb error 2w Exception 
            //// we dah motwke3 l2n 27na 2olna men el bedya el Key mynfa34 yb2a fe null we mynfa34 yb2a duplicated 
            //// laze el Key ykon [Unique]
            //// fa hwa hatl2eh by2olk fe el Error 2w el Exception el tal3 hatl2eh by2olk ==>[Item has already been added]
            //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf tb hwa 3erf mnen 2enoh 2etdaf ??
            //// ma 27na 2olna hwa bygeb el HashCode ll key men 5elal method el [GetHashCode()] we el Key men type String
            //// fa sa3tha hygeb el [GetHashCode()]] beta3t el String we hygeb el [Equals] beta3t el String 
            //// fa Amira wal lykon 5adt 2wl mara hashcode = 001
            //// fa lama had5loh Amira tany [benafs el Case Sensetivity ya3ny el char el cpaital yb2a capital we el small yb2a small]
            //// fa hytla3 le Amira deh bardo nafs el hashcode fa sa3tha b2a hyro7 y call el method [Equals()]
            //// we hyb3tloh el [2 keys] we sa3tha hyl2ehom Equall fe3ln ly ba3d fa hydrb error 2w exception l2n dah 8alt meny me4 menoh

            //phoneBook.Add("Amira" , 999 );


            //// law 5adt balk fe el 7eta el fo2 deh 3altol ana 2olt 2eny deft Amira tany el hya Key bs [benafs el Case Sensetivity]
            //// ma3na kdah law ana da5lt key 2smoh [amira] bs mo5talef 3an el key el 2wlany el hwa [Amira] fe 2n el [A capital badl small]
            //// fa kdah hy2bl el Key 3ady bs hal dah hy7sl ??
            //// ah ll 2sf hy7sl 3ady l2n hwa by3ml Call ll method [GetHashCode()] beta3t el [Key] we el [Key] dah hwa [String]
            //// fa ka2noh by3ml Call ll method [GetHashCode()] beta3t el [String] 
            //// we 27na 3arfen 2en fe el string law nafs el 2sm maktob bs el Case Sensetivity met8yra fe 7arf wa7d zay [amira & Amira]
            //// fa hwa hy4ofhm ka 2enohm 2smen me4 2sm wa7d l2n dah el behavior bta3 el method [GetHashCode()] fe el string
            //// l2noh sa3tha hyd le kol wa7d fehom hashCode mo5talef we lmay ynday 2w y call 3al el method [Equals()] beta3t el string
            //// bardo we ykarn el [2 hashcode's be ba3d] hytla3o mo5tlfen me4 zay ba3d 
            //// fa sa3tha hydef [Amira] ka key we hydef [amira] ka key tany 5als

            //phoneBook.Add("amira" , 999 );

            //// fa 3l4an ne7l el mo4kela deh we n5aleh y4of 2n [Amira] deh hya hya [amira] deh bem3na 2s7 25leh [Non Case Sensetivity]
            //// ya3ny el Capital zay el Small
            //// fa lazem ana 2bny be 2edy el behvior beta3 el [GetHashCode() & Equals()] be7yes 25leha 
            //// law 7ad 7awl yda5l el Key marten be nafs el 2sm bs 2sm Capital we 2sm Small 2w Char Capital we char Small uorfod dah 
            //// we ydrb error 2w Exception y2olh feh ==>[Item has already been added]
            //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf
            //// we tab3n hwa hy3rf dah men 5elal el [GetHashCode() & Equals()] el habnehom be 2edy
            //// fa haro7 23ml Folder 2smoh ==> HashTable
            //// we ha3ml feh [ Class ] by Implement el Interface [IEqualityComparer] we hab3tlk menoh Object 
            //// bs lazem el interface [IEqualityComparer] ykon el erison el Non Generic l2n el HashTable hwa non Generic
            //// ma y3rf4 7aga 3an el Generic Version fa lazem 2st5dm el [IEqualityComparer] el Non Generic
            //// tb hateb3at el object lmen hab3toh ll [Constructor el Hashtabel() el by5od mene el [IEqualityComparer? equalityComparer]]
            //// by5od meny object by implement el interface [IEqualityComparer] dah el Constructor beta3 el Hashtabel()
            //// fa hamsy el Class ==> [StringEqualityComparerNonGenericHashTable]
            //// ha3ml feh eh ??
            //// 2w bem3na 2s7 azay ha3ml gwah 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            //// bem3na 2s7 25leh [Non Case Sensetivity]
            //// 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            //// 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            //// we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydrb error 2w Exception
            //// fa 3l4an negarb el [StringEqualityComparerNonGenericHashTable] el 3amlnah dah 
            //// hanro7 nest5dm el Version baeta3t el constructor el beta5od meny object by implement el [IEqualityComparer]


            //Hashtable phoneBook = new Hashtable(new StringEqualityComparerNonGenericHashTable())
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //// we ba3d ma 3amlt el fo2 dah 3altol law 7awlt 2def [amira] tany hydrb error 2w exception we 7asl f3ln

            //phoneBook.Add("amira", 999);

            #endregion

            #region Loop using Datatype [Dictionary Entry]

            //// 3ayzen b2a ne3rd el data deh bs deh me4 data 3adya deh data feha Key we Value fa ha3rdh azay 2w ha loop 3aleha azay ?
            //// ana 3andy el Key be datatype ==> String
            //// we 3andy el Value be Datatype ==> int
            //// el 2tnen ma3 da3d 2smohm ==> [Dictionary Entry] el ma7tot gwa el hashtable dah type 2smoh [Dictionary Entry]
            //// fa 3l4an te Loop 3al el data deh we te3rdha lazem test5dm el Datatype el hya ==>[Dictionary Entry]
            //// we dah hwa Strcut el C# el 3amloh ll Hashtable we 3andoh gwah el Key we el Value
            //// fa ha3ml el Foreach we el element el hyloop 3al el data hyb2a men type ==> [Dictionary Entry]

            //// bs law 5adt balk men el o/p el bytal3 men el loop lama by3rd el data me4 by3rd el data zay ma anta med5lha
            //// bem3na anta med5al mariam we ba3den omar we ba3den amira fe el motwek3 ytal3 be nafs el tarteb dah fe el console
            //// bs l2a el by7sl 2enoh ma3 kol run bet3mloh ll program bytal3 tarteb mo5talef bytal3 tarteb Random kol mara 
            //// lama bet3ml Run ll Program
            //// we hwa kol 4waya bygblk tarteb mo5talef l2n dah hwa el tarteb el fe3ly el met5azen 3andoh fe el buckets beta3toh
            //// hwa me4 bytratb 7asb ma nata ba3thom l2a hwa bytarb based on el [HashCode] fa nata kol mara by generate lek
            //// [HashCode] mo5talef 3an el mara el 2blha fe kol Run ll Program 
            //// hw abyrabt based on el HashCode bs beta3 el Key wla el Value ?
            //// la2 beta3 el KEy l2n dah hwa el byta5zen fe el bucket 2sln
            //// we el Key dah men type ==> String
            //// we hwa kol mara bygen HashCode ll Key dah el hwa men Type String el kol 4waya ma3 kol run leh hashcode 8er el 2bloh 2sln
            //// fa mara Maraim el hashcode beta3ha yb2a be msln be 001 we omar 003 we amira 002 fa kdah el tarteb hhyb2a 
            //// mariam amira omar 
            //// we mara Maraim el hashcode beta3ha yb2a be msln be 003 we omar 001 we amira 002 fa kdah el tarteb hhyb2a 
            //// omar amira mariam we hakza b2a
            //// bs el bucket 2sln sabta men el bedaya el byt8er el key we 3al 7asb el value beta3toh we el 3amlya el 7ysabya el betm 3aleh
            //// 3l4an yt5azen fe el bucket fa hwa ma3 kol run el key dah byt5azen fe bucket 8er el tanya we 3al 7asb tarteb el bukcet
            //// hwa hy3rd el data beta3toh

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            //// tab law 3ayez 23rd bs el Key me4 3yez 23rd el Value 23ml dah azay ??
            //// haro7 2a access el entry el bet loop fe el foreach we 25tar menha el property el key bs zay kdah ==>
            //// el Property [key] deh hya gwa el Strcut el [Dictionary Entry] fa ba3rf 23mlha access 3altol

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry.Key);
            //}
            //Console.WriteLine();


            //// tab law 3ayez 23rd bs el value me4 3yez 23rd el Key 23ml dah azay ??
            //// haro7 2a access el entry el bet loop fe el foreach we 25tar menha el property el value bs zay kdah ==>
            //// el Property [value] deh hya gwa el Strcut el [Dictionary Entry] fa ba3rf 23mlha access 3altol

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry.Value);
            //}
            //Console.WriteLine();


            //// tab ana 3ayez 2a loop 3al el Key's bs 2w el Value's bs men el 2wl me4 3ayez 2st5dhom ka Property zay 
            //// ma 3amlt el datatype [Dictionary Entry] we men gwaha 3aml access ll Property el Key we eL Value
            //// bs ana me4 3ayez 23ml dah 
            //// ana 3ayez men el 2wl 27dd 2nohm Keys we 2a loop 3alehom 2w 27aded 2nohm Values we 2a loop 3alehom
            //// fa 3andy Property gwa el HashTable 2smha _keys deh 4ayela gwaha el keys bs 
            //// we 3andy Property gwa el HashTable 2smha _values deh 4ayela gwaha el values bs 
            //// we tab3n law ha loop 3al el keys fa lazem el iterator ykon men nfas el data type bet3a el key el hwa string
            //// we tab3n law ha loop 3al el values fa lazem el iterator ykon men nfas el data type bet3a el values el hwa int

            //Console.WriteLine();
            //foreach (string name in phoneBook.Keys)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();

            //Console.WriteLine();
            //foreach (int phone in phoneBook.Values)
            //{
            //    Console.WriteLine(phone);
            //}
            //Console.WriteLine();

            #endregion

            #region Loop using [Object] Parent of Datatype's 

            //// tab 3ayzen ne loop 3al el data bs be 7aga badl ma nest5dm el datatype el hya [Dictionary Entry]
            //// ana 2sln ba loop 3al Entry we el Entry deh 3ady 2a loop 3aleha be 2st5dm el Object 
            //// l2n el Object hwa el Paraent ly kol el Datatype

            //Console.WriteLine();
            //foreach (object entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            #endregion

            #region Loop using Var Datatype 

            //// tab 3ayzen ne loop 3al el data bs be 7aga badl ma nest5dm el datatype el hya [Dictionary Entry]
            //// ana 2sln ba loop 3al Entry we el Entry deh 3ady 2a loop 3aleha be 2st5dm el Var 
            //// lysa han5od el Var 2doma

            //Console.WriteLine();
            //foreach (var entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            #endregion

            #region Indexer

            //// 3andy Indexer 3and el HashTable by3ml eh el Indexer dah b2a 
            //// by3ml kol 7aga hy5leh te get el value we te set el value we te update el value 
            //// fa hwa by3ml kol 7aga 

            //// 1] bast5dm el Indexer 3l4an 2a Get el hwa 23rd el Data
            //// fa lama hat3ml kda ==> phoneBook[] hwa metsany gwah el [object key]
            //// el mafrod hwa by return object fa lazem 2st2bloh fe 7aga 2w 2tba3oh 3altol
            //// we tab3n ha7tag 23ml casting 3l4an a22loh 7awly el object dah ly int el hya el vlaue el ana mestanyha
            //// bs el object dah el byrag3 null fa lazme ba3d ma 23mloh casting lazem el null el 3amltha casting tekon nullable bardo
            //// 3l4an momken yrg3 men el object null fa lazem 23mloh casting fe 7aga nullable fe lazem 23mloh nullable int
            //// fa hyb2a kdah ==> (int?)phoneBook["Mariam"];
            //// bs kdah el goz2 el 3al el ymene b2a nullabe momken yrag3 null el hwa ==> (int?)phoneBook["Mariam"];
            //// lakn el goz2 el 3al el 4emla dah me4 be null me4 by allow el null fa kdah mynfa34 assign nullable datatype 
            //// fa datatype me4 bet allow el null fa el sa7 tekon hya kman be null ==> int? num 

            //int? num = (int?)phoneBook["Mariam"];
            //Console.WriteLine($"Number is : {num}");
            //Console.WriteLine();

            ////or

            ////Console.WriteLine($"Number is : {phoneBook["Mariam"]}");

            //// 2] bast5dm el Indexer 3l4an 2a update el hwa 23dl 2w 28er fel value
            //// fa lama hat3ml kda ==> phoneBook[] hwa metsany gwah el [object key]
            //// hateb3tloh we el Key el 3ayez te8er fe el vlaue we ba3den te assign el Value we gdeda 
            //// we ba3den hane3rd el data
            //// hwa hena yo3tabr 3aml update l2noh lama ra7 dawr 3al el Key fe el HashTable la2a el Key fe3ln mawgod we leh value
            //// fa l4an kdah ra7 3aml Update
            //// lakn law 2detoh Key me4 Mawgod 2sln fe el HashTable fa sa3tha hwa kdah el Indexer 4a8al be y set 2w hy3ml Insert
            //// ll key we el value el gdeda 

            //phoneBook["Mariam"] = 777;
            //Console.WriteLine($"Number of Mariam is : {phoneBook["Mariam"]}");

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            //// 3] bast5dm el Indexer 3l4an 2a Set el hwa 2def Key we Value fe el HashTable
            //// fa lama hat3ml kda ==> phoneBook[] hwa metsany gwah el [object key]
            //// hateb3tloh we el Key we el Value 
            //// we ba3den hane3rd el data
            //// hwa hena yo3tabr ma3aml4 update l2noh lama ra7 dawr 3al el Key fe el HashTable mla2a4 el Key 
            //// fa 3l4an kdah ra7 3aml Set
            //// lakn law 2detoh Key Mawgod 2sln fe el HashTable fa sa3tha hwa kdah el Indexer 4a8al be y update 
            //// fa hymsk el Key y7ot feh el value el 2dema 

            //phoneBook["Ahmed"] = 222;
            //Console.WriteLine($"Number of Ahmed is : {phoneBook["Ahmed"]}");

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();


            //// law get 2olteloh hatl2y el Value ly Key bs el Key dah me4 mawgod 3andy 2sln sa3tha hwa hy3ml ??
            //// hyrg3l null we el null fe el Console hy EmptyString
            //// l2n lama ha2loh ==> Console.WriteLine($"Number of amr is : {phoneBook["amr"]}");
            //// we el Key [amr] dah me4 mawgod 2sln we kdah kdah el phoneBook by return lek nullable object
            //// fa lama ydawr 3al el key el 2smph amr fe el hashtable me4 hyl2eh fe hyrg3lk el null
            //// dah 7asl l2n el HashTable hwa NonGeneric we Based on [Object]
            //// el Klam dah fe el [Dictionary] hydrb error 2w exception me4 hytala3lk null wla result kdah fe el console l2a hydrb error
            //// l2nk bet7awl te access Key me4 mawgod 2sln

            //Console.WriteLine($"Number of Amr is : {phoneBook["Amr"]}");

            #endregion

            #region Constructors

            //// 27na 5adna fo2 no3en men el Constructor 
            //// 1] Parameterless Constructor
            //// 2] Hashtabel(IEqualityComparer? equalityComparer) el by5od mene el [IEqualityComparer? equalityComparer]
            //// 3] 3andena Constructor talt by5od meny Collection by implement el interface [IDictionary] ==> Hashtanle(IDictionary d)
            ////    tb dah zay men ?? zay el Hastable nafsoh l2n el Hashtable by implement el interface [IDictionary]
            ////    fa ha3ml kdah hashtable we ha3rf el data feh bets5dam el [Object Initializer]
            ////    we ba3den ha3ml hashtable tany hy5od meny el hash table el temp dah we ha loop 3al el phoneBook el 5ad el data
            ////    men el temp fa hal2y el data ba2t feh 


            //Hashtable temp = new Hashtable()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //Hashtable phoneBook = new Hashtable(temp);

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();


            #endregion

            #region Remove

            //// 3andy Method 2smha [Remove()] fa ana hab3tlk el Key we anta hatms7ly el Key we el Value el mokabl leha kman 

            //Hashtable phoneBook = new Hashtable()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            //phoneBook.Remove("Mariam");

            //Console.WriteLine();
            //foreach (DictionaryEntry entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            #endregion

            #region Properties [Keys , Values , Count , IsFixedSize , IsReadOnly]

            //// 27na 4ofna fo2 el Properties el  ==> [Keys , Values , Count ]

            //// fadl b2a el 2 Properties dol ==> [ IsFixedSize , IsReadOnly ] ==> Dol malhom4 ay lazma hena 2wii
            //// hwa wa5edhom as a Signutare men interfcae 2smoh [IDictionary]
            //// el interface el 2smoh [IDictionary] hwa 3andoh el 2 Properties dol 3andoh el 2 Signature for 2 Properties dol
            //// 3l4an fe Collections Tanya bet Implement el [IDictionary] fa me7tagenhom 3andha sa3tha 
            //// bs ana 3andy hena fe el Hashtable hatl2eh hwa 3amel gwahom 2enohm hy return False da2emn
            //// l2n ana ka Hashtable wla ana FixedSize wla ana ReadOnly 
            //// tb hwa 3amlohm implement leh ??
            //// l2noh 3aml implement ll interface [IDictioanry] fa lazem kan y implement el signaute beta3 el 2 Properties dol
            //// bs hwa me4 by3ml gwahm 7aga 8er 2enoh by return False we kman hwa 3amlhom get bs ya3ny readonly me4 hat2dr te3dl feha
            //// 2w t8yer feha 7aga l2enha ma3ndha4 set 


            //Hashtable phoneBook = new Hashtable()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //Console.WriteLine($"IsFixedSize in HashTable = {phoneBook.IsFixedSize}");
            //Console.WriteLine();
            //Console.WriteLine($"IsReadOnly in HashTable = {phoneBook.IsReadOnly}");

            #endregion

            #endregion


            #region Dictionary


            /************************************* Concept of Double Hashing and how it work *************************************/

            //// tab3n el Dictionary dah Generic Collection we 3l4an 2st5dmoh lazme 2st5dm el namespace el hya => System.Generic.Collections
            //// el Dictionary be use el [Double Hashing] 
            //// tab eh hwa el [Double Hashing] ??
            //// dah hwa mechanism beydmanly 2en my7sla4 2zma fe w2t el ta5zen 
            //// tb eh 2sln el 2zma el momken te7sl 2sln ? ha2lok delw2ty
            //// 5aly balk el [Entries] el anta bet4el feha el data momken te4el or Contain 0 or 1 Element[mean Key] dah el Maximum
            //// matge4 t2oly 2enha hat4el 2ktr men kdah mynfa34 t4el 2ktr men kdah hya 25eha ya t4el 1 key ya ma t4el4  
            //// tab el klam dah by7sl azay ??
            //// baro7 2sy5dm [ 2 Hashing functions ] me4 bast5dm el 2tnene ma3 ba3d l2a tb 2omal bet3ml eh ??
            //// anta delw2ty ba3tly el [Key] we 3ayez te5azn el data deh fe [Entry] 3andy ya3ny 3ayez te7gz Entry t7ot feh el key 
            //// we hat5zen sa3tha el data el hya el value el mkable lel key feh bs lazem el 2wl nel2ay Entry ma3ndha4 key 
            //// l2n law 2detny Entry 3andha key hy7sl b2a mo4kela we hya deh el 2zma el bahrb menha 3l4an ma te7sal4 
            //// fa baro7 2msk el [Key] el anta ba3toh dah we ba3ml 3aleh el 2wl [2wl hash function] el hya law da5lt gwa el Dictionary
            //// hal2y 2wl function ba3mlha 3al el [Key] el gya hya ==> h1(key) = GetHash(key); // default implementations calls key.GetHashCode()
            //// fa el mafrod hyrg3l rakm mo3yen el rakm el rag3 dah law el [Entry] el rag3holy 2w el index beta3 el Entry el rag3 dah
            //// ma el rakm el rag3 dah hwa hwa el index beta3 el Entry el hat7ot feh el key 3l4an y7tafez bel data beta3tk fa law kan fady 
            //// ma3n 2enoh fady me4 3al el rakm la2 3al el index of Entry 2enha me4 ma5zena gwaha key 2sln we fady we gahza ly ta5zen key 
            //// fa law kant el Entry me4 ma5zena 7aga we fadya fa
            //// habd2 27ot feh el [Key] beta3k we el donya hateb2a zay el fol we el data beta3tk 2et7at 
            //// tab law kan rag3ly [HashCode] el [HashCode] dah already hywadeny ly [Entry] el [Entry] deh feha data
            //// ya3ny rag3ly index beta3 Entry 2sln hya me5zena key we me5zena el data beta3toh fa hya kdah met5azena fa me4 hynf3 25zen 7aga tany
            //// l2n el Entry el wa7da hya bt4el maximum 1 key bs fa hwa b2a rag3l Entry feh 2sln key 
            //// hwa dah 2sln momken y7asl 2enk te3ml 3amlya 7esabya mo3yna
            //// we ytla3ly el [Entry] marten we 2sln el mafrod el Entry by4el 0 or 1 element[Key] bs  ??
            //// ah dah momken y7asl we law 7asl bensameh [Collision mean tasadom] tb el [collision] dah ben7eloh azay ??
            //// byro7 sa3tha yt Check 3al el [Equals()] w2tha tb hy3ml eh bel [Equals()] ??
            //// yro7 y4of el [Equals()] law el [2 Key's el hwa el Key el already met5azen fe el Entry we el key beta3y el ana ba3toh]
            //// be Equal ba3d yb2a anta bet3ml behavior 8alt fa ana hadrb Exception hadrb error l2n 27na 2olna el Key lazem yb2a Unique
            //// maynfa34 23ml Dupliacte ll Key fa el 8alt men 3ansy ana we ana el lazzem 27eloh lakn
            //// tb law el [2 Key's el hwa el Key el already met5azen fe el Entry we el key beta3y el ana ba3toh]
            //// me4 be equal ba3d anta kdah malk4 zanb el 7asl 2en [2wl hash function] rag3tly nafs el [Entry]
            //// we dah 8alt men 3andha nateget 7esabat mo3yna 
            //// fa ana ha7tag 27l el 2zma deh 
            //// we sa3tha haro7 3al [tany hash function] el hya ==> h2(key) = 1 + (((h1(key) >> 5) +1) % (hashsize - 1));
            //// we hast5dmha we ha4oflk [Entry] gded han2l feh el data beta3tk henak
            //// we dah ana ha3mloh kolo internaly anta me4 hatal7ez 7aga 

            /***********************************************************************************************************************/

            //// el Dictionary men Gwa hwa 3obara 3an Array of Entry we el Entry mokwan men [hash_code , Key , Value , Next]
            //// we el Dictionary gwah 2 Array el homa ==> [_buckets , _entries]
            //// tb el [_enteries] dah el byt3aml ma3 el Key we el Value
            //// men b2a el [_buckets] deh ??
            //// dah hwa el mohtm beh me4 ana el [_buckets] dah hwa el ==> Array of indexes beta3t el Entries 
            //// fa 3l4an kdah hwa mawgod 3andy we kamn el datatype beta3 el Array of _buckets dah hwa mn Datatype int l2noh by4el 
            //// el indexes beta3t el Entries 
            //// tb el Array of Entries dah bybd2a be Size kam ??
            //// hwa me4 3aml Initial size tb el Capacity hatkon be 2eh 2w el initial Capacity hatkon be eh ??
            //// a2lk hwa men 2wl el Dictionary l7ad ba2et el 7agat el hanetklm 3aleha 2odam 2btda y4ta8l be Mechanism mo5talef 4wya 
            //// fe 7awr el ReSize we el Capacity tab azay ??
            //// a2lk men 2wl el Dictionary l7ad el ba2y el gay 2odam 2btada yfsl mo3zm el [HelperMethods] fe Class tany el hwa [HashHelpers]
            //// we men gwa el Class el [HashHelpers] ben access el method el hwa me7tagha 
            //// fa hwa fe mawdo3 el Resize we el Capacity byst5dm el Method [GetPrime()] el bygbha men el Class[HashHelpers]
            //// tb eh hya el [GetPrime()] eh bet3ml azay ya3ny el Resize 2w betbny azay el Capacity ??
            //// el [GetPrime()] deh 4a8al be tare2a mo5talefa fe mawdo3 el mechanism beta3 el Rsize wel Capacity
            //// ana fe el 2wl 5als lma babd2a badb2a be Capacity = zero[0] el Size beta3 el Array beta3y byb2a be zero[0]
            //// ya3ny lama test5dm el Patameterless Constructor el hwa [Dictionary<TKey , TVlaue>()] ana 3arf el Capacity betb2a  = zero [0]
            //// lakn lma 2bd2a b2a 2def 2wl elemnt el hwa ha3ml Resize haro7 2nady 3al el method [Initialize(int capacity)] we 2bd2a 23ml Resize 
            //// el Resize hytm azay ?? 
            //// byro7 ynady 3al el method [GetPrime(capacity)]  we hyb3tlha el Capacity el hya 2sln = 0 we bybd2a y4of 2wl rakm [Prime]
            //// men ba3d el Rakm el anta ba3toh fe el Capacity fa ana ba3t el Capacity be = 0 fa hadawr 3al 2wl rakm Prime ba3d el 0
            //// we el rakm el Prime el ba3d el 0 hwa el [2] bs hwa me4 hybd2a bel [2] hwa hyro7 ybd2a men el [3] ma el 3 rakm Prime bardo
            //// fa hwa by3tbr 2wl rakm Prime ba3d el 0 hwa [3] fa hyba2a el Capacity =  InitialCapacity = 3 
            //// hwa bybd2a be 3 ma3 2wl element hadefoh 
            //// tab el Capacity deh 2w el size byzed azay ?? ya3na 2bl kdah fe el List kan byzed bel de3f 
            //// tab hena el Capacity hatzeb be 2eh 2w azay ??
            //// lama b2a 2def el 3 elements kolhom we ba3d kdah hadef el element el 4 fa hwa tabe3y hyzawd el Capacity bs hwa 
            //// byzawdha bel [GetPrime(Capacity)] fa hya kant be 3 fa lama hab3t 3 ll GetPrime() hyro7 y4of el rakm el Prime el 
            //// ba3d el 3 el hwa 5 we law deft 5 elements we hadef el 6 hyro7 yzawd el Cpapcity we y4of el rakm el prime el ba3d 
            //// el 5 el hwa 7 we hakza fa hwa dah tare2t el Resize beta3oh fe el Capacity we el Size 

            /***********************************************************************************************************************/

            //// yala b2a net3aml ma3 el Dictionary
            //// lazem ne7add el 2wl el DataType beta3 el Key we el Value men el 2wl 3l4an dol el nahme4y 3alehom fe ba2y el program
            //// law ma7detthom4 me4 hynf3 l2n deh Generic we lazem te7adedhom
            //// we hwa 3amlk Constrain 3al el T_Key el hya el datatype beta3t el Key 2enha me4 hateb2a be null kdah==>[where TKey : notnull]
            //// hwa 7atet Constrain 3al el Class kolh beta3 el Dictionary kdah ==>[System.Collections.Generic.Dictionary<TKey,TValue> where TKey : notnull ]
            //// tab3n 27na lys fe el bedaya ma7tena4 ay element fa lama hatb3 el Count hyb2a be = zero[0]
            //// l2n el Count hwa el 3add el element el fe3ly el gwa el Dictionary we hwa lysa fady fa hwa be 0
            //// tab belnesba ll Capacity ?
            //// anta hena lek access 3al el Capacity ya3ny law ro7t 3amlt kdah ==> phoneBook.Capacity
            //// hatl2eha mawgoda 2sln ka Property 2smha Capacity 3al 3aks el HashTable makn4 leh access 3al el Capacity 
            //// l2n me4 3andoh el Property deh 2sln
            //// we tab3n hya fe el bedya el Capacity be = Zero[0] we lma hatdef 2wl element hyro7 b2a ynday 3al el [GetPrime(Capacity)]
            //// we yro7 ygeb el rakm el Prime el ba3d el 0 we hena hwa by3tbr 2wl rakm prime ba3d el 0 hwa 3 me4 2 fa sa3tha 
            //// el Cpapcity hateb2a be 3 we hakza b2a 

            //Dictionary<string , int> phoneBook = new Dictionary<string , int>();

            //Console.WriteLine($"Count of Dictionary => {phoneBook.Count} , Capacity of Dictionary => {phoneBook.Capacity}");

            #region Add Elements in Dictionary using 3 Ways

            //// 3ayzen b2a nebd2a ne add Elements 3andy fe el Dictionary 
            //// 3andy 3 tor2 :-

            /*********************************************** use Method [Add()] ***************************************************/

            //// 1] 3andy MEthod 2smha ==> [Add()] ==> beta5od men Key , Value

            //// el Key men type Tkey el ana 7adetoh fo2 fe el Generic fe el Dictionary el hwa [string] l2n el Dictionary dah Generic
            //// el key mynfa34 yb2a be null l2n mafe4 hashcode ll null fa mynfa34 yb2a nullable string
            //// we kman hwa 3aml Constrain fo2 3al el Class beta3 el Dictionary kdah ==>[System.Collections.Generic.Dictionary<TKey,TValue> where TKey : notnull ]
            //// el hwa mynfa34 el Type el hat7oth ll Tkey ykon be null mynf34
            //// el Value men type Tvalue el ana 7adetoh fo2 fe el Generic fe el Dictionary el hwa [int] l2n el Dictionary dah Generic
            //// 3ady el value yb2a feha null fa 3l4an kdah hya momken teb2a nullable int ma3l4an Constrain zay el type beta3 el Key
            //// 27na ben3ml PhoneBook 2w NoteBook el hwa byno7t 2sm el 4a5s we gamboh el phonenumber el 5as beh 

            phoneBook.Add("Mariam", 123);
            phoneBook.Add("Omar"  , 456);
            phoneBook.Add("Amira" , 789);

            //// tab3n ba3d ma deft 3 elements fe el hashtable beta3y kdah el Count hyb2a be 3 
            //// we tab3n mogard ma deft 2wl element el Capacity ba2t mn 0 ba2et be 3 
            //// l2n dah el prime el ba3d el 0 l2enoh me4 mo3tbr el 2 2enha prime
            
            Console.WriteLine($"Count of Dictionary => {phoneBook.Count} , Capacity of Dictionary => {phoneBook.Capacity}");

            /****************************** Very Important about Capacity and how it Increase ****************************************/

            //// we tab3na law deft element rab3 fa el Count hyzeb be 1 3ady lakn el el Capacity sa3tha htro7 tedawr 3al el prime
            //// number el ba3d el 3 el hwa hykon be 5 bs el 7asl hale2eh b2a be 7 fa el Capacity hateb2a be 7
            //// tb zay ba2et be 7 me4 5 l2n hwa ah el [GetPrime(capacity)] betgeb el Prime number el ba3d el rakm ely Capacity beh
            //// bs me4 el next prime number 3altol l2a deh hya betgeb el rkam el b3yed 4wya 3al4an teb2a more efficent and high performance
            //// 3l4an me4 kol 4waya yro7 ybnelk Array of Entries gdeda kol 4wya lama tezawd el Capcity fa hwa 3l4na kdah byro7 ygeb el rakm
            //// el be3ed 4waya bs Prime number b7yes yb2a wafrlk mas7a fe el Array of Entries we kman me4 kol 4waya hyro7 y3mlk
            //// array of Entry gded 3l4an y2alel el unreachable array el hy7sl lma kol 4waya y8er el Capacity fa hy8er el Array 
            //// we hy3ml Array gded fa 3l4an kdah lam ana da5lt gwaha l2et 2n el Capacity betb2a = 0 3 7 17 37 89 ... we hakza
            //// kolhm Prime number bs me4 next wara ba3d la2 bo3ad 4wya 3l4an y2all 7etet el unreachable Array of Entry el by3mlha 
            //// lama el elemenyt tzed 3an el Capaicty fa byzawd el Capacity we by3aml Array of Entry gded 

            //phoneBook.Add("Ahmed", 222);
            //Console.WriteLine($"Count of Dictionary => {phoneBook.Count} , Capacity of Dictionary => {phoneBook.Capacity}");


            /**********************************************************************************************************************/

            /******************************************** use [Object Initializer] ************************************************/

            //// 2] tany tare2a 2def beha badl ma kol 4wyay 3amal ba3ml Add Add Add
            //// ah feh el tare2a deh hya ==> [Object Initializer]

            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            /**********************************************************************************************************************/

            /****************************************** use [Indexer in Dictionary] ************************************************/

            //// 3] talt tare2a we hya 23rf el data beta3ty 3an tare2 el [indexer]
            //// 3andy [Indexer] gwa el Dictionary
            //// 3an tare2 bamsk el Key bel Indexer we ba assign feh el Value zay kdah ==>

            //Dictionary<string, int> phoneBook3 = new Dictionary<string, int>()
            //{
            //    ["Mariam"] = 123 ,
            //    ["Omar"]   = 456 ,
            //    ["Amira"]  = 789 
            //};


            /**********************************************************************************************************************/

            //// tab law ro7t deft element kman benafs el Key bs Value mo5talefa ya3ny hadef "Amira" tany bs be value tanya
            //// fa law ro7t ta7t 3ardt el data hydrb error 2w Exception 
            //// we dah motwke3 l2n 27na 2olna men el bedya el Key mynfa34 yb2a fe null we mynfa34 yb2a duplicated 
            //// lazem el Key ykon [Unique]
            //// fa hwa hatl2eh by2olk fe el Error 2w el Exception el tal3 hatl2eh by2olk ==>[Item has already been added]
            //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf tb hwa 3erf mnen 2enoh 2etdaf ??
            //// ma 27na 2olna hwa bygeb el HashCode ll key men 5elal method el [GetHashCode()] we el Key men type String
            //// fa sa3tha hygeb el [GetHashCode()]] beta3t el String we hygeb el [Equals] beta3t el String 
            //// fa Amira wal lykon 5adt 2wl mara hashcode = 001
            //// fa lama had5loh Amira tany [benafs el Case Sensetivity ya3ny el char el cpaital yb2a capital we el small yb2a small]
            //// fa hytla3 le Amira deh bardo nafs el hashcode fa sa3tha b2a hyro7 y call el method [Equals()]
            //// we hyb3tloh el [2 keys] we sa3tha hyl2ehom Equall fe3ln ly ba3d fa hydrb error 2w exception l2n dah 8alt meny me4 menoh

            //phoneBook.Add("Amira" , 999 );


            //// law 5adt balk fe el 7eta el fo2 deh 3altol ana 2olt 2eny deft Amira tany el hya Key bs [benafs el Case Sensetivity]
            //// ma3na kdah law ana da5lt key 2smoh [amira] bs mo5talef 3an el key el 2wlany el hwa [Amira] fe 2n el [A capital badl small]
            //// fa kdah hy2bl el Key 3ady bs hal dah hy7sl ??
            //// ah ll 2sf hy7sl 3ady l2n hwa by3ml Call ll method [GetHashCode()] beta3t el [Key] we el [Key] dah hwa [String]
            //// fa ka2noh by3ml Call ll method [GetHashCode()] beta3t el [String] 
            //// we 27na 3arfen 2en fe el string law nafs el 2sm maktob bs el Case Sensetivity met8yra fe 7arf wa7d zay [amira & Amira]
            //// fa hwa hy4ofhm ka 2enohm 2smen me4 2sm wa7d l2n dah el behavior bta3 el method [GetHashCode()] fe el string
            //// l2noh sa3tha hyd le kol wa7d fehom hashCode mo5talef we lmay ynday 2w y call 3al el method [Equals()] beta3t el string
            //// bardo we ykarn el [2 strings el hwa Amira we amira] hytla3o mo5tlfen me4 zay ba3d l2n fe 25etlaf fe 7arf el [A we a] 
            //// fa sa3tha hydef [Amira] ka key we hydef [amira] ka key tany 5als

            //phoneBook.Add("amira" , 999 );

            //// fa 3l4an ne7l el mo4kela deh we n5aleh y4of 2n [Amira] deh hya hya [amira] deh bem3na 2s7 25leh [Non Case Sensetivity]
            //// ya3ny el Capital zay el Small
            //// fa lazem ana 2bny be 2edy el behvior beta3 el [GetHashCode() & Equals()] be7yes 25leha 
            //// law 7ad 7awl yda5l el Key marten be nafs el 2sm bs 2sm Capital we 2sm Small 2w Char Capital we Char Small uorfod dah 
            //// we ydrb error 2w Exception y2olh feh ==>[Item has already been added]
            //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf
            //// we tab3n hwa hy3rf dah men 5elal el [GetHashCode() & Equals()] el habnehom be 2edy
            //// fa haro7 23ml Folder 2smoh ==> Dictionary
            //// we ha3ml feh [ Class ] by Implement el Interface [IEqualityComparer] we hab3tlk menoh Instance 
            //// bs lazem el interface [IEqualityComparer] ykon el Verison el Generic l2n el Dictionary hwa Generic
            //// ma y3rf4 7aga 3an el Non-Generic Version fa lazem 2st5dm el [IEqualityComparer<TKey>] el Generic
            //// we tab3n lazem ykon el Generic beta3 el IEqualityComparer<TKey> ykon men nafs el Type beta3 el TKey el hwa string
            //// l2noh hwa by check 3al el key el hwa el string we el bagbloh hashcode
            //// tb hateb3at el instance lmen hab3toh ll [Constructor el Dictionary<string,int>() el by5od mene el [IEqualityComparer<string>? Comparer]]
            //// by5od meny instance by implement el interface [IEqualityComparer] dah el Constructor beta3 el Dictionary<TKey,Tvalue>()
            //// fa hamsy el Class ==> [StringEqualityComparerGenericdictionary]
            //// ha3ml feh eh ??
            //// 2w bem3na 2s7 azay ha3ml gwah 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            //// bem3na 2s7 25leh [Non Case Sensetivity]
            //// 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            //// 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            //// we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydrb error 2w Exception
            //// fa 3l4an negarb el [StringEqualityComparerGenericdictionary] el 3amlnah dah 
            //// hanro7 nest5dm el Version baeta3t el constructor el beta5od meny object by implement el [IEqualityComparer]


            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>(new StringEqualityComparerGenericDictionary())
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //// we ba3d ma 3amlt el fo2 dah 3altol law 7awlt 2def [amira] tany hydrb error 2w exception we 7asl f3ln

            //phoneBook2.Add("amira", 999);




            //// fe overload Constructor tany ll Dictionary el hwa by5od meny [IEnumerable<KeyValuePair<string , int>> collection]
            //// hwa by5od meny IEnumberable of type <KeyValuePair<string , int>
            //// ma el <KeyValuePair<string , int> dah Type 3ady homa 3amlenoh dah type mawgod ka struct te2dr tet3aml beh 3ady 
            //// tb el <KeyValuePair<string , int> dha hateb3tloh 2eh el data type beta3 el key we el value 
            //// hab3thom string we int 
            //// we ha3mloh array kdah ==> KeyValuePair<string, int>[] arr ==> dah kdah b2a array 2detoh 2sm arr we hat3ml beh 3ady 
            //// zay ma ba3ml ay array 3ady 
            //// el hwa badl ma kont hateb3tly array of int l2a anat hateb3tly array of KeyValuePair 3ady zay ma kona ben3ml zman 
            //// we kol element fehom hwa 3obara 3an object of KeyValuePair<string, int>(by5od hean el key w el value)
            //// zay kdah ==> new KeyValuePair<string, int>("Mariam" , 123 )
            //// tab hwa lazem array bs mynfa34 ay 7aga 8er el array ??
            //// momken te3mloh list 3ady bs of KeyValuePair<string, int>
            //// ay 7aga b2a bet implement el interface [IEnumerable<KeyValuePair<string , int>> collection] hwa hy2blha menk fe el
            //// Constrcutor 3ady 
            //// we haro7 b2a 23bt el array dah [arr] ly el Dictonary el ana 3amlha 3ady 
            //// kdah ==> Dictionary<string, int> phoneBook2 = new Dictionary<string, int>(arr);


            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[]

            //{
            //    new KeyValuePair<string, int>("Mariam" , 123 ),
            //    new KeyValuePair<string, int>("Omar"   , 456 ),
            //    new KeyValuePair<string, int>("Ahmed"  , 222 )
            //};

            //or

            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[3];

            //arr[0] = new KeyValuePair<string, int>("Alpha", 100);
            //arr[1] = new KeyValuePair<string, int>("Beta", 200);
            //arr[2] = new KeyValuePair<string, int>("Gamma", 300);


            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>(arr);

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook2)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();



            //// tab law ro7t deft element kman benafs el Key bs Value mo5talefa ya3ny hadef "Ahmed" tany bs be value tanya
            //// fa law ro7t ta7t 3ardt el data hydrb error 2w Exception 
            //// we dah motwke3 l2n 27na 2olna men el bedya el Key mynfa34 yb2a fe null we mynfa34 yb2a duplicated 
            //// lazem el Key ykon [Unique]
            //// fa hwa hatl2eh by2olk fe el Error 2w el Exception el tal3 hatl2eh by2olk ==>[Item has already been added]
            //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf tb hwa 3erf mnen 2enoh 2etdaf ??
            //// ma 27na 2olna hwa bygeb el HashCode ll key men 5elal method el [GetHashCode()] we el Key men type String
            //// fa sa3tha hygeb el [GetHashCode()]] beta3t el String we hygeb el [Equals] beta3t el String 
            //// fa Ahmed wal lykon 5adt 2wl mara hashcode = 001
            //// fa lama had5loh Ahmed tany [benafs el Case Sensetivity ya3ny el char el cpaital yb2a capital we el small yb2a small]
            //// fa hytla3 le Ahmed deh bardo nafs el hashcode fa sa3tha b2a hyro7 y call el method [Equals()]
            //// we hyb3tloh el [2 keys] we sa3tha hyl2ehom Equall fe3ln ly ba3d fa hydrb error 2w exception l2n dah 8alt meny me4 menoh


            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[]

            //{
            //    new KeyValuePair<string, int>("Mariam" , 123 ),
            //    new KeyValuePair<string, int>("Omar"   , 456 ),
            //    new KeyValuePair<string, int>("Ahmed"  , 222 ),
            //    new KeyValuePair<string, int>("Ahmed"  , 111 )
            //};

            ////or

            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[3];

            //arr[0] = new KeyValuePair<string, int>("Alpha", 100);
            //arr[1] = new KeyValuePair<string, int>("Beta", 200);
            //arr[2] = new KeyValuePair<string, int>("Gamma", 300);
            //arr[3] = new KeyValuePair<string, int>("Gamma", 350);



            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>(arr);

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook2)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();



            //// bs hal2y hena fe mo4kela b2a
            //// law 5adt balk fe el 7eta el fo2 deh 3altol ana 2olt 2eny deft Ahmed tany el hya Key bs [benafs el Case Sensetivity]
            //// ma3na kdah law ana da5lt key 2smoh [ahmed] bs mo5talef 3an el key el 2wlany el hwa [Ahmed] fe 2n el [A capital badl small]
            //// fa kdah hy2bl el Key 3ady bs hal dah hy7sl ??
            //// ah ll 2sf hy7sl 3ady l2n hwa by3ml Call ll method [GetHashCode()] beta3t el [Key] we el [Key] dah hwa [String]
            //// fa ka2noh by3ml Call ll method [GetHashCode()] beta3t el [String] 
            //// we 27na 3arfen 2en fe el string law nafs el 2sm maktob bs el Case Sensetivity met8yra fe 7arf wa7d zay [ahmed & Ahmed]
            //// fa hwa hy4ofhm ka 2enohm 2smen me4 2sm wa7d l2n dah el behavior bta3 el method [GetHashCode()] fe el string
            //// l2noh sa3tha hyd le kol wa7d fehom hashCode mo5talef we lmay ynday 2w y call 3al el method [Equals()] beta3t el string
            //// bardo we ykarn el [2 strings el hwa Ahmed we ahmed] hytla3o mo5tlfen me4 zay ba3d l2n fe 25etlaf fe 7arf el [A we a] 
            //// fa sa3tha hydef [Ahmed] ka key we hydef [ahmed] ka key tany 5als

            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[]

            //{
            //    new KeyValuePair<string, int>("Mariam" , 123 ),
            //    new KeyValuePair<string, int>("Omar"   , 456 ),
            //    new KeyValuePair<string, int>("Ahmed"  , 222 ),
            //    new KeyValuePair<string, int>("ahmed"  , 111 )
            //};

            //or

            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[3];

            //arr[0] = new KeyValuePair<string, int>("Alpha", 100);
            //arr[1] = new KeyValuePair<string, int>("Beta", 200);
            //arr[2] = new KeyValuePair<string, int>("Gamma", 300);
            //arr[3] = new KeyValuePair<string, int>("gamma", 350);



            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>(arr);

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook2)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();


            //// fa 3l4an ne7l el mo4kela deh we n5aleh y4of 2n [Amira] deh hya hya [amira] deh bem3na 2s7 25leh [Non Case Sensetivity]
            //// ya3ny el Capital zay el Small
            //// fa lazem ana 2bny be 2edy el behvior beta3 el [GetHashCode() & Equals()] be7yes 25leha 
            //// law 7ad 7awl yda5l el Key marten be nafs el 2sm bs 2sm Capital we 2sm Small 2w Char Capital we Char Small uorfod dah 
            //// we ydrb error 2w Exception y2olh feh ==>[Item has already been added]
            //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf
            //// we tab3n hwa hy3rf dah men 5elal el [GetHashCode() & Equals()] el habnehom be 2edy
            //// fa haro7 23ml Folder 2smoh ==> Dictionary
            //// we ha3ml feh [ Class ] by Implement el Interface [IEqualityComparer] we hab3tlk menoh Instance 
            //// bs lazem el interface [IEqualityComparer] ykon el Verison el Generic l2n el Dictionary hwa Generic
            //// ma y3rf4 7aga 3an el Non-Generic Version fa lazem 2st5dm el [IEqualityComparer<TKey>] el Generic
            //// we tab3n lazem ykon el Generic beta3 el IEqualityComparer<TKey> ykon men nafs el Type beta3 el TKey el hwa string
            //// l2noh hwa by check 3al el key el hwa el string we el bagbloh hashcode
            //// tb hateb3at el instance lmen 
            //// hab3toh ll overload Constructor el by5od meny el collection 2w el array 2w el list 
            //// el 3aml implement ll interface [IEnumerable<KeyValuePair<Tkey,Tvale>>] we kman el by5od meny el [IEqualityComparer<TKey>]
            //// fa el overlaod Constructor el hwa 
            //// ==> Dictionary<string,int>() el by5od mene el [IEnumerable<KeyValuePair<Tkey,Tvale>> collection , IEqualityComparer<string>? Comparer]]
            //// by5od meny instance by implement el interface [IEqualityComparer] dah el Constructor beta3 el Dictionary<TKey,Tvalue>()
            //// we hy5od meny el Collection 2w el array 2w el list el 3aml implement ll interface [IEnumerable<KeyValuePair<Tkey,Tvale>>]
            //// fa hamsy el Class ==> [StringEqualityComparerGenericdictionary]
            //// ha3ml feh eh ??
            //// 2w bem3na 2s7 azay ha3ml gwah 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            //// bem3na 2s7 25leh [Non Case Sensetivity]
            //// 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            //// 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            //// we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydrb error 2w Exception
            //// fa 3l4an negarb el [StringEqualityComparerGenericdictionary] el 3amlnah dah 
            //// hanro7 nest5dm el Version baeta3t el constructor el beta5od meny object by implement el [IEqualityComparer] 
            //// we le by5o meny el Collection 2w el array 2w el list el 3aml implement ll interface [IEnumerable<KeyValuePair<Tkey,Tvale>>]


            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[]

            //{
            //    new KeyValuePair<string, int>("Mariam" , 123 ),
            //    new KeyValuePair<string, int>("Omar"   , 456 ),
            //    new KeyValuePair<string, int>("Ahmed"  , 222 ),
            //    new KeyValuePair<string, int>("ahmed"  , 111 )
            //};

            ////or

            //KeyValuePair<string, int>[] arr = new KeyValuePair<string, int>[3];

            //arr[0] = new KeyValuePair<string, int>("Alpha", 100);
            //arr[1] = new KeyValuePair<string, int>("Beta", 200);
            //arr[2] = new KeyValuePair<string, int>("Gamma", 300);
            //arr[3] = new KeyValuePair<string, int>("gamma", 350);



            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>(arr , new StringEqualityComparerGenericDictionary());

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook2)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();


            #endregion

            #region Loop using Datatype [Dictionary Entry]

            //// 3ayzen b2a ne3rd el data deh bs deh me4 data 3adya deh data feha Key we Value fa ha3rdh azay 2w ha loop 3aleha azay ?
            //// ana 3andy el Key be datatype ==> String
            //// we 3andy el Value be Datatype ==> int
            //// el Dictionary 8ayer geh we 8yer el type el by5azen feh el KeyValuePairs gwaha 8eroh men [dictionaryEntry] ly [KeyValuePair]
            //// el 2tnen ma3 ba3d 2smohm ==> [KeyValuePair<TKey , TValue>] el ma7tot gwa el Dictioanry dah type 2smoh [KeyValuePair]
            //// fa 3l4an te Loop 3al el data deh we te3rdha lazem test5dm el Datatype el hya ==>[KeyValuePair<TKey , TValue>]
            //// we dah hwa readonly Strcut el C# el 3amloh ll Dictionary we 3andoh gwah el Key we el Value we dah type Generic 
            //// l2n hate7dedloh el type beta3 el Key we el Vlaue we lazm ykona zay el Dictionary 3l4an law mo5telfen hy3ml Compiler Error 
            //// fa ha3ml el Foreach we el element el hy loop 3al el data hyb2a men type ==> [KeyValuePair<TKey , TValue>]

            //// bs law 5adt balk men el o/p el bytal3 men el loop lama by3rd el data by3rd el data zay ma anta med5lha
            //// bem3na anta med5al mariam we ba3den omar we ba3den amira fe el motwek3 ytal3 be nafs el tarteb dah fe el console
            //// we dah el by7sl fe3ln 3al 3aks el HashTable kan ma3 kol run byta3l tarteb mo5telf kol mara 
            //// hwa masbet4 el Entries el by7ot feha el data lakn el 7asl 2noh b2a fe el Dictionry 3amlk Enhancement byrg3lk el Data 
            //// benafs el tarteb el anta meda5loh bs dah me4 ma3nah 2n el data metrateba kdah fe el Memeory
            //// el Data fe el Meemory by7slha Random kol Mara based on el Hashcode beta3ha el hwa beta3 el Key ma bagebloh hashCode
            //// fa anta kol mara by generate lek
            //// [HashCode] mo5talef 3an el mara el 2blha fe kol Run ll Program 
            //// hw abyrabt based on el HashCode bs beta3 el Key wla el Value ?
            //// la2 beta3 el KEy l2n dah hwa el byta5zen fe el Entry 2sln
            //// we el Key dah men type ==> String
            //// we hwa kol mara bygen HashCode ll Key dah el hwa men Type String el kol 4waya ma3 kol run leh hashcode 8er el 2bloh 2sln
            //// fa mara Maraim el hashcode beta3ha yb2a be msln be 001 we omar 003 we amira 002 bs dah me4 hy2sr 3al el tarteb 2sln
            //// el tarteb hy5tlf kol mara f3ln fe el memory men gwa lakn bara hwa 3aml enhanment ytla3lk el Data zay ma anta med5lha
            //// malo4 3elka be tartebha gwa azay fa kdah el tarteb hhyb2a 
            //// mariam omar amira bardo me 4hyt8er
            //// we mara Maraim el hashcode beta3ha yb2a be msln be 003 we omar 001 we amira 002 bs dah me4 hy2sr 3al el tarteb 2sln
            //// el tarteb hy5tlf kol mara f3ln fe el memory men gwa lakn bara hwa 3aml enhanment ytla3lk el Data zay ma anta med5lha
            //// malo4 3elka be tartebha gwa azay fa kdah el tarteb hhyb2a 
            //// mariam omar amira bardo me 4hyt8er
            //// 3al 3aks el HashTable byrag3 kol mara el data random me4 zay ma anata med5alha 
            //// bs el Entry 2sln sabta men el bedaya el byt8er el key we 3al 7asb el value beta3toh we el 3amlya el 7ysabya el betm 3aleh
            //// 3l4an yt5azen fe el Entry fa hwa ma3 kol run el key dah byt5azen fe Entry 8er el tanya 

            Console.WriteLine();
            foreach (KeyValuePair<string,int> kvp in phoneBook)
            {
                Console.WriteLine(kvp);
            }
            Console.WriteLine();

            //// tab law 3ayez 23rd bs el Key me4 3yez 23rd el Value 23ml dah azay ??
            //// haro7 2a access el entry el bet loop fe el foreach we 25tar menha el property el key bs zay kdah ==>
            //// el Property [key] deh hya gwa el Strcut el [KeyValuePair<string,int>] fa ba3rf 23mlha access 3altol

            //Console.WriteLine();
            //foreach (KeyValuePair<string,int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp.Key);
            //}
            //Console.WriteLine();


            //// tab law 3ayez 23rd bs el value me4 3yez 23rd el Key 23ml dah azay ??
            //// haro7 2a access el entry el bet loop fe el foreach we 25tar menha el property el value bs zay kdah ==>
            //// el Property [value] deh hya gwa el Strcut el [KeyValuePair<string,int>] fa ba3rf 23mlha access 3altol

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp.Value);
            //}
            //Console.WriteLine();


            //// tab ana 3ayez 2a loop 3al el Key's bs 2w el Value's bs men el 2wl me4 3ayez 2st5dhom ka Property zay 
            //// ma 3amlt el datatype [KeyValuePair<string,int>] we men gwaha 3aml access ll Property el Key we eL Value
            //// bs ana me4 3ayez 23ml dah 
            //// ana 3ayez men el 2wl 27dd 2nohm Keys we 2a loop 3alehom 2w 27aded 2nohm Values we 2a loop 3alehom
            //// fa 3andy Property gwa el Dictionary 2smha _keys deh 4ayela gwaha el keys bs 
            //// we 3andy Property gwa el Dictionary 2smha _values deh 4ayela gwaha el values bs 
            //// we tab3n law ha loop 3al el keys fa lazem el iterator ykon men nfas el data type bet3a el key el hwa string
            //// we tab3n law ha loop 3al el values fa lazem el iterator ykon men nfas el data type bet3a el values el hwa int

            //Console.WriteLine();
            //foreach (string name in phoneBook.Keys)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.WriteLine();

            //Console.WriteLine();
            //foreach (int phone in phoneBook.Values)
            //{
            //    Console.WriteLine(phone);
            //}
            //Console.WriteLine();

            #endregion

            #region Loop using [Object] Parent of Datatype's 

            //// tab 3ayzen ne loop 3al el data bs be 7aga badl ma nest5dm el datatype el hya [KeyValuePair<TKey , TValue>]
            //// ana 2sln ba loop 3al Entry we el Entry deh 3ady 2a loop 3aleha be 2st5dm el Object 
            //// l2n el Object hwa el Paraent ly kol el Datatype we hwa 3erf 2en el phoneBook dah dictionary fa hy5aly el object 
            //// ka2noh 3amloh casting hyb2a be [KeyValuePair<TKey , TValue>]

            //Console.WriteLine();
            //foreach (object entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            #endregion

            #region Loop using Var Datatype 

            //// tab 3ayzen ne loop 3al el data bs be 7aga badl ma nest5dm el datatype el hya [KeyValuePair<TKey , TValue>]
            //// ana 2sln ba loop 3al Entry we el Entry deh 3ady 2a loop 3aleha be 2st5dm el Var we hwa 3erf 2en el phoneBook
            //// dah dictionary fa hy5aly el var 
            //// ka2noh 3amloh casting 2w 7aweloh hyb2a be [KeyValuePair<TKey , TValue>]
            //// lysa han5od el Var 2doma 

            //Console.WriteLine();
            //foreach (var entry in phoneBook)
            //{
            //    Console.WriteLine(entry);
            //}
            //Console.WriteLine();

            #endregion

            #region Indexer

            //// 3andy Indexer 3and el Dictionary by3ml eh el Indexer dah b2a 
            //// by3ml kol 7aga hy5leh te get el value we te set el value we te update el value 
            //// fa hwa by3ml kol 7aga 

            //// 1] bast5dm el Indexer 3l4an 2a Get el hwa 23rd el Data
            //// fa lama hat3ml kda ==> phoneBook[] hwa metsany gwah el [string key] me4 [object key] 
            //// l2n hena generic we 3arf men el 2wl 2en el key be string me4 object
            //// el mafrod hwa by return int me4 object l2n me7adedloh men el 2wl el value 2enha be int l2noh generic 
            //// fa lazem 2st2bloh fe 7aga 2w 2tba3oh 3altol
            //// we tab3n me4 ha7tag 23ml casting 3l4an a22loh 7awly el object dah ly int el hya el vlaue el ana mestanyha
            //// l2n el rag3 hwa int 3altol me4 object 2sln
            //// fa hyb2a kdah ==> int num = phoneBook["Mariam"];

            //int num = phoneBook["Mariam"];
            //Console.WriteLine($"Number of Marima is : {num}");
            //Console.WriteLine();

            ////or

            //Console.WriteLine($"Number is : {phoneBook["Mariam"]}");

            //// 2] bast5dm el Indexer 3l4an 2a update el hwa 23dl 2w 28er fel value
            //// fa lama hat3ml kda ==> phoneBook[] hwa metsany gwah el [string key] me4 [object key] 
            //// l2n hena generic we 3arf men el 2wl 2en el key be string me4 object
            //// hateb3tloh el Key el 3ayez te8er fe el vlaue we ba3den te assign el Value el gdeda 
            //// we ba3den hane3rd el data
            //// hwa hena yo3tabr 3aml update l2noh lama ra7 dawr 3al el Key fe el Dictionary la2a el Key fe3ln mawgod we leh value
            //// fa 3l4an kdah ra7 3aml Update
            //// lakn law 2detoh Key me4 Mawgod 2sln fe el Dictionary fa sa3tha hwa kdah el Indexer 4a8al be y set 2w hy3ml Insert
            //// ll key we el value el gdeda 

            //phoneBook["Mariam"] = 777;
            //Console.WriteLine($"Number of Mariam is : {phoneBook["Mariam"]}");

            //Console.WriteLine();
            //foreach (KeyValuePair<string,int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            //// 3] bast5dm el Indexer 3l4an 2a Set el hwa 2def Key we Value fe el Dictionary
            //// fa lama hat3ml kda ==> phoneBook[] hwa metsany gwah el [string key] me4 [object key] 
            //// l2n hena generic we 3arf men el 2wl 2en el key be string me4 object
            //// hateb3tloh el Key we el Value 
            //// we ba3den hane3rd el data
            //// hwa hena yo3tabr ma3aml4 update l2noh lama ra7 dawr 3al el Key fe el Dictionary mala2a4 el Key 
            //// fa 3l4an kdah ra7 3aml Set
            //// lakn law 2detoh Key Mawgod 2sln fe el Dictionary fa sa3tha hwa kdah el Indexer 4a8al be y update 
            //// fa hymsk el Key y7ot feh el value el 2dema 

            //phoneBook["Ahmed"] = 222;
            //Console.WriteLine($"Number of Ahmed is : {phoneBook["Ahmed"]}");

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            //// law get 2olteloh hatl2y el Value ly Key bs el Key dah me4 mawgod 3andy 2sln sa3tha hwa hy3ml ??
            //// hydrb Exception 2w error l2n el Key dh me4 mawgod 2sln
            //// l2n lama ha2loh ==> Console.WriteLine($"Number of amr is : {phoneBook["amr"]}");
            //// we el Key [amr] dah me4 mawgod 2sln we kdah kdah el phoneBook by return lek int me4 nuallable int
            //// fa lama ydawr 3al el key el 2smoh amr fe el Dictionary me4 hyl2eh fe me4 hyl2a 7aga yrg3aha l2noh int 
            //// fa hydrb exception 2w error 
            //// dah 7asl l2n el Dictionary hwa Generic we Based on [Tkey , TValue] me4 based on [object] zay el HashTable
            //// el Klam dah fe el [HashTable] me4 hydrb error 2w exception hytala3lk null we result kdah fe el console l2n hwa 
            //// 4a8al based on [object] we el object dah by allow el null 3ady fa hyb3tl null el hwa fe el console empty string
            //// l2nk bet7awl te access Key me4 mawgod 2sln
            //// we han7el el mo4kela deh ta7t de 2st5dam el method el [TryGetValue()]

            //Console.WriteLine($"Number of Amr is : {phoneBook["Amr"]}");

            #endregion

            #region TryAdd() , TryGetValue()

            /********************************************* TryGetValue() ********************************************************/

            //// 3andy Method 2smha [TryGetValue()] deh me4 mawgoda 2yam el HashTable lakn mawgoda hena fe el Dictionary
            //// deh beta5od meny el Key we betrga3ly el Value el mokabl ll Key dah bast2bloh fe output parameter
            //// bs el method zat nafsha betrag3 [Boolean] el hwa law el key mawgod harg3 [True] we hab3tlk el vlaue fe el o/p parameter
            //// lakn law el key me4 mawgod harg3 [False] we kdah mafe4 Key fe el Dictionary bel 2sm dah we tabe3y me4 hyb2a fe 7aga fe 
            //// el o/p parameter l2n mal2a4 2sln key hygeb value menen fa sa3tha hy7otelk el defualt value ll type beta3 
            //// el value el hwa TValue el hwa be int fa hyrg3l 0 
            //// fa deh Method 7elw 3l4an law me4 mot2ked el Key dah mawgod wla l2a 
            //// we dah yo3tabr 7al ly mo4kelt el indexer el 25era lma 2oltelh hatly el value bta3t el key amr we hwa 2sln me4 mawgod

            //bool flag = phoneBook.TryGetValue("Mariam", out int value);
            //Console.WriteLine($"Flag = {flag} , Value = {value}");

            //flag = phoneBook.TryGetValue("amr", out int value2);
            //Console.WriteLine($"Flag = {flag} , Value = {value2}");

            /********************************************************************************************************************/

            /************************************************** TryAdd() ********************************************************/

            //// 3andy Method 2smha [TryAdd()] deh me4 mawgoda 2yam el HashTable lakn mawgoda hena fe el Dictionary
            //// we hwa 3amlha l2n el method [Add()] deh un safe l2enha momken ta5od menk el key tany 3ady we te3ml duplicate key
            //// we dah hy3ml ma4kel 3andena zay 7war Amira we amira bs 7alenha bel IEqualityComparer bs law me4 3ayez el 7al dah 
            //// fa fe el method deh el hya [TryAdd()]
            //// deh beta5od meny el Key we el Value 
            //// bs el method zat nafsha betrag3 [Boolean] el hwa law el key me4 mawgod harg3 [True] we sa3tha hadeflk el key we le Value
            //// dol fe el Dictionary
            //// lakn law el key mawgod harg3 [False] we kdah dah ma3nah 2n 2sln el key mawgod 2bl kdah we me4 hynfa3 2defoh tany 
            //// fa deh Method 7elw 3l4an law me4 mot2ked el Key dah mawgod wla l2a 


            //bool flag = phoneBook.TryAdd("Mariam",123);
            //Console.WriteLine($"Flag = {flag}");
            //Console.WriteLine() ;
            //flag = phoneBook.TryAdd("amr", 888);
            //Console.WriteLine($"Flag = {flag}");

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            /********************************************************************************************************************/

            #endregion

            #region Contains() , ContainsKey() , ContainsValue()

            /*********************************************** Contains() *********************************************************/

            // el Method el [Contains()] deh me4 mawgoda fe el Dictionary lakn mawgoda fe el HashTable
            // bs hya fe el 3mom fe el HastTable hya bet5od menk [object key] we bet4oflk el Key dah mawgod fe el HashTable
            // wla l2a we hya bet return  [Boolean] law mawgod hatrg3lk [True] law me4 mawgod hatrg3lk [false]

            /********************************************************************************************************************/



            /********************************************** ContainsKey() *******************************************************/

            //// el Method el [ContainsKey()] deh  mawgoda fe el Dictionary 
            //// bs hya fe el 3mom fe el Dictionary hya bet5od menk [TKey key] we bet4oflk el Key dah mawgod fe el Dictionary
            //// wla l2a we hya bet return  [Boolean] law mawgod hatrg3lk [True] law me4 mawgod hatrg3lk [false]

            //bool flag = phoneBook.ContainsKey("Mariam");
            //Console.WriteLine($"Flag = {flag}");

            //flag = phoneBook.ContainsKey("Amr");
            //Console.WriteLine($"Flag = {flag}");

            //// fa momken 2st8l dah be 2eny 2a check law el key dah me4 mawgod 23mloh insert b2 3andk fe el Dictionary 
            //// lakn law mowgod ma te3mlo4 insert

            //if (!phoneBook.ContainsKey("Amr"))
            //{
            //    phoneBook.Add("Amr" , 111);
            //    Console.WriteLine($"Flag = {phoneBook.ContainsKey("Amr")}");
            //}

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            /********************************************************************************************************************/




            /********************************************* ContainsValue() ******************************************************/

            //// el Method el [ContainsValue()] deh mawgoda fe el Dictionary
            //// bs hya fe el 3mom fe el Dictionary hya bet5od menk [TValue value] we bet4oflk el Value dah mawgod fe el Dictionary
            //// wla l2a we hya bet return  [Boolean] law mawgod hatrg3lk [True] law me4 mawgod hatrg3lk [false]

            //bool flag = phoneBook.ContainsValue(123);
            //Console.WriteLine($"Flag = {flag}");

            //flag = phoneBook.ContainsValue(222);
            //Console.WriteLine($"Flag = {flag}");


            //// fa momken 2st8l dah be 2eny 2a check law el value dah me4 mawgod 23mloh insert b2 3andk fe el Dictionary 
            //// lakn law mowgod ma te3mlo4 insert

            //if (!phoneBook.ContainsValue(777))
            //{
            //    phoneBook["Amr"] = 777;
            //    Console.WriteLine($"Flag = {phoneBook.ContainsValue(777)}");
            //}

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();


            /********************************************************************************************************************/
            #endregion

            #region Constructors

            //// 27na 5adna fo2 no3en men el Constructor 
            //// 1] Parameterless Constructor
            ////    3amlnah fo2
            //// 2] Dictionary<Tkey,TValue>(IEqualityComparer<Tkey>? Comparer) el by5od meny el [IEqualityComparer<Tkey>? Comparer]
            ////    we yab3n el TKey deh el hya el datatype beta3t el Key el 3arftha men badry fe el Dictionary l2noh Generic
            ////    el hya 2sln hatkon be String
            ////    3amlnah fo2
            //// 3] Dictionary<Tkey,TValue>(IEnumerable<KeyValuePair<Tkey,Tvale>> collection) el by5od meny el Collection 
            ////    2w el array 2w el list el 3aml implement ll interface [IEnumerable<KeyValuePair<Tkey,Tvale>>]
            ////    3amlnah fo2
            //// 4] Dictionary<string,int>()[IEnumerable<KeyValuePair<Tkey,Tvale>> collection , IEqualityComparer<string>? Comparer]]
            ////    by5od meny instance by implement el interface [IEqualityComparer] dah el Constructor beta3 el Dictionary<TKey,Tvalue>()
            ////    we hy5od meny el Collection 2w el array 2w el list el 3aml implement ll interface [IEnumerable<KeyValuePair<Tkey,Tvale>>]
            ////    3amlnah fo2
            //// 5] 3andena Constructor 5ams by5od meny Collection by implement el interface [IDictionary<TKey , TValue>] bs el Generic
            ////    ==> Dictionary<string, int>(IDictionary<string,int> dictionary)
            ////    tb dah zay men ?? zay el Dictionary nafsoh l2n el Dictionary by implement el interface [IDictionary<TKey,TValue>]
            ////    fa ha3ml kdah dictionary we ha3rf el data feh bets5dam el [Object Initializer]
            ////    we ba3den ha3ml dictionary tany hy5od meny el dictionary el temp dah we ha loop 3al el phoneBook el 5ad el data
            ////    men el temp fa hal2y el data ba2t feh 


            //Dictionary<string, int> temp = new Dictionary<string, int>()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 },
            //    {"ahmed"  , 222 }
            //};

            //Dictionary<string, int> phoneBook1 = new Dictionary<string, int>(temp);

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook1)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();


            #endregion

            #region Remove

            //// 1] dah 2wl overload ly Method 2smha [Remove(Tkey key)] fa ana hab3tlk el Key we anta hatms7ly el Key 
            ////    we el Value el mokabl leha kman


            //Dictionary<string, int> phoneBook = new Dictionary<string, int>()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            //phoneBook.Remove("Mariam");

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            //// 2] tany overload ly method [Remove(Tkey key , out int value)] by5od menk el Key we byrg3lk el value el mokabl 
            ////    leh fe o/p parameter 3l4an law 3ayez test5dmoh fe 7aga tany
            ////    we tab3n betrag3 bool el hwa law kan mawgod yb2a hams7oh we harg3lk [True]
            ////    we law kan me4 mawgod yb2a me4 hams7 7aga we harg3lk [False]

            //Dictionary<string, int> phoneBook2 = new Dictionary<string, int>()
            //{
            //    {"Mariam" , 123 },
            //    {"Omar"   , 456 },
            //    {"Amira"  , 789 }
            //};

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook2)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            //bool flag = phoneBook.Remove("Mariam" , out int value);
            //Console.WriteLine($"Flag = {flag} , Value = {value}");

            //Console.WriteLine();
            //foreach (KeyValuePair<string, int> kvp in phoneBook2)
            //{
            //    Console.WriteLine(kvp);
            //}
            //Console.WriteLine();

            #endregion

            #region User Defined Datatype[Class Employee]

            // ha3ml yser defined datatype ana el ha3mloh
            // 3andoh property int id , string? name , decimal salary

            //Empolyee empolyee01 = new Empolyee(10, "Mariam",1000);
            //Empolyee empolyee02 = new Empolyee(100, "Omar" , 2000);
            //Empolyee empolyee03 = new Empolyee(2, "Zaki" , 5000);
            //Empolyee empolyee04 = new Empolyee(50, "Amir" , 1500);
            //Empolyee empolyee05 = new Empolyee(50, "Osama" , 1500);
            //Dictionary<Empolyee, int> employees = new(new IdEqualityComparer());
            //employees.Add(empolyee01,1);
            //employees.Add(empolyee02,2);
            //employees.Add(empolyee03,3);
            //employees.Add(empolyee04,4);
            //employees.Add(empolyee05,5);
            //{
            //    [empolyee01] = 1 ,
            //    [empolyee02] = 2 ,
            //    [empolyee03] = 3 ,
            //    [empolyee04] = 4 ,
            //    [empolyee05] = 5,
            //};
            //foreach(KeyValuePair<Empolyee , int> kvp in employees)
            //{
            //    Console.WriteLine(kvp);
            //}


            #endregion

            #endregion


            #region SortedDictionary
            //Based on Binary Search Tree
            //Sorted based on key acsending by default
            //Operations take O(log n)
            //SortedDictionary<string, int> phoneBook = new(new StringComparer())
            //{
            //    {"Mariam" ,111 },
            //    {"Ziad" ,222 },
            //    {"Omar" ,333},
            //    {"Ahmed" , 444 }
            //};
            //foreach (var phone in phoneBook) {
            //    Console.WriteLine(phone);
            //}

            //Ctors,Reverse

            //Example - 2 Employee
            //Empolyee empolyee01 = new Empolyee(200, "Amira", 2000);
            //SortedDictionary<Empolyee, int> employees = new(new SalaryComparer())
            //{
            //    {empolyee01,2 },
            //    {new Empolyee(1,"Mariam",1000),1 },
            //    {new Empolyee(20,"Omar",3000),3 }
            //};
            //foreach (var employee in employees) {
            //    Console.WriteLine(employee);
            //}
            //Remove
            //Console.WriteLine($"After Remove ");
            //employees.Remove(empolyee01,out int Rank);
            //Console.WriteLine($"Rank ==> {Rank}");
            //foreach (var employee in employees) {
            //    Console.WriteLine(employee);
            //}
            #endregion


            #region SortedList
            //Use 2 internal Arrays to store keys and values
            //Insert and Remove O(n)
            //LookUp is O(log n) ==> Binary search algo
            //Default capacity 4

            //Empolyee empolyee01 = new Empolyee(200, "Amira", 2000);
            //SortedList<Empolyee, int> employees = new(new SalaryComparer())
            //{
            //    {empolyee01,2 },
            //    {new Empolyee(1,"Mariam",1000),1 },
            //    {new Empolyee(20,"Omar",3000),3 }
            //};
            //foreach (var entry in employees)
            //{
            //    Console.WriteLine(entry);
            //}

            //SortedList<string, int> phoneBook = new SortedList<string, int>(new StringComparer());
            //phoneBook.Add("Mariam", 123);
            //phoneBook.Add("Omar", 456);
            //phoneBook.Add("Salma", 789);
            //phoneBook.Add("Ahmed", 1000);
            //phoneBook.Add("Zaki", 2000);

            //foreach (var phone in phoneBook)
            //{
            //    Console.WriteLine(phone);
            //}
            //Console.WriteLine($"==>{phoneBook["Mariam"]}");

            //Index [GetValueAtIndex , GetKeyAtIndex , SetValueAtIndex]
            //int value = phoneBook.GetValueAtIndex(0);
            //Console.WriteLine(value);

            //string key = phoneBook.GetKeyAtIndex(0);
            //Console.WriteLine($"==>{key}");


            //phoneBook.SetValueAtIndex(0, 10000);
            //Console.WriteLine();

            //foreach (var phone in phoneBook)
            //{
            //    Console.WriteLine(phone);
            //}

            //Ctors
            //Dictionary<string , int> tempDic = new Dictionary<string , int>()
            //{
            //    ["Mariam"] = 123,
            //    ["Samar"] = 456,
            //    ["Ahmed"] = 789,
            //    ["Zaki"] = 1000
            //};
            //phoneBook = new SortedList<string, int>(tempDic);
            //foreach (var phone in phoneBook)
            //{
            //    Console.WriteLine(phone);
            //}
            #endregion


            #region HashSet
            //HashSet<string> names = new HashSet<string>(new stringEqualityComparerGeneric());
            //Console.WriteLine($"Count ==> {names.Count} , Capacity ==> {names.Capacity}");
            //names.Add("Zaki");
            //Console.WriteLine($"Count ==> {names.Count} , Capacity ==> {names.Capacity}");
            //names.Add("Ahmed");
            //names.Add("Mariam");
            //names.Add("Yousef");
            //names.Add("Yousef");
            //Console.WriteLine($"Count ==> {names.Count} , Capacity ==> {names.Capacity}");
            //foreach (string name in names) {
            //    Console.WriteLine(name);
            //}
            //Add , ctor [EqualityComparer]

            //Example - 2 Employee
            //HashSet<Empolyee> empolyees = new HashSet<Empolyee>();
            //Empolyee employee01 = new Empolyee(10,"Mariam" , 1000);
            //Empolyee employee02 = new Empolyee(1,"Omar" , 3000);
            //Empolyee employee03 = new Empolyee(5,"Amira" , 2000);
            //empolyees.Add(employee01);
            //empolyees.Add(employee02);
            //empolyees.Add(employee03);
            //foreach (Empolyee empolyee in empolyees)
            //{
            //    Console.WriteLine(empolyee);
            //}

            ////Example - 3 Car
            //HashSet<Car> cars = new HashSet<Car>()
            //{
            //    new Car(10,"BMW",200),
            //    new Car(20,"Audi",250),
            //    new Car(30,"Toyota",150),
            //    new Car(10,"BMW",120),
            //    new Car(20,"Audi",80),
            //    new Car(30,"Toyota",60),
            //};
            //foreach (var car in cars) {
            //    Console.WriteLine(car);
            //}

            //ISet<T>
            //HashSet<int> numbers01 = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            //HashSet<int> numbers02 = [1,2,3,4,5];
            //numbers01.Add(100);
            //numbers01.UnionWith(numbers02);
            //numbers01.IntersectWith(numbers02);
            //numbers01.ExceptWith(numbers02);
            //numbers01.SymmetricExceptWith(numbers02);
            //bool result = numbers01.IsSubsetOf(numbers02);
            //bool result = numbers01.IsProperSubsetOf(numbers02);
            //bool result = numbers01.IsSupersetOf(numbers02);
            //bool result = numbers01.IsProperSupersetOf(numbers02);
            //bool result = numbers01.Overlaps(numbers02);
            //bool result = numbers01.SetEquals(numbers02);
            //Console.WriteLine(result);
            //Console.WriteLine();
            //Console.WriteLine($"Numbers01");
            //foreach (int i in numbers01) {
            //    Console.WriteLine($"{i}");
            //}
            //Console.WriteLine($"\n\nNumbers02");
            //foreach (int i in numbers02) {
            //    Console.WriteLine($"{i} ");
            //}

            //Add

            //UnionWith

            //IntersectWith

            //ExceptWith
            #endregion


            #region SortedSet
            //SortedSet<int> numbers = new SortedSet<int>(new IntComparer());
            //numbers.Add(1);
            //numbers.Add(10);
            //numbers.Add(9);
            //numbers.Add(2);
            //numbers.Add(30);
            //numbers.Add(5);
            //foreach (int i in numbers) {
            //    Console.WriteLine($"{i} ");
            //}
            //Reverse
            //List<int> reverseNums = numbers.Reverse().ToList();
            //foreach (int i in numbers) {
            //    Console.WriteLine($"{i} ");
            //}
            //Ctors

            //Max , Min Properties
            //int maxElement = numbers.Max;
            //int minElement = numbers.Min;
            //Console.WriteLine($"Max ==> {maxElement}");
            //Console.WriteLine($"Min ==> {minElement}");


            //GetViewBetween
            //Console.WriteLine();
            //SortedSet<int> rangeNums = numbers.GetViewBetween(0, 10);
            //foreach (int i in rangeNums) {
            //    Console.WriteLine($"{i} ");
            //}

            //Example2 - Car
            //SortedSet<Car> cars = new() 
            //{
            //new Car(1,"Audi",200),
            //new Car(20,"BMW",100),
            //new Car(30,"Toyota",250),
            //new Car(1,"Audi",400),
            //new Car(1,"Audi",500),
            //};
            //foreach (Car car in cars)
            //{
            //    Console.WriteLine(car.ToString());
            //}

            //Max , Min Properties
            //Car? carMax = cars.Max;
            //Console.WriteLine($"max car ==> {carMax}");

            //GetViewBetween
            //SortedSet<Car> rangeCars =cars.GetViewBetween(new Car(20,"BMW",100) , new Car(30, "Toyota", 250));
            //foreach (Car car in rangeCars) {
            //    Console.WriteLine($"{car} ");
            //}
            #endregion
        }
    }
}
