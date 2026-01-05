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

    public class UpdateTriggerTaskPartiallyRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务基本属性
        /// </summary>
        [JsonProperty("NewSetting")]
        public UpdateTriggerTaskPart NewSetting{ get; set; }

        /// <summary>
        /// 删除字段内容，采用属性路径的形式标识，删除的值以":"分割，多个值以","分割 // 删除调度参数中 ParamKey 为 aa,bb 的属性 "TaskConfiguration/TaskSchedulingParameterList:aa,bb" // 删除上游依赖中 TaskId 为 2509162129381111,2509162129381112 的上游依赖 "TaskSchedulerConfiguration/UpstreamDependencyConfigList:2509162129381111,2509162129381112" // 删除下游循环依赖中 TaskId 为 2509162129382222,2509162129382223 的下游依赖 "TaskSchedulerConfiguration/DownStreamDependencyConfigList:2509162129382222,2509162129382223" // 删除事件中 EventName 为 event_250916_213234,event_250916_213235 的事件 "TaskSchedulerConfiguration/EventListenerList:event_250916_213234,event_250916_213235" // 删除传递参数输出中 ParamKey 为 pp_out,pp_1 的参数 "TaskSchedulerConfiguration/ParamTaskOutList:pp_out,pp_1" // 删除传递参数应用中 ParamKey 为 pp_in,pp_1 的参数 "TaskSchedulerConfiguration/ParamTaskInList:pp_in,pp_1" // 删除产品登记中 TablePhysicalId 为6578laxif4d1的产出登记 "TaskSchedulerConfiguration/TaskOutputRegistryList:6578laxif4d1"
        /// </summary>
        [JsonProperty("FieldToRemoveList")]
        public string[] FieldToRemoveList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamObj(map, prefix + "NewSetting.", this.NewSetting);
            this.SetParamArraySimple(map, prefix + "FieldToRemoveList.", this.FieldToRemoveList);
        }
    }
}

