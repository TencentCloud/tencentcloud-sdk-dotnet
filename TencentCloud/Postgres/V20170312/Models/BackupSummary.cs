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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupSummary : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 实例日志备份数量。
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// 实例日志备份大小。
        /// </summary>
        [JsonProperty("LogBackupSize")]
        public ulong? LogBackupSize{ get; set; }

        /// <summary>
        /// 手动创建的实例数据备份数量。
        /// </summary>
        [JsonProperty("ManualBaseBackupCount")]
        public ulong? ManualBaseBackupCount{ get; set; }

        /// <summary>
        /// 手动创建的实例数据备份大小。
        /// </summary>
        [JsonProperty("ManualBaseBackupSize")]
        public ulong? ManualBaseBackupSize{ get; set; }

        /// <summary>
        /// 自动创建的实例数据备份数量。
        /// </summary>
        [JsonProperty("AutoBaseBackupCount")]
        public ulong? AutoBaseBackupCount{ get; set; }

        /// <summary>
        /// 自动创建的实例数据备份大小。
        /// </summary>
        [JsonProperty("AutoBaseBackupSize")]
        public ulong? AutoBaseBackupSize{ get; set; }

        /// <summary>
        /// 总备份数量
        /// </summary>
        [JsonProperty("TotalBackupCount")]
        public ulong? TotalBackupCount{ get; set; }

        /// <summary>
        /// 总备份大小
        /// </summary>
        [JsonProperty("TotalBackupSize")]
        public ulong? TotalBackupSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSize", this.LogBackupSize);
            this.SetParamSimple(map, prefix + "ManualBaseBackupCount", this.ManualBaseBackupCount);
            this.SetParamSimple(map, prefix + "ManualBaseBackupSize", this.ManualBaseBackupSize);
            this.SetParamSimple(map, prefix + "AutoBaseBackupCount", this.AutoBaseBackupCount);
            this.SetParamSimple(map, prefix + "AutoBaseBackupSize", this.AutoBaseBackupSize);
            this.SetParamSimple(map, prefix + "TotalBackupCount", this.TotalBackupCount);
            this.SetParamSimple(map, prefix + "TotalBackupSize", this.TotalBackupSize);
        }
    }
}

