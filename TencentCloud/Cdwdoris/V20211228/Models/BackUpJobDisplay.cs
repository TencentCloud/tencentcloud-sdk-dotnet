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

    public class BackUpJobDisplay : AbstractModel
    {
        
        /// <summary>
        /// 备份实例id
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 备份实例名
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// 备份数据量
        /// </summary>
        [JsonProperty("BackUpSize")]
        public long? BackUpSize{ get; set; }

        /// <summary>
        /// 备份单副本数据量
        /// </summary>
        [JsonProperty("BackUpSingleSize")]
        public long? BackUpSingleSize{ get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [JsonProperty("BackUpTime")]
        public string BackUpTime{ get; set; }

        /// <summary>
        /// 实例过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("JobStatus")]
        public string JobStatus{ get; set; }

        /// <summary>
        /// 0为默认。1时是对远端的doris进行备份，不周期，一次性
        /// </summary>
        [JsonProperty("BackupType")]
        public long? BackupType{ get; set; }

        /// <summary>
        /// 0为默认。1时是立即备份。2时是迁移
        /// </summary>
        [JsonProperty("BackupTimeType")]
        public long? BackupTimeType{ get; set; }

        /// <summary>
        /// 远端doris的连接信息
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        public DorisSourceInfo DorisSourceInfo{ get; set; }

        /// <summary>
        /// 实例状态对应的数值
        /// </summary>
        [JsonProperty("JobStatusNum")]
        public long? JobStatusNum{ get; set; }

        /// <summary>
        /// 备份实例中关于cos的信息	
        /// </summary>
        [JsonProperty("BackupCosInfo")]
        public BackupCosInfo BackupCosInfo{ get; set; }

        /// <summary>
        /// 是否使用的自定义桶
        /// </summary>
        [JsonProperty("IsUserDefineBucket")]
        public bool? IsUserDefineBucket{ get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonProperty("ErrorReason")]
        public string ErrorReason{ get; set; }

        /// <summary>
        /// 快照保留策略
        /// </summary>
        [JsonProperty("SnapshotRemainPolicy")]
        public SnapshotRemainPolicy SnapshotRemainPolicy{ get; set; }

        /// <summary>
        /// 隔离次数
        /// </summary>
        [JsonProperty("IsolationCount")]
        public long? IsolationCount{ get; set; }

        /// <summary>
        /// 是否开启安全锁
        /// </summary>
        [JsonProperty("EnableSecurityLock")]
        public ulong? EnableSecurityLock{ get; set; }

        /// <summary>
        /// 宽限期天数
        /// </summary>
        [JsonProperty("GracePeriod")]
        public ulong? GracePeriod{ get; set; }

        /// <summary>
        /// 宽限期开始时间
        /// </summary>
        [JsonProperty("GraceStartTime")]
        public string GraceStartTime{ get; set; }

        /// <summary>
        /// 是否在宽限期内
        /// </summary>
        [JsonProperty("IsWithinGracePeriod")]
        public bool? IsWithinGracePeriod{ get; set; }

        /// <summary>
        /// 是否使用托管桶
        /// </summary>
        [JsonProperty("UseManagedBucket")]
        public bool? UseManagedBucket{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
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
        /// 备份远程桶地域
        /// </summary>
        [JsonProperty("DataRemoteRegion")]
        public string DataRemoteRegion{ get; set; }

        /// <summary>
        /// 桶加密状态信息
        /// </summary>
        [JsonProperty("BucketEncryption")]
        public BucketEncryptionInfo BucketEncryption{ get; set; }

        /// <summary>
        /// 备份任务创建时记录的加密类型：SSE-COS/SSE-KMS/disabled
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// 是否开通加密存储：0-未开通，1-已开通
        /// </summary>
        [JsonProperty("EncryptionEnabled")]
        public bool? EncryptionEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Snapshot", this.Snapshot);
            this.SetParamSimple(map, prefix + "BackUpSize", this.BackUpSize);
            this.SetParamSimple(map, prefix + "BackUpSingleSize", this.BackUpSingleSize);
            this.SetParamSimple(map, prefix + "BackUpTime", this.BackUpTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupTimeType", this.BackupTimeType);
            this.SetParamObj(map, prefix + "DorisSourceInfo.", this.DorisSourceInfo);
            this.SetParamSimple(map, prefix + "JobStatusNum", this.JobStatusNum);
            this.SetParamObj(map, prefix + "BackupCosInfo.", this.BackupCosInfo);
            this.SetParamSimple(map, prefix + "IsUserDefineBucket", this.IsUserDefineBucket);
            this.SetParamSimple(map, prefix + "ErrorReason", this.ErrorReason);
            this.SetParamObj(map, prefix + "SnapshotRemainPolicy.", this.SnapshotRemainPolicy);
            this.SetParamSimple(map, prefix + "IsolationCount", this.IsolationCount);
            this.SetParamSimple(map, prefix + "EnableSecurityLock", this.EnableSecurityLock);
            this.SetParamSimple(map, prefix + "GracePeriod", this.GracePeriod);
            this.SetParamSimple(map, prefix + "GraceStartTime", this.GraceStartTime);
            this.SetParamSimple(map, prefix + "IsWithinGracePeriod", this.IsWithinGracePeriod);
            this.SetParamSimple(map, prefix + "UseManagedBucket", this.UseManagedBucket);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamSimple(map, prefix + "DataRemoteRegion", this.DataRemoteRegion);
            this.SetParamObj(map, prefix + "BucketEncryption.", this.BucketEncryption);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
            this.SetParamSimple(map, prefix + "EncryptionEnabled", this.EncryptionEnabled);
        }
    }
}

