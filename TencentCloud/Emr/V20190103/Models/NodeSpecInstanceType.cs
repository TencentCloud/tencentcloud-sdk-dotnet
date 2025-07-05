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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeSpecInstanceType : AbstractModel
    {
        
        /// <summary>
        /// 规格
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 4
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 8，单位G
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 排序，越小排的越前
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 售罄原因
        /// </summary>
        [JsonProperty("SellOutReason")]
        public string SellOutReason{ get; set; }

        /// <summary>
        /// 系统盘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemDisk")]
        public NodeSpecDisk[] SystemDisk{ get; set; }

        /// <summary>
        /// 数据盘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDisk")]
        public NodeSpecDisk[] DataDisk{ get; set; }

        /// <summary>
        /// 本地数据盘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDataDisk")]
        public NodeSpecDisk[] LocalDataDisk{ get; set; }

        /// <summary>
        /// 售罄原因
        /// </summary>
        [JsonProperty("SoldOutReason")]
        public string SoldOutReason{ get; set; }

        /// <summary>
        /// 机型类别
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 类别名称
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 类别分类
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }

        /// <summary>
        /// cpu类型
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 售罄 RunOut、库存少 Less、充足 Enough
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [JsonProperty("OriginPrice")]
        public float? OriginPrice{ get; set; }

        /// <summary>
        /// 包销计费机型支持的购买时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrepaidUnderwritePeriods")]
        public long?[] PrepaidUnderwritePeriods{ get; set; }

        /// <summary>
        /// GPU信息
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "SellOutReason", this.SellOutReason);
            this.SetParamArrayObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamArrayObj(map, prefix + "LocalDataDisk.", this.LocalDataDisk);
            this.SetParamSimple(map, prefix + "SoldOutReason", this.SoldOutReason);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "FamilyName", this.FamilyName);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OriginPrice", this.OriginPrice);
            this.SetParamArraySimple(map, prefix + "PrepaidUnderwritePeriods.", this.PrepaidUnderwritePeriods);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
        }
    }
}

