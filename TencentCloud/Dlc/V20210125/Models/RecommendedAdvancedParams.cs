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

    public class RecommendedAdvancedParams : AbstractModel
    {
        
        /// <summary>
        /// <p>是否启用 trust_remote_code</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRemoteCode")]
        public bool? EnableRemoteCode{ get; set; }

        /// <summary>
        /// <p>GPU 显存利用率（百分比，例如 90 表示 90%）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuMemoryUtilization")]
        public long? GpuMemoryUtilization{ get; set; }

        /// <summary>
        /// <p>Tensor 并行度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TensorParallelSize")]
        public long? TensorParallelSize{ get; set; }

        /// <summary>
        /// <p>Pipeline 并行度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PipelineParallelSize")]
        public long? PipelineParallelSize{ get; set; }

        /// <summary>
        /// <p>Data 并行度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataParallelSize")]
        public long? DataParallelSize{ get; set; }

        /// <summary>
        /// <p>推理引擎参数列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineArgs")]
        public RecommendedKeyValue[] EngineArgs{ get; set; }

        /// <summary>
        /// <p>环境变量列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvVars")]
        public RecommendedKeyValue[] EnvVars{ get; set; }

        /// <summary>
        /// <p>Ray Actor Options 列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RayOptions")]
        public RecommendedKeyValue[] RayOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableRemoteCode", this.EnableRemoteCode);
            this.SetParamSimple(map, prefix + "GpuMemoryUtilization", this.GpuMemoryUtilization);
            this.SetParamSimple(map, prefix + "TensorParallelSize", this.TensorParallelSize);
            this.SetParamSimple(map, prefix + "PipelineParallelSize", this.PipelineParallelSize);
            this.SetParamSimple(map, prefix + "DataParallelSize", this.DataParallelSize);
            this.SetParamArrayObj(map, prefix + "EngineArgs.", this.EngineArgs);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamArrayObj(map, prefix + "RayOptions.", this.RayOptions);
        }
    }
}

