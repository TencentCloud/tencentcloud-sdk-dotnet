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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIAgentInfo : AbstractModel
    {
        
        /// <summary>
        /// 智能体ID
        /// </summary>
        [JsonProperty("AIAgentId")]
        public ulong? AIAgentId{ get; set; }

        /// <summary>
        /// 智能体名称
        /// </summary>
        [JsonProperty("AIAgentName")]
        public string AIAgentName{ get; set; }

        /// <summary>
        /// 智能体变量名列表
        /// </summary>
        [JsonProperty("VariableNames")]
        public string[] VariableNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AIAgentId", this.AIAgentId);
            this.SetParamSimple(map, prefix + "AIAgentName", this.AIAgentName);
            this.SetParamArraySimple(map, prefix + "VariableNames.", this.VariableNames);
        }
    }
}

