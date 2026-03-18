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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVaultsItem : AbstractModel
    {
        
        /// <summary>
        /// 保险箱ID
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// 保险箱名称
        /// </summary>
        [JsonProperty("VaultName")]
        public string VaultName{ get; set; }

        /// <summary>
        /// 保险箱描述
        /// </summary>
        [JsonProperty("VaultDescribe")]
        public string VaultDescribe{ get; set; }

        /// <summary>
        /// 加密密钥ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 密钥所在地域
        /// </summary>
        [JsonProperty("KeyRegion")]
        public string KeyRegion{ get; set; }

        /// <summary>
        /// 密钥类型
        /// </summary>
        [JsonProperty("KeyType")]
        public string KeyType{ get; set; }

        /// <summary>
        /// 备份文件数量
        /// </summary>
        [JsonProperty("BackupFileCount")]
        public long? BackupFileCount{ get; set; }

        /// <summary>
        /// 备份文件总大小（字节）
        /// </summary>
        [JsonProperty("BackupFileSize")]
        public long? BackupFileSize{ get; set; }

        /// <summary>
        /// Binlog文件数量
        /// </summary>
        [JsonProperty("BinlogFileCount")]
        public long? BinlogFileCount{ get; set; }

        /// <summary>
        /// Binlog文件总大小（字节）
        /// </summary>
        [JsonProperty("BinlogFileSize")]
        public long? BinlogFileSize{ get; set; }

        /// <summary>
        /// RedoLog文件数量
        /// </summary>
        [JsonProperty("RedoLogFileCount")]
        public long? RedoLogFileCount{ get; set; }

        /// <summary>
        /// RedoLog文件总大小（字节）
        /// </summary>
        [JsonProperty("RedoLogFileSize")]
        public long? RedoLogFileSize{ get; set; }

        /// <summary>
        /// 保险箱状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 备份保留时长（秒）
        /// </summary>
        [JsonProperty("BackupSaveSeconds")]
        public long? BackupSaveSeconds{ get; set; }

        /// <summary>
        /// 锁定时间
        /// </summary>
        [JsonProperty("LockedTime")]
        public string LockedTime{ get; set; }

        /// <summary>
        /// 关联任务列表
        /// </summary>
        [JsonProperty("Tasks")]
        public ObjectTask[] Tasks{ get; set; }

        /// <summary>
        /// 保险箱所在地域
        /// </summary>
        [JsonProperty("VaultRegion")]
        public string VaultRegion{ get; set; }

        /// <summary>
        /// 自动投递关系
        /// </summary>
        [JsonProperty("AutoCopyConfigs")]
        public AutoCopyConfig[] AutoCopyConfigs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamSimple(map, prefix + "VaultName", this.VaultName);
            this.SetParamSimple(map, prefix + "VaultDescribe", this.VaultDescribe);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyRegion", this.KeyRegion);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "BackupFileCount", this.BackupFileCount);
            this.SetParamSimple(map, prefix + "BackupFileSize", this.BackupFileSize);
            this.SetParamSimple(map, prefix + "BinlogFileCount", this.BinlogFileCount);
            this.SetParamSimple(map, prefix + "BinlogFileSize", this.BinlogFileSize);
            this.SetParamSimple(map, prefix + "RedoLogFileCount", this.RedoLogFileCount);
            this.SetParamSimple(map, prefix + "RedoLogFileSize", this.RedoLogFileSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BackupSaveSeconds", this.BackupSaveSeconds);
            this.SetParamSimple(map, prefix + "LockedTime", this.LockedTime);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "VaultRegion", this.VaultRegion);
            this.SetParamArrayObj(map, prefix + "AutoCopyConfigs.", this.AutoCopyConfigs);
        }
    }
}

