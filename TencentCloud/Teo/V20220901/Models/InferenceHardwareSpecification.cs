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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceHardwareSpecification : AbstractModel
    {
        
        /// <summary>
        /// 规格标识。
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 规格名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// CPU 核数。
        /// </summary>
        [JsonProperty("CPUNum")]
        public float? CPUNum{ get; set; }

        /// <summary>
        /// 内存大小。单位为 MB。
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// GPU 卡数。
        /// </summary>
        [JsonProperty("GPUNum")]
        public float? GPUNum{ get; set; }

        /// <summary>
        /// 显存大小。单位为 MB。
        /// </summary>
        [JsonProperty("GPUMemSize")]
        public long? GPUMemSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CPUNum", this.CPUNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "GPUNum", this.GPUNum);
            this.SetParamSimple(map, prefix + "GPUMemSize", this.GPUMemSize);
        }
    }
}

