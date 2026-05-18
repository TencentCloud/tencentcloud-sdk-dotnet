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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TestRunningSubRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>开发时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>执行平台执行id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionJobId")]
        public string ExecutionJobId{ get; set; }

        /// <summary>
        /// <p>执行平台子执行jobid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutionSubJobId")]
        public string ExecutionSubJobId{ get; set; }

        /// <summary>
        /// <p>开发侧提交的jobid</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>子记录id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailId")]
        public long? DetailId{ get; set; }

        /// <summary>
        /// <p>试运行记录id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public long? RecordId{ get; set; }

        /// <summary>
        /// <p>脚本内容</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>耗时</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeCost")]
        public long? TimeCost{ get; set; }

        /// <summary>
        /// <p>结果总行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultTotalCount")]
        public long? ResultTotalCount{ get; set; }

        /// <summary>
        /// <p>预览结果行数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultPreviewCount")]
        public long? ResultPreviewCount{ get; set; }

        /// <summary>
        /// <p>结果文件路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultFilePath")]
        public string ResultFilePath{ get; set; }

        /// <summary>
        /// <p>预览结果文件路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultPreviewFilePath")]
        public string ResultPreviewFilePath{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>序号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sequence")]
        public string Sequence{ get; set; }

        /// <summary>
        /// <p>日志路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogFilePath")]
        public string LogFilePath{ get; set; }

        /// <summary>
        /// <p>是否包含子结果</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasSubResultSet")]
        public bool? HasSubResultSet{ get; set; }

        /// <summary>
        /// <p>脚本内容是否被截断</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptContentTruncated")]
        public bool? ScriptContentTruncated{ get; set; }

        /// <summary>
        /// <p>结果集表字符信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaInfoFilePath")]
        public string SchemaInfoFilePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecutionJobId", this.ExecutionJobId);
            this.SetParamSimple(map, prefix + "ExecutionSubJobId", this.ExecutionSubJobId);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "DetailId", this.DetailId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TimeCost", this.TimeCost);
            this.SetParamSimple(map, prefix + "ResultTotalCount", this.ResultTotalCount);
            this.SetParamSimple(map, prefix + "ResultPreviewCount", this.ResultPreviewCount);
            this.SetParamSimple(map, prefix + "ResultFilePath", this.ResultFilePath);
            this.SetParamSimple(map, prefix + "ResultPreviewFilePath", this.ResultPreviewFilePath);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Sequence", this.Sequence);
            this.SetParamSimple(map, prefix + "LogFilePath", this.LogFilePath);
            this.SetParamSimple(map, prefix + "HasSubResultSet", this.HasSubResultSet);
            this.SetParamSimple(map, prefix + "ScriptContentTruncated", this.ScriptContentTruncated);
            this.SetParamSimple(map, prefix + "SchemaInfoFilePath", this.SchemaInfoFilePath);
        }
    }
}

