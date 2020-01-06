/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendSmsRequest : AbstractModel
    {
        
        /// <summary>
        /// 下发手机号码，采用 e.164 标准，+[国家或地区码][手机号] ，示例如：+8613711112222， 其中前面有一个+号 ，86为国家码，13711112222为手机号，最多不要超过200个手机号。
        /// </summary>
        [JsonProperty("PhoneNumberSet")]
        public string[] PhoneNumberSet{ get; set; }

        /// <summary>
        /// 模板 ID，必须填写已审核通过的模板 ID。模板ID可登录 [短信控制台](https://console.cloud.tencent.com/sms/smslist) 查看。
        /// </summary>
        [JsonProperty("TemplateID")]
        public string TemplateID{ get; set; }

        /// <summary>
        /// 短信SdkAppid在 [短信控制台](https://console.cloud.tencent.com/sms/smslist)  添加应用后生成的实际SdkAppid，示例如1400006666。
        /// </summary>
        [JsonProperty("SmsSdkAppid")]
        public string SmsSdkAppid{ get; set; }

        /// <summary>
        /// 短信签名内容，使用 UTF-8 编码，必须填写已审核通过的签名，签名信息可登录 [短信控制台](https://console.cloud.tencent.com/sms/smslist)  查看。
        /// </summary>
        [JsonProperty("Sign")]
        public string Sign{ get; set; }

        /// <summary>
        /// 模板参数，若无模板参数，则设置为空。
        /// </summary>
        [JsonProperty("TemplateParamSet")]
        public string[] TemplateParamSet{ get; set; }

        /// <summary>
        /// 短信码号扩展号，默认未开通，如需开通请联系 [sms helper](https://cloud.tencent.com/document/product/382/3773)。
        /// </summary>
        [JsonProperty("ExtendCode")]
        public string ExtendCode{ get; set; }

        /// <summary>
        /// 用户的 session 内容，可以携带用户侧 ID 等上下文信息，server 会原样返回。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 国际/港澳台短信 senderid，国内短信填空，默认未开通，如需开通请联系 [sms helper](https://cloud.tencent.com/document/product/382/3773)。
        /// </summary>
        [JsonProperty("SenderId")]
        public string SenderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PhoneNumberSet.", this.PhoneNumberSet);
            this.SetParamSimple(map, prefix + "TemplateID", this.TemplateID);
            this.SetParamSimple(map, prefix + "SmsSdkAppid", this.SmsSdkAppid);
            this.SetParamSimple(map, prefix + "Sign", this.Sign);
            this.SetParamArraySimple(map, prefix + "TemplateParamSet.", this.TemplateParamSet);
            this.SetParamSimple(map, prefix + "ExtendCode", this.ExtendCode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SenderId", this.SenderId);
        }
    }
}

