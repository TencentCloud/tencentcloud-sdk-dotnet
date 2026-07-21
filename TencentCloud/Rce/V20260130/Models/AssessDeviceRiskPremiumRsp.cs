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

    public class AssessDeviceRiskPremiumRsp : AbstractModel
    {
        
        /// <summary>
        /// <p>决策信息</p>
        /// </summary>
        [JsonProperty("Decision")]
        public Decision Decision{ get; set; }

        /// <summary>
        /// <p>设备风险分信息</p>
        /// </summary>
        [JsonProperty("Score")]
        public DataScore Score{ get; set; }

        /// <summary>
        /// <p>设备基础信息</p>
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// <p>IP环境基础信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Environment")]
        public Environment Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Decision.", this.Decision);
            this.SetParamObj(map, prefix + "Score.", this.Score);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamObj(map, prefix + "Environment.", this.Environment);
        }
    }
}

