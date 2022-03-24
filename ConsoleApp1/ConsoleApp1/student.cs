class student : Person
{
    //    IQRank(IQ imtahanının nəticəsi (100 bal üzərindən))
    //   LanguageRank(Dil imtahanının nəticəsi (100 bal üzərindən))

    public int IQRank {
        get
        {
            return IQRank;
        }
        set
        {
            if (value > 60)

            {
                value = IQRank;

            }

        }
    }

    public int LanguageRank
    {
        get
        {
            return LanguageRank;
        }
        set
        {
            if (value > 60)

            {
                value = LanguageRank;

            }

        }
    }
    public void ExamResult(int IqRank, int LanguageRank, int age)
    {
        if (true)
        {

        }
    }

    
        
       

    

//public string ExamResult(int IQRank, int LanguageRank, int age)
//{
//    if (age < 6 || age > 20) return "Siz shagird deyilsigiz.";

//    int Great = IQRank + LanguageRank;
//    string text = $"Siz imtahandan {Great} bal toplamisiz.";

//    if (Great >= 120)
//        text += "\nTEBRIKLER! SIZ IMTAHANDAN UGURLA KECDINIZ.";
//    else
//        text += "\nSiz kechid bali toplaya bilmesiz. Teesufki sinifde qaldiniz. ";

//    return text;
//}
