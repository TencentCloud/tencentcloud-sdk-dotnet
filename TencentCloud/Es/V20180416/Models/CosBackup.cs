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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosBackup : AbstractModel
    {
        
        /// <summary>
        /// 是否开启cos自动备份
        /// </summary>
        [JsonProperty("IsAutoBackup")]
        public bool? IsAutoBackup{ get; set; }

        /// <summary>
        /// 自动备份执行时间（精确到小时）, e.g. "22:00"
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// 0 腾讯云仓库; 1 客户仓库
        /// </summary>
        [JsonProperty("EsRepositoryType")]
        public ulong? EsRepositoryType{ get; set; }

        /// <summary>
        /// 客户快照仓库名称
        /// </summary>
        [JsonProperty("UserEsRepository")]
        public string UserEsRepository{ get; set; }

        /// <summary>
        /// 快照存储周期 单位天
        /// </summary>
        [JsonProperty("StorageDuration")]
        public ulong? StorageDuration{ get; set; }

        /// <summary>
        /// 自动备份频率单位小时
        /// </summary>
        [JsonProperty("AutoBackupInterval")]
        public ulong? AutoBackupInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsAutoBackup", this.IsAutoBackup);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "EsRepositoryType", this.EsRepositoryType);
            this.SetParamSimple(map, prefix + "UserEsRepository", this.UserEsRepository);
            this.SetParamSimple(map, prefix + "StorageDuration", this.StorageDuration);
            this.SetParamSimple(map, prefix + "AutoBackupInterval", this.AutoBackupInterval);
        }
    }
}

