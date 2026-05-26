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

    public class DynamicInstanceGroupSpec : AbstractModel
    {
        
        /// <summary>
        /// group 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// pod 数量
        /// </summary>
        [JsonProperty("PodCount")]
        public long? PodCount{ get; set; }

        /// <summary>
        /// 最小节点数
        /// </summary>
        [JsonProperty("MinNodes")]
        public long? MinNodes{ get; set; }

        /// <summary>
        /// 最大节点数
        /// </summary>
        [JsonProperty("MaxNodes")]
        public long? MaxNodes{ get; set; }

        /// <summary>
        ///  是否开启存储配置
        /// </summary>
        [JsonProperty("StorageConfigEnabled")]
        public bool? StorageConfigEnabled{ get; set; }

        /// <summary>
        /// headGroup:head;
        /// workerGroup:worker
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// CPU 核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存(GB)
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// GPU类型
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// GPU核数
        /// </summary>
        [JsonProperty("Gpu")]
        public long? Gpu{ get; set; }

        /// <summary>
        /// 资源标签
        /// </summary>
        [JsonProperty("ResourceLabels")]
        public string ResourceLabels{ get; set; }

        /// <summary>
        /// 环境变量
        /// </summary>
        [JsonProperty("Env")]
        public NameValue[] Env{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Labels")]
        public NameValue[] Labels{ get; set; }

        /// <summary>
        /// 容忍度
        /// </summary>
        [JsonProperty("Tolerations")]
        public Toleration[] Tolerations{ get; set; }

        /// <summary>
        /// 调度策略
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 卷目录
        /// </summary>
        [JsonProperty("PersistentVolume")]
        public PersistentVolume PersistentVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "MinNodes", this.MinNodes);
            this.SetParamSimple(map, prefix + "MaxNodes", this.MaxNodes);
            this.SetParamSimple(map, prefix + "StorageConfigEnabled", this.StorageConfigEnabled);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "ResourceLabels", this.ResourceLabels);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Tolerations.", this.Tolerations);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamObj(map, prefix + "PersistentVolume.", this.PersistentVolume);
        }
    }
}

