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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务流程ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskFlowId")]
        public string TaskFlowId{ get; set; }

        /// <summary>
        /// 任务流程名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskFlowName")]
        public string TaskFlowName{ get; set; }

        /// <summary>
        /// Query 重写结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryRewrite")]
        public string QueryRewrite{ get; set; }

        /// <summary>
        /// 命中意图
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HitIntent")]
        public string HitIntent{ get; set; }

        /// <summary>
        /// 任务流程回复类型
        /// 0: 任务流回复
        /// 1: 任务流静默
        /// 2: 任务流拉回话术
        /// 3: 任务流自定义回复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskFlowId", this.TaskFlowId);
            this.SetParamSimple(map, prefix + "TaskFlowName", this.TaskFlowName);
            this.SetParamSimple(map, prefix + "QueryRewrite", this.QueryRewrite);
            this.SetParamSimple(map, prefix + "HitIntent", this.HitIntent);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

