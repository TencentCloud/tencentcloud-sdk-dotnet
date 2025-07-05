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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssessmentTask : AbstractModel
    {
        
        /// <summary>
        /// 评估任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 评估任务的自增ID
        /// </summary>
        [JsonProperty("TaskUid")]
        public long? TaskUid{ get; set; }

        /// <summary>
        /// 评估任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 业务名称
        /// </summary>
        [JsonProperty("BusinessName")]
        public string BusinessName{ get; set; }

        /// <summary>
        /// 业务所属部门
        /// </summary>
        [JsonProperty("BusinessDept")]
        public string BusinessDept{ get; set; }

        /// <summary>
        /// 业务负责人
        /// </summary>
        [JsonProperty("BusinessOwner")]
        public string BusinessOwner{ get; set; }

        /// <summary>
        /// 评估模板Id
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 评估模板名称
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 分类分级模板Id
        /// </summary>
        [JsonProperty("ComplianceGroupId")]
        public long? ComplianceGroupId{ get; set; }

        /// <summary>
        /// 分类分级模板名称
        /// </summary>
        [JsonProperty("ComplianceGroupName")]
        public string ComplianceGroupName{ get; set; }

        /// <summary>
        /// 评估项数量
        /// </summary>
        [JsonProperty("ControlItemCount")]
        public long? ControlItemCount{ get; set; }

        /// <summary>
        /// 风险项数量（仅状态为finished的风险项不计入总数，其余状态均算入该数量）
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 评估任务完成时间
        /// </summary>
        [JsonProperty("FinishedTime")]
        public string FinishedTime{ get; set; }

        /// <summary>
        /// 评估任务发起时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 评估状态。(waiting待评估，processing评估中, , finished已评估, failed评估失败)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 待处理各等级风险项信息
        /// </summary>
        [JsonProperty("RiskCountInfoList")]
        public RiskCountInfo[] RiskCountInfoList{ get; set; }

        /// <summary>
        /// 数据源信息
        /// </summary>
        [JsonProperty("DiscoveryCondition")]
        public DiscoveryCondition DiscoveryCondition{ get; set; }

        /// <summary>
        /// 评估任务失败信息
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// 模板主键id
        /// </summary>
        [JsonProperty("TemplateUid")]
        public long? TemplateUid{ get; set; }

        /// <summary>
        /// 进度百分比
        /// </summary>
        [JsonProperty("ProgressPercent")]
        public long? ProgressPercent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskUid", this.TaskUid);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "BusinessName", this.BusinessName);
            this.SetParamSimple(map, prefix + "BusinessDept", this.BusinessDept);
            this.SetParamSimple(map, prefix + "BusinessOwner", this.BusinessOwner);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "ComplianceGroupId", this.ComplianceGroupId);
            this.SetParamSimple(map, prefix + "ComplianceGroupName", this.ComplianceGroupName);
            this.SetParamSimple(map, prefix + "ControlItemCount", this.ControlItemCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "FinishedTime", this.FinishedTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "RiskCountInfoList.", this.RiskCountInfoList);
            this.SetParamObj(map, prefix + "DiscoveryCondition.", this.DiscoveryCondition);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "TemplateUid", this.TemplateUid);
            this.SetParamSimple(map, prefix + "ProgressPercent", this.ProgressPercent);
        }
    }
}

