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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupProgress : AbstractModel
    {
        
        /// <summary>
        /// 全量备份状态。
        /// </summary>
        [JsonProperty("FullBackupStatus")]
        public string FullBackupStatus{ get; set; }

        /// <summary>
        /// 增量备份状态。
        /// </summary>
        [JsonProperty("IncrementBackupStatus")]
        public string IncrementBackupStatus{ get; set; }

        /// <summary>
        /// 上次备份执行时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未执行过备份时为空字符串。
        /// </summary>
        [JsonProperty("LastBackupTime")]
        public string LastBackupTime{ get; set; }

        /// <summary>
        /// 下次备份执行时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未确定时为空字符串。
        /// </summary>
        [JsonProperty("NextBackupTime")]
        public string NextBackupTime{ get; set; }

        /// <summary>
        /// 上次恢复时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未执行过恢复时为空字符串。
        /// </summary>
        [JsonProperty("LastRestoreTime")]
        public string LastRestoreTime{ get; set; }

        /// <summary>
        /// 上次恢复任务状态。
        /// </summary>
        [JsonProperty("LastRestoreStatus")]
        public string LastRestoreStatus{ get; set; }

        /// <summary>
        /// 当前备份作业状态。
        /// </summary>
        [JsonProperty("CurrentBackupJobStatus")]
        public string CurrentBackupJobStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullBackupStatus", this.FullBackupStatus);
            this.SetParamSimple(map, prefix + "IncrementBackupStatus", this.IncrementBackupStatus);
            this.SetParamSimple(map, prefix + "LastBackupTime", this.LastBackupTime);
            this.SetParamSimple(map, prefix + "NextBackupTime", this.NextBackupTime);
            this.SetParamSimple(map, prefix + "LastRestoreTime", this.LastRestoreTime);
            this.SetParamSimple(map, prefix + "LastRestoreStatus", this.LastRestoreStatus);
            this.SetParamSimple(map, prefix + "CurrentBackupJobStatus", this.CurrentBackupJobStatus);
        }
    }
}

