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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskImportInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否导入编排空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsImport")]
        public bool? IsImport{ get; set; }

        /// <summary>
        /// 是否新建工作流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNewWorkFlow")]
        public bool? IsNewWorkFlow{ get; set; }

        /// <summary>
        /// 工作流所属目录id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkFlowFolderId")]
        public string WorkFlowFolderId{ get; set; }

        /// <summary>
        /// 工作流所属目录名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkFlowFolderName")]
        public string WorkFlowFolderName{ get; set; }

        /// <summary>
        /// 工作流id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkFlowId")]
        public string WorkFlowId{ get; set; }

        /// <summary>
        /// 工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkFlowName")]
        public string WorkFlowName{ get; set; }

        /// <summary>
        /// 重名任务处理策略, 0:跳过,不导入; 1: 重命名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskNameExistMode")]
        public ulong? TaskNameExistMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsImport", this.IsImport);
            this.SetParamSimple(map, prefix + "IsNewWorkFlow", this.IsNewWorkFlow);
            this.SetParamSimple(map, prefix + "WorkFlowFolderId", this.WorkFlowFolderId);
            this.SetParamSimple(map, prefix + "WorkFlowFolderName", this.WorkFlowFolderName);
            this.SetParamSimple(map, prefix + "WorkFlowId", this.WorkFlowId);
            this.SetParamSimple(map, prefix + "WorkFlowName", this.WorkFlowName);
            this.SetParamSimple(map, prefix + "TaskNameExistMode", this.TaskNameExistMode);
        }
    }
}

