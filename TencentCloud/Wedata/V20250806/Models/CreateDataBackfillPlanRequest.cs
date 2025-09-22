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

    public class CreateDataBackfillPlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 所属项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 补录任务集合
        /// </summary>
        [JsonProperty("TaskIds")]
        public string[] TaskIds{ get; set; }

        /// <summary>
        /// 补录任务的数据时间配置
        /// </summary>
        [JsonProperty("DataBackfillRangeList")]
        public DataBackfillRange[] DataBackfillRangeList{ get; set; }

        /// <summary>
        /// 时区，默认UTC+8
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// 数据补录计划名称，不填则由系统随机生成一串字符
        /// </summary>
        [JsonProperty("DataBackfillPlanName")]
        public string DataBackfillPlanName{ get; set; }

        /// <summary>
        /// 检查父任务类型，取值范围：- NONE-全部不检查- ALL-检查全部上游父任务- MAKE_SCOPE-只在（当前补录计划）选中任务中检查,默认NONE不检查
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// 补录是否忽略事件依赖,默认true
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// 自定义的工作流自依赖，yes或者no；如果不配置，则使用工作流原有自依赖
        /// </summary>
        [JsonProperty("RedefineSelfWorkflowDependency")]
        public string RedefineSelfWorkflowDependency{ get; set; }

        /// <summary>
        /// 自定义实例运行并发度, 如果不配置，则使用任务原有自依赖
        /// </summary>
        [JsonProperty("RedefineParallelNum")]
        public ulong? RedefineParallelNum{ get; set; }

        /// <summary>
        /// 调度资源组id，为空则表示使用任务原有调度执行资源组
        /// </summary>
        [JsonProperty("SchedulerResourceGroupId")]
        public string SchedulerResourceGroupId{ get; set; }

        /// <summary>
        /// 集成任务资源组id，为空则表示使用任务原有调度执行资源组
        /// </summary>
        [JsonProperty("IntegrationResourceGroupId")]
        public string IntegrationResourceGroupId{ get; set; }

        /// <summary>
        /// 自定义参数，可以重新指定任务的参数，方便补录实例执行新的逻辑
        /// </summary>
        [JsonProperty("RedefineParamList")]
        public KVPair[] RedefineParamList{ get; set; }

        /// <summary>
        /// 补录是实例数据时间顺序，生效必须满足2个条件:
        /// 1. 必须同周期任务
        /// 2. 优先按依赖关系执行，无依赖关系影响的情况下按配置执行顺序执行
        ///  
        /// 可选值
        /// - NORMAL: 不设置
        /// - ORDER: 顺序
        /// - REVERSE: 逆序
        /// 不设置默认为NORMAL
        /// </summary>
        [JsonProperty("DataTimeOrder")]
        public string DataTimeOrder{ get; set; }

        /// <summary>
        /// 补录实例重新生成周期，如果设置会重新指定补录任务实例的生成周期，目前只会将天实例转换成每月1号生成的实例
        /// * MONTH_CYCLE: 月
        /// </summary>
        [JsonProperty("RedefineCycleType")]
        public string RedefineCycleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "TaskIds.", this.TaskIds);
            this.SetParamArrayObj(map, prefix + "DataBackfillRangeList.", this.DataBackfillRangeList);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "DataBackfillPlanName", this.DataBackfillPlanName);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "RedefineSelfWorkflowDependency", this.RedefineSelfWorkflowDependency);
            this.SetParamSimple(map, prefix + "RedefineParallelNum", this.RedefineParallelNum);
            this.SetParamSimple(map, prefix + "SchedulerResourceGroupId", this.SchedulerResourceGroupId);
            this.SetParamSimple(map, prefix + "IntegrationResourceGroupId", this.IntegrationResourceGroupId);
            this.SetParamArrayObj(map, prefix + "RedefineParamList.", this.RedefineParamList);
            this.SetParamSimple(map, prefix + "DataTimeOrder", this.DataTimeOrder);
            this.SetParamSimple(map, prefix + "RedefineCycleType", this.RedefineCycleType);
        }
    }
}

