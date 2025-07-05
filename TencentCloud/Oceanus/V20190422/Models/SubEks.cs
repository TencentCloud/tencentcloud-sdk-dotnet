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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubEks : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SerialId")]
        public string SerialId{ get; set; }

        /// <summary>
        /// cu数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CuNum")]
        public long? CuNum{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 状态描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 运行cu
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// 总的CPU
        /// </summary>
        [JsonProperty("TotalCpu")]
        public float? TotalCpu{ get; set; }

        /// <summary>
        /// 总的内存
        /// </summary>
        [JsonProperty("TotalMem")]
        public float? TotalMem{ get; set; }

        /// <summary>
        /// 运行的CPU
        /// </summary>
        [JsonProperty("RunningCpu")]
        public float? RunningCpu{ get; set; }

        /// <summary>
        /// 运行的内存
        /// </summary>
        [JsonProperty("RunningMem")]
        public float? RunningMem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SerialId", this.SerialId);
            this.SetParamSimple(map, prefix + "CuNum", this.CuNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamSimple(map, prefix + "TotalCpu", this.TotalCpu);
            this.SetParamSimple(map, prefix + "TotalMem", this.TotalMem);
            this.SetParamSimple(map, prefix + "RunningCpu", this.RunningCpu);
            this.SetParamSimple(map, prefix + "RunningMem", this.RunningMem);
        }
    }
}

