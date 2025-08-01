// 3l4an 23rf 23ml implement ll interfac el Non-Generic [[IEqualityComparer]] lazem 23ml using ll namespace beta3t el Non-Generic deh
using System.Collections;

namespace Session_3_ADV_C__Demo.HashTable
{
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
    internal class StringEqualityComparerNonGenericHashTable : IEqualityComparer
    {
        // tab3n hwa by5od meny Object we Object l2noh hwa Non Generic 
        // law 5adt balk hwa byst5dm el [KeyWord el 2smha ==> {new} ] dah kdah ka2noh by5fy el implementation el mawgod 
        // dah 3l4an deh nos5a non Generic men el interface 
        // lakn law mest5dm nos5a Generic me4 hatl2ay dah 7asl mafe4 el [KeyWord el 2smha ==> {new} ]

        public new bool Equals(object? x, object? y)
        {
            // hamsk el [x] el gaya deh ha3rfha 3al 2enha string 
            // kdah ==> string X = x as string;
            // bs hwa za3lan fe el goz2 dah ==> x as string;
            // l2n el [x] deh hya fo2 2sln nullable object ya3nya 3ady y4el null we ana lama 3amlt [x as string]
            // anta kdah 2olteloh ana badmnlk 2n el object el gaya dah hwa hykon string 
            // fa kdah el string dah b2a nullable bardo l2n el object hwa nullable kman fa lazem yb2 zay ba3d
            // we ba3d kdah get 7atet kol dah fe [string X] bs el string dah me4 nullable 
            // fa kdah anta bet7awl te7ot nullable string el hwa [x as string] fe string me4 by allow el null me4 nullable el hwa [string X]
            // fa 3l4an ne4el el za3l dah 2w el error 2w el warning lazem ne5aly el [string X] tekon nullable ya3ny bet allow el null
            // fa hateb2 akdah ==> string? X = x as string;

            // ana meskt el string beta3y 3l4an 2t3aml beh gwa el function bera7ty badl ma kol 4wya fe kol 5atwa
            // ha3ml casting 3l4an 23rfoh 2enoh byt3aml ma3 string fa hary7 dema8y we 23mlha mara wa7da we 2st5dm b2a el ana 3amltoh
            // dah gwa el method bera7ty we me4 me7tag 23ml casting kol 4wya
            // fa ana meskt el string el hygel fe el x we ha2loh 4ofoh 3al 2enoh string we 5azenoh fe string 2smoh X
            // we 2t3aml bel X be ra7tk b2a gwa el method

            string? X = x as string;

            // we han3ml nafs el 2r belzabt 3al el y

            // ana meskt el string beta3y 3l4an 2t3aml beh gwa el function bera7ty badl ma kol 4wya fe kol 5atwa
            // ha3ml casting 3l4an 23rfoh 2enoh byt3aml ma3 string fa hary7 dema8y we 23mlha mara wa7da we 2st5dm b2a el ana 3amltoh
            // dah gwa el method bera7ty we me4 me7tag 23ml casting kol 4wya
            // fa ana meskt el string el hygel fe el y we ha2loh 4ofoh 3al 2enoh string we 5azenoh fe string 2smoh Y
            // we 2t3aml bel Y be ra7tk b2a gwa el method

            string? Y = y as string;

            // 3ayzen b2a ne3ml 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            // bem3na 2s7 25leh [Non Case Sensetivity]
            // 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            // 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            // we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydrb error 2w Exception

            // bs hwa za3lan men lama 3amlt kdah ==> return X.ToLower().Equals(Y.ToLower());
            // l2n by2olk el [X] deh momken teb2a be null we anta me4 m handle 2w me4 m3arfny law gat be null 23ml eh
            // ma law gat be null ana me4 ha2dr wla 23ml 2w 2wsel ll [ToLower()] wla ll [Equals]
            // we kazalk el  [Y] deh momken teb2a be null we anta me4 m handle 2w me4 m3arfny law gat be null 23ml eh
            // ma law gat be null ana me4 ha2dr wla 23ml 2w 2wsel ll [ToLower()] wla ll [Equals]
            // fa haro7 23ml 3alamt el nullable 3al el X kdah ==> [X?.ToLower().Equals(Y.ToLower());]
            // law hya magt4 be null 5las el donya tmam lakn law gat be null 23ml eh we el mafrod el method el [Equals()] deh
            // betrg3 [bool] fa a2llk hanst5dm null-coalescing operator we sa3tha law gat be null yb2a harg3 flase
            // l2n madam el X gat be null fa ma3na kdah 3omr el X ma hatswy el Y fa tabe3y hatrg3 False 
            // fa hateb2a kdah ==> [X?.ToLower().Equals(Y.ToLower()) ?? false;]
            // tab belnesba ll Y ha5leha teb2a nyllable fa hateb2a kdah ==> [X?.ToLower().Equals(Y?.ToLower()) ?? false;]
            // law magt4 be null ro7 23ml ll geh ToLower() lakn law gat be null el Equals() hathandl dah men gwaha 
            // l2n el Equals 3andha [Overload beta5od meny nullable string 3ady fa hya hathandl men gwaha law geh el Y be null]


            return X?.ToLower().Equals(Y?.ToLower()) ?? false;


            //// lama nebd2a ne7awl el string beta3n kolo ly lowercase 2w uppercase sa3tha 2odam hansmeh [Normalization]
            //// fe el DataBase haneb2a 3amlen Save ll Email bta3na 3al 2enoh feh Column 2smoh [Normalized Email] dah byb2a kol el Email
            //// bett3ay y Capital y kolo Small 3l4an lama 2karn ana me4 bakran bel Email el 3ady ana bakrn bel [Normalized Email]
            //// 3l4an lazem 2karn 7arf 7arf we rakm rakm we lazem 
        }

        public int GetHashCode(object obj)
        {
            // hamsk el [obj] el gaya deh ha3rfha 3al 2enha string l2n ana hat3aml ma3 string
            // kdah ==> string str = obj as string;
            // bs hwa za3lan fe el goz2 dah ==> obj as string;
            // l2n el [obj] deh hya fo2 2sln object ya3nya 3ady y4el null we ana lama 3amlt [obj as string]
            // anta kdah 2olteloh ana badmnlk 2n el object el gaya dah hwa hykon string 
            // fa kdah el string dah b2a nullable bardo l2n el object hwa nullable kman fa lazem yb2 zay ba3d
            // we ba3d kdah get 7atet kol dah fe [string str] bs el string dah me4 nullable 
            // fa kdah anta bet7awl te7ot nullable string el hwa [obj as string] fe string me4 by allow el null me4 nullable el hwa [string str]
            // fa 3l4an ne4el el za3l dah 2w el error 2w el warning lazem ne5aly el [string str] tekon nullable ya3ny bet allow el null
            // fa hateb2 akdah ==> string? str = obj as string;
            
            // ana meskt el string beta3y 3l4an 2t3aml beh gwa el function bera7ty badl ma kol 4wya fe kol 5atwa
            // ha3ml casting 3l4an23rfoh 2enoh byt3aml ma3 string fa hary7 dema8y we 23mlha mara wa7da we 2st5dm b2a el ana 3amltoh
            // dah gwa el method bera7ty we me4 me7tag 23ml casting kol 4wya
            // fa ana meskt el string el hygel fe el obj we ha2loh 4ofoh 3al 2enoh string we 5azenoh fe string 2smoh str
            // we 2t3aml bel str be ra7tk b2a gwa el method

            string? str = obj as string;

            // tab3n hena el mafrod 2geb el hashCode ll String el gayel bs law 3amlt kdah bs ==> return str.GetHashCode();
            // 2waln fe warning 2n momken el str tegy be null l2nha nullable string fa lazem 25leh kdah ==> return str?.GetHashCode();
            // law hya magt4 be null 5las el donya tmam lakn law gat be null 23ml eh we el mafrod el method el [GetHashCode()] deh
            // betrg3 [int] fa a2llk hanst5dm null-coalescing operator we sa3tha law gat be null yb2a harg3 0
            // l2n madam el str gat be null fa ma3na kdah mafe4 2sln hashcode ll null fa lazem yrg3 7aga fa hyrg3 el default value 
            // lel el betrga3ho el method hena we hya betrg3 int fa el default value be 0 
            // fa hateb2a kdah ==> [str?.GetHashCode()??0;]
            // bs badl ma hyrg3 0 we deh me4 7aga hyfhma 7ad harg3loh Exception ha2olh feh 2en el da5ltoh dah be null 
            // fa hyb2a kdah ==> [str?.GetHashCode()?? throw new Exception("Obj is null") ;]
            // bs kdah fe Mo4kela lysa 2en law ba3t [Amira] we [amira] hydy ly kol wa7da hashcode mo5talef la2noh el str deh string
            // fa hykalm el [GetHashCode()] bta3 el string we kdah ka2ny ma3mlt4 7aga we zayha zay el 2dema
            // fa el sa7 2st5dm 2w ne3ml 7etet 2n n5aleh y4of 2n [Amira] deh hya hya [amira] deh
            // bem3na 2s7 25leh [Non Case Sensetivity]
            // 3an tare2 hamsk el string el gay we 27weloh ly [Lower Case best5dma el method el 3andy el String el hya [toLower()]]
            // 2w 3an tare2 hamsk el string el gay we 27weloh ly [upper Case best5dma el method el 3andy el String el hya [toUpper()]]
            // we kdah kolhom ba2o nafs el Case Sensetivity we sa3tha law da5ltelo [Amira] we [amira] hydehom nafs el HashCode
            // we lama hytla3 3al el Equals fo2 we ykarn hyta3 true fe hydrb error 2w excpetion

            return str?.ToLower().GetHashCode()?? throw new Exception("Obj is null") ;
        }
    }
}
