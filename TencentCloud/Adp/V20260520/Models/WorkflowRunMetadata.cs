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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowRunMetadata : AbstractModel
    {
        
        /// <summary>
        /// 用户的输入
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 主模型名称
        /// </summary>
        [JsonProperty("MainModelName")]
        public string MainModelName{ get; set; }

        /// <summary>
        /// API参数配置
        /// </summary>
        [JsonProperty("CustomVariableList")]
        public CustomVariable[] CustomVariableList{ get; set; }

        /// <summary>
        /// 工作流的流程图
        /// </summary>
        [JsonProperty("WorkflowGraph")]
        public string WorkflowGraph{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "MainModelName", this.MainModelName);
            this.SetParamArrayObj(map, prefix + "CustomVariableList.", this.CustomVariableList);
            this.SetParamSimple(map, prefix + "WorkflowGraph", this.WorkflowGraph);
        }
    }
}

