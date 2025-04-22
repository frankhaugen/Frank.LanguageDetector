

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable MissingXmlDoc
// ReSharper disable StringLiteralTypo
// ReSharper disable StringLiteralsWordIsNotInDictionary

namespace Frank.LanguageDetector;

/// <summary>
/// </summary>
public enum Language
{
    [EnglishName("Abkhazian")] [LocalName("аҧсуа бызшәа, аҧсшәа")]
    ABK = 1,
    [EnglishName("Afar")] [LocalName("Afaraf")]
    AAR = 2,

    [EnglishName("Afrikaans")] [LocalName("Afrikaans")]
    AFR = 3,
    
    [EnglishName("Akan")] [LocalName("Akan")]
    AKA = 4,

    [EnglishName("Albanian")] [LocalName("Shqip")]
    ALB = 5,
    
    [EnglishName("Amharic")] [LocalName("አማርኛ")] AMH = 6,

    [EnglishName("Arabic")] [LocalName("العربية")]
    ARA = 7,

    [EnglishName("Aragonese")] [LocalName("aragonés")]
    ARG = 8,

    [EnglishName("Armenian")] [LocalName("Հայերեն")]
    ARM = 9,

    [EnglishName("Assamese")] [LocalName("অসমীয়া")]
    ASM = 10,

    [EnglishName("Avaric")] [LocalName("авар мацӀ, магӀарул мацӀ")]
    AVA = 11,

    [EnglishName("Avestan")] [LocalName("avesta")]
    AVE = 12,

    [EnglishName("Aymara")] [LocalName("aymar aru")]
    AYM = 13,

    [EnglishName("Azerbaijani")] [LocalName("azərbaycan dili")]
    AZE = 14,

    [EnglishName("Bambara")] [LocalName("bamanankan")]
    BAM = 15,

    [EnglishName("Bashkir")] [LocalName("башҡорт теле")]
    BAK = 16,

    [EnglishName("Basque")] [LocalName("euskara, euskera")]
    BAQ = 17,

    [EnglishName("Belarusian")] [LocalName("беларуская мова")]
    BEL = 18,
    [EnglishName("Bengali")] [LocalName("বাংলা")] BEN = 19,

    [EnglishName("Bihari languages")] [LocalName("भोजपुरी")]
    BIH = 20,

    [EnglishName("Bislama")] [LocalName("Bislama")]
    BIS = 21,

    [EnglishName("Bosnian")] [LocalName("bosanski jezik")]
    BOS = 22,

    [EnglishName("Breton")] [LocalName("brezhoneg")]
    BRE = 23,

    [EnglishName("Bulgarian")] [LocalName("български език")]
    BUL = 24,
    [EnglishName("Burmese")] [LocalName("ဗမာစာ")] BUR = 25,

    [EnglishName("Catalan, Valencian")] [LocalName("català, valencià")]
    CAT = 26,

    [EnglishName("Chamorro")] [LocalName("Chamoru")]
    CHA = 27,

    [EnglishName("Chechen")] [LocalName("нохчийн мотт")]
    CHE = 28,

    [EnglishName("Chichewa, Chewa, Nyanja")] [LocalName("chiCheŵa, chinyanja")]
    NYA = 29,

    [EnglishName("Chinese")] [LocalName("中文 (Zhōngwén), 汉语, 漢語")]
    CHI = 30,

    [EnglishName("Chuvash")] [LocalName("чӑваш чӗлхи")]
    CHV = 31,

    [EnglishName("Cornish")] [LocalName("Kernewek")]
    COR = 32,

    [EnglishName("Corsican")] [LocalName("corsu, lingua corsa")]
    COS = 33,
    [EnglishName("Cree")] [LocalName("ᓀᐦᐃᔭᐍᐏᐣ")] CRE = 34,

    [EnglishName("Croatian")] [LocalName("hrvatski jezik")]
    HRV = 35,

    [EnglishName("Czech")] [LocalName("čeština, český jazyk")]
    CZE = 36,
    [EnglishName("Danish")] [LocalName("dansk")] DAN = 37,

    [EnglishName("Divehi, Dhivehi, Maldivian")] [LocalName("ދިވެހި")]
    DIV = 38,

    [EnglishName("Dutch, Flemish")] [LocalName("Nederlands, Vlaams")]
    DUT = 39,

    [EnglishName("Dzongkha")] [LocalName("རྫོང་ཁ")]
    DZO = 40,

    [EnglishName("English")] [LocalName("English")]
    ENG = 41,

    [EnglishName("Esperanto")] [LocalName("Esperanto")]
    EPO = 42,

    [EnglishName("Estonian")] [LocalName("eesti, eesti keel")]
    EST = 43,
    [EnglishName("Ewe")] [LocalName("Eʋegbe")] EWE = 44,

    [EnglishName("Faroese")] [LocalName("føroyskt")]
    FAO = 45,

    [EnglishName("Fijian")] [LocalName("vosa Vakaviti")]
    FIJ = 46,

    [EnglishName("Finnish")] [LocalName("suomi, suomen kieli")]
    FIN = 47,

    [EnglishName("French")] [LocalName("français, langue française")]
    FRE = 48,

    [EnglishName("Fulah")] [LocalName("Fulfulde, Pulaar, Pular")]
    FUL = 49,

    [EnglishName("Galician")] [LocalName("Galego")]
    GLG = 50,

    [EnglishName("Georgian")] [LocalName("ქართული")]
    GEO = 51,

    [EnglishName("German")] [LocalName("Deutsch")]
    GER = 52,

    [EnglishName("Greek, Modern")] [LocalName("ελληνικά")]
    GRE = 53,

    [EnglishName("Guarani")] [LocalName("Avañe'ẽ")]
    GRN = 54,

    [EnglishName("Gujarati")] [LocalName("ગુજરાતી")]
    GUJ = 55,

    [EnglishName("Haitian, Haitian Creole")] [LocalName("Kreyòl ayisyen")]
    HAT = 56,

    [EnglishName("Hausa")] [LocalName("(Hausa) هَوُسَ")]
    HAU = 57,
    [EnglishName("Hebrew")] [LocalName("עברית")] HEB = 58,

    [EnglishName("Herero")] [LocalName("Otjiherero")]
    HER = 59,

    [EnglishName("Hindi")] [LocalName("हिन्दी, हिंदी")]
    HIN = 60,

    [EnglishName("Hiri Motu")] [LocalName("Hiri Motu")]
    HMO = 61,

    [EnglishName("Hungarian")] [LocalName("magyar")]
    HUN = 62,

    [EnglishName("Interlingua (International Auxiliary Language Association)")] [LocalName("Interlingua")]
    INA = 63,

    [EnglishName("Indonesian")] [LocalName("Bahasa Indonesia")]
    IND = 64,

    [EnglishName("Interlingue, Occidental")] [LocalName("(originally:) Occidental, (after WWII:) Interlingue")]
    ILE = 65,
    [EnglishName("Irish")] [LocalName("Gaeilge")] GLE = 66,

    [EnglishName("Igbo")] [LocalName("Asụsụ Igbo")]
    IBO = 67,

    [EnglishName("Inupiaq")] [LocalName("Iñupiaq, Iñupiatun")]
    IPK = 68,
    [EnglishName("Ido")] [LocalName("Ido")] IDO = 69,

    [EnglishName("Icelandic")] [LocalName("Íslenska")]
    ICE = 70,

    [EnglishName("Italian")] [LocalName("Italiano")]
    ITA = 71,

    [EnglishName("Inuktitut")] [LocalName("ᐃᓄᒃᑎᑐᑦ")]
    IKU = 72,

    [EnglishName("Japanese")] [LocalName("日本語 (にほんご)")]
    JPN = 73,

    [EnglishName("Javanese")] [LocalName("ꦧꦱꦗꦮ, Basa Jawa")]
    JAV = 74,

    [EnglishName("Kalaallisut, Greenlandic")] [LocalName("kalaallisut, kalaallit oqaasii")]
    KAL = 75,
    [EnglishName("Kannada")] [LocalName("ಕನ್ನಡ")] KAN = 76,
    [EnglishName("Kanuri")] [LocalName("Kanuri")] KAU = 77,

    [EnglishName("Kashmiri")] [LocalName("कश्मीरी, كشميري‎")]
    KAS = 78,

    [EnglishName("Kazakh")] [LocalName("қазақ тілі")]
    KAZ = 79,

    [EnglishName("Central Khmer")] [LocalName("ខ្មែរ, ខេមរភាសា, ភាសាខ្មែរ")]
    KHM = 80,

    [EnglishName("Kikuyu, Gikuyu")] [LocalName("Gĩkũyũ")]
    KIK = 81,

    [EnglishName("Kinyarwanda")] [LocalName("Ikinyarwanda")]
    KIN = 82,

    [EnglishName("Kirghiz, Kyrgyz")] [LocalName("Кыргызча, Кыргыз тили")]
    KIR = 83,
    [EnglishName("Komi")] [LocalName("коми кыв")] KOM = 84,
    [EnglishName("Kongo")] [LocalName("Kikongo")] KON = 85,
    [EnglishName("Korean")] [LocalName("한국어")] KOR = 86,

    [EnglishName("Kurdish")] [LocalName("Kurdî, کوردی‎")]
    KUR = 87,

    [EnglishName("Kuanyama, Kwanyama")] [LocalName("Kuanyama")]
    KUA = 88,

    [EnglishName("Latin")] [LocalName("latine, lingua latina")]
    LAT = 89,

    [EnglishName("Luxembourgish, Letzeburgesch")] [LocalName("Lëtzebuergesch")]
    LTZ = 90,
    [EnglishName("Ganda")] [LocalName("Luganda")] LUG = 91,

    [EnglishName("Limburgan, Limburger, Limburgish")] [LocalName("Limburgs")]
    LIM = 92,

    [EnglishName("Lingala")] [LocalName("Lingála")]
    LIN = 93,
    [EnglishName("Lao")] [LocalName("ພາສາລາວ")] LAO = 94,

    [EnglishName("Lithuanian")] [LocalName("lietuvių kalba")]
    LIT = 95,

    [EnglishName("Luba-Katanga")] [LocalName("Kiluba")]
    LUB = 96,

    [EnglishName("Latvian")] [LocalName("latviešu valoda")]
    LAV = 97,

    [EnglishName("Manx")] [LocalName("Gaelg, Gailck")]
    GLV = 98,

    [EnglishName("Macedonian")] [LocalName("македонски јазик")]
    MAC = 99,

    [EnglishName("Malagasy")] [LocalName("fiteny malagasy")]
    MLG = 100,

    [EnglishName("Malay")] [LocalName("Bahasa Melayu, بهاس ملايو‎")]
    MAY = 101,

    [EnglishName("Malayalam")] [LocalName("മലയാളം")]
    MAL = 102,
    [EnglishName("Maltese")] [LocalName("Malti")] MLT = 103,

    [EnglishName("Maori")] [LocalName("te reo Māori")]
    MAO = 104,
    [EnglishName("Marathi")] [LocalName("मराठी")] MAR = 105,

    [EnglishName("Marshallese")] [LocalName("Kajin M̧ajeļ")]
    MAH = 106,

    [EnglishName("Mongolian")] [LocalName("Монгол хэл")]
    MON = 107,

    [EnglishName("Nauru")] [LocalName("Dorerin Naoero")]
    NAU = 108,

    [EnglishName("Navajo, Navaho")] [LocalName("Diné bizaad")]
    NAV = 109,

    [EnglishName("North Ndebele")] [LocalName("isiNdebele")]
    NDE = 110,
    [EnglishName("Nepali")] [LocalName("नेपाली")] NEP = 111,
    [EnglishName("Ndonga")] [LocalName("Owambo")] NDO = 112,

    [EnglishName("Norwegian Bokmål")] [LocalName("Norsk Bokmål")]
    NOB = 113,

    [EnglishName("Norwegian Nynorsk")] [LocalName("Norsk Nynorsk")]
    NNO = 114,

    [EnglishName("Norwegian")] [LocalName("Norsk")]
    NOR = 115,

    [EnglishName("Sichuan Yi, Nuosu")] [LocalName("ꆈꌠ꒿ Nuosuhxop")]
    III = 116,

    [EnglishName("South Ndebele")] [LocalName("isiNdebele")]
    NBL = 117,

    [EnglishName("Occitan")] [LocalName("occitan, lenga d'òc")]
    OCI = 118,

    [EnglishName("Ojibwa")] [LocalName("ᐊᓂᔑᓈᐯᒧᐎᓐ")]
    OJI = 119,

    [EnglishName("Church Slavic, Old Slavonic, Church Slavonic, Old Bulgarian, Old Church Slavonic")] [LocalName("ѩзыкъ словѣньскъ")]
    CHU = 120,

    [EnglishName("Oromo")] [LocalName("Afaan Oromoo")]
    ORM = 121,
    [EnglishName("Oriya")] [LocalName("ଓଡ଼ିଆ")] ORI = 122,

    [EnglishName("Ossetian, Ossetic")] [LocalName("ирон æвзаг")]
    OSS = 123,

    [EnglishName("Punjabi, Panjabi")] [LocalName("ਪੰਜਾਬੀ, پنجابی‎")]
    PAN = 124,

    [EnglishName("Pali")] [LocalName("पालि, पाळि")]
    PLI = 125,
    [EnglishName("Persian")] [LocalName("فارسی")] PER = 126,

    [EnglishName("Polish")] [LocalName("język polski, polszczyzna")]
    POL = 127,

    [EnglishName("Pashto, Pushto")] [LocalName("پښتو")]
    PUS = 128,

    [EnglishName("Portuguese")] [LocalName("Português")]
    POR = 129,

    [EnglishName("Quechua")] [LocalName("Runa Simi, Kichwa")]
    QUE = 130,

    [EnglishName("Romansh")] [LocalName("Rumantsch Grischun")]
    ROH = 131,

    [EnglishName("Rundi")] [LocalName("Ikirundi")]
    RUN = 132,

    [EnglishName("Romanian, Moldavian, Moldovan")] [LocalName("Română")]
    RUM = 133,

    [EnglishName("Russian")] [LocalName("русский")]
    RUS = 134,

    [EnglishName("Sanskrit")] [LocalName("संस्कृतम्")]
    SAN = 135,

    [EnglishName("Sardinian")] [LocalName("sardu")]
    SRD = 136,

    [EnglishName("Sindhi")] [LocalName("सिन्धी, سنڌي، سندھی‎")]
    SND = 137,

    [EnglishName("Northern Sami")] [LocalName("Davvisámegiella")]
    SME = 138,

    [EnglishName("Samoan")] [LocalName("gagana fa'a Samoa")]
    SMO = 139,

    [EnglishName("Sango")] [LocalName("yângâ tî sängö")]
    SAG = 140,

    [EnglishName("Serbian")] [LocalName("српски језик")]
    SRP = 141,

    [EnglishName("Gaelic, Scottish Gaelic")] [LocalName("Gàidhlig")]
    GLA = 142,

    [EnglishName("Shona")] [LocalName("chiShona")]
    SNA = 143,

    [EnglishName("Sinhala, Sinhalese")] [LocalName("සිංහල")]
    SIN = 144,

    [EnglishName("Slovak")] [LocalName("Slovenčina, Slovenský Jazyk")]
    SLO = 145,

    [EnglishName("Slovenian")] [LocalName("Slovenski Jezik, Slovenščina")]
    SLV = 146,

    [EnglishName("Somali")] [LocalName("Soomaaliga, af Soomaali")]
    SOM = 147,

    [EnglishName("Southern Sotho")] [LocalName("Sesotho")]
    SOT = 148,

    [EnglishName("Spanish, Castilian")] [LocalName("Español")]
    SPA = 149,

    [EnglishName("Sundanese")] [LocalName("Basa Sunda")]
    SUN = 150,

    [EnglishName("Swahili")] [LocalName("Kiswahili")]
    SWA = 151,
    [EnglishName("Swati")] [LocalName("SiSwati")] SSW = 152,

    [EnglishName("Swedish")] [LocalName("Svenska")]
    SWE = 153,
    [EnglishName("Tamil")] [LocalName("தமிழ்")] TAM = 154,
    [EnglishName("Telugu")] [LocalName("తెలుగు")] TEL = 155,

    [EnglishName("Tajik")] [LocalName("тоҷикӣ, toçikī, تاجیکی‎")]
    TGK = 156,
    [EnglishName("Thai")] [LocalName("ไทย")] THA = 157,
    [EnglishName("Tigrinya")] [LocalName("ትግርኛ")] TIR = 158,

    [EnglishName("Tibetan")] [LocalName("བོད་ཡིག")]
    TIB = 159,

    [EnglishName("Turkmen")] [LocalName("Türkmen, Түркмен")]
    TUK = 160,

    [EnglishName("Tagalog")] [LocalName("Wikang Tagalog")]
    TGL = 161,

    [EnglishName("Tswana")] [LocalName("Setswana")]
    TSN = 162,

    [EnglishName("Tonga (Tonga Islands)")] [LocalName("Faka Tonga")]
    TON = 163,

    [EnglishName("Turkish")] [LocalName("Türkçe")]
    TUR = 164,

    [EnglishName("Tsonga")] [LocalName("Xitsonga")]
    TSO = 165,

    [EnglishName("Tatar")] [LocalName("татар теле, tatar tele")]
    TAT = 166,
    [EnglishName("Twi")] [LocalName("Twi")] TWI = 167,

    [EnglishName("Tahitian")] [LocalName("Reo Tahiti")]
    TAH = 168,

    [EnglishName("Uighur, Uyghur")] [LocalName("ئۇيغۇرچە‎, Uyghurche")]
    UIG = 169,

    [EnglishName("Ukrainian")] [LocalName("Українська")]
    UKR = 170,
    [EnglishName("Urdu")] [LocalName("اردو")] URD = 171,

    [EnglishName("Uzbek")] [LocalName("Oʻzbek, Ўзбек, أۇزبېك‎")]
    UZB = 172,

    [EnglishName("Venda")] [LocalName("Tshivenḓa")]
    VEN = 173,

    [EnglishName("Vietnamese")] [LocalName("Tiếng Việt")]
    VIE = 174,

    [EnglishName("Volapük")] [LocalName("Volapük")]
    VOL = 175,
    [EnglishName("Walloon")] [LocalName("Walon")] WLN = 176,
    [EnglishName("Welsh")] [LocalName("Cymraeg")] WEL = 177,
    [EnglishName("Wolof")] [LocalName("Wollof")] WOL = 178,

    [EnglishName("Western Frisian")] [LocalName("Frysk")]
    FRY = 179,

    [EnglishName("Xhosa")] [LocalName("isiXhosa")]
    XHO = 180,

    [EnglishName("Yiddish")] [LocalName("ייִדיש")]
    YID = 181,
    [EnglishName("Yoruba")] [LocalName("Yorùbá")] YOR = 182,

    [EnglishName("Zhuang, Chuang")] [LocalName("Saɯ cueŋƅ, Saw cuengh")]
    ZHA = 183,
    [EnglishName("Zulu")] [LocalName("isiZulu")] ZUL = 184
}