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

    public class WorkflowRunDetail : AbstractModel
    {
        
        /// <summary>
        /// 运行环境。0: 测试环境； 1: 正式环境
        /// </summary>
        [JsonProperty("RunEnv")]
        public ulong? RunEnv{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// 工作流运行实例的ID
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }

        /// <summary>
        /// 所属工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 运行状态。0: 排队中；1: 运行中；2: 运行成功；3: 运行失败； 4: 已取消
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// 消耗的token总数
        /// </summary>
        [JsonProperty("TotalTokens")]
        public ulong? TotalTokens{ get; set; }

        /// <summary>
        /// 创建时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 开始时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 工作流画布Json
        /// </summary>
        [JsonProperty("DialogJson")]
        public string DialogJson{ get; set; }

        /// <summary>
        /// 用户的输入
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 主模型名称
        /// </summary>
        [JsonProperty("MainModelName")]
        public string MainModelName{ get; set; }

        /// <summary>
        /// API参数配置
        /// </summary>
        [JsonProperty("CustomVariables")]
        public CustomVariable[] CustomVariables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunEnv", this.RunEnv);
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DialogJson", this.DialogJson);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "MainModelName", this.MainModelName);
            this.SetParamArrayObj(map, prefix + "CustomVariables.", this.CustomVariables);
        }
    }
}

