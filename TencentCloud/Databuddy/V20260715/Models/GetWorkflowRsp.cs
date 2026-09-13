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

    public class GetWorkflowRsp : AbstractModel
    {
        
        /// <summary>
        /// <p>工作空间ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// <p>工作流基本信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BaseInfo")]
        public WorkflowBaseInfoDetail BaseInfo{ get; set; }

        /// <summary>
        /// <p>工作流调度配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Trigger")]
        public WorkflowTriggerConfiguration[] Trigger{ get; set; }

        /// <summary>
        /// <p>工作流参数列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamList")]
        public ParamInfo[] ParamList{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelList")]
        public LabelBrief[] LabelList{ get; set; }

        /// <summary>
        /// <p>工作流告警配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Alarm")]
        public AlarmBrief Alarm{ get; set; }

        /// <summary>
        /// <p>监控指标配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorMetric")]
        public MonitorMetricBrief MonitorMetric{ get; set; }

        /// <summary>
        /// <p>工作流高级设置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdvanceConfig")]
        public WorkflowAdvanceConfig AdvanceConfig{ get; set; }

        /// <summary>
        /// <p>工作流任务列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskList")]
        public WorkflowTask[] TaskList{ get; set; }

        /// <summary>
        /// <p>工作流绑定的 Bundle唯一标识，未绑定时为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleId")]
        public string BundleId{ get; set; }

        /// <summary>
        /// <p>Bundle信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BundleInfo")]
        public string BundleInfo{ get; set; }

        /// <summary>
        /// <p>Git配置ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GitConfigId")]
        public string GitConfigId{ get; set; }

        /// <summary>
        /// <p>Git分支信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GitBranch")]
        public string GitBranch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamObj(map, prefix + "BaseInfo.", this.BaseInfo);
            this.SetParamArrayObj(map, prefix + "Trigger.", this.Trigger);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamArrayObj(map, prefix + "LabelList.", this.LabelList);
            this.SetParamObj(map, prefix + "Alarm.", this.Alarm);
            this.SetParamObj(map, prefix + "MonitorMetric.", this.MonitorMetric);
            this.SetParamObj(map, prefix + "AdvanceConfig.", this.AdvanceConfig);
            this.SetParamArrayObj(map, prefix + "TaskList.", this.TaskList);
            this.SetParamSimple(map, prefix + "BundleId", this.BundleId);
            this.SetParamSimple(map, prefix + "BundleInfo", this.BundleInfo);
            this.SetParamSimple(map, prefix + "GitConfigId", this.GitConfigId);
            this.SetParamSimple(map, prefix + "GitBranch", this.GitBranch);
        }
    }
}

