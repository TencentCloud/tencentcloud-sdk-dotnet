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

namespace TencentCloud.Captcha.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCaptchaDataSumResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求总量
        /// </summary>
        [JsonProperty("GetSum")]
        public long? GetSum{ get; set; }

        /// <summary>
        /// 请求验证成功量
        /// </summary>
        [JsonProperty("VfySuccSum")]
        public long? VfySuccSum{ get; set; }

        /// <summary>
        /// 请求验证量
        /// </summary>
        [JsonProperty("VfySum")]
        public long? VfySum{ get; set; }

        /// <summary>
        /// 拦截攻击量
        /// </summary>
        [JsonProperty("AttackSum")]
        public long? AttackSum{ get; set; }

        /// <summary>
        /// 返回信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CaptchaMsg")]
        public string CaptchaMsg{ get; set; }

        /// <summary>
        /// 成功返回0  其它失败
        /// </summary>
        [JsonProperty("CaptchaCode")]
        public long? CaptchaCode{ get; set; }

        /// <summary>
        /// 票据校验量
        /// </summary>
        [JsonProperty("CheckTicketSum")]
        public long? CheckTicketSum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GetSum", this.GetSum);
            this.SetParamSimple(map, prefix + "VfySuccSum", this.VfySuccSum);
            this.SetParamSimple(map, prefix + "VfySum", this.VfySum);
            this.SetParamSimple(map, prefix + "AttackSum", this.AttackSum);
            this.SetParamSimple(map, prefix + "CaptchaMsg", this.CaptchaMsg);
            this.SetParamSimple(map, prefix + "CaptchaCode", this.CaptchaCode);
            this.SetParamSimple(map, prefix + "CheckTicketSum", this.CheckTicketSum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

