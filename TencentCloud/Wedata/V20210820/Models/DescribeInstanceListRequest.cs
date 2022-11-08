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

    public class DescribeInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目/工作空间id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 周期列表（如天，一次性），可选
        /// </summary>
        [JsonProperty("CycleList")]
        public string[] CycleList{ get; set; }

        /// <summary>
        /// 责任人
        /// </summary>
        [JsonProperty("OwnerList")]
        public string[] OwnerList{ get; set; }

        /// <summary>
        /// 跟之前保持一致
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 排序顺序（asc，desc）
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 排序列（costTime 运行耗时，startTime 开始时间，state 实例状态，curRunDate 数据时间）
        /// </summary>
        [JsonProperty("SortCol")]
        public string SortCol{ get; set; }

        /// <summary>
        /// 类型列表（如35 shell任务），可选
        /// </summary>
        [JsonProperty("TaskTypeList")]
        public long?[] TaskTypeList{ get; set; }

        /// <summary>
        /// 状态列表（如成功 2，正在执行 1），可选
        /// </summary>
        [JsonProperty("StateList")]
        public long?[] StateList{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "CycleList.", this.CycleList);
            this.SetParamArraySimple(map, prefix + "OwnerList.", this.OwnerList);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "SortCol", this.SortCol);
            this.SetParamArraySimple(map, prefix + "TaskTypeList.", this.TaskTypeList);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

