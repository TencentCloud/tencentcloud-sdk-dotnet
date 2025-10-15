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

    public class DataBackfill : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据补录计划id
        /// </summary>
        [JsonProperty("DataBackfillPlanId")]
        public string DataBackfillPlanId{ get; set; }

        /// <summary>
        /// 数据补录计划名称
        /// </summary>
        [JsonProperty("DataBackfillPlanName")]
        public string DataBackfillPlanName{ get; set; }

        /// <summary>
        /// 补录任务集合
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 补录任务的数据配置列表
        /// </summary>
        [JsonProperty("DataBackfillRangeList")]
        public DataBackfillRange[] DataBackfillRangeList{ get; set; }

        /// <summary>
        /// 检查父任务类型，取值范围：- NONE-全部不检查- ALL-检查全部上游父任务- MAKE_SCOPE-只在（当前补录计划）选中任务中检查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// 补录是否忽略事件依赖	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// 自定义实例运行并发度, 返回为null或者不返回，则表示任务原有自依赖
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedefineParallelNum")]
        public ulong? RedefineParallelNum{ get; set; }

        /// <summary>
        /// 自定义的工作流自依赖，yes或者no；如果不配置，则使用工作流原有自依赖
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedefineSelfWorkflowDependency")]
        public string RedefineSelfWorkflowDependency{ get; set; }

        /// <summary>
        /// 调度资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulerResourceGroupId")]
        public string SchedulerResourceGroupId{ get; set; }

        /// <summary>
        /// 集成资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntegrationResourceGroupId")]
        public string IntegrationResourceGroupId{ get; set; }

        /// <summary>
        /// 补录自定义的生成周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedefineCycleType")]
        public string RedefineCycleType{ get; set; }

        /// <summary>
        /// 自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RedefineParamList")]
        public KVPair[] RedefineParamList{ get; set; }

        /// <summary>
        /// 补录任务的执行开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 补录任务的执行结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 创建用户id
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// 补录计划实例完成百分数
        /// </summary>
        [JsonProperty("CompletePercent")]
        public ulong? CompletePercent{ get; set; }

        /// <summary>
        /// 补录计划实例成功百分数
        /// </summary>
        [JsonProperty("SuccessPercent")]
        public ulong? SuccessPercent{ get; set; }

        /// <summary>
        /// 补录是实例数据时间顺序，生效必须满足2个条件:1. 必须同周期任务2. 优先按依赖关系执行，无依赖关系影响的情况下按配置执行顺序执行 可选值- NORMAL: 不设置- ORDER: 顺序- REVERSE: 逆序不设置默认为NORMAL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataTimeOrder")]
        public string DataTimeOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DataBackfillPlanId", this.DataBackfillPlanId);
            this.SetParamSimple(map, prefix + "DataBackfillPlanName", this.DataBackfillPlanName);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamArrayObj(map, prefix + "DataBackfillRangeList.", this.DataBackfillRangeList);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "RedefineParallelNum", this.RedefineParallelNum);
            this.SetParamSimple(map, prefix + "RedefineSelfWorkflowDependency", this.RedefineSelfWorkflowDependency);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupId", this.SchedulerResourceGroupId);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupId", this.IntegrationResourceGroupId);
            this.SetParamSimple(map, prefix + "RedefineCycleType", this.RedefineCycleType);
            this.SetParamArrayObj(map, prefix + "RedefineParamList.", this.RedefineParamList);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "CompletePercent", this.CompletePercent);
            this.SetParamSimple(map, prefix + "SuccessPercent", this.SuccessPercent);
            this.SetParamSimple(map, prefix + "DataTimeOrder", this.DataTimeOrder);
        }
    }
}

