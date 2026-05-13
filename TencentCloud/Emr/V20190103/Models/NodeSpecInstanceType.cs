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
        /// <p>规格</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>4</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>8，单位G</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>排序，越小排的越前</p>
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// <p>数量</p>
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// <p>售罄原因</p>
        /// </summary>
        [JsonProperty("SellOutReason")]
        public string SellOutReason{ get; set; }

        /// <summary>
        /// <p>系统盘</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemDisk")]
        public NodeSpecDisk[] SystemDisk{ get; set; }

        /// <summary>
        /// <p>数据盘</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDisk")]
        public NodeSpecDisk[] DataDisk{ get; set; }

        /// <summary>
        /// <p>本地数据盘</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalDataDisk")]
        public NodeSpecDisk[] LocalDataDisk{ get; set; }

        /// <summary>
        /// <p>售罄原因</p>
        /// </summary>
        [JsonProperty("SoldOutReason")]
        public string SoldOutReason{ get; set; }

        /// <summary>
        /// <p>机型类别</p>
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// <p>节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>节点类型</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>类别</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>类别名称</p>
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// <p>类别分类</p>
        /// </summary>
        [JsonProperty("FamilyName")]
        public string FamilyName{ get; set; }

        /// <summary>
        /// <p>cpu类型</p>
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// <p>售罄 RunOut、库存少 Less、充足 Enough</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>原价</p>
        /// </summary>
        [JsonProperty("OriginPrice")]
        public float? OriginPrice{ get; set; }

        /// <summary>
        /// <p>包销计费机型支持的购买时长</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrepaidUnderwritePeriods")]
        public long?[] PrepaidUnderwritePeriods{ get; set; }

        /// <summary>
        /// <p>GPU信息</p>
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }

        /// <summary>
        /// <p>配额数量</p>
        /// </summary>
        [JsonProperty("QuotaNum")]
        public long? QuotaNum{ get; set; }

        /// <summary>
        /// <p>配额单位</p>
        /// </summary>
        [JsonProperty("QuotaUnit")]
        public string QuotaUnit{ get; set; }


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
            this.SetParamSimple(map, prefix + "QuotaNum", this.QuotaNum);
            this.SetParamSimple(map, prefix + "QuotaUnit", this.QuotaUnit);
        }
    }
}

