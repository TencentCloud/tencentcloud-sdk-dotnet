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
        /// <p>备份实例id</p>
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// <p>备份实例名</p>
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// <p>备份数据量</p>
        /// </summary>
        [JsonProperty("BackUpSize")]
        public long? BackUpSize{ get; set; }

        /// <summary>
        /// <p>备份单副本数据量</p>
        /// </summary>
        [JsonProperty("BackUpSingleSize")]
        public long? BackUpSingleSize{ get; set; }

        /// <summary>
        /// <p>实例创建时间</p>
        /// </summary>
        [JsonProperty("BackUpTime")]
        public string BackUpTime{ get; set; }

        /// <summary>
        /// <p>实例过期时间</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// </summary>
        [JsonProperty("JobStatus")]
        public string JobStatus{ get; set; }

        /// <summary>
        /// <p>0为默认。1时是对远端的doris进行备份，不周期，一次性</p>
        /// </summary>
        [JsonProperty("BackupType")]
        public long? BackupType{ get; set; }

        /// <summary>
        /// <p>0为默认。1时是立即备份。2时是迁移</p>
        /// </summary>
        [JsonProperty("BackupTimeType")]
        public long? BackupTimeType{ get; set; }

        /// <summary>
        /// <p>远端doris的连接信息</p>
        /// </summary>
        [JsonProperty("DorisSourceInfo")]
        public DorisSourceInfo DorisSourceInfo{ get; set; }

        /// <summary>
        /// <p>实例状态对应的数值</p>
        /// </summary>
        [JsonProperty("JobStatusNum")]
        public long? JobStatusNum{ get; set; }

        /// <summary>
        /// <p>备份实例中关于cos的信息</p>
        /// </summary>
        [JsonProperty("BackupCosInfo")]
        public BackupCosInfo BackupCosInfo{ get; set; }

        /// <summary>
        /// <p>是否使用的自定义桶</p>
        /// </summary>
        [JsonProperty("IsUserDefineBucket")]
        public bool? IsUserDefineBucket{ get; set; }

        /// <summary>
        /// <p>错误原因</p>
        /// </summary>
        [JsonProperty("ErrorReason")]
        public string ErrorReason{ get; set; }

        /// <summary>
        /// <p>快照保留策略</p>
        /// </summary>
        [JsonProperty("SnapshotRemainPolicy")]
        public SnapshotRemainPolicy SnapshotRemainPolicy{ get; set; }

        /// <summary>
        /// <p>隔离次数</p>
        /// </summary>
        [JsonProperty("IsolationCount")]
        public long? IsolationCount{ get; set; }

        /// <summary>
        /// <p>是否开启安全锁</p>
        /// </summary>
        [JsonProperty("EnableSecurityLock")]
        public ulong? EnableSecurityLock{ get; set; }

        /// <summary>
        /// <p>宽限期天数</p>
        /// </summary>
        [JsonProperty("GracePeriod")]
        public ulong? GracePeriod{ get; set; }

        /// <summary>
        /// <p>宽限期开始时间</p>
        /// </summary>
        [JsonProperty("GraceStartTime")]
        public string GraceStartTime{ get; set; }

        /// <summary>
        /// <p>是否在宽限期内</p>
        /// </summary>
        [JsonProperty("IsWithinGracePeriod")]
        public bool? IsWithinGracePeriod{ get; set; }

        /// <summary>
        /// <p>是否使用托管桶</p>
        /// </summary>
        [JsonProperty("UseManagedBucket")]
        public bool? UseManagedBucket{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
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
        /// <p>备份远程桶地域</p>
        /// </summary>
        [JsonProperty("DataRemoteRegion")]
        public string DataRemoteRegion{ get; set; }

        /// <summary>
        /// <p>桶加密状态信息</p>
        /// </summary>
        [JsonProperty("BucketEncryption")]
        public BucketEncryptionInfo BucketEncryption{ get; set; }

        /// <summary>
        /// <p>备份任务创建时记录的加密类型：SSE-COS/SSE-KMS/disabled</p>
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }

        /// <summary>
        /// <p>是否开通加密存储：0-未开通，1-已开通</p>
        /// </summary>
        [JsonProperty("EncryptionEnabled")]
        public bool? EncryptionEnabled{ get; set; }

        /// <summary>
        /// <p>任务调度id</p>
        /// </summary>
        [JsonProperty("ScheduleId")]
        public long? ScheduleId{ get; set; }

        /// <summary>
        /// <p>总任务数（库数）</p>
        /// </summary>
        [JsonProperty("TotalTasks")]
        public long? TotalTasks{ get; set; }

        /// <summary>
        /// <p>已完成任务数</p>
        /// </summary>
        [JsonProperty("CompletedTasks")]
        public long? CompletedTasks{ get; set; }

        /// <summary>
        /// <p>失败任务数</p>
        /// </summary>
        [JsonProperty("FailedTasks")]
        public long? FailedTasks{ get; set; }

        /// <summary>
        /// <p>备份进度描述，如 3/5</p>
        /// </summary>
        [JsonProperty("BackupProgress")]
        public string BackupProgress{ get; set; }


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
            this.SetParamSimple(map, prefix + "ScheduleId", this.ScheduleId);
            this.SetParamSimple(map, prefix + "TotalTasks", this.TotalTasks);
            this.SetParamSimple(map, prefix + "CompletedTasks", this.CompletedTasks);
            this.SetParamSimple(map, prefix + "FailedTasks", this.FailedTasks);
            this.SetParamSimple(map, prefix + "BackupProgress", this.BackupProgress);
        }
    }
}

