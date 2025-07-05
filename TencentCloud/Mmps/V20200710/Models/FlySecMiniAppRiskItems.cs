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

namespace TencentCloud.Mmps.V20200710.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlySecMiniAppRiskItems : AbstractModel
    {
        
        /// <summary>
        /// 代码防护(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem1Score")]
        public long? RiskItem1Score{ get; set; }

        /// <summary>
        /// 开发测试信息泄露(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem2Score")]
        public long? RiskItem2Score{ get; set; }

        /// <summary>
        /// 编码规范(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem3Score")]
        public long? RiskItem3Score{ get; set; }

        /// <summary>
        /// 配置风险(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem4Score")]
        public long? RiskItem4Score{ get; set; }

        /// <summary>
        /// 账号安全(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem5Score")]
        public long? RiskItem5Score{ get; set; }

        /// <summary>
        /// 用户信息安全(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem6Score")]
        public long? RiskItem6Score{ get; set; }

        /// <summary>
        /// 内部信息泄露(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem7Score")]
        public long? RiskItem7Score{ get; set; }

        /// <summary>
        /// 其他安全(基础诊断)
        /// </summary>
        [JsonProperty("RiskItem8Score")]
        public long? RiskItem8Score{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskItem1Score", this.RiskItem1Score);
            this.SetParamSimple(map, prefix + "RiskItem2Score", this.RiskItem2Score);
            this.SetParamSimple(map, prefix + "RiskItem3Score", this.RiskItem3Score);
            this.SetParamSimple(map, prefix + "RiskItem4Score", this.RiskItem4Score);
            this.SetParamSimple(map, prefix + "RiskItem5Score", this.RiskItem5Score);
            this.SetParamSimple(map, prefix + "RiskItem6Score", this.RiskItem6Score);
            this.SetParamSimple(map, prefix + "RiskItem7Score", this.RiskItem7Score);
            this.SetParamSimple(map, prefix + "RiskItem8Score", this.RiskItem8Score);
        }
    }
}

