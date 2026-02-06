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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupRulesResponse : AbstractModel
    {
        
        /// <summary>
        /// 备份数据保留期限。单位为：天。
        /// </summary>
        [JsonProperty("BackupSaveTime")]
        public ulong? BackupSaveTime{ get; set; }

        /// <summary>
        /// 备份频率。备份时间间隔，单位小时。取值12，24
        /// </summary>
        [JsonProperty("BackupFrequency")]
        public long? BackupFrequency{ get; set; }

        /// <summary>
        /// 自动备份开始时间。
        /// </summary>
        [JsonProperty("BackupTime")]
        public ulong? BackupTime{ get; set; }

        /// <summary>
        /// 备份方式。
        /// - 0：逻辑备份。
        /// - 1：物理备份。
        /// - 3：快照备份。
        /// **说明**:
        /// 1. 通用版实例支持逻辑备份与物理备份。云盘版实例支持物理备份与快照备份，暂不支持逻辑备份。
        /// 2. 实例开通存储加密，则备份方式不能为物理备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public ulong? BackupMethod{ get; set; }

        /// <summary>
        /// 周几备份，0-6，逗号分割
        /// </summary>
        [JsonProperty("ActiveWeekdays")]
        public string ActiveWeekdays{ get; set; }

        /// <summary>
        /// 长期备份周期。weekly-按周，monthly-按月，空不开启。
        /// </summary>
        [JsonProperty("LongTermInterval")]
        public string LongTermInterval{ get; set; }

        /// <summary>
        /// 长期备份的日期，周0-6，月1-31
        /// </summary>
        [JsonProperty("LongTermActiveDays")]
        public string LongTermActiveDays{ get; set; }

        /// <summary>
        /// 长期备份保留时间
        /// </summary>
        [JsonProperty("LongTermExpiredDays")]
        public long? LongTermExpiredDays{ get; set; }

        /// <summary>
        /// 增量备份保留时间
        /// </summary>
        [JsonProperty("OplogExpiredDays")]
        public long? OplogExpiredDays{ get; set; }

        /// <summary>
        /// 备份版本号。0-旧备份方式，1-高级备份
        /// </summary>
        [JsonProperty("BackupVersion")]
        public long? BackupVersion{ get; set; }

        /// <summary>
        /// 备份大小
        /// </summary>
        [JsonProperty("BackupTotalSize")]
        public BackupTotalSize BackupTotalSize{ get; set; }

        /// <summary>
        /// 告警额度
        /// </summary>
        [JsonProperty("AlertThreshold")]
        public long? AlertThreshold{ get; set; }

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
            this.SetParamSimple(map, prefix + "BackupSaveTime", this.BackupSaveTime);
            this.SetParamSimple(map, prefix + "BackupFrequency", this.BackupFrequency);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "ActiveWeekdays", this.ActiveWeekdays);
            this.SetParamSimple(map, prefix + "LongTermInterval", this.LongTermInterval);
            this.SetParamSimple(map, prefix + "LongTermActiveDays", this.LongTermActiveDays);
            this.SetParamSimple(map, prefix + "LongTermExpiredDays", this.LongTermExpiredDays);
            this.SetParamSimple(map, prefix + "OplogExpiredDays", this.OplogExpiredDays);
            this.SetParamSimple(map, prefix + "BackupVersion", this.BackupVersion);
            this.SetParamObj(map, prefix + "BackupTotalSize.", this.BackupTotalSize);
            this.SetParamSimple(map, prefix + "AlertThreshold", this.AlertThreshold);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

