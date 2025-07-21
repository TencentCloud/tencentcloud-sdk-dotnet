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

namespace TencentCloud.Ctsdb.V20230202.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Spec : AbstractModel
    {
        
        /// <summary>
        /// 1：包年包月、2：按小时计费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 请求单元，为0则表示走资源配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestUnit")]
        public ulong? RequestUnit{ get; set; }

        /// <summary>
        /// CPU 核数最大限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuLimit")]
        public float? CpuLimit{ get; set; }

        /// <summary>
        /// 内存 最大限制(Gi)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public float? MemoryLimit{ get; set; }

        /// <summary>
        /// 磁盘 最大限制(Gi)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskLimit")]
        public ulong? DiskLimit{ get; set; }

        /// <summary>
        /// 业务分片数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Shards")]
        public ulong? Shards{ get; set; }

        /// <summary>
        /// 业务节点数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replicas")]
        public ulong? Replicas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RequestUnit", this.RequestUnit);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "DiskLimit", this.DiskLimit);
            this.SetParamSimple(map, prefix + "Shards", this.Shards);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
        }
    }
}

