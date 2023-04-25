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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyAddress : AbstractModel
    {
        
        /// <summary>
        /// 代理组地址ID
        /// </summary>
        [JsonProperty("ProxyAddressId")]
        public string ProxyAddressId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 私有子网ID
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("VPort")]
        public ulong? VPort{ get; set; }

        /// <summary>
        /// 权重分配模式；
        /// 系统自动分配："system"， 自定义："custom"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// 是否开启延迟剔除，取值："true" | "false"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// 最小保留数量，最小取值：0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// 延迟剔除阈值，最小取值：0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// 是否自动添加RO，取值："true" | "false"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// 是否是只读，取值："true" | "false"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// 是否开启事务分离
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// 是否开启故障转移
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// 是否开启连接池
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 实例读权重分配
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyAddressId", this.ProxyAddressId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
        }
    }
}

