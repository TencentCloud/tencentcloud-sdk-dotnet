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

    public class SetBackupRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id，例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

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
        /// 设置自动备份开始时间。取值范围为：[0,23]，例如：该参数设置为2，表示02:00开始备份。
        /// </summary>
        [JsonProperty("BackupTime")]
        public ulong? BackupTime{ get; set; }

        /// <summary>
        /// 自动备份频率，内部展示，默认取值为24h。
        /// </summary>
        [JsonProperty("BackupFrequency")]
        public ulong? BackupFrequency{ get; set; }

        /// <summary>
        /// 设置自动备份发生错误时，是否发送失败告警。
        /// - true：发送。
        /// - false：不发送。
        /// </summary>
        [JsonProperty("Notify")]
        public bool? Notify{ get; set; }

        /// <summary>
        /// 指定备份数据保存天数。默认为 7 天，支持设置为7、30、90、180、365。
        /// </summary>
        [JsonProperty("BackupRetentionPeriod")]
        public ulong? BackupRetentionPeriod{ get; set; }

        /// <summary>
        /// 周几备份，0-6，逗号分割。仅对高级备份生效
        /// </summary>
        [JsonProperty("ActiveWeekdays")]
        public string ActiveWeekdays{ get; set; }

        /// <summary>
        /// 长期保留周期，周weekly，月monthly，空不开启
        /// </summary>
        [JsonProperty("LongTermUnit")]
        public string LongTermUnit{ get; set; }

        /// <summary>
        /// 长期保留哪些天的，周0-6，月1-31，逗号分割
        /// </summary>
        [JsonProperty("LongTermActiveDays")]
        public string LongTermActiveDays{ get; set; }

        /// <summary>
        /// 长期备份保留多少天
        /// </summary>
        [JsonProperty("LongTermExpiredDays")]
        public long? LongTermExpiredDays{ get; set; }

        /// <summary>
        /// 增量保留多少天
        /// </summary>
        [JsonProperty("OplogExpiredDays")]
        public long? OplogExpiredDays{ get; set; }

        /// <summary>
        /// 备份版本。旧版本备份为0，高级备份为1。开启高级备份此值传1
        /// </summary>
        [JsonProperty("BackupVersion")]
        public long? BackupVersion{ get; set; }

        /// <summary>
        /// 告警额度。50-300
        /// </summary>
        [JsonProperty("AlarmWaterLevel")]
        public long? AlarmWaterLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "BackupFrequency", this.BackupFrequency);
            this.SetParamSimple(map, prefix + "Notify", this.Notify);
            this.SetParamSimple(map, prefix + "BackupRetentionPeriod", this.BackupRetentionPeriod);
            this.SetParamSimple(map, prefix + "ActiveWeekdays", this.ActiveWeekdays);
            this.SetParamSimple(map, prefix + "LongTermUnit", this.LongTermUnit);
            this.SetParamSimple(map, prefix + "LongTermActiveDays", this.LongTermActiveDays);
            this.SetParamSimple(map, prefix + "LongTermExpiredDays", this.LongTermExpiredDays);
            this.SetParamSimple(map, prefix + "OplogExpiredDays", this.OplogExpiredDays);
            this.SetParamSimple(map, prefix + "BackupVersion", this.BackupVersion);
            this.SetParamSimple(map, prefix + "AlarmWaterLevel", this.AlarmWaterLevel);
        }
    }
}

