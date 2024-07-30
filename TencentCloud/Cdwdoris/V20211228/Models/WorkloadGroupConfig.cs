/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// 资源组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkloadGroupName")]
        public string WorkloadGroupName{ get; set; }

        /// <summary>
        /// CPU权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuShare")]
        public long? CpuShare{ get; set; }

        /// <summary>
        /// 内存限制，所有资源组的内存限制值之和应该小于等于100
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public long? MemoryLimit{ get; set; }

        /// <summary>
        /// 是否允许超配分配
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableMemoryOverCommit")]
        public bool? EnableMemoryOverCommit{ get; set; }

        /// <summary>
        /// cpu硬限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuHardLimit")]
        public string CpuHardLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkloadGroupName", this.WorkloadGroupName);
            this.SetParamSimple(map, prefix + "CpuShare", this.CpuShare);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "EnableMemoryOverCommit", this.EnableMemoryOverCommit);
            this.SetParamSimple(map, prefix + "CpuHardLimit", this.CpuHardLimit);
        }
    }
}

