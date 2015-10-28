﻿using System.Collections.Generic;
using System.Configuration;
using Bode.Plugin.Core.SMS;
using OSharp.Utility.Logging;

namespace Bode.Plugin.Sms.Ccp
{
    public class CcpSms :ISms
    {
        private static readonly ILogger Logger = LogManager.GetLogger("CcpSms");
        private readonly CCPRestSDK.CCPRestSDK _api = new CCPRestSDK.CCPRestSDK();


        public CcpSms()
        {
            var sid = ConfigurationManager.AppSettings["SMS_CCP_Sid"];
            var token = ConfigurationManager.AppSettings["SMS_CCP_Token"];
            var appId = ConfigurationManager.AppSettings["SMS_CCP_AppId"];

            if (!_api.init("sandboxapp.cloopen.com", "8883"))
            {
                Logger.Error("CcpSms初始化失败");
            }
            else
            {
                _api.setAccount(sid, token);
                _api.setAppId(appId);
            }
        }

        /// <summary>
        /// 发送短信(重试3次)
        /// </summary>
        /// <param name="phoneNos">电话号码集合，逗号分隔</param>
        /// <param name="templateId">模版Id</param>
        /// <param name="content">短信内容</param>
        /// <returns>是否发送成功</returns>
        
        public bool Send(string phoneNos, int templateId = 0, params string[] content)
        {
            int retryCount = 4;
            while (retryCount > 0)
            {
                Dictionary<string, object> result = _api.SendTemplateSMS(phoneNos, templateId.ToString(), content);
                if ((string) result["statusCode"] == "000000")
                {
                    return true;
                }
                retryCount--;
            }
            return false;
        }
    }
}
