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

    public class ReferenceAppDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>来源应用当前名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>来源应用模式</p><p>枚举值：</p><ul><li>1： 标准模式</li><li>2： Multi-Agent模式</li><li>3： 单工作流模式</li><li>4： Claw模式</li></ul>
        /// </summary>
        [JsonProperty("AppMode")]
        public long? AppMode{ get; set; }

        /// <summary>
        /// <p>主 Agent 名称</p>
        /// </summary>
        [JsonProperty("MainAgentName")]
        public string MainAgentName{ get; set; }

        /// <summary>
        /// <p>子 Agent 名称列表</p>
        /// </summary>
        [JsonProperty("SubAgentNameList")]
        public string[] SubAgentNameList{ get; set; }

        /// <summary>
        /// <p>来源应用创建人</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>来源应用修改时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AppMode", this.AppMode);
            this.SetParamSimple(map, prefix + "MainAgentName", this.MainAgentName);
            this.SetParamArraySimple(map, prefix + "SubAgentNameList.", this.SubAgentNameList);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

