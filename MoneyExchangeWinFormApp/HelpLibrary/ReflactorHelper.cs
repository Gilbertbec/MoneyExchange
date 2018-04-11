namespace HelpLibrary
{
    using MoneyExchange.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Forms;

    public static class ReflactorHelper
    {
        public static Assembly GetAssemblyByAssemblyName(string assemblyName)
        {
            Assembly assembly = Assembly.Load(assemblyName);
            return assembly;
        }

        public static dynamic GetInstenceByClassName(string className, Assembly assembly)
        {
            var instance = assembly.CreateInstance(className, true);
            return instance;
        }

        public static dynamic GetInstenceByClassName(string className, string assemblyName)
        {
            Assembly assembly = Assembly.Load(assemblyName);
            var instance = assembly.CreateInstance(className, true);
            return instance;
        }

        public static FieldInfo GetFieldInfoByFieldName(string fieldName, dynamic fieldValue, object instance)
        {
            Type type = instance.GetType();
            FieldInfo fieldInfo = type.GetField(fieldName);
            return fieldInfo;
        }

        public static FieldInfo GetFieldInfoByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            FieldInfo fieldInfo = type.GetField(fieldName);
            return fieldInfo;
        }

        public static dynamic SetFieldValueByFieldName(string fieldName, dynamic fieldValue, object instance)
        {
            Type type = instance.GetType();
            FieldInfo fieldInfo = type.GetField(fieldName);
            fieldInfo.SetValue(instance, fieldValue);
            return instance;
        }

        public static dynamic SetFieldValueByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            type.GetField(fieldName).SetValue(instance, fieldValue);
            return instance;
        }

        public static FieldInfo GetPrivateFieldInfoByFieldName(string fieldName, dynamic fieldValue, object instance)
        {
            Type type = instance.GetType();
            FieldInfo fieldInfo = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            return fieldInfo;
        }

        public static FieldInfo GetPrivateFieldInfoByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            FieldInfo fieldInfo = type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            return fieldInfo;
        }

        public static dynamic SetPrivateFieldValueByFieldName(string fieldName, dynamic fieldValue, object instance)
        {
            Type type = instance.GetType();
            type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, fieldValue);
            return instance;
        }

        public static dynamic SetPrivateFieldValueByFieldName(string fieldName, dynamic fieldValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            type.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, fieldValue);
            return instance;
        }

        public static PropertyInfo GetPropertyInfoByPropertyName(string propertyName, dynamic propertyValue, object instance)
        {
            Type type = instance.GetType();
            PropertyInfo propertyInfo = type.GetProperty(propertyName);
            return propertyInfo;
        }

        public static PropertyInfo GetPropertyInfoByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            PropertyInfo propertyInfo = type.GetProperty(propertyName);
            return propertyInfo;
        }

        public static dynamic SetPropertyValueByPropertyName(string propertyName, dynamic propertyValue, object instance)
        {
            Type type = instance.GetType();
            type.GetProperty(propertyName).SetValue(instance, propertyValue);
            return instance;
        }

        public static dynamic SetPropertyValueByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            type.GetProperty(propertyName).SetValue(instance, propertyValue);
            return instance;
        }

        public static PropertyInfo GetPrivatePropertyInfoByPropertyName(string propertyName, dynamic propertyValue, object instance)
        {
            Type type = instance.GetType();
            PropertyInfo propertyInfo = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic);
            return propertyInfo;
        }

        public static PropertyInfo GetPrivatePropertyInfoByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            PropertyInfo propertyInfo = type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic);
            return propertyInfo;
        }

        public static dynamic SetPrivatePropertyValueByPropertyName(string propertyName, dynamic propertyValue, object instance)
        {
            Type type = instance.GetType();
            type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, propertyValue);
            return instance;
        }

        public static dynamic SetPrivatePropertyValueByPropertyName(string propertyName, dynamic propertyValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            type.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic).SetValue(instance, propertyValue);
            return instance;
        }

        public static MethodInfo GetMethodInfoByMethodName(string methodName, dynamic methodValue, object instance)
        {
            Type type = instance.GetType();
            MethodInfo methodInfo = type.GetMethod(methodName);
            return methodInfo;
        }

        public static MethodInfo GetMethodInfoByMethodName(string methodName, dynamic methodValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            MethodInfo methodInfo = type.GetMethod(methodName);
            return methodInfo;
        }

        public static void InvokeMethodValueByMethodName(string methodName, dynamic instance)
        {
            Type type = instance.GetType();
            type.GetMethod(methodName).Invoke(instance, null);
        }

        //public static List<ExchangeRate> InvokeMethodValueByMethodNameWithParameter(string methodName, dynamic instance, string[] parameters)
        //{
        //    Type type = instance.GetType();
        //    List<ExchangeRate> exchangeRateList = (List<ExchangeRate>)type.InvokeMember("methodName", BindingFlags.InvokeMethod, null, "methodName", parameters);
        //    return exchangeRateList;
        //}
        public static void InvokeMethodValueByMethodName(string methodName, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            type.GetMethod(methodName).Invoke(instance, null);
        }

        //public static List<ExchangeRate> InvokeMethodValueByMethodNameWithParameter(string methodName, string className, string assemblyName, string[] parameters)
        //{
        //    //var methodInfo = GetAssemblyByAssemblyName(assemblyName).GetTypes().Where(x => x.Namespace.ToUpper().Contains("HELPLIBRARY"))
        //    //.Select(t => t.GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public));
        //    //var methodInfo = GetAssemblyByAssemblyName(assemblyName).GetTypes().Select(t => t.GetMethod(methodName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public));
        //    var assembly = GetAssemblyByAssemblyName(assemblyName);
        //    var types = assembly.GetTypes();                         
        //    var types1 = types.Where(x => x.FullName == "HelpLibrary.ReflactorHelper");
        //    var methodInfo = types1.Select(t => t.GetMethod(methodName, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public));


        //    List<ExchangeRate> exchangeRateList = null; 
        //    methodInfo.ToList().ForEach(x =>
        //    {
        //        if (x != null)
        //        {
        //            exchangeRateList = (List<ExchangeRate>)x.Invoke(null, parameters);
        //        }
        //    });

        //    return exchangeRateList;
        //}
        public static MethodInfo GetPrivateMethodInfoByMethodName(string methodName, dynamic methodValue, object instance)
        {
            Type type = instance.GetType();
            MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            return methodInfo;
        }

        public static MethodInfo GetPrivateMethodInfoByMethodName(string methodName, dynamic methodValue, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            return methodInfo;
        }

        public static void InvokePrivateMethodValueByMethodName(string methodName, object instance)
        {
            Type type = instance.GetType();
            type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(instance, null);
        }

        public static void InvokePrivateMethodValueByMethodName(string methodName, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke(instance, null);
        }

        public static Func<object, object[], object> GetDelegateMethodValueByMethodName(string methodName, object instance)
        {
            Type type = instance.GetType();
            Func<object, object[], object> func = type.GetMethod(methodName).Invoke;
            return func;
        }

        public static Func<object, object[], object> GetDelegateMethodValueByMethodName(string methodName, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            Func<object, object[], object> func = type.GetMethod(methodName).Invoke;
            return func;
        }

        public static Func<object, object[], object> GetDelegatePrivateMethodValueByMethodName(string methodName, object instance)
        {
            Type type = instance.GetType();
            Func<object, object[], object> func = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic).Invoke;
            return func;
        }

        public static Func<object, object[], object> GetDelegatePrivateMethodValueByMethodName(string methodName, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            MethodInfo methodInfo = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            Func<object, object[], object> func = methodInfo.Invoke;

            return func;
        }

        public static void InvokeMethodValueByAttributeName(string functionName, string conditionString, object instance)
        {
            Type type = instance.GetType();
            MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var method in methodInfo)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ConditionAttribute), true);
                foreach (var item in attributes)
                {
                    ConditionAttribute attr = item as ConditionAttribute;
                    if (null != attr)
                    {
                        if (attr.FunctionName == functionName && attr.ConditionString == conditionString)
                        {
                            type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke(instance, null);
                        }
                    }
                }
            }
        }

        public static void InvokeMethodValueByAttributeName(string functionName, string conditionString, string className, string assemblyName)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var method in methodInfo)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ConditionAttribute), true);
                foreach (var item in attributes)
                {
                    ConditionAttribute attr = item as ConditionAttribute;
                    if (null != attr)
                    {
                        if (attr.FunctionName == functionName && attr.ConditionString == conditionString)
                        {
                            type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke(instance, null);
                        }
                    }
                }
            }
        }

        public static void InvokeMethodValueByAttributeNameWithParameter(string functionName, string conditionString, string className, string assemblyName, ICollection<ExchangeRate> exchangeRateList)
        {
            Assembly assembly = GetAssemblyByAssemblyName(assemblyName);
            var instance = GetInstenceByClassName(className, assembly);
            Type type = instance.GetType();
            MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var method in methodInfo)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ConditionAttribute), true);
                object[] obj = new object[1];
                obj[0] = exchangeRateList;
                foreach (var item in attributes)
                {
                    ConditionAttribute attr = item as ConditionAttribute;
                    if (null != attr)
                    {
                        if (attr.FunctionName == functionName && attr.ConditionString == conditionString)
                        {
                            type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke(instance, obj);
                        }
                    }
                }
            }
        }

        //public static ICollection<T> InvokeMethodValueByAttributeNameForExchangeRateList(string functionName, string conditionString, string className, string assemblyName)
        //{
        //    Assembly assembly = GetAssemblyByAssemblyName(assemblyName);

        //    var classNames = assembly.GetTypes();
        //    foreach (var item in classNames)
        //    {
        //        MessageBox.Show(item.Name);
        //    }


        //    var instance = GetInstenceByClassName(className, assembly);
        //    Type type = instance.GetType();
        //    MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        //    ICollection<T> collection = null;
        //    foreach (var method in methodInfo)
        //    {
        //        object[] attributes = method.GetCustomAttributes(typeof(ConditionAttribute), true);
        //        foreach (var item in attributes)
        //        {
        //            ConditionAttribute attr = item as ConditionAttribute;
        //            if (null != attr)
        //            {
        //                if (attr.FunctionName == functionName && attr.ConditionString == conditionString)
        //                {
        //                    collection = type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Invoke(instance, null);
        //                }
        //            }
        //        }
        //    }
        //    return collection;
        //}
    }
}
