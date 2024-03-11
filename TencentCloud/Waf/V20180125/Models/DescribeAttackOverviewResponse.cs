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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAttackOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 访问请求总数
        /// </summary>
        [JsonProperty("AccessCount")]
        public ulong? AccessCount{ get; set; }

        /// <summary>
        /// Web攻击总数
        /// </summary>
        [JsonProperty("AttackCount")]
        public ulong? AttackCount{ get; set; }

        /// <summary>
        /// 访问控制总数
        /// </summary>
        [JsonProperty("ACLCount")]
        public ulong? ACLCount{ get; set; }

        /// <summary>
        /// CC攻击总数
        /// </summary>
        [JsonProperty("CCCount")]
        public ulong? CCCount{ get; set; }

        /// <summary>
        /// Bot攻击总数
        /// </summary>
        [JsonProperty("BotCount")]
        public ulong? BotCount{ get; set; }

        /// <summary>
        /// api资产总数
        /// </summary>
        [JsonProperty("ApiAssetsCount")]
        public ulong? ApiAssetsCount{ get; set; }

        /// <summary>
        /// api风险事件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiRiskEventCount")]
        public ulong? ApiRiskEventCount{ get; set; }

        /// <summary>
        /// 黑名单总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPBlackCount")]
        public ulong? IPBlackCount{ get; set; }

        /// <summary>
        /// 防篡改总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TamperCount")]
        public ulong? TamperCount{ get; set; }

        /// <summary>
        /// 信息泄露总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LeakCount")]
        public ulong? LeakCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessCount", this.AccessCount);
            this.SetParamSimple(map, prefix + "AttackCount", this.AttackCount);
            this.SetParamSimple(map, prefix + "ACLCount", this.ACLCount);
            this.SetParamSimple(map, prefix + "CCCount", this.CCCount);
            this.SetParamSimple(map, prefix + "BotCount", this.BotCount);
            this.SetParamSimple(map, prefix + "ApiAssetsCount", this.ApiAssetsCount);
            this.SetParamSimple(map, prefix + "ApiRiskEventCount", this.ApiRiskEventCount);
            this.SetParamSimple(map, prefix + "IPBlackCount", this.IPBlackCount);
            this.SetParamSimple(map, prefix + "TamperCount", this.TamperCount);
            this.SetParamSimple(map, prefix + "LeakCount", this.LeakCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

