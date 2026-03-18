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

    public class ModifyVaultRequest : AbstractModel
    {
        
        /// <summary>
        /// 保险箱ID
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// 保险箱名称，最大255字符
        /// </summary>
        [JsonProperty("VaultName")]
        public string VaultName{ get; set; }

        /// <summary>
        /// 保险箱描述，最大1024字符
        /// </summary>
        [JsonProperty("VaultDescribe")]
        public string VaultDescribe{ get; set; }

        /// <summary>
        /// 备份保留时长（秒），范围: (0, 632448000]
        /// </summary>
        [JsonProperty("BackupSaveSeconds")]
        public long? BackupSaveSeconds{ get; set; }

        /// <summary>
        /// 加密密钥ID，最大36字符
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 密钥类型，可选值: cloud、custom
        /// </summary>
        [JsonProperty("KeyType")]
        public string KeyType{ get; set; }

        /// <summary>
        /// 密钥所在地域，最大32字符
        /// </summary>
        [JsonProperty("KeyRegion")]
        public string KeyRegion{ get; set; }

        /// <summary>
        /// 是否锁定保险箱
        /// </summary>
        [JsonProperty("IsLock")]
        public bool? IsLock{ get; set; }

        /// <summary>
        /// 锁定到期时间，格式: 2006-01-02 15:04:05，锁定时间距当前最多15天
        /// </summary>
        [JsonProperty("LockedTime")]
        public string LockedTime{ get; set; }

        /// <summary>
        /// 是否加密
        /// </summary>
        [JsonProperty("IsEncryption")]
        public bool? IsEncryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamSimple(map, prefix + "VaultName", this.VaultName);
            this.SetParamSimple(map, prefix + "VaultDescribe", this.VaultDescribe);
            this.SetParamSimple(map, prefix + "BackupSaveSeconds", this.BackupSaveSeconds);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "KeyRegion", this.KeyRegion);
            this.SetParamSimple(map, prefix + "IsLock", this.IsLock);
            this.SetParamSimple(map, prefix + "LockedTime", this.LockedTime);
            this.SetParamSimple(map, prefix + "IsEncryption", this.IsEncryption);
        }
    }
}

