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

    public class IncrementBackup : AbstractModel
    {
        
        /// <summary>
        /// 备份集 ID。
        /// </summary>
        [JsonProperty("BackupSetId")]
        public string BackupSetId{ get; set; }

        /// <summary>
        /// 源实例信息。
        /// </summary>
        [JsonProperty("SourceInfo")]
        public string SourceInfo{ get; set; }

        /// <summary>
        /// 备份集状态。可能的取值为：
        /// "running" - 运行中;
        /// "finished" - 已完成;
        /// "failed" - 已失败;
        /// "stopped" - 已终止。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 开始时间。格式为 YYYY-MM-DD hh:mm:ss。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。格式为 YYYY-MM-DD hh:mm:ss，备份集尚未结束时返回 0000-00-00 00:00:00。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 过期时间。格式为 YYYY-MM-DD hh:mm:ss，备份集尚未生成过期时间时返回空字符串。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 备份集文件个数。
        /// </summary>
        [JsonProperty("FileCount")]
        public long? FileCount{ get; set; }

        /// <summary>
        /// 备份方式。可能的取值为：
        /// "logical" - 逻辑备份；
        /// "physical" - 物理备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 存储类型。目前仅支持 "DBSStorage"，即 DBS 内置存储。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 备份池类型。目前仅支持 "DefaultPool"，即默认存储池。
        /// </summary>
        [JsonProperty("BackupPool")]
        public string BackupPool{ get; set; }

        /// <summary>
        /// 备份集存储类型。支持的取值范围为："standard" - 标准存储；"tiered" - 分级存储。
        /// </summary>
        [JsonProperty("RetentionType")]
        public string RetentionType{ get; set; }

        /// <summary>
        /// 备份集存储状态详情。
        /// </summary>
        [JsonProperty("ResourceDetail")]
        public ResourceItemDetail ResourceDetail{ get; set; }


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
            this.SetParamSimple(map, prefix + "FileCount", this.FileCount);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "BackupPool", this.BackupPool);
            this.SetParamSimple(map, prefix + "RetentionType", this.RetentionType);
            this.SetParamObj(map, prefix + "ResourceDetail.", this.ResourceDetail);
        }
    }
}

