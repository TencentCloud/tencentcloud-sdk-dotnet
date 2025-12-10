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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBatchOperateTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("Page")]
        public string Page{ get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// 状态列表
        /// 草稿：'NS'，'N','P','R'
        /// 运行：''Y'
        /// 停止：'F'
        /// 冻结：'O'
        /// 停止中：'T'
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }

        /// <summary>
        /// 责任人名列表
        /// </summary>
        [JsonProperty("OwnerNameList")]
        public string[] OwnerNameList{ get; set; }

        /// <summary>
        /// 工作流列表
        /// </summary>
        [JsonProperty("WorkflowIdList")]
        public string[] WorkflowIdList{ get; set; }

        /// <summary>
        /// 任务名称搜索
        /// </summary>
        [JsonProperty("TaskNameFilter")]
        public string TaskNameFilter{ get; set; }

        /// <summary>
        /// 任务类型列表
        /// </summary>
        [JsonProperty("TaskTypeList")]
        public string[] TaskTypeList{ get; set; }

        /// <summary>
        /// 文件夹列表
        /// </summary>
        [JsonProperty("FordIdList")]
        public string[] FordIdList{ get; set; }

        /// <summary>
        /// 任务Id搜索
        /// </summary>
        [JsonProperty("TaskIdFilter")]
        public string TaskIdFilter{ get; set; }

        /// <summary>
        /// 责任人搜索
        /// </summary>
        [JsonProperty("OwnerNameFilter")]
        public string OwnerNameFilter{ get; set; }

        /// <summary>
        /// 排序字段：
        /// UpdateTime
        /// CreateTime
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// asc:升序
        /// desc:降序
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// 引擎类型列表：三种
        /// SparkJob
        /// SparkSql
        /// presto
        /// </summary>
        [JsonProperty("DataEngineList")]
        public string[] DataEngineList{ get; set; }

        /// <summary>
        /// 操作人名
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("OwnerId")]
        public string OwnerId{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// 数据源ID列表
        /// </summary>
        [JsonProperty("DatasourceIdList")]
        public string[] DatasourceIdList{ get; set; }

        /// <summary>
        /// 数据源类型列表
        /// </summary>
        [JsonProperty("DatasourceTypeList")]
        public string[] DatasourceTypeList{ get; set; }

        /// <summary>
        /// 调度单位类型列表
        /// </summary>
        [JsonProperty("CycleUnitList")]
        public string[] CycleUnitList{ get; set; }

        /// <summary>
        /// 是否筛选出可提交的任务
        /// </summary>
        [JsonProperty("CanSubmit")]
        public bool? CanSubmit{ get; set; }

        /// <summary>
        /// 返回时间字段需要转换的时区
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// 任务最后更新时间最小值，ISO8601格式，如2025-07-16T15:00:00+08:00
        /// </summary>
        [JsonProperty("MinUpdateTime")]
        public string MinUpdateTime{ get; set; }

        /// <summary>
        /// 任务最后更新时间最大值，ISO8601格式，如2025-07-17T15:00:00+08:00
        /// </summary>
        [JsonProperty("MaxUpdateTime")]
        public string MaxUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
            this.SetParamArraySimple(map, prefix + "OwnerNameList.", this.OwnerNameList);
            this.SetParamArraySimple(map, prefix + "WorkflowIdList.", this.WorkflowIdList);
            this.SetParamSimple(map, prefix + "TaskNameFilter", this.TaskNameFilter);
            this.SetParamArraySimple(map, prefix + "TaskTypeList.", this.TaskTypeList);
            this.SetParamArraySimple(map, prefix + "FordIdList.", this.FordIdList);
            this.SetParamSimple(map, prefix + "TaskIdFilter", this.TaskIdFilter);
            this.SetParamSimple(map, prefix + "OwnerNameFilter", this.OwnerNameFilter);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamArraySimple(map, prefix + "DataEngineList.", this.DataEngineList);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "OwnerId", this.OwnerId);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamArraySimple(map, prefix + "DatasourceIdList.", this.DatasourceIdList);
            this.SetParamArraySimple(map, prefix + "DatasourceTypeList.", this.DatasourceTypeList);
            this.SetParamArraySimple(map, prefix + "CycleUnitList.", this.CycleUnitList);
            this.SetParamSimple(map, prefix + "CanSubmit", this.CanSubmit);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "MinUpdateTime", this.MinUpdateTime);
            this.SetParamSimple(map, prefix + "MaxUpdateTime", this.MaxUpdateTime);
        }
    }
}

