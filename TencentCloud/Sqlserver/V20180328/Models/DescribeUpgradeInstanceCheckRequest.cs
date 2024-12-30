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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUpgradeInstanceCheckRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据库实例ID，形如mssql-njj2mtpl
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例变配后的CPU核心数，不填则不修改
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 实例变配后内存大小，单位GB，不填则不修改
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例变配后磁盘大小，单位GB，不填则不修改
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 实例版本，不填则不修改
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 实例变配后的类型，可选值：CLUSTER-集群，不填则不修改
        /// </summary>
        [JsonProperty("HAType")]
        public string HAType{ get; set; }

        /// <summary>
        /// 实例变配后的跨可用区类型，可选值： SameZones-修改为同可用区 MultiZones-修改为跨可用区，不填则不修改
        /// </summary>
        [JsonProperty("MultiZones")]
        public string MultiZones{ get; set; }

        /// <summary>
        /// 多节点架构实例的备节点可用区，默认为空。如果需要在变配的同时修改指定备节点的可用区时必传，当MultiZones = MultiZones时主节点和备节点可用区不能全部相同。备机可用区集合最小为2个，最大不超过5个。
        /// </summary>
        [JsonProperty("DrZones")]
        public DrZoneInfo[] DrZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "HAType", this.HAType);
            this.SetParamSimple(map, prefix + "MultiZones", this.MultiZones);
            this.SetParamArrayObj(map, prefix + "DrZones.", this.DrZones);
        }
    }
}

