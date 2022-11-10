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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HyperParameter : AbstractModel
    {
        
        /// <summary>
        /// 最大nnz数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxNNZ")]
        public string MaxNNZ{ get; set; }

        /// <summary>
        /// slot数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SlotNum")]
        public string SlotNum{ get; set; }

        /// <summary>
        /// gpu cache 使用率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuCachePercentage")]
        public string CpuCachePercentage{ get; set; }

        /// <summary>
        /// cpu cache 使用率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuCachePercentage")]
        public string GpuCachePercentage{ get; set; }

        /// <summary>
        /// 是否开启分布式模式(true/false)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableDistributed")]
        public string EnableDistributed{ get; set; }

        /// <summary>
        /// TORCH_SCRIPT、MMDETECTION、DETECTRON2、HUGGINGFACE格式在进行优化时切分子图的最小算子数目，一般无需进行改动，默认为3
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinBlockSizePt")]
        public string MinBlockSizePt{ get; set; }

        /// <summary>
        /// FROZEN_GRAPH、SAVED_MODEL格式在进行优化时切分子图的最小算子数目，一般无需进行改动，默认为10
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinBlockSizeTf")]
        public string MinBlockSizeTf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxNNZ", this.MaxNNZ);
            this.SetParamSimple(map, prefix + "SlotNum", this.SlotNum);
            this.SetParamSimple(map, prefix + "CpuCachePercentage", this.CpuCachePercentage);
            this.SetParamSimple(map, prefix + "GpuCachePercentage", this.GpuCachePercentage);
            this.SetParamSimple(map, prefix + "EnableDistributed", this.EnableDistributed);
            this.SetParamSimple(map, prefix + "MinBlockSizePt", this.MinBlockSizePt);
            this.SetParamSimple(map, prefix + "MinBlockSizeTf", this.MinBlockSizeTf);
        }
    }
}

