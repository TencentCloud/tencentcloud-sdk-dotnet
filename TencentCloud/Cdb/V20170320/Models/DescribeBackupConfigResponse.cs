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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 自动备份开始的最早时间点，单位为时刻。例如，2 - 凌晨 2:00。（该字段已废弃，建议使用 BackupTimeWindow 字段）
        /// </summary>
        [JsonProperty("StartTimeMin")]
        [System.Obsolete]
        public long? StartTimeMin{ get; set; }

        /// <summary>
        /// 自动备份开始的最晚时间点，单位为时刻。例如，6 - 凌晨 6:00。（该字段已废弃，建议使用 BackupTimeWindow 字段）
        /// </summary>
        [JsonProperty("StartTimeMax")]
        [System.Obsolete]
        public long? StartTimeMax{ get; set; }

        /// <summary>
        /// 备份文件保留时间，单位为天。
        /// </summary>
        [JsonProperty("BackupExpireDays")]
        public long? BackupExpireDays{ get; set; }

        /// <summary>
        /// 备份方式，可能的值为：physical - 物理备份，logical - 逻辑备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// Binlog 文件保留时间，单位为天。
        /// </summary>
        [JsonProperty("BinlogExpireDays")]
        public long? BinlogExpireDays{ get; set; }

        /// <summary>
        /// 实例自动备份的时间窗。
        /// </summary>
        [JsonProperty("BackupTimeWindow")]
        public CommonTimeWindow BackupTimeWindow{ get; set; }

        /// <summary>
        /// 定期保留开关，off - 不开启定期保留策略，on - 开启定期保留策略，默认为off
        /// </summary>
        [JsonProperty("EnableBackupPeriodSave")]
        public string EnableBackupPeriodSave{ get; set; }

        /// <summary>
        /// 定期保留最长天数，最小值：90，最大值：3650，默认值：1080
        /// </summary>
        [JsonProperty("BackupPeriodSaveDays")]
        public long? BackupPeriodSaveDays{ get; set; }

        /// <summary>
        /// 定期保留策略周期，可取值：weekly - 周，monthly - 月， quarterly - 季度，yearly - 年，默认为monthly
        /// </summary>
        [JsonProperty("BackupPeriodSaveInterval")]
        public string BackupPeriodSaveInterval{ get; set; }

        /// <summary>
        /// 定期保留的备份数量，最小值为1，最大值不超过定期保留策略周期内常规备份个数，默认值为1
        /// </summary>
        [JsonProperty("BackupPeriodSaveCount")]
        public long? BackupPeriodSaveCount{ get; set; }

        /// <summary>
        /// 定期保留策略周期起始日期，格式：YYYY-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("StartBackupPeriodSaveDate")]
        public string StartBackupPeriodSaveDate{ get; set; }

        /// <summary>
        /// 是否开启数据备份归档策略，off-关闭，on-打开，默认为off
        /// </summary>
        [JsonProperty("EnableBackupArchive")]
        public string EnableBackupArchive{ get; set; }

        /// <summary>
        /// 数据备份归档起始天数，数据备份达到归档起始天数时进行归档，最小为180天，不得大于数据备份保留天数
        /// </summary>
        [JsonProperty("BackupArchiveDays")]
        public long? BackupArchiveDays{ get; set; }

        /// <summary>
        /// 是否开启日志备份归档策略，off-关闭，on-打开，默认为off
        /// </summary>
        [JsonProperty("EnableBinlogArchive")]
        public string EnableBinlogArchive{ get; set; }

        /// <summary>
        /// 日志备份归档起始天数，日志备份达到归档起始天数时进行归档，最小为180天，不得大于日志备份保留天数
        /// </summary>
        [JsonProperty("BinlogArchiveDays")]
        public long? BinlogArchiveDays{ get; set; }

        /// <summary>
        /// 是否开启数据备份标准存储策略，off-关闭，on-打开，默认为off
        /// </summary>
        [JsonProperty("EnableBackupStandby")]
        public string EnableBackupStandby{ get; set; }

        /// <summary>
        /// 数据备份标准存储起始天数，数据备份达到标准存储起始天数时进行转换，最小为30天，不得大于数据备份保留天数。如果开启备份归档，不得大于等于备份归档天数
        /// </summary>
        [JsonProperty("BackupStandbyDays")]
        public long? BackupStandbyDays{ get; set; }

        /// <summary>
        /// 是否开启日志备份标准存储策略，off-关闭，on-打开，默认为off
        /// </summary>
        [JsonProperty("EnableBinlogStandby")]
        public string EnableBinlogStandby{ get; set; }

        /// <summary>
        /// 日志备份标准存储起始天数，日志备份达到标准存储起始天数时进行转换，最小为30天，不得大于日志备份保留天数。如果开启备份归档，不得大于等于备份归档天数
        /// </summary>
        [JsonProperty("BinlogStandbyDays")]
        public long? BinlogStandbyDays{ get; set; }

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
            this.SetParamSimple(map, prefix + "StartTimeMin", this.StartTimeMin);
            this.SetParamSimple(map, prefix + "StartTimeMax", this.StartTimeMax);
            this.SetParamSimple(map, prefix + "BackupExpireDays", this.BackupExpireDays);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BinlogExpireDays", this.BinlogExpireDays);
            this.SetParamObj(map, prefix + "BackupTimeWindow.", this.BackupTimeWindow);
            this.SetParamSimple(map, prefix + "EnableBackupPeriodSave", this.EnableBackupPeriodSave);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveDays", this.BackupPeriodSaveDays);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveInterval", this.BackupPeriodSaveInterval);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveCount", this.BackupPeriodSaveCount);
            this.SetParamSimple(map, prefix + "StartBackupPeriodSaveDate", this.StartBackupPeriodSaveDate);
            this.SetParamSimple(map, prefix + "EnableBackupArchive", this.EnableBackupArchive);
            this.SetParamSimple(map, prefix + "BackupArchiveDays", this.BackupArchiveDays);
            this.SetParamSimple(map, prefix + "EnableBinlogArchive", this.EnableBinlogArchive);
            this.SetParamSimple(map, prefix + "BinlogArchiveDays", this.BinlogArchiveDays);
            this.SetParamSimple(map, prefix + "EnableBackupStandby", this.EnableBackupStandby);
            this.SetParamSimple(map, prefix + "BackupStandbyDays", this.BackupStandbyDays);
            this.SetParamSimple(map, prefix + "EnableBinlogStandby", this.EnableBinlogStandby);
            this.SetParamSimple(map, prefix + "BinlogStandbyDays", this.BinlogStandbyDays);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

