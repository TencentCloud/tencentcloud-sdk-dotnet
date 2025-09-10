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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RunGroup : AbstractModel
    {
        
        /// <summary>
        /// 任务批次ID。
        /// </summary>
        [JsonProperty("RunGroupId")]
        public string RunGroupId{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目名称。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 应用类型。
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 应用版本。
        /// </summary>
        [JsonProperty("ApplicationVersion")]
        public ApplicationVersion ApplicationVersion{ get; set; }

        /// <summary>
        /// 应用访问类型：
        /// - PRIVATE 私有应用
        /// - PUBLIC 公共应用
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// 环境ID。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// 表格ID，单例运行为空。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 任务状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务批次类型 ：
        /// - WDL
        /// - NEXTFLOW
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 工作目录。
        /// </summary>
        [JsonProperty("WorkDir")]
        public string WorkDir{ get; set; }

        /// <summary>
        /// 任务输入。
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 任务输入类型：
        /// - JSON: 导入JSON
        /// - MANUAL: 手动输入
        /// - COS: COS文件
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 输入COS地址。
        /// </summary>
        [JsonProperty("InputCosUri")]
        public string InputCosUri{ get; set; }

        /// <summary>
        /// 输入模板ID。
        /// </summary>
        [JsonProperty("InputTemplateId")]
        public string InputTemplateId{ get; set; }

        /// <summary>
        /// WDL运行选项。
        /// </summary>
        [JsonProperty("Option")]
        public RunOption Option{ get; set; }

        /// <summary>
        /// Nextflow运行选项。
        /// </summary>
        [JsonProperty("NFOption")]
        public NFOption NFOption{ get; set; }

        /// <summary>
        /// 使用的缓存卷。
        /// </summary>
        [JsonProperty("Volumes")]
        public VolumeInfo[] Volumes{ get; set; }

        /// <summary>
        /// 任务总数量。
        /// </summary>
        [JsonProperty("TotalRun")]
        public ulong? TotalRun{ get; set; }

        /// <summary>
        /// 各状态任务的数量。
        /// </summary>
        [JsonProperty("RunStatusCounts")]
        public RunStatusCount[] RunStatusCounts{ get; set; }

        /// <summary>
        /// 执行时间。
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public ExecutionTime ExecutionTime{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 任务批次通知。
        /// </summary>
        [JsonProperty("Notification")]
        public RunGroupNotification Notification{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建者。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 创建者ID。
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// 运行结果通知方式。
        /// </summary>
        [JsonProperty("ResultNotify")]
        public string ResultNotify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RunGroupId", this.RunGroupId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamObj(map, prefix + "ApplicationVersion.", this.ApplicationVersion);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WorkDir", this.WorkDir);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputCosUri", this.InputCosUri);
            this.SetParamSimple(map, prefix + "InputTemplateId", this.InputTemplateId);
            this.SetParamObj(map, prefix + "Option.", this.Option);
            this.SetParamObj(map, prefix + "NFOption.", this.NFOption);
            this.SetParamArrayObj(map, prefix + "Volumes.", this.Volumes);
            this.SetParamSimple(map, prefix + "TotalRun", this.TotalRun);
            this.SetParamArrayObj(map, prefix + "RunStatusCounts.", this.RunStatusCounts);
            this.SetParamObj(map, prefix + "ExecutionTime.", this.ExecutionTime);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamObj(map, prefix + "Notification.", this.Notification);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "ResultNotify", this.ResultNotify);
        }
    }
}

