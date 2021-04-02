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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReadOnlyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 主实例ID
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// 只读组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 延迟时间大小开关：0关、1开
        /// </summary>
        [JsonProperty("ReplayLagEliminate")]
        public ulong? ReplayLagEliminate{ get; set; }

        /// <summary>
        /// 延迟空间大小开关： 0关、1开
        /// </summary>
        [JsonProperty("ReplayLatencyEliminate")]
        public ulong? ReplayLatencyEliminate{ get; set; }

        /// <summary>
        /// 延迟时间大小阈值，单位ms
        /// </summary>
        [JsonProperty("MaxReplayLag")]
        public ulong? MaxReplayLag{ get; set; }

        /// <summary>
        /// 延迟空间大小阈值，单位MB
        /// </summary>
        [JsonProperty("MaxReplayLatency")]
        public ulong? MaxReplayLatency{ get; set; }

        /// <summary>
        /// 延迟剔除最小保留实例数
        /// </summary>
        [JsonProperty("MinDelayEliminateReserve")]
        public ulong? MinDelayEliminateReserve{ get; set; }

        /// <summary>
        /// 安全组id
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ReplayLagEliminate", this.ReplayLagEliminate);
            this.SetParamSimple(map, prefix + "ReplayLatencyEliminate", this.ReplayLatencyEliminate);
            this.SetParamSimple(map, prefix + "MaxReplayLag", this.MaxReplayLag);
            this.SetParamSimple(map, prefix + "MaxReplayLatency", this.MaxReplayLatency);
            this.SetParamSimple(map, prefix + "MinDelayEliminateReserve", this.MinDelayEliminateReserve);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

