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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstance : AbstractModel
    {
        
        /// <summary>
        /// 预留实例ID
        /// </summary>
        [JsonProperty("ReservedInstanceId")]
        public string ReservedInstanceId{ get; set; }

        /// <summary>
        /// 预留实例名称
        /// </summary>
        [JsonProperty("ReservedInstanceName")]
        public string ReservedInstanceName{ get; set; }

        /// <summary>
        /// 预留券状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 有效期，单位：月
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 抵扣资源类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 资源核数
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 资源内存，单位：Gi
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// 预留券的范围，默认值region。
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonProperty("ActiveAt")]
        public string ActiveAt{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// GPU卡数
        /// </summary>
        [JsonProperty("GpuCount")]
        public string GpuCount{ get; set; }

        /// <summary>
        /// 自动续费标记
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

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
        ///  上个周期预留券的抵扣状态，Deduct、NotDeduct
        /// </summary>
        [JsonProperty("DeductStatus")]
        public string DeductStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReservedInstanceId", this.ReservedInstanceId);
            this.SetParamSimple(map, prefix + "ReservedInstanceName", this.ReservedInstanceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "ActiveAt", this.ActiveAt);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "GpuCount", this.GpuCount);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "DeductStatus", this.DeductStatus);
        }
    }
}

