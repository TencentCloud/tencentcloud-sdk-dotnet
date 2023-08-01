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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlotSharingGroupSpec : AbstractModel
    {
        
        /// <summary>
        /// 适用的cpu
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CPU")]
        public float? CPU{ get; set; }

        /// <summary>
        /// 默认为b, 支持单位有 b, kb, mb, gb
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeapMemory")]
        public string HeapMemory{ get; set; }

        /// <summary>
        /// 默认为b, 支持单位有 b, kb, mb, gb
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OffHeapMemory")]
        public string OffHeapMemory{ get; set; }

        /// <summary>
        /// 默认为b, 支持单位有 b, kb, mb, gb
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManagedMemory")]
        public string ManagedMemory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "HeapMemory", this.HeapMemory);
            this.SetParamSimple(map, prefix + "OffHeapMemory", this.OffHeapMemory);
            this.SetParamSimple(map, prefix + "ManagedMemory", this.ManagedMemory);
        }
    }
}

