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

    public class EngineTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineSubmitTime")]
        public string EngineSubmitTime{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeTime")]
        public string EngineExeTime{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeTimes")]
        public ulong? EngineExeTimes{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CuConsume")]
        public ulong? CuConsume{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceUsage")]
        public long? ResourceUsage{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExeStatus")]
        public string EngineExeStatus{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskKind")]
        public string TaskKind{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskContent")]
        public string TaskContent{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputBytesSum")]
        public ulong? InputBytesSum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShuffleReadBytesSum")]
        public ulong? ShuffleReadBytesSum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShuffleReadRecordsSum")]
        public ulong? ShuffleReadRecordsSum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputRecordsSum")]
        public ulong? OutputRecordsSum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputBytesSum")]
        public ulong? OutputBytesSum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputFilesNum")]
        public ulong? OutputFilesNum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputSmallFilesNum")]
        public ulong? OutputSmallFilesNum{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitTime")]
        public ulong? WaitTime{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryResultTime")]
        public ulong? QueryResultTime{ get; set; }

        /// <summary>
        /// 1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineSubmitTime", this.EngineSubmitTime);
            this.SetParamSimple(map, prefix + "EngineExeTime", this.EngineExeTime);
            this.SetParamSimple(map, prefix + "EngineExeTimes", this.EngineExeTimes);
            this.SetParamSimple(map, prefix + "CuConsume", this.CuConsume);
            this.SetParamSimple(map, prefix + "ResourceUsage", this.ResourceUsage);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "EngineExeStatus", this.EngineExeStatus);
            this.SetParamSimple(map, prefix + "TaskKind", this.TaskKind);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TaskContent", this.TaskContent);
            this.SetParamSimple(map, prefix + "InputBytesSum", this.InputBytesSum);
            this.SetParamSimple(map, prefix + "ShuffleReadBytesSum", this.ShuffleReadBytesSum);
            this.SetParamSimple(map, prefix + "ShuffleReadRecordsSum", this.ShuffleReadRecordsSum);
            this.SetParamSimple(map, prefix + "OutputRecordsSum", this.OutputRecordsSum);
            this.SetParamSimple(map, prefix + "OutputBytesSum", this.OutputBytesSum);
            this.SetParamSimple(map, prefix + "OutputFilesNum", this.OutputFilesNum);
            this.SetParamSimple(map, prefix + "OutputSmallFilesNum", this.OutputSmallFilesNum);
            this.SetParamSimple(map, prefix + "WaitTime", this.WaitTime);
            this.SetParamSimple(map, prefix + "QueryResultTime", this.QueryResultTime);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
        }
    }
}

