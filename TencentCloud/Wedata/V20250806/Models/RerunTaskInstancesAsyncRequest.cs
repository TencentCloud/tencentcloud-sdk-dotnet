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

    public class RerunTaskInstancesAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 实例id列表,可以从ListInstances中获取
        /// </summary>
        [JsonProperty("InstanceKeyList")]
        public string[] InstanceKeyList{ get; set; }

        /// <summary>
        /// 重跑类型, 1: 自身; 3: 孩子; 2: 自身以及孩子，默认1
        /// </summary>
        [JsonProperty("RerunType")]
        public string RerunType{ get; set; }

        /// <summary>
        /// 是否检查上游任务： ALL（全部）、 MAKE_SCOPE（选中）、NONE （全部不检查），默认NONE
        /// </summary>
        [JsonProperty("CheckParentType")]
        public string CheckParentType{ get; set; }

        /// <summary>
        /// 下游实例范围 WORKFLOW: 所在工作流 PROJECT: 所在项目 ALL: 所有跨工作流依赖的项目，默认WORKFLOW
        /// </summary>
        [JsonProperty("SonRangeType")]
        public string SonRangeType{ get; set; }

        /// <summary>
        /// 重跑是否忽略事件监听
        /// </summary>
        [JsonProperty("SkipEventListening")]
        public bool? SkipEventListening{ get; set; }

        /// <summary>
        /// 自定义实例运行并发度, 如果不配置，则使用任务原有自依赖
        /// </summary>
        [JsonProperty("RedefineParallelNum")]
        public long? RedefineParallelNum{ get; set; }

        /// <summary>
        /// 自定义的工作流自依赖: yes开启，no关闭，如果不配置，则使用工作流原有自依赖
        /// </summary>
        [JsonProperty("RedefineSelfWorkflowDependency")]
        public string RedefineSelfWorkflowDependency{ get; set; }

        /// <summary>
        /// 重跑实例自定义参数
        /// </summary>
        [JsonProperty("RedefineParamList")]
        public KVMap RedefineParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "InstanceKeyList.", this.InstanceKeyList);
            this.SetParamSimple(map, prefix + "RerunType", this.RerunType);
            this.SetParamSimple(map, prefix + "CheckParentType", this.CheckParentType);
            this.SetParamSimple(map, prefix + "SonRangeType", this.SonRangeType);
            this.SetParamSimple(map, prefix + "SkipEventListening", this.SkipEventListening);
            this.SetParamSimple(map, prefix + "RedefineParallelNum", this.RedefineParallelNum);
            this.SetParamSimple(map, prefix + "RedefineSelfWorkflowDependency", this.RedefineSelfWorkflowDependency);
            this.SetParamObj(map, prefix + "RedefineParamList.", this.RedefineParamList);
        }
    }
}

