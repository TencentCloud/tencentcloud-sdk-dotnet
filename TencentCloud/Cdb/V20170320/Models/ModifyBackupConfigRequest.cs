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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv。与云数据库控制台页面中显示的实例ID相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份文件的保留时间，单位为天。最小值为7天，最大值为1830天。
        /// </summary>
        [JsonProperty("ExpireDays")]
        public long? ExpireDays{ get; set; }

        /// <summary>
        /// (将废弃，建议使用 BackupTimeWindow 参数) 备份时间范围，格式为：02:00-06:00，起点和终点时间目前限制为整点，目前可以选择的范围为： 00:00-12:00，02:00-06:00，06：00-10：00，10:00-14:00，14:00-18:00，18:00-22:00，22:00-02:00。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 自动备份方式，仅支持：physical - 物理冷备
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// binlog的保留时间，单位为天。最小值为7天，最大值为1830天。该值的设置不能大于备份文件的保留时间。
        /// </summary>
        [JsonProperty("BinlogExpireDays")]
        public long? BinlogExpireDays{ get; set; }

        /// <summary>
        /// 备份时间窗，比如要设置每周二和周日 10:00-14:00之间备份，该参数如下：{"Monday": "", "Tuesday": "10:00-14:00", "Wednesday": "", "Thursday": "", "Friday": "", "Saturday": "", "Sunday": "10:00-14:00"}    （注：可以设置一周的某几天备份，但是每天的备份时间需要设置为相同的时间段。 如果设置了该字段，将忽略StartTime字段的设置）
        /// </summary>
        [JsonProperty("BackupTimeWindow")]
        public CommonTimeWindow BackupTimeWindow{ get; set; }

        /// <summary>
        /// 定期保留开关，off - 不开启定期保留策略，on - 开启定期保留策略，默认为off。首次开启定期保留策略时，BackupPeriodSaveDays，BackupPeriodSaveInterval，BackupPeriodSaveCount，StartBackupPeriodSaveDate参数为必填项，否则定期保留策略不会生效
        /// </summary>
        [JsonProperty("EnableBackupPeriodSave")]
        public string EnableBackupPeriodSave{ get; set; }

        /// <summary>
        /// 长期保留开关,该字段功能暂未上线，可忽略。off - 不开启长期保留策略，on - 开启长期保留策略，默认为off，如果开启，则BackupPeriodSaveDays，BackupPeriodSaveInterval，BackupPeriodSaveCount参数无效
        /// </summary>
        [JsonProperty("EnableBackupPeriodLongTermSave")]
        public string EnableBackupPeriodLongTermSave{ get; set; }

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
        /// 日志备份归档起始天数，日志备份达到归档起始天数时进行归档，最小为180天，不得大于日志备份保留天数
        /// </summary>
        [JsonProperty("BinlogArchiveDays")]
        public long? BinlogArchiveDays{ get; set; }

        /// <summary>
        /// 是否开启日志备份归档策略，off-关闭，on-打开，默认为off
        /// </summary>
        [JsonProperty("EnableBinlogArchive")]
        public string EnableBinlogArchive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ExpireDays", this.ExpireDays);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BinlogExpireDays", this.BinlogExpireDays);
            this.SetParamObj(map, prefix + "BackupTimeWindow.", this.BackupTimeWindow);
            this.SetParamSimple(map, prefix + "EnableBackupPeriodSave", this.EnableBackupPeriodSave);
            this.SetParamSimple(map, prefix + "EnableBackupPeriodLongTermSave", this.EnableBackupPeriodLongTermSave);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveDays", this.BackupPeriodSaveDays);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveInterval", this.BackupPeriodSaveInterval);
            this.SetParamSimple(map, prefix + "BackupPeriodSaveCount", this.BackupPeriodSaveCount);
            this.SetParamSimple(map, prefix + "StartBackupPeriodSaveDate", this.StartBackupPeriodSaveDate);
            this.SetParamSimple(map, prefix + "EnableBackupArchive", this.EnableBackupArchive);
            this.SetParamSimple(map, prefix + "BackupArchiveDays", this.BackupArchiveDays);
            this.SetParamSimple(map, prefix + "BinlogArchiveDays", this.BinlogArchiveDays);
            this.SetParamSimple(map, prefix + "EnableBinlogArchive", this.EnableBinlogArchive);
        }
    }
}

