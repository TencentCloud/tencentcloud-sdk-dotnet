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

    public class SignFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 流程编号
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 意愿确认票据。
        /// 1. VerifyChannel 为 WEIXINAPP，使用响应的VerifyResult；
        /// 2. VerifyChannel 为 FACEID时，使用OrderNo；
        /// 3. VerifyChannel 为 VERIFYCODE，使用短信验证码
        /// 4. VerifyChannel 为 NONE，传空值
        /// （注：普通情况下，VerifyResult不能为None，如您不希望腾讯电子签对用户签署意愿做校验，请提前与客户经理或邮件至e-contract@tencent.com与我们联系）
        /// </summary>
        [JsonProperty("VerifyResult")]
        public string VerifyResult{ get; set; }

        /// <summary>
        /// 意愿确认渠道：
        /// 1. WEIXINAPP - 微信小程序
        /// 2. FACEID - 慧眼 (默认) 
        /// 3. VERIFYCODE - 验证码
        /// 4. THIRD - 第三方 (暂不支持)
        /// 5. NONE - 无需电子签系统验证
        /// （注：普通情况下，VerifyChannel不能为None，如您不希望腾讯电子签对用户签署意愿做校验，请提前与客户经理或邮件至e-contract@tencent.com与我们联系）
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string VerifyChannel{ get; set; }

        /// <summary>
        /// 客户端来源IP
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 签署内容
        /// </summary>
        [JsonProperty("SignSeals")]
        public SignSeal[] SignSeals{ get; set; }

        /// <summary>
        /// 签署备注
        /// </summary>
        [JsonProperty("ApproveMessage")]
        public string ApproveMessage{ get; set; }

        /// <summary>
        /// 签署参与者编号
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "VerifyResult", this.VerifyResult);
            this.SetParamSimple(map, prefix + "VerifyChannel", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamArrayObj(map, prefix + "SignSeals.", this.SignSeals);
            this.SetParamSimple(map, prefix + "ApproveMessage", this.ApproveMessage);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
        }
    }
}

