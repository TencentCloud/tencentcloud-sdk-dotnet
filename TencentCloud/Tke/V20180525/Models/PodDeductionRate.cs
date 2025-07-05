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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodDeductionRate : AbstractModel
    {
        
        /// <summary>
        /// Pod的 CPU
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// Pod 的内存
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        ///  Pod 的类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        ///  Pod 的 GPU 卡数，Pod 类型为 GPU 时有效。
        /// </summary>
        [JsonProperty("GpuNum")]
        public string GpuNum{ get; set; }

        /// <summary>
        /// 这种规格的 Pod总数
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 这种规格的 Pod被预留券抵扣的数量
        /// </summary>
        [JsonProperty("DeductionNum")]
        public ulong? DeductionNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GpuNum", this.GpuNum);
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamSimple(map, prefix + "DeductionNum", this.DeductionNum);
        }
    }
}

