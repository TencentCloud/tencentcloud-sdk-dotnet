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

    public class BackupStatus : AbstractModel
    {
        
        /// <summary>
        /// 备份任务id
        /// </summary>
        [JsonProperty("JobId")]
        public long? JobId{ get; set; }

        /// <summary>
        /// 快照名称
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 库名
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 备份对象
        /// </summary>
        [JsonProperty("BackupObjects")]
        public string BackupObjects{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 快照结束时间
        /// </summary>
        [JsonProperty("SnapshotFinishedTime")]
        public string SnapshotFinishedTime{ get; set; }

        /// <summary>
        /// 上传结束时间
        /// </summary>
        [JsonProperty("UploadFinishedTime")]
        public string UploadFinishedTime{ get; set; }

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
        /// 超时信息
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 备份实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupJobId")]
        public long? BackupJobId{ get; set; }

        /// <summary>
        /// 实例对应snapshoit的id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "BackupObjects", this.BackupObjects);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SnapshotFinishedTime", this.SnapshotFinishedTime);
            this.SetParamSimple(map, prefix + "UploadFinishedTime", this.UploadFinishedTime);
            this.SetParamSimple(map, prefix + "FinishedTime", this.FinishedTime);
            this.SetParamSimple(map, prefix + "UnfinishedTasks", this.UnfinishedTasks);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TaskErrMsg", this.TaskErrMsg);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "BackupJobId", this.BackupJobId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}

