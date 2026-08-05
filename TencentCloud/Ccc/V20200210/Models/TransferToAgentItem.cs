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

    public class TransferToAgentItem : AbstractModel
    {
        
        /// <summary>
        /// <p>转智能体的function calling 名称</p>
        /// </summary>
        [JsonProperty("TransferToAgentName")]
        public string TransferToAgentName{ get; set; }

        /// <summary>
        /// <p>转智能体描述</p>
        /// </summary>
        [JsonProperty("TransferToAgentDesc")]
        public string TransferToAgentDesc{ get; set; }

        /// <summary>
        /// <p>目标智能体ID</p>
        /// </summary>
        [JsonProperty("TransferToAgentId")]
        public ulong? TransferToAgentId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransferToAgentName", this.TransferToAgentName);
            this.SetParamSimple(map, prefix + "TransferToAgentDesc", this.TransferToAgentDesc);
            this.SetParamSimple(map, prefix + "TransferToAgentId", this.TransferToAgentId);
        }
    }
}

