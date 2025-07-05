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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackupMigrationRequest : AbstractModel
    {
        
        /// <summary>
        /// 导入目标实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 迁移任务恢复类型，FULL-全量备份恢复，FULL_LOG-全量备份+事务日志恢复，FULL_DIFF-全量备份+差异备份恢复
        /// </summary>
        [JsonProperty("RecoveryType")]
        public string RecoveryType{ get; set; }

        /// <summary>
        /// 备份上传类型，COS_URL-备份放在用户的对象存储上，提供URL。COS_UPLOAD-备份放在业务的对象存储上，需要用户上传。
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("MigrationName")]
        public string MigrationName{ get; set; }

        /// <summary>
        /// UploadType是COS_URL时这里填URL，COS_UPLOAD这里填备份文件的名字。只支持1个备份文件，但1个备份文件内可包含多个库
        /// </summary>
        [JsonProperty("BackupFiles")]
        public string[] BackupFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RecoveryType", this.RecoveryType);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamSimple(map, prefix + "MigrationName", this.MigrationName);
            this.SetParamArraySimple(map, prefix + "BackupFiles.", this.BackupFiles);
        }
    }
}

