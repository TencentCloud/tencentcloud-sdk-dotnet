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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopologySpreadConstraint : AbstractModel
    {
        
        /// <summary>
        /// <p>最大偏差值</p>
        /// </summary>
        [JsonProperty("MaxSkew")]
        public long? MaxSkew{ get; set; }

        /// <summary>
        /// <p>拓扑域键</p>
        /// </summary>
        [JsonProperty("TopologyKey")]
        public string TopologyKey{ get; set; }

        /// <summary>
        /// <p>不满足约束时的处理策略</p>
        /// </summary>
        [JsonProperty("WhenUnsatisfiable")]
        public string WhenUnsatisfiable{ get; set; }

        /// <summary>
        /// <p>标签选择器</p>
        /// </summary>
        [JsonProperty("LabelSelector")]
        public LabelSelector LabelSelector{ get; set; }

        /// <summary>
        /// <p>最小拓扑域数量</p>
        /// </summary>
        [JsonProperty("MinDomains")]
        public long? MinDomains{ get; set; }

        /// <summary>
        /// <p>节点亲和性策略</p>
        /// </summary>
        [JsonProperty("NodeAffinityPolicy")]
        public string NodeAffinityPolicy{ get; set; }

        /// <summary>
        /// <p>节点污点策略</p>
        /// </summary>
        [JsonProperty("NodeTaintsPolicy")]
        public string NodeTaintsPolicy{ get; set; }

        /// <summary>
        /// <p>匹配标签键列表</p>
        /// </summary>
        [JsonProperty("MatchLabelKeys")]
        public string[] MatchLabelKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxSkew", this.MaxSkew);
            this.SetParamSimple(map, prefix + "TopologyKey", this.TopologyKey);
            this.SetParamSimple(map, prefix + "WhenUnsatisfiable", this.WhenUnsatisfiable);
            this.SetParamObj(map, prefix + "LabelSelector.", this.LabelSelector);
            this.SetParamSimple(map, prefix + "MinDomains", this.MinDomains);
            this.SetParamSimple(map, prefix + "NodeAffinityPolicy", this.NodeAffinityPolicy);
            this.SetParamSimple(map, prefix + "NodeTaintsPolicy", this.NodeTaintsPolicy);
            this.SetParamArraySimple(map, prefix + "MatchLabelKeys.", this.MatchLabelKeys);
        }
    }
}

