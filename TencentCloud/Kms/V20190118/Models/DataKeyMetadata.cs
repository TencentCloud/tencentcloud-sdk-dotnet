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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataKeyMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>DataKey的全局唯一标识</p>
        /// </summary>
        [JsonProperty("DataKeyId")]
        public string DataKeyId{ get; set; }

        /// <summary>
        /// <p>CMK的全局唯一标识</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>CMK的名称</p>
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// <p>作为密钥更容易辨识，更容易被人看懂的数据密钥名称</p>
        /// </summary>
        [JsonProperty("DataKeyName")]
        public string DataKeyName{ get; set; }

        /// <summary>
        /// <p>数据密钥的长度,单位字节</p>
        /// </summary>
        [JsonProperty("NumberOfBytes")]
        public ulong? NumberOfBytes{ get; set; }

        /// <summary>
        /// <p>密钥创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>DataKey的描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>DataKey的状态， 取值为：Enabled | Disabled | PendingDelete</p>
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// <p>创建者</p>
        /// </summary>
        [JsonProperty("CreatorUin")]
        public ulong? CreatorUin{ get; set; }

        /// <summary>
        /// <p>数据密钥的创建者，用户创建的为 user，授权各云产品自动创建的为对应的产品名</p>
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// <p>计划删除的时间</p>
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// <p>DataKey 密钥材料类型，由KMS创建的为： TENCENT_KMS， 由用户导入的类型为：EXTERNAL</p>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// <p>HSM 集群 ID（仅对 KMS 独占版/托管版服务实例有效）</p>
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// <p>资源ID，格式：creatorUin/$creatorUin/$dataKeyId</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>密钥是否是主副本。0:主本，1:同步副本。</p>
        /// </summary>
        [JsonProperty("IsSyncReplica")]
        public long? IsSyncReplica{ get; set; }

        /// <summary>
        /// <p>同步的原始地域</p>
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// <p>密钥同步的状态，0:未同步，1:同步成功，2:同步失败，3:同步中。</p>
        /// </summary>
        [JsonProperty("SyncStatus")]
        public long? SyncStatus{ get; set; }

        /// <summary>
        /// <p>同步的结果描述</p>
        /// </summary>
        [JsonProperty("SyncMessages")]
        public string SyncMessages{ get; set; }

        /// <summary>
        /// <p>同步的开始时间</p>
        /// </summary>
        [JsonProperty("SyncStartTime")]
        public ulong? SyncStartTime{ get; set; }

        /// <summary>
        /// <p>同步的结束时间</p>
        /// </summary>
        [JsonProperty("SyncEndTime")]
        public ulong? SyncEndTime{ get; set; }

        /// <summary>
        /// <p>同步的原始集群，如果为空，是公有云公共集群</p>
        /// </summary>
        [JsonProperty("SourceHsmClusterId")]
        public string SourceHsmClusterId{ get; set; }

        /// <summary>
        /// <p>成员账号appId</p>
        /// </summary>
        [JsonProperty("AccountAppId")]
        public ulong? AccountAppId{ get; set; }

        /// <summary>
        /// <p>成员账号uin</p>
        /// </summary>
        [JsonProperty("AccountUin")]
        public ulong? AccountUin{ get; set; }

        /// <summary>
        /// <p>成员账号名称</p>
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>创建者UIN</p>
        /// </summary>
        [JsonProperty("CreatorUinString")]
        public string CreatorUinString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataKeyId", this.DataKeyId);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "DataKeyName", this.DataKeyName);
            this.SetParamSimple(map, prefix + "NumberOfBytes", this.NumberOfBytes);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "DeletionDate", this.DeletionDate);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "IsSyncReplica", this.IsSyncReplica);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncMessages", this.SyncMessages);
            this.SetParamSimple(map, prefix + "SyncStartTime", this.SyncStartTime);
            this.SetParamSimple(map, prefix + "SyncEndTime", this.SyncEndTime);
            this.SetParamSimple(map, prefix + "SourceHsmClusterId", this.SourceHsmClusterId);
            this.SetParamSimple(map, prefix + "AccountAppId", this.AccountAppId);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "CreatorUinString", this.CreatorUinString);
        }
    }
}

