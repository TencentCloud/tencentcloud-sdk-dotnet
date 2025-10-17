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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportContractComparisonTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行合同审查任务的员工信息。
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同对比任务ID，该参数通过调用接口CreateContractComparisonTask获取。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 导出对比结果文件类型。
        /// 类型如下：
        /// <ul>
        /// <li> **0**：【PDF】以新合同文件为基础，导出带有可视化对比点标注的PDF文件。</li>
        /// <li> **1**：【EXCEL】导出结构化的对比点明细表格，以列表形式罗列每一个差异点，包含改动位置、类型、标签及修改前后的完整内容。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ExportType")]
        public long? ExportType{ get; set; }

        /// <summary>
        /// 是否忽略，适用于PDF。
        /// <ul>
        /// <li> **true**：导出文件标注去掉忽略项。</li>
        /// <li> **false**：导出文件包含所有对比点。</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Ignore")]
        public bool? Ignore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "ExportType", this.ExportType);
            this.SetParamSimple(map, prefix + "Ignore", this.Ignore);
        }
    }
}

