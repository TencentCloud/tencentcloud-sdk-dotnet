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

    public class DescribeBackupMigrationRequest : AbstractModel
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
        /// 导入任务名称
        /// </summary>
        [JsonProperty("MigrationName")]
        public string MigrationName{ get; set; }

        /// <summary>
        /// 备份文件名称
        /// </summary>
        [JsonProperty("BackupFileName")]
        public string BackupFileName{ get; set; }

        /// <summary>
        /// 导入任务状态集合
        /// </summary>
        [JsonProperty("StatusSet")]
        public long?[] StatusSet{ get; set; }

        /// <summary>
        /// 导入任务恢复类型，FULL,FULL_LOG,FULL_DIFF
        /// </summary>
        [JsonProperty("RecoveryType")]
        public string RecoveryType{ get; set; }

        /// <summary>
        /// COS_URL-备份放在用户的对象存储上，提供URL。COS_UPLOAD-备份放在业务的对象存储上，用户上传
        /// </summary>
        [JsonProperty("UploadType")]
        public string UploadType{ get; set; }

        /// <summary>
        /// 分页，页大小，默认值：100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页，页数，默认值：0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序字段，name；createTime；startTime；endTime，默认按照createTime递增排序。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式，desc-递减排序，asc-递增排序。默认按照asc排序，且在OrderBy为有效值时，本参数有效
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupMigrationId", this.BackupMigrationId);
            this.SetParamSimple(map, prefix + "MigrationName", this.MigrationName);
            this.SetParamSimple(map, prefix + "BackupFileName", this.BackupFileName);
            this.SetParamArraySimple(map, prefix + "StatusSet.", this.StatusSet);
            this.SetParamSimple(map, prefix + "RecoveryType", this.RecoveryType);
            this.SetParamSimple(map, prefix + "UploadType", this.UploadType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

