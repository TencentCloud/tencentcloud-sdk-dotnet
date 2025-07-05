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

    public class SendSignInnerVerifyCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 验证码类型，取值(SIGN)
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 用户 id
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 模板 id
        /// </summary>
        [JsonProperty("VerifyTemplateId")]
        public string VerifyTemplateId{ get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("VerifySign")]
        public string VerifySign{ get; set; }

        /// <summary>
        /// 流程(目录) id
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 三要素检测结果
        /// </summary>
        [JsonProperty("CheckThreeElementResult")]
        public long? CheckThreeElementResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "VerifyTemplateId", this.VerifyTemplateId);
            this.SetParamSimple(map, prefix + "VerifySign", this.VerifySign);
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "CheckThreeElementResult", this.CheckThreeElementResult);
        }
    }
}

