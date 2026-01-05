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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateTriggerWorkflowPartiallyRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 工作流ID
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 责任人ID
        /// </summary>
        [JsonProperty("NewSetting")]
        public UpdateTriggerWorkflowPartially NewSetting{ get; set; }

        /// <summary>
        /// 删除字段内容，采用属性路径的形式标识，删除的值以":"分割，多个值以","分割
        ///  // 删除调度参数中 ParamKey 为 aa,bb 的属性 "WorkflowParams:aa,bb"
        ///  // 删除配置的 TriggerId 为 da46d950-d5ca-4cfb-a5a9-f3c2eeea1bf0 的调度配置"TriggerWorkflowSchedulerConfigurations :da46d950-d5ca-4cfb-a5a9-f3c2eeea1bf0" 
        /// // 删除spark sql通用参数 "GeneralTaskParams: SPARK_SQL" 
        /// </summary>
        [JsonProperty("FieldToRemoveList")]
        public string[] FieldToRemoveList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamObj(map, prefix + "NewSetting.", this.NewSetting);
            this.SetParamArraySimple(map, prefix + "FieldToRemoveList.", this.FieldToRemoveList);
        }
    }
}

