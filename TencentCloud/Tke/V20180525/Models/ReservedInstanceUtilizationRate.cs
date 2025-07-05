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

    public class ReservedInstanceUtilizationRate : AbstractModel
    {
        
        /// <summary>
        /// 使用率
        /// </summary>
        [JsonProperty("Rate")]
        public float? Rate{ get; set; }

        /// <summary>
        /// 预留券数量
        /// </summary>
        [JsonProperty("Num")]
        public ulong? Num{ get; set; }

        /// <summary>
        /// 核数
        /// </summary>
        [JsonProperty("CPU")]
        public float? CPU{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        ///  预留券类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// GPU 卡数
        /// </summary>
        [JsonProperty("GpuNum")]
        public string GpuNum{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Pod 数量
        /// </summary>
        [JsonProperty("PodNum")]
        public ulong? PodNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "GpuNum", this.GpuNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
        }
    }
}

