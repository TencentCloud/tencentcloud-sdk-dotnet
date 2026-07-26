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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppTriggerInstance : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConversationId")]
        public string ConversationId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FinishedAt")]
        public string FinishedAt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResultCode")]
        public string ResultCode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ResultSummary")]
        public string ResultSummary{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RunId")]
        public string RunId{ get; set; }

        /// <summary>
        /// <table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>APP_TRIGGER_INSTANCE_SOURCE_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>APP_TRIGGER_INSTANCE_SOURCE_APP_TRIGGER</td><td>1</td><td>来源于应用触发器</td></tr></table>
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StartedAt")]
        public string StartedAt{ get; set; }

        /// <summary>
        /// <table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>TIMER_RUN_STATUS_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>TIMER_RUN_STATUS_PENDING</td><td>1</td><td>等待执行</td></tr><tr><td>TIMER_RUN_STATUS_RUNNING</td><td>2</td><td>执行中</td></tr><tr><td>TIMER_RUN_STATUS_RETRY_WAIT</td><td>3</td><td>等待重试</td></tr><tr><td>TIMER_RUN_STATUS_SUCCESS</td><td>4</td><td>成功</td></tr><tr><td>TIMER_RUN_STATUS_DEAD</td><td>5</td><td>失败终态 (重试耗尽 / 不可重试)</td></tr><tr><td>TIMER_RUN_STATUS_CANCELLED</td><td>6</td><td>被任务暂停/删除/修改取消</td></tr></table>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TriggerId")]
        public string TriggerId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("WorkflowRunId")]
        public string WorkflowRunId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ConversationId", this.ConversationId);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "FinishedAt", this.FinishedAt);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "ResultSummary", this.ResultSummary);
            this.SetParamSimple(map, prefix + "RunId", this.RunId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "StartedAt", this.StartedAt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamSimple(map, prefix + "TriggerId", this.TriggerId);
            this.SetParamSimple(map, prefix + "WorkflowRunId", this.WorkflowRunId);
        }
    }
}

