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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupDownloadTask : AbstractModel
    {
        
        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 备份文件名。
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 分片名称。
        /// </summary>
        [JsonProperty("ReplicaSetId")]
        public string ReplicaSetId{ get; set; }

        /// <summary>
        /// 备份数据大小，单位：字节。
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// 任务状态。
        /// - 0：等待执行。
        /// - 1：正在下载。
        /// - 2：下载完成。
        /// - 3：下载失败。
        /// - 4：等待重试。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务进度百分比。
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

        /// <summary>
        /// 耗时，单位为秒。
        /// </summary>
        [JsonProperty("TimeSpend")]
        public long? TimeSpend{ get; set; }

        /// <summary>
        /// 备份数据下载链接。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 备份方式。
        /// - 0：逻辑备份。
        /// - 1：物理备份。
        /// - 3：快照备份。
        /// **说明**:
        /// 1. 通用版实例支持逻辑备份与物理备份。云盘版实例支持物理备份与快照备份，暂不支持逻辑备份。
        /// 2. 实例开通存储加密，则备份方式不能为物理备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public long? BackupMethod{ get; set; }

        /// <summary>
        /// 发起备份时指定的备注信息。
        /// </summary>
        [JsonProperty("BackupDesc")]
        public string BackupDesc{ get; set; }

        /// <summary>
        /// 地区信息。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Bucket信息。
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "ReplicaSetId", this.ReplicaSetId);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "TimeSpend", this.TimeSpend);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupDesc", this.BackupDesc);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
        }
    }
}

