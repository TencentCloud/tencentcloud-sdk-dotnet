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
        /// 整机备份点总数
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }

        /// <summary>
        /// 创建中数量
        /// </summary>
        [JsonProperty("CreatingBackupCount")]
        public long? CreatingBackupCount{ get; set; }

        /// <summary>
        /// 失败数量
        /// </summary>
        [JsonProperty("FailedBackupCount")]
        public long? FailedBackupCount{ get; set; }

        /// <summary>
        /// 已完成数量
        /// </summary>
        [JsonProperty("SuccessBackupCount")]
        public long? SuccessBackupCount{ get; set; }

        /// <summary>
        /// 恢复中的总数量
        /// </summary>
        [JsonProperty("RestoringBackupCount")]
        public long? RestoringBackupCount{ get; set; }

        /// <summary>
        /// 整机备份总容量
        /// </summary>
        [JsonProperty("BackupSizeMb")]
        public long? BackupSizeMb{ get; set; }

        /// <summary>
        /// 受保护 CVM 资源数
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

