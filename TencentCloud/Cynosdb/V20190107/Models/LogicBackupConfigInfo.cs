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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogicBackupConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启自动逻辑备份</p>
        /// </summary>
        [JsonProperty("LogicBackupEnable")]
        public string LogicBackupEnable{ get; set; }

        /// <summary>
        /// <p>自动逻辑备份开始时间</p>
        /// </summary>
        [JsonProperty("LogicBackupTimeBeg")]
        public ulong? LogicBackupTimeBeg{ get; set; }

        /// <summary>
        /// <p>自动逻辑备份结束时间</p>
        /// </summary>
        [JsonProperty("LogicBackupTimeEnd")]
        public ulong? LogicBackupTimeEnd{ get; set; }

        /// <summary>
        /// <p>自动逻辑备份保留时间<br>单位：秒</p>
        /// </summary>
        [JsonProperty("LogicReserveDuration")]
        public ulong? LogicReserveDuration{ get; set; }

        /// <summary>
        /// <p>是否开启跨地域逻辑备份<br>可选值：ON/OFF</p>
        /// </summary>
        [JsonProperty("LogicCrossRegionsEnable")]
        public string LogicCrossRegionsEnable{ get; set; }

        /// <summary>
        /// <p>逻辑备份所跨地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogicCrossRegions")]
        public string[] LogicCrossRegions{ get; set; }

        /// <summary>
        /// <p>备份投递关系</p>
        /// </summary>
        [JsonProperty("AutoCopyVaults")]
        public CreateBackupVaultItem[] AutoCopyVaults{ get; set; }

        /// <summary>
        /// <p>天</p><p>单位：跨地域逻辑备份保留时间</p>
        /// </summary>
        [JsonProperty("LogicCrossRegionSaveDays")]
        public long? LogicCrossRegionSaveDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogicBackupEnable", this.LogicBackupEnable);
            this.SetParamSimple(map, prefix + "LogicBackupTimeBeg", this.LogicBackupTimeBeg);
            this.SetParamSimple(map, prefix + "LogicBackupTimeEnd", this.LogicBackupTimeEnd);
            this.SetParamSimple(map, prefix + "LogicReserveDuration", this.LogicReserveDuration);
            this.SetParamSimple(map, prefix + "LogicCrossRegionsEnable", this.LogicCrossRegionsEnable);
            this.SetParamArraySimple(map, prefix + "LogicCrossRegions.", this.LogicCrossRegions);
            this.SetParamArrayObj(map, prefix + "AutoCopyVaults.", this.AutoCopyVaults);
            this.SetParamSimple(map, prefix + "LogicCrossRegionSaveDays", this.LogicCrossRegionSaveDays);
        }
    }
}

