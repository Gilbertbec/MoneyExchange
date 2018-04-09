using MoneyExchange.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLibrary
{
    public static class GilbertIoc
    {
        //static GilbertIoc()
        //{ }
        //static Dictionary<string,string[]> dic = new Dictionary<string, string[]>();

        //public static void Setup(string InvokeMethodName, string methodName, string conditionString)
        //{
        //    string[] parms = { methodName, conditionString };
        //    dic.Add(InvokeMethodName, parms);
        //    List<ExchangeRate> exchangeRateList = ReflactorHelper.InvokeMethodValueByAttributeNameForExchangeRateList(methodName, conditionString, "MoneyExchange.BLL.ExchangeRateReadService", "MoneyExchange.BLL");
        //}

        //public static List<ExchangeRate> Invoke(string InvokeMethodName)
        //{
        //    string[] parameters = null;
        //    if (dic.TryGetValue(InvokeMethodName, out string[] tempParameters))
        //    {
        //        parameters = tempParameters;
        //    }

        //    List<ExchangeRate> exchangeRateList = ReflactorHelper.InvokeMethodValueByMethodNameWithParameter(InvokeMethodName, "HelpLibrary.ReflactorHelper", "HelpLibrary", parameters);
        //    return exchangeRateList;
        //}
        //static Func<string, string, string, string, List<ExchangeRate>> func;
        //public static void Setup()
        //{
        //    string conditionString = GlobalConfig.fileType.ToString();
        //    func = ReflactorHelper.InvokeMethodValueByAttributeNameForExchangeRateList;
        //}

        //public static List<ExchangeRate> Invoke(string InvokeMethodName)
        //{
        //    string conditionString = GlobalConfig.fileType.ToString();
        //    List<ExchangeRate> exchangeRates = ReflactorHelper.InvokeMethodValueByAttributeNameForExchangeRateList("ExchangeRateList.GetExchangeRateFromFile", conditionString, "MoneyExchange.BLL.ExchangeRateReadService", "MoneyExchange.BLL");
        //    return exchangeRates;
        //}
    }
}
