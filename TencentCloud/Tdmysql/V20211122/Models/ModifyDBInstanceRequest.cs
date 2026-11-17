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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>是否仅做预检查，不实际执行变配。true: 仅返回变配计划和预检查结果；false: 实际执行变配（默认）</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>对等节点CPU核数，不传则保持当前值不变</p>
        /// </summary>
        [JsonProperty("HybridNodeCpu")]
        public long? HybridNodeCpu{ get; set; }

        /// <summary>
        /// <p>对等节点内存大小，单位GB，不传则保持当前值不变</p>
        /// </summary>
        [JsonProperty("HybridNodeMem")]
        public long? HybridNodeMem{ get; set; }

        /// <summary>
        /// <p>对等节点数量，不传则保持当前值不变</p>
        /// </summary>
        [JsonProperty("HybridNodeNum")]
        public long? HybridNodeNum{ get; set; }

        /// <summary>
        /// <p>对等节点磁盘容量，单位GB，不传则保持当前值不变</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>存储类型，可选值：CLOUD_HSSD（增强型SSD云硬盘）、CLOUD_TCS（本地盘）、CLOUD_BSSD（通用型SSD云硬盘），不传则保持当前值不变</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>规格编码，如 4c8g、16c32g 等</p>
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>目标可用区列表，不传则保持当前值不变</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>可用区模式，1: 单可用区，3: 多可用区主AZ模式</p>
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>主可用区，AZMode传3时生效</p>
        /// </summary>
        [JsonProperty("PrimaryAZ")]
        public string PrimaryAZ{ get; set; }

        /// <summary>
        /// <p>全功能型副本数，取值范围1-3</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "HybridNodeCpu", this.HybridNodeCpu);
            this.SetParamSimple(map, prefix + "HybridNodeMem", this.HybridNodeMem);
            this.SetParamSimple(map, prefix + "HybridNodeNum", this.HybridNodeNum);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "PrimaryAZ", this.PrimaryAZ);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
        }
    }
}

