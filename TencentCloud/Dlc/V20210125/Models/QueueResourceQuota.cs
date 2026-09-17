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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueueResourceQuota : AbstractModel
    {
        
        /// <summary>
        /// <p>资源类型标识。CPU / HM_CPU 类计费项统一映射为 "CU"；GPU 类计费项取卡型简称（如 "T4"、"H20"）</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>资源单位。CU 类为 "core"；GPU 类为 "card"</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>配额总量，由 resource_usage 最大值（index 1）× spec 折算得出</p>
        /// </summary>
        [JsonProperty("Total")]
        public float? Total{ get; set; }

        /// <summary>
        /// 当前已使用量，计费 spec 口径：队列内业务容器（ray-head/ray-worker）的 Pod limits 之和，经 kube_pod_labels 按 local queue 过滤。依赖 kube_pod_labels 指标采集，未开启时恒为 0
        /// </summary>
        [JsonProperty("Used")]
        public float? Used{ get; set; }

        /// <summary>
        /// <p>可用量（总量 - 已使用量，截断至 0）。当 used 超出 total 时（例如配额尚未生效或数据短暂不一致），返回 0 而非负数</p>
        /// </summary>
        [JsonProperty("Available")]
        public float? Available{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Used", this.Used);
            this.SetParamSimple(map, prefix + "Available", this.Available);
        }
    }
}

