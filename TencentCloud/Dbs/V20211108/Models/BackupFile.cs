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

    public class BackupFile : AbstractModel
    {
        
        /// <summary>
        /// 文件名。
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 备份集 ID。
        /// </summary>
        [JsonProperty("BackupSetId")]
        public string BackupSetId{ get; set; }

        /// <summary>
        /// 文件状态。取值：
        /// - notReady：未就绪
        /// - backuping：备份中
        /// - finished：备份完成
        /// - failed：备份失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 源库连接信息。云数据库实例为实例 ID，其余为 ip:port。
        /// </summary>
        [JsonProperty("SourceInfo")]
        public string SourceInfo{ get; set; }

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
        /// 过期时间。格式为 YYYY-MM-DD hh:mm:ss。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 文件大小，单位：字节。
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// 备份方式。取值：logical（逻辑备份）。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// 存储类型。取值：DBSStorage（内置存储）。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 存储策略类型。取值：
        /// - standard：标准存储
        /// - tiered：分级存储
        /// </summary>
        [JsonProperty("RetentionType")]
        public string RetentionType{ get; set; }

        /// <summary>
        /// 备份集存储详情。
        /// </summary>
        [JsonProperty("ResourceDetail")]
        public ResourceDetail ResourceDetail{ get; set; }

        /// <summary>
        /// 备份池。
        /// </summary>
        [JsonProperty("BackupPool")]
        public string BackupPool{ get; set; }

        /// <summary>
        /// 当前状态下允许的操作。取值：download。
        /// </summary>
        [JsonProperty("AllowedActions")]
        public string[] AllowedActions{ get; set; }

        /// <summary>
        /// 支持的全部操作。
        /// </summary>
        [JsonProperty("AllActions")]
        public string[] AllActions{ get; set; }

        /// <summary>
        /// 文件最后修改时间。格式为 YYYY-MM-DD hh:mm:ss。
        /// </summary>
        [JsonProperty("LastModified")]
        public string LastModified{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "BackupSetId", this.BackupSetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SourceInfo", this.SourceInfo);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "RetentionType", this.RetentionType);
            this.SetParamObj(map, prefix + "ResourceDetail.", this.ResourceDetail);
            this.SetParamSimple(map, prefix + "BackupPool", this.BackupPool);
            this.SetParamArraySimple(map, prefix + "AllowedActions.", this.AllowedActions);
            this.SetParamArraySimple(map, prefix + "AllActions.", this.AllActions);
            this.SetParamSimple(map, prefix + "LastModified", this.LastModified);
        }
    }
}

