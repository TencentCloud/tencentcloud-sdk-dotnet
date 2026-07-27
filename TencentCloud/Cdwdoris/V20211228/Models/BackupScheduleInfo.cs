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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupScheduleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>迁移类型：<br>1-远端集群迁移；2-COS迁移</p>
        /// </summary>
        [JsonProperty("BackupType")]
        public long? BackupType{ get; set; }

        /// <summary>
        /// <p>当前任务现存实例数</p>
        /// </summary>
        [JsonProperty("ExistCount")]
        public long? ExistCount{ get; set; }

        /// <summary>
        /// <p>cos信息</p>
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        public string CosSourceInfo{ get; set; }

        /// <summary>
        /// <p>doris信息</p>
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        public string DorisSourceInfo{ get; set; }

        /// <summary>
        /// <p>恢复类型</p>
        /// </summary>
        [JsonProperty("RestoreType")]
        public long? RestoreType{ get; set; }

        /// <summary>
        /// <p>快照保留策略</p>
        /// </summary>
        [JsonProperty("SnapshotRemainPolicy")]
        public SnapshotRemainPolicy SnapshotRemainPolicy{ get; set; }

        /// <summary>
        /// <p>远程备份地域</p>
        /// </summary>
        [JsonProperty("DataRemoteRegion")]
        public string DataRemoteRegion{ get; set; }

        /// <summary>
        /// <p>是否在宽限期内</p>
        /// </summary>
        [JsonProperty("IsWithinGracePeriod")]
        public bool? IsWithinGracePeriod{ get; set; }

        /// <summary>
        /// <p>宽限期（天数）</p>
        /// </summary>
        [JsonProperty("GracePeriod")]
        public long? GracePeriod{ get; set; }

        /// <summary>
        /// <p>宽限开始时间</p>
        /// </summary>
        [JsonProperty("GraceStartTime")]
        public string GraceStartTime{ get; set; }

        /// <summary>
        /// <p>托管桶类型：standard-标准，多可用区-MAZ</p>
        /// </summary>
        [JsonProperty("BucketType")]
        public string BucketType{ get; set; }

        /// <summary>
        /// <p>是否开启安全锁：0-未开启，1-已开启</p>
        /// </summary>
        [JsonProperty("EnableSecurityLock")]
        public ulong? EnableSecurityLock{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>实例状态描述</p>
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// <p>桶加密状态信息</p>
        /// </summary>
        [JsonProperty("BucketEncryption")]
        public BucketEncryptionInfo BucketEncryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "ExistCount", this.ExistCount);
            this.SetParamSimple(map, prefix + "CosSourceInfo", this.CosSourceInfo);
            this.SetParamSimple(map, prefix + "DorisSourceInfo", this.DorisSourceInfo);
            this.SetParamSimple(map, prefix + "RestoreType", this.RestoreType);
            this.SetParamObj(map, prefix + "SnapshotRemainPolicy.", this.SnapshotRemainPolicy);
            this.SetParamSimple(map, prefix + "DataRemoteRegion", this.DataRemoteRegion);
            this.SetParamSimple(map, prefix + "IsWithinGracePeriod", this.IsWithinGracePeriod);
            this.SetParamSimple(map, prefix + "GracePeriod", this.GracePeriod);
            this.SetParamSimple(map, prefix + "GraceStartTime", this.GraceStartTime);
            this.SetParamSimple(map, prefix + "BucketType", this.BucketType);
            this.SetParamSimple(map, prefix + "EnableSecurityLock", this.EnableSecurityLock);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamObj(map, prefix + "BucketEncryption.", this.BucketEncryption);
        }
    }
}

