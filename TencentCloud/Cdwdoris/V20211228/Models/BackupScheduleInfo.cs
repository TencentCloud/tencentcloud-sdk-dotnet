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
        /// 迁移类型：
        /// 1-远端集群迁移；2-COS迁移
        /// </summary>
        [JsonProperty("BackupType")]
        public long? BackupType{ get; set; }

        /// <summary>
        /// 当前任务现存实例数
        /// </summary>
        [JsonProperty("ExistCount")]
        public long? ExistCount{ get; set; }

        /// <summary>
        /// cos信息
        /// </summary>
        [JsonProperty("CosSourceInfo")]
        public string CosSourceInfo{ get; set; }

        /// <summary>
        /// doris信息
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        public string DorisSourceInfo{ get; set; }

        /// <summary>
        /// 恢复类型
        /// </summary>
        [JsonProperty("RestoreType")]
        public long? RestoreType{ get; set; }

        /// <summary>
        /// 快照保留策略
        /// </summary>
        [JsonProperty("SnapshotRemainPolicy")]
        public SnapshotRemainPolicy SnapshotRemainPolicy{ get; set; }

        /// <summary>
        /// 远程备份地域
        /// </summary>
        [JsonProperty("DataRemoteRegion")]
        public string DataRemoteRegion{ get; set; }

        /// <summary>
        /// 是否在宽限期内
        /// </summary>
        [JsonProperty("IsWithinGracePeriod")]
        public bool? IsWithinGracePeriod{ get; set; }

        /// <summary>
        /// 宽限期（天数）
        /// </summary>
        [JsonProperty("GracePeriod")]
        public long? GracePeriod{ get; set; }

        /// <summary>
        /// 宽限开始时间
        /// </summary>
        [JsonProperty("GraceStartTime")]
        public string GraceStartTime{ get; set; }

        /// <summary>
        /// 托管桶类型：standard-标准，多可用区-MAZ
        /// </summary>
        [JsonProperty("BucketType")]
        public string BucketType{ get; set; }

        /// <summary>
        /// 是否开启安全锁：0-未开启，1-已开启
        /// </summary>
        [JsonProperty("EnableSecurityLock")]
        public ulong? EnableSecurityLock{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 实例状态描述
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// 桶加密状态信息
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

