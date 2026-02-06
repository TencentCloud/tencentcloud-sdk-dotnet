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

    public class BackupConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 系统自动时间
        /// </summary>
        [JsonProperty("BackupCustomAutoTime")]
        public bool? BackupCustomAutoTime{ get; set; }

        /// <summary>
        /// 表示全备开始时间，[0-24*3600]， 如0:00, 1:00, 2:00 分别为 0，3600， 7200
        /// </summary>
        [JsonProperty("BackupTimeBeg")]
        public ulong? BackupTimeBeg{ get; set; }

        /// <summary>
        /// 表示全备结束时间，[0-24*3600]， 如0:00, 1:00, 2:00 分别为 0，3600， 7200
        /// </summary>
        [JsonProperty("BackupTimeEnd")]
        public ulong? BackupTimeEnd{ get; set; }

        /// <summary>
        /// 该参数目前不支持修改，无需填写。备份频率，长度为7的数组，分别对应周日到周六的备份方式，full-全量备份，increment-增量备份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupWeekDays")]
        public string[] BackupWeekDays{ get; set; }

        /// <summary>
        /// 间隔时间
        /// </summary>
        [JsonProperty("BackupIntervalTime")]
        public long? BackupIntervalTime{ get; set; }

        /// <summary>
        /// 表示保留备份时长, 单位秒，超过该时间将被清理, 七天表示为3600247=604800，最大为158112000
        /// </summary>
        [JsonProperty("ReserveDuration")]
        public ulong? ReserveDuration{ get; set; }

        /// <summary>
        /// 跨地域备份开启
        /// yes-开启
        /// no-关闭
        /// </summary>
        [JsonProperty("CrossRegionsEnable")]
        public string CrossRegionsEnable{ get; set; }

        /// <summary>
        /// 跨地域备份地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrossRegions")]
        public string[] CrossRegions{ get; set; }

        /// <summary>
        /// 动数据备份触发策略，periodically:自动周期备份,frequent:高频备份
        /// </summary>
        [JsonProperty("BackupTriggerStrategy")]
        public string BackupTriggerStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupCustomAutoTime", this.BackupCustomAutoTime);
            this.SetParamSimple(map, prefix + "BackupTimeBeg", this.BackupTimeBeg);
            this.SetParamSimple(map, prefix + "BackupTimeEnd", this.BackupTimeEnd);
            this.SetParamArraySimple(map, prefix + "BackupWeekDays.", this.BackupWeekDays);
            this.SetParamSimple(map, prefix + "BackupIntervalTime", this.BackupIntervalTime);
            this.SetParamSimple(map, prefix + "ReserveDuration", this.ReserveDuration);
            this.SetParamSimple(map, prefix + "CrossRegionsEnable", this.CrossRegionsEnable);
            this.SetParamArraySimple(map, prefix + "CrossRegions.", this.CrossRegions);
            this.SetParamSimple(map, prefix + "BackupTriggerStrategy", this.BackupTriggerStrategy);
        }
    }
}

