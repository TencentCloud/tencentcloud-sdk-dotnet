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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadOnlyGroup : AbstractModel
    {
        
        /// <summary>
        /// 只读组标识
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// 只读组名字
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 主实例id
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// 最小保留实例数
        /// </summary>
        [JsonProperty("MinDelayEliminateReserve")]
        public long? MinDelayEliminateReserve{ get; set; }

        /// <summary>
        /// 延迟空间大小阈值。单位MB。
        /// </summary>
        [JsonProperty("MaxReplayLatency")]
        public long? MaxReplayLatency{ get; set; }

        /// <summary>
        /// 延迟大小开关。0 - 关闭； 1 - 开启。
        /// </summary>
        [JsonProperty("ReplayLatencyEliminate")]
        public long? ReplayLatencyEliminate{ get; set; }

        /// <summary>
        /// 延迟时间大小阈值，单位：秒。
        /// </summary>
        [JsonProperty("MaxReplayLag")]
        public float? MaxReplayLag{ get; set; }

        /// <summary>
        /// 延迟时间开关。0 - 关闭； 1 - 开启。
        /// </summary>
        [JsonProperty("ReplayLagEliminate")]
        public long? ReplayLagEliminate{ get; set; }

        /// <summary>
        /// 虚拟网络id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 地域id
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 地区id
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 状态。枚举值：creating、ok、modifying、deleting、deleted
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 实例详细信息
        /// </summary>
        [JsonProperty("ReadOnlyDBInstanceList")]
        public DBInstance[] ReadOnlyDBInstanceList{ get; set; }

        /// <summary>
        /// 自动负载均衡开关
        /// </summary>
        [JsonProperty("Rebalance")]
        public long? Rebalance{ get; set; }

        /// <summary>
        /// 网络信息
        /// </summary>
        [JsonProperty("DBInstanceNetInfo")]
        public DBInstanceNetInfo[] DBInstanceNetInfo{ get; set; }

        /// <summary>
        /// 只读组网络信息列表（此字段已废弃）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkAccessList")]
        public NetworkAccess[] NetworkAccessList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "MinDelayEliminateReserve", this.MinDelayEliminateReserve);
            this.SetParamSimple(map, prefix + "MaxReplayLatency", this.MaxReplayLatency);
            this.SetParamSimple(map, prefix + "ReplayLatencyEliminate", this.ReplayLatencyEliminate);
            this.SetParamSimple(map, prefix + "MaxReplayLag", this.MaxReplayLag);
            this.SetParamSimple(map, prefix + "ReplayLagEliminate", this.ReplayLagEliminate);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "ReadOnlyDBInstanceList.", this.ReadOnlyDBInstanceList);
            this.SetParamSimple(map, prefix + "Rebalance", this.Rebalance);
            this.SetParamArrayObj(map, prefix + "DBInstanceNetInfo.", this.DBInstanceNetInfo);
            this.SetParamArrayObj(map, prefix + "NetworkAccessList.", this.NetworkAccessList);
        }
    }
}

