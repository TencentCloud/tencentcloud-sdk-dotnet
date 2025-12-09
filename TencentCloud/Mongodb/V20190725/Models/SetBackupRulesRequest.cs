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
        /// 实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
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
        /// 指定每日自动备份频率。
        /// - 12: 每日备份2次，间隔约12小时。
        /// - 24: 每日备份1次（默认），间隔约24小时。
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
        /// 指定备份数据保留时长。
        /// - 单位：天，默认为 7 天。
        /// - 取值范围：[7,365]。
        /// </summary>
        [JsonProperty("BackupRetentionPeriod")]
        public ulong? BackupRetentionPeriod{ get; set; }

        /// <summary>
        /// 指定每周内执行自动备份的具体日期。
        /// - 格式：请输入 0-6 之间的数字代表周日至周六（例如：1 代表周一），多个日期请用英文逗号 , 分隔。
        /// - 示例：输入 1,3,5 表示系统将在每周的周一、周三、周五执行备份。
        /// - 默认值：不设置，则默认为全周期 (0,1,2,3,4,5,6)，即每日执行备份。
        /// </summary>
        [JsonProperty("ActiveWeekdays")]
        public string ActiveWeekdays{ get; set; }

        /// <summary>
        /// 长期保留周期。支持按周或按月选择特定日期的备份（例如，每月1日、15日的备份数据），将其保留更长周期。
        /// - 不开启（默认）：不启用长期保留功能。
        /// - 按周保留： 指定为 weekly。
        /// - 按月保留： 指定为 monthly。
        /// </summary>
        [JsonProperty("LongTermUnit")]
        public string LongTermUnit{ get; set; }

        /// <summary>
        /// 指定用于长期保留的具体备份日期。此设置仅在 **LongTermUnit** 被设为**weekly** 或 **monthly** 时生效。
        /// - 按周（weekly）保留：请输入 0-6 之间的数字来代表周日至周六。多个日期请用英文逗号 , 分隔。
        /// - 按月（monthly）保留：请输入 1-31 之间的数字来代表月份中的具体日期。多个日期请用英文逗号 , 分隔。
        /// </summary>
        [JsonProperty("LongTermActiveDays")]
        public string LongTermActiveDays{ get; set; }

        /// <summary>
        /// 长期备份保留时长。取值范围[30,1075]。
        /// </summary>
        [JsonProperty("LongTermExpiredDays")]
        public long? LongTermExpiredDays{ get; set; }

        /// <summary>
        /// 增量备份保留时长。
        /// - 单位：天。
        /// - 默认值：7天。
        /// - 取值范围：[7,365]。
        /// </summary>
        [JsonProperty("OplogExpiredDays")]
        public long? OplogExpiredDays{ get; set; }

        /// <summary>
        /// 指定备份版本。
        /// - 旧版本备份：0。
        /// - 开启高级备份：1。
        /// </summary>
        [JsonProperty("BackupVersion")]
        public long? BackupVersion{ get; set; }

        /// <summary>
        /// 设置备份数据集存储空间使用率的告警阈值。
        /// - 单位：%。
        /// -  默认值：100。
        /// - 取值范围：[50,300]。
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

