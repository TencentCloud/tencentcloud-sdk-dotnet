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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PaymentResult : AbstractModel
    {
        
        /// <summary>
        /// <p>支付状态</p><p>枚举值：</p><ul><li>success： 成功</li><li>failure： 失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>支付失败原因</p>
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// <p>是否使用3DS，枚举值：</p><ul><li>是：true</li><li>否：false</li></ul>
        /// </summary>
        [JsonProperty("ThreeDomainSecure")]
        public bool? ThreeDomainSecure{ get; set; }

        /// <summary>
        /// <p>ECI返回码</p>
        /// </summary>
        [JsonProperty("ECICode")]
        public string ECICode{ get; set; }

        /// <summary>
        /// <p>AVS响应结果（地址验证）</p>
        /// </summary>
        [JsonProperty("AVSCode")]
        public string AVSCode{ get; set; }

        /// <summary>
        /// <p>CVC验证结果（交易真实性验证）</p>
        /// </summary>
        [JsonProperty("CVCCode")]
        public string CVCCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "ThreeDomainSecure", this.ThreeDomainSecure);
            this.SetParamSimple(map, prefix + "ECICode", this.ECICode);
            this.SetParamSimple(map, prefix + "AVSCode", this.AVSCode);
            this.SetParamSimple(map, prefix + "CVCCode", this.CVCCode);
        }
    }
}

