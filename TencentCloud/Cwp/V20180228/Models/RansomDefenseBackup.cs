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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RansomDefenseBackup : AbstractModel
    {
        
        /// <summary>
        /// 备份时间
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// 勒索状态：0无告警, 1有告警
        /// </summary>
        [JsonProperty("EventStatus")]
        public ulong? EventStatus{ get; set; }

        /// <summary>
        /// 备份状态：0备份中，1正常，2、3失败，4快照已过期，5快照数量超出限制，9快照已删除
        /// </summary>
        [JsonProperty("BackupStatus")]
        public ulong? BackupStatus{ get; set; }

        /// <summary>
        /// 备份磁盘数量
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// 硬盘信息，；分隔
        /// </summary>
        [JsonProperty("Disks")]
        public string Disks{ get; set; }

        /// <summary>
        /// 快照列表，；分隔
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string SnapshotIds{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("StrategyId")]
        public ulong? StrategyId{ get; set; }

        /// <summary>
        /// 策略状态:0关闭，1开启，9已删除
        /// </summary>
        [JsonProperty("StrategyStatus")]
        public ulong? StrategyStatus{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "BackupStatus", this.BackupStatus);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "Disks", this.Disks);
            this.SetParamSimple(map, prefix + "SnapshotIds", this.SnapshotIds);
            this.SetParamSimple(map, prefix + "StrategyId", this.StrategyId);
            this.SetParamSimple(map, prefix + "StrategyStatus", this.StrategyStatus);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
        }
    }
}

