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

    public class DescribeOpsWorkflowsRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务产品类型名称列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("ProductNameList")]
        public string ProductNameList{ get; set; }

        /// <summary>
        /// 文件id列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("FolderIdList")]
        public string FolderIdList{ get; set; }

        /// <summary>
        /// 工作流id，以 ',' 号分割
        /// </summary>
        [JsonProperty("WorkFlowIdList")]
        public string WorkFlowIdList{ get; set; }

        /// <summary>
        /// 工作流名称列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("WorkFlowNameList")]
        public string WorkFlowNameList{ get; set; }

        /// <summary>
        /// 任务名称列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string TaskNameList{ get; set; }

        /// <summary>
        /// 任务id列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string TaskIdList{ get; set; }

        /// <summary>
        /// 状态列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("StatusList")]
        public string StatusList{ get; set; }

        /// <summary>
        /// 负责人列表，以 ',' 号分割
        /// </summary>
        [JsonProperty("InChargeList")]
        public string InChargeList{ get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 排序项
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// 排序方式，DESC或ASC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// 项目ID列表，用于多项目工作流筛选
        /// </summary>
        [JsonProperty("ProjectIds")]
        public string[] ProjectIds{ get; set; }

        /// <summary>
        /// 工作流类型列表 多个用英文逗号连接 cycle,manual. 默认只查询 cycle
        /// </summary>
        [JsonProperty("WorkflowTypeList")]
        public string[] WorkflowTypeList{ get; set; }

        /// <summary>
        /// 工作流过滤keyword，支持工作流 id/name 模糊匹配， 多个用|分割
        /// </summary>
        [JsonProperty("KeyWord")]
        public string KeyWord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProductNameList", this.ProductNameList);
            this.SetParamSimple(map, prefix + "FolderIdList", this.FolderIdList);
            this.SetParamSimple(map, prefix + "WorkFlowIdList", this.WorkFlowIdList);
            this.SetParamSimple(map, prefix + "WorkFlowNameList", this.WorkFlowNameList);
            this.SetParamSimple(map, prefix + "TaskNameList", this.TaskNameList);
            this.SetParamSimple(map, prefix + "TaskIdList", this.TaskIdList);
            this.SetParamSimple(map, prefix + "StatusList", this.StatusList);
            this.SetParamSimple(map, prefix + "InChargeList", this.InChargeList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "WorkflowTypeList.", this.WorkflowTypeList);
            this.SetParamSimple(map, prefix + "KeyWord", this.KeyWord);
        }
    }
}

