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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListWorkflowRunsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID，可通过 ListWorkspaces 获取。必填</p>
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>分页页码，从 1 开始。非必填，默认 1</p>
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// <p>每页大小。非必填，默认 10，取值范围 [10, 200]</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>工作流ID，精确匹配。非必填，单值</p>
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// <p>工作流名称关键字，对 WorkflowName 做模糊匹配。非必填，单值</p>
        /// </summary>
        [JsonProperty("WorkflowNameKeyword")]
        public string WorkflowNameKeyword{ get; set; }

        /// <summary>
        /// <p>运行创建时间下界，范围匹配（CreateTime &gt;= 本值），单位：毫秒时间戳。<br>非必填，单值，对应出参 WorkflowRun.CreateTime</p>
        /// </summary>
        [JsonProperty("CreateStartTime")]
        public string CreateStartTime{ get; set; }

        /// <summary>
        /// <p>运行创建时间上界，范围匹配（CreateTime &lt;= 本值），单位：毫秒时间戳。<br>非必填，单值，对应出参 WorkflowRun.CreateTime</p>
        /// </summary>
        [JsonProperty("CreateEndTime")]
        public string CreateEndTime{ get; set; }

        /// <summary>
        /// <p>运行状态，精确匹配。非必填，多选（多个值之间为 OR 关系）。运行状态。CREATE(&quot;初始化&quot;), QUEUED(&quot;等待中&quot;), PENDING(&quot;准备中&quot;), RUNNING(&quot;运行中&quot;), SKIPPED(&quot;跳过运行&quot;), SUCCESS(&quot;成功&quot;), FAILED(&quot;失败&quot;), TERMINATING(&quot;终止中&quot;), TERMINATED(&quot;终止&quot;), CANCELLED(&quot;被手动终止&quot;)等</p>
        /// </summary>
        [JsonProperty("RunStates")]
        public string[] RunStates{ get; set; }

        /// <summary>
        /// <p>错误码，精确匹配。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("ErrorCodeStrings")]
        public string[] ErrorCodeStrings{ get; set; }

        /// <summary>
        /// <p>运行人UIN，精确匹配。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("RunUserUins")]
        public string[] RunUserUins{ get; set; }

        /// <summary>
        /// <p>标签名称ID，精确匹配，可通过标签相关接口获取。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("LabelKeyIds")]
        public string[] LabelKeyIds{ get; set; }

        /// <summary>
        /// <p>标签值ID，精确匹配，可通过标签相关接口获取。非必填，多选（多个值之间为 OR 关系）</p>
        /// </summary>
        [JsonProperty("LabelValueIds")]
        public string[] LabelValueIds{ get; set; }

        /// <summary>
        /// <p>排序条件，多个之间按数组顺序表示优先级。非必填，默认按 CreateTime Desc。<br>可排序字段白名单：CreateTime、EndTime、RunCostTime</p>
        /// </summary>
        [JsonProperty("OrderBys")]
        public OrderBy[] OrderBys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "WorkflowNameKeyword", this.WorkflowNameKeyword);
            this.SetParamSimple(map, prefix + "CreateStartTime", this.CreateStartTime);
            this.SetParamSimple(map, prefix + "CreateEndTime", this.CreateEndTime);
            this.SetParamArraySimple(map, prefix + "RunStates.", this.RunStates);
            this.SetParamArraySimple(map, prefix + "ErrorCodeStrings.", this.ErrorCodeStrings);
            this.SetParamArraySimple(map, prefix + "RunUserUins.", this.RunUserUins);
            this.SetParamArraySimple(map, prefix + "LabelKeyIds.", this.LabelKeyIds);
            this.SetParamArraySimple(map, prefix + "LabelValueIds.", this.LabelValueIds);
            this.SetParamArrayObj(map, prefix + "OrderBys.", this.OrderBys);
        }
    }
}

