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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentThought : AbstractModel
    {
        
        /// <summary>
        /// 会话 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 请求 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 对应哪条会话, 会话 ID, 用于回答的消息存储使用, 可提前生成, 保存消息时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 当前请求执行时间, 单位 ms
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Elapsed")]
        public ulong? Elapsed{ get; set; }

        /// <summary>
        /// 当前是否为工作流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsWorkflow")]
        public bool? IsWorkflow{ get; set; }

        /// <summary>
        /// 如果当前是工作流，工作流名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowName")]
        public string WorkflowName{ get; set; }

        /// <summary>
        /// 具体思考过程详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Procedures")]
        public AgentProcedure[] Procedures{ get; set; }

        /// <summary>
        /// TraceId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// 文件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Files")]
        public FileInfo[] Files{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "IsWorkflow", this.IsWorkflow);
            this.SetParamSimple(map, prefix + "WorkflowName", this.WorkflowName);
            this.SetParamArrayObj(map, prefix + "Procedures.", this.Procedures);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamArrayObj(map, prefix + "Files.", this.Files);
        }
    }
}

