/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceApiOpsRequest : AbstractModel
    {
        
        /// <summary>
        /// 单个查询条件
        /// </summary>
        [JsonProperty("Instance")]
        public InstanceOpsDto Instance{ get; set; }

        /// <summary>
        /// 排序字段，目前包含：重试次数，实例数据时间，运行耗时
        /// </summary>
        [JsonProperty("SortCol")]
        public string SortCol{ get; set; }

        /// <summary>
        /// 任务id列表
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string[] TaskIdList{ get; set; }

        /// <summary>
        /// 按照taskName模糊查询
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string[] TaskNameList{ get; set; }

        /// <summary>
        /// 文件夹列表
        /// </summary>
        [JsonProperty("FolderList")]
        public string[] FolderList{ get; set; }

        /// <summary>
        /// 升序或者降序
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 实例状态列表
        /// </summary>
        [JsonProperty("StateList")]
        public long?[] StateList{ get; set; }

        /// <summary>
        /// 实例类型列表
        /// </summary>
        [JsonProperty("TaskTypeList")]
        public long?[] TaskTypeList{ get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        [JsonProperty("CycleList")]
        public string[] CycleList{ get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("OwnerList")]
        public string[] OwnerList{ get; set; }

        /// <summary>
        /// 数据时间
        /// </summary>
        [JsonProperty("DateFrom")]
        public string DateFrom{ get; set; }

        /// <summary>
        /// 数据时间
        /// </summary>
        [JsonProperty("DateTo")]
        public string DateTo{ get; set; }

        /// <summary>
        /// 实例入库时间
        /// </summary>
        [JsonProperty("CreateTimeFrom")]
        public string CreateTimeFrom{ get; set; }

        /// <summary>
        /// 实例入库时间
        /// </summary>
        [JsonProperty("CreateTimeTo")]
        public string CreateTimeTo{ get; set; }

        /// <summary>
        ///  开始执行时间
        /// </summary>
        [JsonProperty("StartFrom")]
        public string StartFrom{ get; set; }

        /// <summary>
        ///  开始执行时间
        /// </summary>
        [JsonProperty("StartTo")]
        public string StartTo{ get; set; }

        /// <summary>
        /// 所属工作流
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// 按照workflowName模糊查询
        /// </summary>
        [JsonProperty("WorkflowNameList")]
        public string[] WorkflowNameList{ get; set; }

        /// <summary>
        /// 关键字模糊查询
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// searchColumns是搜索的字段名列表
        /// </summary>
        [JsonProperty("SearchColumns")]
        public string[] SearchColumns{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 限制
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 任务类型映射关系, 存储任务类型id和任务类型描述信息
        /// </summary>
        [JsonProperty("TaskTypeMap")]
        public TaskTypeMap[] TaskTypeMap{ get; set; }

        /// <summary>
        /// 0 补录类型 1 周期实例 2 非周期实例
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 是否dag
        /// </summary>
        [JsonProperty("DagDeal")]
        public bool? DagDeal{ get; set; }

        /// <summary>
        ///  1 父实例 2 子实例
        /// </summary>
        [JsonProperty("DagType")]
        public string DagType{ get; set; }

        /// <summary>
        /// 1 自依赖 2 任务依赖  3 所有依赖
        /// </summary>
        [JsonProperty("DagDependent")]
        public string DagDependent{ get; set; }

        /// <summary>
        /// dag深度 默认为1，取值 1-6
        /// </summary>
        [JsonProperty("DagDepth")]
        public long? DagDepth{ get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 根据当前数据时间或者是下一个数据时间查询, 默认当前数据时间
        /// </summary>
        [JsonProperty("DataTimeCycle")]
        public string DataTimeCycle{ get; set; }

        /// <summary>
        /// 资源组id,多个资源组id用英文逗号分隔
        /// </summary>
        [JsonProperty("ExecutorGroupIdList")]
        public string[] ExecutorGroupIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Instance.", this.Instance);
            this.SetParamSimple(map, prefix + "SortCol", this.SortCol);
            this.SetParamArraySimple(map, prefix + "TaskIdList.", this.TaskIdList);
            this.SetParamArraySimple(map, prefix + "TaskNameList.", this.TaskNameList);
            this.SetParamArraySimple(map, prefix + "FolderList.", this.FolderList);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamArraySimple(map, prefix + "TaskTypeList.", this.TaskTypeList);
            this.SetParamArraySimple(map, prefix + "CycleList.", this.CycleList);
            this.SetParamArraySimple(map, prefix + "OwnerList.", this.OwnerList);
            this.SetParamSimple(map, prefix + "DateFrom", this.DateFrom);
            this.SetParamSimple(map, prefix + "DateTo", this.DateTo);
            this.SetParamSimple(map, prefix + "CreateTimeFrom", this.CreateTimeFrom);
            this.SetParamSimple(map, prefix + "CreateTimeTo", this.CreateTimeTo);
            this.SetParamSimple(map, prefix + "StartFrom", this.StartFrom);
            this.SetParamSimple(map, prefix + "StartTo", this.StartTo);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamArraySimple(map, prefix + "WorkflowNameList.", this.WorkflowNameList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "SearchColumns.", this.SearchColumns);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "TaskTypeMap.", this.TaskTypeMap);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "DagDeal", this.DagDeal);
            this.SetParamSimple(map, prefix + "DagType", this.DagType);
            this.SetParamSimple(map, prefix + "DagDependent", this.DagDependent);
            this.SetParamSimple(map, prefix + "DagDepth", this.DagDepth);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "DataTimeCycle", this.DataTimeCycle);
            this.SetParamArraySimple(map, prefix + "ExecutorGroupIdList.", this.ExecutorGroupIdList);
        }
    }
}

