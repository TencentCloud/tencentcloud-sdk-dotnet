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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileBackupOverview : AbstractModel
    {
        
        /// <summary>
        /// <p>备份点总数</p>
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }

        /// <summary>
        /// <p>创建中数量</p>
        /// </summary>
        [JsonProperty("CreatingBackupCount")]
        public long? CreatingBackupCount{ get; set; }

        /// <summary>
        /// <p>失败数量</p>
        /// </summary>
        [JsonProperty("FailedBackupCount")]
        public long? FailedBackupCount{ get; set; }

        /// <summary>
        /// <p>已完成数量</p>
        /// </summary>
        [JsonProperty("SuccessBackupCount")]
        public long? SuccessBackupCount{ get; set; }

        /// <summary>
        /// <p>恢复中的总数量</p>
        /// </summary>
        [JsonProperty("RestoringBackupCount")]
        public long? RestoringBackupCount{ get; set; }

        /// <summary>
        /// <p>备份总容量</p>
        /// </summary>
        [JsonProperty("BackupSizeMb")]
        public long? BackupSizeMb{ get; set; }

        /// <summary>
        /// <p>受保护资源数</p>
        /// </summary>
        [JsonProperty("BackupResourceCount")]
        public long? BackupResourceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
            this.SetParamSimple(map, prefix + "CreatingBackupCount", this.CreatingBackupCount);
            this.SetParamSimple(map, prefix + "FailedBackupCount", this.FailedBackupCount);
            this.SetParamSimple(map, prefix + "SuccessBackupCount", this.SuccessBackupCount);
            this.SetParamSimple(map, prefix + "RestoringBackupCount", this.RestoringBackupCount);
            this.SetParamSimple(map, prefix + "BackupSizeMb", this.BackupSizeMb);
            this.SetParamSimple(map, prefix + "BackupResourceCount", this.BackupResourceCount);
        }
    }
}

