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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreStatus : AbstractModel
    {
        
        /// <summary>
        /// 恢复任务id
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 恢复任务标签
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 恢复任务时间戳
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 恢复任务所在库
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 恢复任务状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 恢复时是否允许导入
        /// </summary>
        [JsonProperty("AllowLoad")]
        public bool? AllowLoad{ get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("ReplicationNum")]
        public string ReplicationNum{ get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("ReplicaAllocation")]
        public string ReplicaAllocation{ get; set; }

        /// <summary>
        /// 恢复对象
        /// </summary>
        [JsonProperty("RestoreObjects")]
        public string RestoreObjects{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 元数据准备时间
        /// </summary>
        [JsonProperty("MetaPreparedTime")]
        public string MetaPreparedTime{ get; set; }

        /// <summary>
        /// 快照结束时间
        /// </summary>
        [JsonProperty("SnapshotFinishedTime")]
        public string SnapshotFinishedTime{ get; set; }

        /// <summary>
        /// 下载结束时间
        /// </summary>
        [JsonProperty("DownloadFinishedTime")]
        public string DownloadFinishedTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("FinishedTime")]
        public string FinishedTime{ get; set; }

        /// <summary>
        /// 未完成任务
        /// </summary>
        [JsonProperty("UnfinishedTasks")]
        public string UnfinishedTasks{ get; set; }

        /// <summary>
        /// 进度
        /// </summary>
        [JsonProperty("Progress")]
        public string Progress{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("TaskErrMsg")]
        public string TaskErrMsg{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 作业超时时间
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 是否保持源表中的副本数
        /// </summary>
        [JsonProperty("ReserveReplica")]
        public bool? ReserveReplica{ get; set; }

        /// <summary>
        /// 是否保持源表中的动态分区
        /// </summary>
        [JsonProperty("ReserveDynamicPartitionEnable")]
        public bool? ReserveDynamicPartitionEnable{ get; set; }

        /// <summary>
        /// 备份实例id
        /// </summary>
        [JsonProperty("BackupJobId")]
        public long? BackupJobId{ get; set; }

        /// <summary>
        /// 实例对应snapshot的id
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "AllowLoad", this.AllowLoad);
            this.SetParamSimple(map, prefix + "ReplicationNum", this.ReplicationNum);
            this.SetParamSimple(map, prefix + "ReplicaAllocation", this.ReplicaAllocation);
            this.SetParamSimple(map, prefix + "RestoreObjects", this.RestoreObjects);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MetaPreparedTime", this.MetaPreparedTime);
            this.SetParamSimple(map, prefix + "SnapshotFinishedTime", this.SnapshotFinishedTime);
            this.SetParamSimple(map, prefix + "DownloadFinishedTime", this.DownloadFinishedTime);
            this.SetParamSimple(map, prefix + "FinishedTime", this.FinishedTime);
            this.SetParamSimple(map, prefix + "UnfinishedTasks", this.UnfinishedTasks);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TaskErrMsg", this.TaskErrMsg);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "ReserveReplica", this.ReserveReplica);
            this.SetParamSimple(map, prefix + "ReserveDynamicPartitionEnable", this.ReserveDynamicPartitionEnable);
            this.SetParamSimple(map, prefix + "BackupJobId", this.BackupJobId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

