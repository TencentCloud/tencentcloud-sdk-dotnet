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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupConfigsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：tdsql-c1nl9rpv，与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 常规备份存储时长，范围[1, 3650]。
        /// </summary>
        [JsonProperty("Days")]
        public ulong? Days{ get; set; }

        /// <summary>
        /// 每天备份执行的区间的开始时间，格式 mm:ss，形如 22:00。
        /// </summary>
        [JsonProperty("StartBackupTime")]
        public string StartBackupTime{ get; set; }

        /// <summary>
        /// 每天备份执行的区间的结束时间，格式 mm:ss，形如 23:59。
        /// </summary>
        [JsonProperty("EndBackupTime")]
        public string EndBackupTime{ get; set; }

        /// <summary>
        /// 执行备份周期，枚举值：Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        /// </summary>
        [JsonProperty("WeekDays")]
        public string[] WeekDays{ get; set; }

        /// <summary>
        /// 沉降到归档存储时长，-1表示关闭归档设置。
        /// </summary>
        [JsonProperty("ArchiveDays")]
        public long? ArchiveDays{ get; set; }

        /// <summary>
        /// 超期备份配置。
        /// </summary>
        [JsonProperty("BackupConfigSet")]
        public NewBackupConfig[] BackupConfigSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Days", this.Days);
            this.SetParamSimple(map, prefix + "StartBackupTime", this.StartBackupTime);
            this.SetParamSimple(map, prefix + "EndBackupTime", this.EndBackupTime);
            this.SetParamArraySimple(map, prefix + "WeekDays.", this.WeekDays);
            this.SetParamSimple(map, prefix + "ArchiveDays", this.ArchiveDays);
            this.SetParamArrayObj(map, prefix + "BackupConfigSet.", this.BackupConfigSet);
        }
    }
}

