using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_3_ADV_C__Demo.Dictionary
{
    //// fa 3l4an ne7l el mo4kela deh we n5aleh y4of 2n [Amira] deh hya hya [amira] deh bem3na 2s7 25leh [Non Case Sensetivity]
    //// ya3ny el Capital zay el Small
    //// fa lazem ana 2bny be 2edy el behvior beta3 el [GetHashCode() & Equals()] be7yes 25leha 
    //// law 7ad 7awl yda5l el Key marten be nafs el 2sm bs 2sm Capital we 2sm Small 2w Char Capital we Char Small uorfod dah 
    //// we ydrb error 2w Exception y2olh feh ==>[Item has already been added]
    //// ya3ny el Key dah 2sln kan medaf 5las mynfa34 tedefoh tany l2noh 2tdaf
    //// we tab3n hwa hy3rf dah men 5elal el [GetHashCode() & Equals()] el habnehom be 2edy
    //// fa haro7 23ml Folder 2smoh ==> Dictionary
    //// we ha3ml feh [ Class ] by Implement el Interface [IEqualityComparer] we hab3tlk menoh Object 
    //// bs lazem el interface [IEqualityComparer] ykon el Verison el Generic l2n el Dictionary hwa Generic
    //// ma y3rf4 7aga 3an el Non-Generic Version fa lazem 2st5dm el [IEqualityComparer<TKey>] el Generic
    //// we tab3n lazem ykon el Generic beta3 el IEqualityComparer<TKey> ykon men nafs el Type beta3 el TKey el hwa string
    //// l2noh hwa by check 3al el key el hwa el string we el bagbloh hashcode
    //// tb hateb3at el object lmen hab3toh ll [Constructor el Dictionary<string,int>() el by5od mene el [IEqualityComparer<string>? Comparer]]
    //// by5od meny object by implement el interface [IEqualityComparer] dah el Constructor beta3 el Hashtabel()
    //// fa hamsy el Class ==> [StringEqualityComparerGenericdictionary]
    //// ha3ml feh eh ??
    //// 2w bem3na 2s7 azay ha3ml gwah 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
    //// bem3na 2s7 25leh [Non Case Sensetivity]
    //// 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
    //// 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
    //// we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydrb error 2w Exception
    //// fa 3l4an negarb el [StringEqualityComparerGenericdictionary] el 3amlnah dah 
    //// hanro7 nest5dm el Version baeta3t el constructor el beta5od meny object by implement el [IEqualityComparer]
    internal class StringEqualityComparerGenericDictionary : IEqualityComparer<string>
    {
        // tab3n hwa by5od meny String we string l2noh hwa Generic we by5o meny nafs el type beat3 el Key el hwa String 
        // law 5adt balk hwa me4 byst5dm el [KeyWord el 2smha ==> {new} ] 
        // dah 3l4an deh nos5a Generic men el interface hwa hybny el Equals benafsoh
        // lakn law mest5dm nos5a Non-Generic  hatl2ay dah 7asl fe el [KeyWord el 2smha ==> {new} ] dah kdah ka2noh by5fy el implementation el mawgod 
        public bool Equals(string? x, string? y)
        {
            // me4 me7tag 2amsk el [x] el gaya deh we me4 me7tag 2a3rfha 3al 2enha string 
            // kdah ==> string X = x as string;
            // l2n ana bat3aml ma3 nos5a Generic men el Inteface el hwa [IEqualityComparer<string>] me4 mo3tamed 3al el Object
            // hwa 3arf el gayeloh 2enoh 3altol string fa me4 me7tag b2a 23ml Casting wal 8eroh l2n dah me4 object 
            // hwa 3aref 2en el gay hwa string


            // 3ayzen b2a ne3ml 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            // bem3na 2s7 25leh [Non Case Sensetivity]
            // 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            // 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            // we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydrb error 2w Exception

            // bs hwa za3lan men lama 3amlt kdah ==> return x.ToLower().Equals(y.ToLower());
            // l2n by2olk el [x] deh momken teb2a be null l2n el type hwa nullable string [string?]
            // we anta me4 m handle 2w me4 m3arfny law gat be null 23ml eh
            // ma law gat be null ana me4 ha2dr wla 23ml 2w 2wsel ll [ToLower()] wla ll [Equals]
            // we kazalk el [y] deh momken teb2a be null l2n el type hwa nullable string [string?]
            // we anta me4 m handle 2w me4 m3arfny law gat be null 23ml eh
            // ma law gat be null ana me4 ha2dr wla 23ml 2w 2wsel ll [ToLower()] wla ll [Equals]
            // fa haro7 23ml 3alamt el nullable 3al el x kdah ==> [x?.ToLower().Equals(y.ToLower());]
            // law hya magt4 be null 5las el donya tmam lakn law gat be null 23ml eh we el mafrod el method el [Equals()] deh
            // betrg3 [bool] fa a2llk hanst5dm null-coalescing operator we sa3tha law gat be null yb2a harg3 flase
            // l2n madam el x gat be null fa ma3na kdah 3omr el x ma hatswy el y fa tabe3y hatrg3 False me4 True
            // fa hateb2a kdah ==> [x?.ToLower().Equals(y.ToLower()) ?? false;]
            // tab belnesba ll y ha5leha teb2a nullable fa hateb2a kdah ==> [x?.ToLower().Equals(y?.ToLower()) ?? false;]
            // law magt4 be null ro7 23ml ll geh ToLower() lakn law gat be null el Equals() hathandl dah men gwaha 
            // l2n el Equals 3andha [Overload beta5od meny nullable string 3ady fa hya hathandl men gwaha law geh el Y be null]

            return x?.ToLower().Equals(y?.ToLower()) ?? false;

            //// lama nebd2a ne7awl el string beta3n kolo ly lowercase 2w uppercase sa3tha 2odam hansmeh [Normalization]
            //// fe el DataBase haneb2a 3amlen Save ll Email bta3na 3al 2enoh feh Column 2smoh [Normalized Email] dah byb2a kol el Email
            //// bett3ay y Capital y kolo Small 3l4an lama 2karn ana me4 bakran bel Email el 3ady ana bakrn bel [Normalized Email]
            //// 3l4an lazem 2karn 7arf 7arf we rakm rakm we lazem
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            // me4 me7tag 2amsk el[obj] el gaya deh we me4 me7tag 2a3rfha 3al 2enha string 
            // kdah ==> string str = obj as string;
            // l2n ana bat3aml ma3 nos5a Generic men el Inteface el hwa [IEqualityComparer<string>] me4 mo3tamed 3al el Object
            // hwa 3arf el gayeloh 2enoh 3altol string fa me4 me7tag b2a 23ml Casting wal 8eroh l2n dah me4 object 
            // hwa 3aref 2en el gay hwa string
            // we kman 3aml el Attribute el hwa [DisallowNull] ==> 3l4an y2olk 2en most7el el key yb2a be null we ana 
            // me4 hasm7 bel null me4 hasm7lk teb3tly null 2sln


            // tab3n hena el mafrod 2geb el hashCode ll String el gayel bs law 3amlt kdah bs ==> return obj.GetHashCode();
            // 2waln mafe3 el warning 2n momken el obj tegy be null l2nha me4 nullable string hwa string bs
            // we kman 3aml el Attribute el hwa [DisallowNull] fa most7el ygey be null fa me4 ha3ml kdah ==> return obj?.GetHashCode();
            // we haseboh kdah ==> return obj.GetHashCode();
            // bs kdah fe Mo4kela lysa 2en law ba3t [Amira] we [amira] hydy ly kol wa7da hashcode mo5talef la2noh el obj deh string
            // fa hykalm el [GetHashCode()] bta3 el string we kdah ka2ny ma3mlt4 7aga we zayha zay el 2dema
            // fa el sa7 2st5dm 2w ne3ml 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            // bem3na 2s7 25leh [Non Case Sensetivity]
            // 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            // 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            // we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydehom nafs el HashCode
            // we lama hytla3 3al el Equals fo2 we ykarn hyta3 true fe hydrb error 2w excpetion

            return obj.ToLower().GetHashCode() ;
        }
    }
}
