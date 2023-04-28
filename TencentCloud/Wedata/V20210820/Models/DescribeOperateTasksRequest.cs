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

    public class DescribeOperateTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 文件夹id，多个文件夹以逗号分隔
        /// </summary>
        [JsonProperty("FolderIdList")]
        public string FolderIdList{ get; set; }

        /// <summary>
        /// 工作流id，多个工作流id之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("WorkFlowIdList")]
        public string WorkFlowIdList{ get; set; }

        /// <summary>
        /// 工作流名称，多个工作流名称之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("WorkFlowNameList")]
        public string WorkFlowNameList{ get; set; }

        /// <summary>
        /// 任务名称，多个任务名称之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("TaskNameList")]
        public string TaskNameList{ get; set; }

        /// <summary>
        /// 任务id，多个任务id之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("TaskIdList")]
        public string TaskIdList{ get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [JsonProperty("PageNumber")]
        public string PageNumber{ get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public string PageSize{ get; set; }

        /// <summary>
        /// 排序字段，支持字段为FirstSubmitTime和FirstRunTime，标识最近提交和首次执行事件
        /// </summary>
        [JsonProperty("SortItem")]
        public string SortItem{ get; set; }

        /// <summary>
        /// 排序类型。两种取值 DESC、ASC
        /// </summary>
        [JsonProperty("SortType")]
        public string SortType{ get; set; }

        /// <summary>
        /// 责任人，多个责任人之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("InChargeList")]
        public string InChargeList{ get; set; }

        /// <summary>
        /// 任务类型Id字符串，多个任务类型id之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("TaskTypeIdList")]
        public string TaskTypeIdList{ get; set; }

        /// <summary>
        /// 任务状态字符串，多个任务状态之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("StatusList")]
        public string StatusList{ get; set; }

        /// <summary>
        /// 任务周期类型字符串，多个任务周期之间以英文字符逗号分隔
        /// </summary>
        [JsonProperty("TaskCycleUnitList")]
        public string TaskCycleUnitList{ get; set; }

        /// <summary>
        /// 任务所属产品类型
        /// </summary>
        [JsonProperty("ProductNameList")]
        public string ProductNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "FolderIdList", this.FolderIdList);
            this.SetParamSimple(map, prefix + "WorkFlowIdList", this.WorkFlowIdList);
            this.SetParamSimple(map, prefix + "WorkFlowNameList", this.WorkFlowNameList);
            this.SetParamSimple(map, prefix + "TaskNameList", this.TaskNameList);
            this.SetParamSimple(map, prefix + "TaskIdList", this.TaskIdList);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortItem", this.SortItem);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
            this.SetParamSimple(map, prefix + "InChargeList", this.InChargeList);
            this.SetParamSimple(map, prefix + "TaskTypeIdList", this.TaskTypeIdList);
            this.SetParamSimple(map, prefix + "StatusList", this.StatusList);
            this.SetParamSimple(map, prefix + "TaskCycleUnitList", this.TaskCycleUnitList);
            this.SetParamSimple(map, prefix + "ProductNameList", this.ProductNameList);
        }
    }
}

