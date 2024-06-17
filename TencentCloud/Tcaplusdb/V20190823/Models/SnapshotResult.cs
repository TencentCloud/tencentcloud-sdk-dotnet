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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotResult : AbstractModel
    {
        
        /// <summary>
        /// 表格所属表格组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// 表格名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 任务ID，对于创建单任务的接口有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Error")]
        public ErrorInfo Error{ get; set; }

        /// <summary>
        /// 快照名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 快照的时间点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotTime")]
        public string SnapshotTime{ get; set; }

        /// <summary>
        /// 快照的过期时间点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotDeadTime")]
        public string SnapshotDeadTime{ get; set; }

        /// <summary>
        /// 快照创建时间点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotCreateTime")]
        public string SnapshotCreateTime{ get; set; }

        /// <summary>
        /// 快照大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public ulong? SnapshotSize{ get; set; }

        /// <summary>
        /// 快照状态，0 生成中 1 正常 2 删除中 3 已失效 4 回档使用中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotStatus")]
        public ulong? SnapshotStatus{ get; set; }

        /// <summary>
        /// 申请单ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "Error.", this.Error);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "SnapshotTime", this.SnapshotTime);
            this.SetParamSimple(map, prefix + "SnapshotDeadTime", this.SnapshotDeadTime);
            this.SetParamSimple(map, prefix + "SnapshotCreateTime", this.SnapshotCreateTime);
            this.SetParamSimple(map, prefix + "SnapshotSize", this.SnapshotSize);
            this.SetParamSimple(map, prefix + "SnapshotStatus", this.SnapshotStatus);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
        }
    }
}

