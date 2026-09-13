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

    public class InnerWorkflowTaskRun : AbstractModel
    {
        
        /// <summary>
        /// 当前页码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 总记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 总页数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalPageNumber")]
        public long? TotalPageNumber{ get; set; }

        /// <summary>
        /// 迭代运行列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Items")]
        public InnerWorkflowTaskRunIteration[] Items{ get; set; }

        /// <summary>
        /// 迭代次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IterationCount")]
        public long? IterationCount{ get; set; }

        /// <summary>
        /// 失败次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureCount")]
        public long? FailureCount{ get; set; }

        /// <summary>
        /// 成功次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// 内嵌工作流ID，可通过 ListWorkflows 获取
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerWorkflowId")]
        public string InnerWorkflowId{ get; set; }

        /// <summary>
        /// 内嵌任务ID，可通过 ListWorkflowTasks 获取
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerTaskId")]
        public string InnerTaskId{ get; set; }

        /// <summary>
        /// 内嵌任务运行状态数量统计（实例业务枚举键值对列表）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerTaskRunBizEnumInfos")]
        public ScheduleBizEnumBrief[] InnerTaskRunBizEnumInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalPageNumber", this.TotalPageNumber);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "IterationCount", this.IterationCount);
            this.SetParamSimple(map, prefix + "FailureCount", this.FailureCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "InnerWorkflowId", this.InnerWorkflowId);
            this.SetParamSimple(map, prefix + "InnerTaskId", this.InnerTaskId);
            this.SetParamArrayObj(map, prefix + "InnerTaskRunBizEnumInfos.", this.InnerTaskRunBizEnumInfos);
        }
    }
}

