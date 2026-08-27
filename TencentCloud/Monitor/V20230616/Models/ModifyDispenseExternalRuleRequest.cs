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

    public class ModifyDispenseExternalRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 云监控对外命名空间
        /// </summary>
        [JsonProperty("ExtNamespace")]
        public string ExtNamespace{ get; set; }

        /// <summary>
        /// 转发目标消信息
        /// </summary>
        [JsonProperty("Producer")]
        public Producer Producer{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// 转发部署地域列表
        /// </summary>
        [JsonProperty("DispenseRegions")]
        public string[] DispenseRegions{ get; set; }

        /// <summary>
        /// 云监控对外指标
        /// </summary>
        [JsonProperty("ExtMetrics")]
        public string[] ExtMetrics{ get; set; }

        /// <summary>
        /// 指标统计周期
        /// </summary>
        [JsonProperty("Period")]
        public long?[] Period{ get; set; }

        /// <summary>
        /// 转发过滤信息
        /// </summary>
        [JsonProperty("DispenseConditions")]
        public DispenseCondition[] DispenseConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ExtNamespace", this.ExtNamespace);
            this.SetParamObj(map, prefix + "Producer.", this.Producer);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArraySimple(map, prefix + "DispenseRegions.", this.DispenseRegions);
            this.SetParamArraySimple(map, prefix + "ExtMetrics.", this.ExtMetrics);
            this.SetParamArraySimple(map, prefix + "Period.", this.Period);
            this.SetParamArrayObj(map, prefix + "DispenseConditions.", this.DispenseConditions);
        }
    }
}

