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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApiSecSensitiveRuleListResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>api敏感规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Data")]
        public ApiSecSensitiveRule[] Data{ get; set; }

        /// <summary>
        /// <p>规则数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// <p>自定义敏感检测规则总开关</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>非内置规则的rulename列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleNameList")]
        public string[] RuleNameList{ get; set; }

        /// <summary>
        /// <p>api提取规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiExtractRule")]
        public ApiSecExtractRule[] ApiExtractRule{ get; set; }

        /// <summary>
        /// <p>api鉴权规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiSecPrivilegeRule")]
        public ApiSecPrivilegeRule[] ApiSecPrivilegeRule{ get; set; }

        /// <summary>
        /// <p>api场景规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiSecSceneRule")]
        public ApiSecSceneRule[] ApiSecSceneRule{ get; set; }

        /// <summary>
        /// <p>自定义事件规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiSecCustomEventRule")]
        public ApiSecCustomEventRule[] ApiSecCustomEventRule{ get; set; }

        /// <summary>
        /// <p>无效api排除规则列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiExcludeRule")]
        public ApiSecExcludeRule[] ApiExcludeRule{ get; set; }

        /// <summary>
        /// <p>敏感数据加白规则列表</p>
        /// </summary>
        [JsonProperty("ApiSecSensitiveWhiteRule")]
        public ApiSecSensitiveWhiteRule[] ApiSecSensitiveWhiteRule{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "RuleNameList.", this.RuleNameList);
            this.SetParamArrayObj(map, prefix + "ApiExtractRule.", this.ApiExtractRule);
            this.SetParamArrayObj(map, prefix + "ApiSecPrivilegeRule.", this.ApiSecPrivilegeRule);
            this.SetParamArrayObj(map, prefix + "ApiSecSceneRule.", this.ApiSecSceneRule);
            this.SetParamArrayObj(map, prefix + "ApiSecCustomEventRule.", this.ApiSecCustomEventRule);
            this.SetParamArrayObj(map, prefix + "ApiExcludeRule.", this.ApiExcludeRule);
            this.SetParamArrayObj(map, prefix + "ApiSecSensitiveWhiteRule.", this.ApiSecSensitiveWhiteRule);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

