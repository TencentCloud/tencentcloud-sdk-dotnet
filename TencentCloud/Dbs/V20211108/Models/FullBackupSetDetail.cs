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

    public class FullBackupSetDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>备份集 ID。</p>
        /// </summary>
        [JsonProperty("BackupSetId")]
        public string BackupSetId{ get; set; }

        /// <summary>
        /// <p>源实例信息。</p>
        /// </summary>
        [JsonProperty("SourceInfo")]
        public string SourceInfo{ get; set; }

        /// <summary>
        /// <p>备份集状态。可能的取值为："running" - 运行中;"finished" - 已完成;"failed" - 已失败;"stopped" - 已终止。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建时间。格式为 YYYY-MM-DD hh:mm:ss。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间。格式为 YYYY-MM-DD hh:mm:ss，备份集尚未结束时返回 0000-00-00 00:00:00。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>过期时间。格式为 YYYY-MM-DD hh:mm:ss。</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>备份集大小，单位为 Bytes。</p>
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// <p>备份方式。可能的取值为："logical" - 逻辑备份；"physical" - 物理备份。</p>
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// <p>存储类型。目前仅支持 "DBSStorage"，即 DBS 内置存储。</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>备份池类型。目前仅支持 "DefaultPool"，即默认存储池。</p>
        /// </summary>
        [JsonProperty("BackupPool")]
        public string BackupPool{ get; set; }

        /// <summary>
        /// <p>备份集存储类型。支持的取值范围为："standard" - 标准存储；"tiered" - 分级存储。</p>
        /// </summary>
        [JsonProperty("RetentionType")]
        public string RetentionType{ get; set; }

        /// <summary>
        /// <p>备份集存储状态详情。</p>
        /// </summary>
        [JsonProperty("ResourceDetail")]
        public ResourceDetail ResourceDetail{ get; set; }

        /// <summary>
        /// 备份源实例信息。
        /// </summary>
        [JsonProperty("SourceEndpoint")]
        public Endpoint SourceEndpoint{ get; set; }

        /// <summary>
        /// 备份对象。
        /// </summary>
        [JsonProperty("BackupObject")]
        public BackupObject BackupObject{ get; set; }

        /// <summary>
        /// 备份进度。
        /// </summary>
        [JsonProperty("Progress")]
        public FullBackupProgress Progress{ get; set; }

        /// <summary>
        /// 备份错误信息。备份失败时有值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public FullBackupErrorMessage ErrorMessage{ get; set; }

        /// <summary>
        /// 备份集加密信息。
        /// </summary>
        [JsonProperty("BackupSetOption")]
        public BackupSetOption BackupSetOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupSetId", this.BackupSetId);
            this.SetParamSimple(map, prefix + "SourceInfo", this.SourceInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "BackupPool", this.BackupPool);
            this.SetParamSimple(map, prefix + "RetentionType", this.RetentionType);
            this.SetParamObj(map, prefix + "ResourceDetail.", this.ResourceDetail);
            this.SetParamObj(map, prefix + "SourceEndpoint.", this.SourceEndpoint);
            this.SetParamObj(map, prefix + "BackupObject.", this.BackupObject);
            this.SetParamObj(map, prefix + "Progress.", this.Progress);
            this.SetParamObj(map, prefix + "ErrorMessage.", this.ErrorMessage);
            this.SetParamObj(map, prefix + "BackupSetOption.", this.BackupSetOption);
        }
    }
}

