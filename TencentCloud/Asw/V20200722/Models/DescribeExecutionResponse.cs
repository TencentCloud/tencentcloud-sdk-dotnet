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

namespace TencentCloud.Asw.V20200722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExecutionResponse : AbstractModel
    {
        
        /// <summary>
        /// 执行资源名
        /// </summary>
        [JsonProperty("ExecutionResourceName")]
        public string ExecutionResourceName{ get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 执行开始时间，毫秒
        /// </summary>
        [JsonProperty("StartDate")]
        public string StartDate{ get; set; }

        /// <summary>
        /// 执行结束时间，毫秒
        /// </summary>
        [JsonProperty("StopDate")]
        public string StopDate{ get; set; }

        /// <summary>
        /// 状态机资源名
        /// </summary>
        [JsonProperty("StateMachineResourceName")]
        public string StateMachineResourceName{ get; set; }

        /// <summary>
        /// 执行状态。INIT，RUNNING，SUCCEED，FAILED，TERMINATED
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 执行的输入
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// 执行的输出
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 启动执行时，状态机的定义
        /// </summary>
        [JsonProperty("ExecutionDefinition")]
        public string ExecutionDefinition{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutionResourceName", this.ExecutionResourceName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StartDate", this.StartDate);
            this.SetParamSimple(map, prefix + "StopDate", this.StopDate);
            this.SetParamSimple(map, prefix + "StateMachineResourceName", this.StateMachineResourceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "ExecutionDefinition", this.ExecutionDefinition);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

