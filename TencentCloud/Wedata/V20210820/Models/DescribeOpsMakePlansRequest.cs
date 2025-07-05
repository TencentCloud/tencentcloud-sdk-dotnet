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

    public class DescribeOpsMakePlansRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 分页数，默认值1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 分页大小，默认值10
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 补录计划ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 补录计划名称
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 补录任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 补录任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 补录计划创建者
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 补录计划最小创建时间
        /// </summary>
        [JsonProperty("MinCreateTime")]
        public string MinCreateTime{ get; set; }

        /// <summary>
        /// 补录计划最大创建时间
        /// </summary>
        [JsonProperty("MaxCreateTime")]
        public string MaxCreateTime{ get; set; }

        /// <summary>
        /// 实例状态过滤条件
        /// </summary>
        [JsonProperty("StateList")]
        public long?[] StateList{ get; set; }

        /// <summary>
        /// 模糊查询关键字
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "MinCreateTime", this.MinCreateTime);
            this.SetParamSimple(map, prefix + "MaxCreateTime", this.MaxCreateTime);
            this.SetParamArraySimple(map, prefix + "StateList.", this.StateList);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

