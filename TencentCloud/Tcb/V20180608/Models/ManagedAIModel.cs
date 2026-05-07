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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagedAIModel : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>是否开启MCP</p>
        /// </summary>
        [JsonProperty("EnableMCP")]
        public bool? EnableMCP{ get; set; }

        /// <summary>
        /// <p>模型规格</p>
        /// </summary>
        [JsonProperty("ModelSpec")]
        public ManagedAIModelSpec ModelSpec{ get; set; }

        /// <summary>
        /// <p>模型计费信息</p>
        /// </summary>
        [JsonProperty("ModelChargingInfo")]
        public ManagedAIModelChargingInfo[] ModelChargingInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "EnableMCP", this.EnableMCP);
            this.SetParamObj(map, prefix + "ModelSpec.", this.ModelSpec);
            this.SetParamArrayObj(map, prefix + "ModelChargingInfo.", this.ModelChargingInfo);
        }
    }
}

