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

    public class DescribeRelatedTasksByTaskIdRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 当前页码，从1开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 单页大小，最大200
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 查询直接依赖方向，如UP表示上游、DOWN表示下游
        /// </summary>
        [JsonProperty("DependencyDirection")]
        public string DependencyDirection{ get; set; }

        /// <summary>
        /// 查询开发环境还是生产环境版本，DEV表示开发环境、PROD表示生产环境
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// 任务名称，模糊搜索
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务调度周期,I：分支；H：小时；D：天；W：周；M：月；Y：年；O：一次性。
        /// </summary>
        [JsonProperty("CycleTypeList")]
        public string[] CycleTypeList{ get; set; }

        /// <summary>
        /// 任务状态，N：新建； Y：调度中； O：已暂停；F：已下线；INVALID：已失效
        /// </summary>
        [JsonProperty("StatusList")]
        public string[] StatusList{ get; set; }

        /// <summary>
        /// 任务责任人名
        /// </summary>
        [JsonProperty("OwnerNameList")]
        public string[] OwnerNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "DependencyDirection", this.DependencyDirection);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamArraySimple(map, prefix + "CycleTypeList.", this.CycleTypeList);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
            this.SetParamArraySimple(map, prefix + "OwnerNameList.", this.OwnerNameList);
        }
    }
}

