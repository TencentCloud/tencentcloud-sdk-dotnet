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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GPUParams : AbstractModel
    {
        
        /// <summary>
        /// GPU驱动版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Driver")]
        public string Driver{ get; set; }

        /// <summary>
        /// CUDA版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CUDA")]
        public string CUDA{ get; set; }

        /// <summary>
        /// CUDNN版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CUDNN")]
        public string CUDNN{ get; set; }

        /// <summary>
        /// 是否启用MIG特性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MIGEnable")]
        public bool? MIGEnable{ get; set; }

        /// <summary>
        /// 是否启用Fabric特性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fabric")]
        public bool? Fabric{ get; set; }

        /// <summary>
        /// 自定义驱动下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomGPUDriver")]
        public string CustomGPUDriver{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Driver", this.Driver);
            this.SetParamSimple(map, prefix + "CUDA", this.CUDA);
            this.SetParamSimple(map, prefix + "CUDNN", this.CUDNN);
            this.SetParamSimple(map, prefix + "MIGEnable", this.MIGEnable);
            this.SetParamSimple(map, prefix + "Fabric", this.Fabric);
            this.SetParamSimple(map, prefix + "CustomGPUDriver", this.CustomGPUDriver);
        }
    }
}

