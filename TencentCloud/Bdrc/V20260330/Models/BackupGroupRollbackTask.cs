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

    public class BackupGroupRollbackTask : AbstractModel
    {
        
        /// <summary>
        /// 备份组回滚任务
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 源实例ID
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }

        /// <summary>
        /// 目标实例ID
        /// </summary>
        [JsonProperty("TargetInstanceId")]
        public string TargetInstanceId{ get; set; }

        /// <summary>
        /// 备份组ID
        /// </summary>
        [JsonProperty("BackupGroupId")]
        public string BackupGroupId{ get; set; }

        /// <summary>
        /// 恢复类型：ORIGINAL-原实例恢复，NEW-新实例恢复
        /// </summary>
        [JsonProperty("RollbackType")]
        public string RollbackType{ get; set; }

        /// <summary>
        /// 任务状态。取值包括"init"、"migrating"、"done"、"failed"。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// APP ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 备份点名称
        /// </summary>
        [JsonProperty("BackupGroupName")]
        public string BackupGroupName{ get; set; }

        /// <summary>
        /// 恢复失败原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
            this.SetParamSimple(map, prefix + "TargetInstanceId", this.TargetInstanceId);
            this.SetParamSimple(map, prefix + "BackupGroupId", this.BackupGroupId);
            this.SetParamSimple(map, prefix + "RollbackType", this.RollbackType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BackupGroupName", this.BackupGroupName);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
        }
    }
}

