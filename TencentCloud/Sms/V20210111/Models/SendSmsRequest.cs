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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendSmsRequest : AbstractModel
    {
        
        /// <summary>
        /// 下发手机号码，采用 E.164 标准，格式为+[国家或地区码][手机号]，单次请求最多支持200个手机号且要求全为境内手机号或全为境外手机号。
        /// 例如：+8613711112222， 其中前面有一个+号 ，86为国家码，13711112222为手机号。
        /// 注：发送国内短信格式还支持0086、86或无任何国家或地区码的11位手机号码，前缀默认为+86。
        /// </summary>
        [JsonProperty("PhoneNumberSet")]
        public string[] PhoneNumberSet{ get; set; }

        /// <summary>
        /// 短信 SdkAppId，在 [短信控制台](https://console.cloud.tencent.com/smsv2/app-manage)  添加应用后生成的实际 SdkAppId，示例如1400006666。
        /// </summary>
        [JsonProperty("SmsSdkAppId")]
        public string SmsSdkAppId{ get; set; }

        /// <summary>
        /// 模板 ID，必须填写已审核通过的模板 ID。模板 ID 可登录 [短信控制台](https://console.cloud.tencent.com/smsv2) 查看，若向境外手机号发送短信，仅支持使用国际/港澳台短信模板。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 短信签名内容，使用 UTF-8 编码，必须填写已审核通过的签名，例如：腾讯云，签名信息可登录 [短信控制台](https://console.cloud.tencent.com/smsv2) 查看。
        /// <dx-alert infotype="notice" title="注意">发送国内短信该参数必填。</dx-alert>
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// 模板参数，若无模板参数，则设置为空。
        /// <dx-alert infotype="notice" title="注意">模板参数的个数需要与 TemplateId 对应模板的变量个数保持一致。</dx-alert>
        /// </summary>
        [JsonProperty("TemplateParamSet")]
        public string[] TemplateParamSet{ get; set; }

        /// <summary>
        /// 短信码号扩展号，默认未开通，如需开通请联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81)。
        /// </summary>
        [JsonProperty("ExtendCode")]
        public string ExtendCode{ get; set; }

        /// <summary>
        /// 用户的 session 内容，可以携带用户侧 ID 等上下文信息，server 会原样返回。
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// 国内短信无需填写该项；国际/港澳台短信已申请独立 SenderId 需要填写该字段，默认使用公共 SenderId，无需填写该字段。
        /// 注：月度使用量达到指定量级可申请独立 SenderId 使用，详情请联系 [腾讯云短信小助手](https://cloud.tencent.com/document/product/382/3773#.E6.8A.80.E6.9C.AF.E4.BA.A4.E6.B5.81)。
        /// </summary>
        [JsonProperty("SenderId")]
        public string SenderId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "PhoneNumberSet.", this.PhoneNumberSet);
            this.SetParamSimple(map, prefix + "SmsSdkAppId", this.SmsSdkAppId);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamArraySimple(map, prefix + "TemplateParamSet.", this.TemplateParamSet);
            this.SetParamSimple(map, prefix + "ExtendCode", this.ExtendCode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SenderId", this.SenderId);
        }
    }
}

