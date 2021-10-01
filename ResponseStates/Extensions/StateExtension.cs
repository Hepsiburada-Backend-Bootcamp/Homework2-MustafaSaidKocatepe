using ResponseStates.Attributes;
using ResponseStates.Enums;
using ResponseStates.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;

namespace ResponseStates.Extensions
{
    public static class StateExtension
    {
        private static StateDisplayAttribute StateDisplayAttributeMethod(this StateCode stateCode)
        {
            return stateCode.GetType().GetMember(stateCode.ToString())
                .First()
                .GetCustomAttributes(false)
                .First() as StateDisplayAttribute;
        }
        private static readonly ResourceManager ResourceManager = new ResourceManager("ResponseStates.Resources.Messages", typeof(Messages).Assembly);

        public static int GetOrder(this StateCode stateCode) => StateDisplayAttributeMethod(stateCode).Order;
        public static int GetStateCode(this StateCode stateCode) => StateDisplayAttributeMethod(stateCode).Code;
        public static double GetSubStateCode(this StateCode stateCode) => StateDisplayAttributeMethod(stateCode).SubCode;
        public static string GetName(this StateCode stateCode) => StateDisplayAttributeMethod(stateCode).Name;
        public static string GetMessage(this StateCode stateCode) => StateDisplayAttributeMethod(stateCode).Message;
        public static string GetLocalizationMessage(this StateCode stateCode) => ResourceManager.GetString(StateDisplayAttributeMethod(stateCode).Name, CultureInfo.CurrentCulture);
        public static string GetLocalizationMessage(this StateCode stateCode, params object[] message) => string.Format(ResourceManager.GetString(StateDisplayAttributeMethod(stateCode).Name, CultureInfo.CurrentCulture), message);
        public static string GetMessage(this StateCode stateCode, params object[] message) => string.Format(StateDisplayAttributeMethod(stateCode).Message, message);
        public static string GetMessage(this StateCode stateCode, params int[] message) => string.Format(StateDisplayAttributeMethod(stateCode).Message, message);
        public static bool GetSuccess(this StateCode stateCode) => StateDisplayAttributeMethod(stateCode).Success;

        public static StateCode GetEnum(string enumName)
        {
            return (StateCode)Enum.Parse(typeof(StateCode), enumName, true);
        }
    }
}
