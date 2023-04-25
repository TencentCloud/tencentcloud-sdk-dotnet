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

    public class CreateCdbProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// 代理组ID
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// 权重分配模式，
        /// 系统自动分配："system"， 自定义："custom"
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// 是否开启延迟剔除，取值："true" | "false"
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// 最小保留数量，最小取值：0
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// 延迟剔除阈值，最小取值：0
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// 是否开启故障转移，取值："true" | "false"
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// 是否自动添加RO，取值："true" | "false"
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// 是否是只读，取值："true" | "false"
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// 是否开启事务分离，取值："true" | "false"
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// 读写权重分配
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }

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
        /// 是否开启连接池
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

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
        /// 安全组
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
        }
    }
}

