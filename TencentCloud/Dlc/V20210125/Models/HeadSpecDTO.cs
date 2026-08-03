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

    public class HeadSpecDTO : AbstractModel
    {
        
        /// <summary>
        /// <p>head/worker名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Pod CPU核数</p>
        /// </summary>
        [JsonProperty("PodCpu")]
        public long? PodCpu{ get; set; }

        /// <summary>
        /// <p>Pod 内存大小</p>
        /// </summary>
        [JsonProperty("PodMem")]
        public long? PodMem{ get; set; }

        /// <summary>
        /// <p>GPU类型</p>
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// <p>GPU数量</p>
        /// </summary>
        [JsonProperty("GpuNum")]
        public long? GpuNum{ get; set; }

        /// <summary>
        /// <p>环境变量列表</p>
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// <p>资源标签列表（用于追加到 headGroupSpec/workerGroupSpec 的 resources map 中，对应 Ray/K8s 的自定义资源声明），Value 必须为字符串形式的整数</p>
        /// </summary>
        [JsonProperty("ResourcesLabels")]
        public Label[] ResourcesLabels{ get; set; }

        /// <summary>
        /// <p>Pod数量</p>
        /// </summary>
        [JsonProperty("PodNum")]
        public long? PodNum{ get; set; }

        /// <summary>
        /// <p>是否支持高级可用</p>
        /// </summary>
        [JsonProperty("HighAvailability")]
        public bool? HighAvailability{ get; set; }

        /// <summary>
        /// <p>资源类型,CPU,GPU</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>机型</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>规格数量</p>
        /// </summary>
        [JsonProperty("Spec")]
        public long? Spec{ get; set; }

        /// <summary>
        /// <p>资源ID(唯一)</p>
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PodCpu", this.PodCpu);
            this.SetParamSimple(map, prefix + "PodMem", this.PodMem);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "GpuNum", this.GpuNum);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "ResourcesLabels.", this.ResourcesLabels);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
            this.SetParamSimple(map, prefix + "HighAvailability", this.HighAvailability);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "BillingItem", this.BillingItem);
        }
    }
}

