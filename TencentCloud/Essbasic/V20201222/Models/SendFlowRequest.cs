/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SendFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 需要推送合同的流程ID
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 签署人用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 签署控件信息 (支持添加多个控件)
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 签署人手机号 (如果选择短信验证码签署，则此字段必填)
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 签署人对应的子机构ID，个人签署者此字段不填
        /// </summary>
        [JsonProperty("SubOrganizationId")]
        public string SubOrganizationId{ get; set; }

        /// <summary>
        /// 签名后校验方式：
        /// 1. WEIXINAPP - 微信小程序；
        /// 2. FACEID - 慧眼 (默认) ；
        /// 3. VERIFYCODE - 验证码；
        /// 4. NONE - 无。此选项为白名单参数，暂不支持公开调用。如需开通权限，请通过客户经理或邮件至e-contract@tencent.com与我们联系；
        /// 5. THIRD - 第三方 (暂不支持)
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string[] VerifyChannel{ get; set; }

        /// <summary>
        /// 签署链接失效截止时间，默认为7天
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 是否为最后一个签署人。若为最后一人，本次签署完成以后自动归档。
        /// </summary>
        [JsonProperty("IsLastApprover")]
        public bool? IsLastApprover{ get; set; }

        /// <summary>
        /// 签署完成后，前端跳转的URL
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 短信模板。默认使用腾讯电子签官方短信模板，如有自定义需求，请通过客户经理或邮件至e-contract@tencent.com与我们联系。
        /// </summary>
        [JsonProperty("SmsTemplate")]
        public SmsTemplate SmsTemplate{ get; set; }

        /// <summary>
        /// 签署前置条件：是否要全文阅读，默认否
        /// </summary>
        [JsonProperty("IsFullText")]
        public bool? IsFullText{ get; set; }

        /// <summary>
        /// 签署前置条件：强制用户阅读待签署文件时长，默认不限制
        /// </summary>
        [JsonProperty("PreReadTime")]
        public long? PreReadTime{ get; set; }

        /// <summary>
        /// 当前参与者是否支持线下核身,默认为不支持
        /// </summary>
        [JsonProperty("CanOffLine")]
        public bool? CanOffLine{ get; set; }

        /// <summary>
        /// 签署任务的回调地址
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "SubOrganizationId", this.SubOrganizationId);
            this.SetParamArraySimple(map, prefix + "VerifyChannel.", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "IsLastApprover", this.IsLastApprover);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamObj(map, prefix + "SmsTemplate.", this.SmsTemplate);
            this.SetParamSimple(map, prefix + "IsFullText", this.IsFullText);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "CanOffLine", this.CanOffLine);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

