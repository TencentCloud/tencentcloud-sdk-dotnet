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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRansomDefenseStateResponse : AbstractModel
    {
        
        /// <summary>
        /// 已开启防御策略数量
        /// </summary>
        [JsonProperty("StrategyCount")]
        public ulong? StrategyCount{ get; set; }

        /// <summary>
        /// 已开启防御机器数
        /// </summary>
        [JsonProperty("MachineCount")]
        public ulong? MachineCount{ get; set; }

        /// <summary>
        /// 快照总容量
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public ulong? SnapshotSize{ get; set; }

        /// <summary>
        /// 恢复备份任务数量
        /// </summary>
        [JsonProperty("RollBackTaskCount")]
        public ulong? RollBackTaskCount{ get; set; }

        /// <summary>
        /// 进行中的创建快照任务数
        /// </summary>
        [JsonProperty("ProgressingSnapshotTaskCount")]
        public ulong? ProgressingSnapshotTaskCount{ get; set; }

        /// <summary>
        /// 进行中的恢复备份任务数
        /// </summary>
        [JsonProperty("ProgressingRollBackTaskCount")]
        public ulong? ProgressingRollBackTaskCount{ get; set; }

        /// <summary>
        /// 机器总数
        /// </summary>
        [JsonProperty("MachineTotal")]
        public ulong? MachineTotal{ get; set; }

        /// <summary>
        /// 策略总数
        /// </summary>
        [JsonProperty("StrategyTotal")]
        public ulong? StrategyTotal{ get; set; }

        /// <summary>
        /// 账户状态：0未欠费，1已欠费
        /// </summary>
        [JsonProperty("BalanceStatus")]
        public ulong? BalanceStatus{ get; set; }

        /// <summary>
        /// 已备份主机数
        /// </summary>
        [JsonProperty("BackupMachineCount")]
        public ulong? BackupMachineCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyCount", this.StrategyCount);
            this.SetParamSimple(map, prefix + "MachineCount", this.MachineCount);
            this.SetParamSimple(map, prefix + "SnapshotSize", this.SnapshotSize);
            this.SetParamSimple(map, prefix + "RollBackTaskCount", this.RollBackTaskCount);
            this.SetParamSimple(map, prefix + "ProgressingSnapshotTaskCount", this.ProgressingSnapshotTaskCount);
            this.SetParamSimple(map, prefix + "ProgressingRollBackTaskCount", this.ProgressingRollBackTaskCount);
            this.SetParamSimple(map, prefix + "MachineTotal", this.MachineTotal);
            this.SetParamSimple(map, prefix + "StrategyTotal", this.StrategyTotal);
            this.SetParamSimple(map, prefix + "BalanceStatus", this.BalanceStatus);
            this.SetParamSimple(map, prefix + "BackupMachineCount", this.BackupMachineCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

