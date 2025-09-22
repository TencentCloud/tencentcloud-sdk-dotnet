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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobExecutionDto : AbstractModel
    {
        
        /// <summary>
        /// 数据探索任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 子查询任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobExecutionId")]
        public string JobExecutionId{ get; set; }

        /// <summary>
        /// 子查询名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobExecutionName")]
        public string JobExecutionName{ get; set; }

        /// <summary>
        /// 子查询sql内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// 子查询状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 执行阶段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecuteStageInfo")]
        public string ExecuteStageInfo{ get; set; }

        /// <summary>
        /// 日志路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogFilePath")]
        public string LogFilePath{ get; set; }

        /// <summary>
        /// 下载结果路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultFilePath")]
        public string ResultFilePath{ get; set; }

        /// <summary>
        /// 预览结果路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultPreviewFilePath")]
        public string ResultPreviewFilePath{ get; set; }

        /// <summary>
        /// 任务执行的结果总行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultTotalCount")]
        public long? ResultTotalCount{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 耗时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeCost")]
        public long? TimeCost{ get; set; }

        /// <summary>
        /// 上下文SQL内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContextScriptContent")]
        public string[] ContextScriptContent{ get; set; }

        /// <summary>
        /// 任务执行的结果预览行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultPreviewCount")]
        public long? ResultPreviewCount{ get; set; }

        /// <summary>
        /// 任务执行的结果影响行数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResultEffectCount")]
        public long? ResultEffectCount{ get; set; }

        /// <summary>
        /// 是否正在收集全量结果：默认false，true表示正在收集全量结果，用于前端判断是否需要继续轮询
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectingTotalResult")]
        public bool? CollectingTotalResult{ get; set; }

        /// <summary>
        /// 是否需要截断脚本内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScriptContentTruncate")]
        public bool? ScriptContentTruncate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobExecutionId", this.JobExecutionId);
            this.SetParamSimple(map, prefix + "JobExecutionName", this.JobExecutionName);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExecuteStageInfo", this.ExecuteStageInfo);
            this.SetParamSimple(map, prefix + "LogFilePath", this.LogFilePath);
            this.SetParamSimple(map, prefix + "ResultFilePath", this.ResultFilePath);
            this.SetParamSimple(map, prefix + "ResultPreviewFilePath", this.ResultPreviewFilePath);
            this.SetParamSimple(map, prefix + "ResultTotalCount", this.ResultTotalCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TimeCost", this.TimeCost);
            this.SetParamArraySimple(map, prefix + "ContextScriptContent.", this.ContextScriptContent);
            this.SetParamSimple(map, prefix + "ResultPreviewCount", this.ResultPreviewCount);
            this.SetParamSimple(map, prefix + "ResultEffectCount", this.ResultEffectCount);
            this.SetParamSimple(map, prefix + "CollectingTotalResult", this.CollectingTotalResult);
            this.SetParamSimple(map, prefix + "ScriptContentTruncate", this.ScriptContentTruncate);
        }
    }
}

