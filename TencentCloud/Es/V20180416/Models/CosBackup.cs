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
        /// 备份快照前缀
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 0 腾讯云仓库; 1 客户仓库
        /// </summary>
        [JsonProperty("EsRepositoryType")]
        public ulong? EsRepositoryType{ get; set; }

        /// <summary>
        /// 托管快照仓库名称
        /// </summary>
        [JsonProperty("PaasEsRepository")]
        public string PaasEsRepository{ get; set; }

        /// <summary>
        /// 客户快照仓库名称
        /// </summary>
        [JsonProperty("UserEsRepository")]
        public string UserEsRepository{ get; set; }

        /// <summary>
        /// cos存储文件夹目录
        /// </summary>
        [JsonProperty("CosBasePath")]
        public string CosBasePath{ get; set; }

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
        /// 备份锁定 0 不锁定; 1 锁定
        /// </summary>
        [JsonProperty("CosRetention")]
        public ulong? CosRetention{ get; set; }

        /// <summary>
        /// 锁定截止日期 2022-12-10T08:34:48.000Z
        /// </summary>
        [JsonProperty("RetainUntilDate")]
        public string RetainUntilDate{ get; set; }

        /// <summary>
        /// 锁定宽限期
        /// </summary>
        [JsonProperty("RetentionGraceTime")]
        public ulong? RetentionGraceTime{ get; set; }

        /// <summary>
        /// 跨地域备份 0 不跨地域; 1 跨地域
        /// </summary>
        [JsonProperty("RemoteCos")]
        public ulong? RemoteCos{ get; set; }

        /// <summary>
        /// 跨地域备份地域名称 ap-guangzhou
        /// </summary>
        [JsonProperty("RemoteCosRegion")]
        public string RemoteCosRegion{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("StrategyName")]
        public string StrategyName{ get; set; }

        /// <summary>
        /// 备份索引列表，如果不填表示备份所有索引
        /// </summary>
        [JsonProperty("Indices")]
        public string Indices{ get; set; }

        /// <summary>
        /// cos多AZ备份 0 单AZ; 1 多AZ
        /// </summary>
        [JsonProperty("MultiAz")]
        public ulong? MultiAz{ get; set; }

        /// <summary>
        /// 策略创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsAutoBackup", this.IsAutoBackup);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "EsRepositoryType", this.EsRepositoryType);
            this.SetParamSimple(map, prefix + "PaasEsRepository", this.PaasEsRepository);
            this.SetParamSimple(map, prefix + "UserEsRepository", this.UserEsRepository);
            this.SetParamSimple(map, prefix + "CosBasePath", this.CosBasePath);
            this.SetParamSimple(map, prefix + "StorageDuration", this.StorageDuration);
            this.SetParamSimple(map, prefix + "AutoBackupInterval", this.AutoBackupInterval);
            this.SetParamSimple(map, prefix + "CosRetention", this.CosRetention);
            this.SetParamSimple(map, prefix + "RetainUntilDate", this.RetainUntilDate);
            this.SetParamSimple(map, prefix + "RetentionGraceTime", this.RetentionGraceTime);
            this.SetParamSimple(map, prefix + "RemoteCos", this.RemoteCos);
            this.SetParamSimple(map, prefix + "RemoteCosRegion", this.RemoteCosRegion);
            this.SetParamSimple(map, prefix + "StrategyName", this.StrategyName);
            this.SetParamSimple(map, prefix + "Indices", this.Indices);
            this.SetParamSimple(map, prefix + "MultiAz", this.MultiAz);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

