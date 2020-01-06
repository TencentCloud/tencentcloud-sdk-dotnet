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

namespace TencentCloud.Tiems.V20190416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instance : AbstractModel
    {
        
        /// <summary>
        /// 节点 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 节点所在地区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 节点充值类型
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Cpu 核数
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Gpu 核数
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// 节点状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 节点故障信息
        /// </summary>
        [JsonProperty("AbnormalReason")]
        public string AbnormalReason{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("Created")]
        public string Created{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("Updated")]
        public string Updated{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 所属资源组 ID
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 自动续费标签
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 节点所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 当前 Cpu 申请使用量
        /// </summary>
        [JsonProperty("CpuRequested")]
        public ulong? CpuRequested{ get; set; }

        /// <summary>
        /// 当前 Memory 申请使用量
        /// </summary>
        [JsonProperty("MemoryRequested")]
        public ulong? MemoryRequested{ get; set; }

        /// <summary>
        /// 当前 Gpu 申请使用量
        /// </summary>
        [JsonProperty("GpuRequested")]
        public ulong? GpuRequested{ get; set; }

        /// <summary>
        /// 节点所在伸缩组 ID
        /// </summary>
        [JsonProperty("RsgAsGroupId")]
        public string RsgAsGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AbnormalReason", this.AbnormalReason);
            this.SetParamSimple(map, prefix + "Created", this.Created);
            this.SetParamSimple(map, prefix + "Updated", this.Updated);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CpuRequested", this.CpuRequested);
            this.SetParamSimple(map, prefix + "MemoryRequested", this.MemoryRequested);
            this.SetParamSimple(map, prefix + "GpuRequested", this.GpuRequested);
            this.SetParamSimple(map, prefix + "RsgAsGroupId", this.RsgAsGroupId);
        }
    }
}

