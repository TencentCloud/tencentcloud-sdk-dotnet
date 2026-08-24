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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreTask : AbstractModel
    {
        
        /// <summary>
        /// 恢复任务 ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 关联备份点 ID
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// 源实例 ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 目标实例 ID
        /// </summary>
        [JsonProperty("TargetResourceId")]
        public string TargetResourceId{ get; set; }

        /// <summary>
        /// 恢复路径列表
        /// </summary>
        [JsonProperty("RestorePaths")]
        public string[] RestorePaths{ get; set; }

        /// <summary>
        /// 目标恢复位置
        /// </summary>
        [JsonProperty("TargetLocation")]
        public string TargetLocation{ get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 需恢复文件总数
        /// </summary>
        [JsonProperty("TotalFileCount")]
        public long? TotalFileCount{ get; set; }

        /// <summary>
        /// 需恢复数据总量（字节）
        /// </summary>
        [JsonProperty("TotalSize")]
        public long? TotalSize{ get; set; }

        /// <summary>
        /// 需恢复数据总量（格式化，如 "1.5 GB"）
        /// </summary>
        [JsonProperty("TotalSizeFormatted")]
        public string TotalSizeFormatted{ get; set; }

        /// <summary>
        /// 已恢复文件数
        /// </summary>
        [JsonProperty("RestoreFileCount")]
        public long? RestoreFileCount{ get; set; }

        /// <summary>
        /// 已恢复数据量（字节）
        /// </summary>
        [JsonProperty("RestoreSize")]
        public long? RestoreSize{ get; set; }

        /// <summary>
        /// 已恢复数据量（格式化）
        /// </summary>
        [JsonProperty("RestoreSizeFormatted")]
        public string RestoreSizeFormatted{ get; set; }

        /// <summary>
        /// 恢复进度（0-100）
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 关联 Job ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 任务开始时间（ISO 格式）
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 恢复任务失败原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 冲突处理策略：skip-跳过/overwrite-覆盖/newer-保留最新版本/if_changed-内容变化时覆盖
        /// </summary>
        [JsonProperty("ConflictStrategy")]
        public string ConflictStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "TargetResourceId", this.TargetResourceId);
            this.SetParamArraySimple(map, prefix + "RestorePaths.", this.RestorePaths);
            this.SetParamSimple(map, prefix + "TargetLocation", this.TargetLocation);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TotalFileCount", this.TotalFileCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamSimple(map, prefix + "TotalSizeFormatted", this.TotalSizeFormatted);
            this.SetParamSimple(map, prefix + "RestoreFileCount", this.RestoreFileCount);
            this.SetParamSimple(map, prefix + "RestoreSize", this.RestoreSize);
            this.SetParamSimple(map, prefix + "RestoreSizeFormatted", this.RestoreSizeFormatted);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "ConflictStrategy", this.ConflictStrategy);
        }
    }
}

