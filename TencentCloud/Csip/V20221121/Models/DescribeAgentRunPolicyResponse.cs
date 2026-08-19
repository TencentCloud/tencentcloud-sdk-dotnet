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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentRunPolicyResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>基础运行策略</p>
        /// </summary>
        [JsonProperty("BasicPolicy")]
        public AgentRunModePolicy BasicPolicy{ get; set; }

        /// <summary>
        /// <p>高级运行策略</p>
        /// </summary>
        [JsonProperty("AdvancePolicy")]
        public AgentRunModePolicy AdvancePolicy{ get; set; }

        /// <summary>
        /// <p>自定义运行策略</p>
        /// </summary>
        [JsonProperty("CustomPolicy")]
        public AgentRunModePolicy CustomPolicy{ get; set; }

        /// <summary>
        /// <p>自定义模式关联的机器instance_id列表</p>
        /// </summary>
        [JsonProperty("CustomModeInstanceIDs")]
        public string[] CustomModeInstanceIDs{ get; set; }

        /// <summary>
        /// <p>高级模式关联的机器instance_id列表</p>
        /// </summary>
        [JsonProperty("AdvanceModeInstanceIDs")]
        public string[] AdvanceModeInstanceIDs{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BasicPolicy.", this.BasicPolicy);
            this.SetParamObj(map, prefix + "AdvancePolicy.", this.AdvancePolicy);
            this.SetParamObj(map, prefix + "CustomPolicy.", this.CustomPolicy);
            this.SetParamArraySimple(map, prefix + "CustomModeInstanceIDs.", this.CustomModeInstanceIDs);
            this.SetParamArraySimple(map, prefix + "AdvanceModeInstanceIDs.", this.AdvanceModeInstanceIDs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

