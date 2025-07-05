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

    public class ModifyIncrementalMigrationRequest : AbstractModel
    {
        
        /// <summary>
        /// 导入目标实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份导入任务ID，由CreateBackupMigration接口返回
        /// </summary>
        [JsonProperty("BackupMigrationId")]
        public string BackupMigrationId{ get; set; }

        /// <summary>
        /// 增量导入任务ID，由CreateIncrementalMigration接口返回
        /// </summary>
        [JsonProperty("IncrementalMigrationId")]
        public string IncrementalMigrationId{ get; set; }

        /// <summary>
        /// 是否需要恢复，NO-不需要，YES-需要，默认不修改增量备份导入任务是否需要恢复的属性。
        /// </summary>
        [JsonProperty("IsRecovery")]
        public string IsRecovery{ get; set; }

        /// <summary>
        /// UploadType是COS_URL时这里时URL，COS_UPLOAD这里填备份文件的名字；只支持1个备份文件，但1个备份文件内可包含多个库
        /// </summary>
        [JsonProperty("BackupFiles")]
        public string[] BackupFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMigrationId", this.BackupMigrationId);
            this.SetParamSimple(map, prefix + "IncrementalMigrationId", this.IncrementalMigrationId);
            this.SetParamSimple(map, prefix + "IsRecovery", this.IsRecovery);
            this.SetParamArraySimple(map, prefix + "BackupFiles.", this.BackupFiles);
        }
    }
}

