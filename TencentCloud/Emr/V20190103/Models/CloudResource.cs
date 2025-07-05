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

    public class CloudResource : AbstractModel
    {
        
        /// <summary>
        /// 组件角色名
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// pod请求数量
        /// </summary>
        [JsonProperty("PodNumber")]
        public long? PodNumber{ get; set; }

        /// <summary>
        /// Cpu请求数量最大值
        /// </summary>
        [JsonProperty("LimitCpu")]
        public long? LimitCpu{ get; set; }

        /// <summary>
        /// 内存请求数量最大值
        /// </summary>
        [JsonProperty("LimitMemory")]
        public long? LimitMemory{ get; set; }

        /// <summary>
        /// 服务名称，如HIVE
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 数据卷目录设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeDir")]
        public VolumeSetting VolumeDir{ get; set; }

        /// <summary>
        /// 组件外部访问设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExternalAccess")]
        public ExternalAccess ExternalAccess{ get; set; }

        /// <summary>
        /// 节点亲和性设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Affinity")]
        public NodeAffinity Affinity{ get; set; }

        /// <summary>
        /// 所选数据盘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Disks")]
        public Disk[] Disks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "PodNumber", this.PodNumber);
            this.SetParamSimple(map, prefix + "LimitCpu", this.LimitCpu);
            this.SetParamSimple(map, prefix + "LimitMemory", this.LimitMemory);
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamObj(map, prefix + "VolumeDir.", this.VolumeDir);
            this.SetParamObj(map, prefix + "ExternalAccess.", this.ExternalAccess);
            this.SetParamObj(map, prefix + "Affinity.", this.Affinity);
            this.SetParamArrayObj(map, prefix + "Disks.", this.Disks);
        }
    }
}

