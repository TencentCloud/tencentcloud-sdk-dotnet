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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Extenders : AbstractModel
    {
        
        /// <summary>
        /// <p>过滤阶段接口</p>
        /// </summary>
        [JsonProperty("FilterVerb")]
        public string FilterVerb{ get; set; }

        /// <summary>
        /// <p>打分阶段扩展接口</p>
        /// </summary>
        [JsonProperty("PrioritizeVerb")]
        public string PrioritizeVerb{ get; set; }

        /// <summary>
        /// <p>打分阶段节点分数的权重,取值范围限定(0,2】</p>
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// <p>扩展调度器(Extender)管理的扩展资源</p>
        /// </summary>
        [JsonProperty("ManagedResources")]
        public ExtenderManagedResource[] ManagedResources{ get; set; }

        /// <summary>
        /// <p>extender客户端配置</p>
        /// </summary>
        [JsonProperty("ExtenderClientConfig")]
        public ExtenderClientConfig ExtenderClientConfig{ get; set; }

        /// <summary>
        /// <p>抢占接口</p>
        /// </summary>
        [JsonProperty("PreemptVerb")]
        public string PreemptVerb{ get; set; }

        /// <summary>
        /// <p>节点缓存能力</p>
        /// </summary>
        [JsonProperty("NodeCacheCapable")]
        public bool? NodeCacheCapable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterVerb", this.FilterVerb);
            this.SetParamSimple(map, prefix + "PrioritizeVerb", this.PrioritizeVerb);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamArrayObj(map, prefix + "ManagedResources.", this.ManagedResources);
            this.SetParamObj(map, prefix + "ExtenderClientConfig.", this.ExtenderClientConfig);
            this.SetParamSimple(map, prefix + "PreemptVerb", this.PreemptVerb);
            this.SetParamSimple(map, prefix + "NodeCacheCapable", this.NodeCacheCapable);
        }
    }
}

