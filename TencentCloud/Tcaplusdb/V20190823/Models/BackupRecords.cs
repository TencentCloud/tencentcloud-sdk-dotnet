/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupRecords : AbstractModel
    {
        
        /// <summary>
        /// 表格组ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 备份源
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 文件标签：TCAPLUS_FULL或OSDATA
        /// </summary>
        [JsonProperty("FileTag")]
        public string FileTag{ get; set; }

        /// <summary>
        /// 分片数量
        /// </summary>
        [JsonProperty("ShardCount")]
        public ulong? ShardCount{ get; set; }

        /// <summary>
        /// 备份批次日期
        /// </summary>
        [JsonProperty("BackupBatchTime")]
        public string BackupBatchTime{ get; set; }

        /// <summary>
        /// 备份文件汇总大小
        /// </summary>
        [JsonProperty("BackupFileSize")]
        public ulong? BackupFileSize{ get; set; }

        /// <summary>
        /// 备份成功率
        /// </summary>
        [JsonProperty("BackupSuccRate")]
        public string BackupSuccRate{ get; set; }

        /// <summary>
        /// 备份文件过期时间
        /// </summary>
        [JsonProperty("BackupExpireTime")]
        public string BackupExpireTime{ get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "FileTag", this.FileTag);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamSimple(map, prefix + "BackupBatchTime", this.BackupBatchTime);
            this.SetParamSimple(map, prefix + "BackupFileSize", this.BackupFileSize);
            this.SetParamSimple(map, prefix + "BackupSuccRate", this.BackupSuccRate);
            this.SetParamSimple(map, prefix + "BackupExpireTime", this.BackupExpireTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

