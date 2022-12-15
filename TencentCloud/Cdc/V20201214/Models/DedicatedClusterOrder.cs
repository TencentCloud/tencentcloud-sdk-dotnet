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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterOrder : AbstractModel
    {
        
        /// <summary>
        /// 专用集群id
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// 专用集群类型id（移到下一层级，已经废弃，后续将删除）
        /// </summary>
        [JsonProperty("DedicatedClusterTypeId")]
        public string DedicatedClusterTypeId{ get; set; }

        /// <summary>
        /// 支持的存储类型列表（移到下一层级，已经废弃，后续将删除）
        /// </summary>
        [JsonProperty("SupportedStorageType")]
        public string[] SupportedStorageType{ get; set; }

        /// <summary>
        /// 支持的上连交换机的链路传输速率(GiB)（移到下一层级，已经废弃，后续将删除）
        /// </summary>
        [JsonProperty("SupportedUplinkSpeed")]
        public long?[] SupportedUplinkSpeed{ get; set; }

        /// <summary>
        /// 支持的实例族列表（移到下一层级，已经废弃，后续将删除）
        /// </summary>
        [JsonProperty("SupportedInstanceFamily")]
        public string[] SupportedInstanceFamily{ get; set; }

        /// <summary>
        /// 地板承重要求(KG)
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 功率要求(KW)
        /// </summary>
        [JsonProperty("PowerDraw")]
        public float? PowerDraw{ get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// 订单创建的时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 大订单ID
        /// </summary>
        [JsonProperty("DedicatedClusterOrderId")]
        public string DedicatedClusterOrderId{ get; set; }

        /// <summary>
        /// 订单类型，创建CREATE或扩容EXTEND
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 子订单详情列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DedicatedClusterOrderItems")]
        public DedicatedClusterOrderItem[] DedicatedClusterOrderItems{ get; set; }

        /// <summary>
        /// cpu值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// mem值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// gpu值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gpu")]
        public long? Gpu{ get; set; }

        /// <summary>
        /// 0代表未支付，1代表已支付
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayStatus")]
        public long? PayStatus{ get; set; }

        /// <summary>
        /// 支付方式，一次性、按月、按年
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 购买时长的单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 购买时长
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 订单类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "DedicatedClusterTypeId", this.DedicatedClusterTypeId);
            this.SetParamArraySimple(map, prefix + "SupportedStorageType.", this.SupportedStorageType);
            this.SetParamArraySimple(map, prefix + "SupportedUplinkSpeed.", this.SupportedUplinkSpeed);
            this.SetParamArraySimple(map, prefix + "SupportedInstanceFamily.", this.SupportedInstanceFamily);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "PowerDraw", this.PowerDraw);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DedicatedClusterOrderId", this.DedicatedClusterOrderId);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArrayObj(map, prefix + "DedicatedClusterOrderItems.", this.DedicatedClusterOrderItems);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "PayStatus", this.PayStatus);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
        }
    }
}

