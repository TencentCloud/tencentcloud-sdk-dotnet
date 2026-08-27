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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Rule : AbstractModel
    {
        
        /// <summary>
        /// 规则Id
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 对外namespace
        /// </summary>
        [JsonProperty("ExtNamespace")]
        public string ExtNamespace{ get; set; }

        /// <summary>
        /// 对外指标列表
        /// </summary>
        [JsonProperty("ExtMetric")]
        public ExtMetric[] ExtMetric{ get; set; }

        /// <summary>
        /// 输出信息
        /// </summary>
        [JsonProperty("Producer")]
        public Producer Producer{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 规则触发状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 指标粒度周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Period")]
        public long?[] Period{ get; set; }

        /// <summary>
        /// 转发过滤条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DispenseConditions")]
        public DispenseCondition[] DispenseConditions{ get; set; }

        /// <summary>
        /// 转发地域列表
        /// </summary>
        [JsonProperty("DispenseRegions")]
        public string[] DispenseRegions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ExtNamespace", this.ExtNamespace);
            this.SetParamArrayObj(map, prefix + "ExtMetric.", this.ExtMetric);
            this.SetParamObj(map, prefix + "Producer.", this.Producer);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Period.", this.Period);
            this.SetParamArrayObj(map, prefix + "DispenseConditions.", this.DispenseConditions);
            this.SetParamArraySimple(map, prefix + "DispenseRegions.", this.DispenseRegions);
        }
    }
}

