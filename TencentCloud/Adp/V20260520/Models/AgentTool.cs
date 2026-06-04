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

    public class AgentTool : AbstractModel
    {
        
        /// <summary>
        /// <p>工具配置字段</p>
        /// </summary>
        [JsonProperty("Config")]
        public AgentToolBasicConfig Config{ get; set; }

        /// <summary>
        /// <p>工具名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>工具状态</p><p>枚举值：</p><ul><li>1： 可用</li><li>2： 不可用</li><li>3： 已失效</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>调用方式</p><p>枚举值：</p><ul><li>0： 非流式</li><li>1： 流式</li></ul>
        /// </summary>
        [JsonProperty("StreamMode")]
        public long? StreamMode{ get; set; }

        /// <summary>
        /// <p>工具访问模式</p><p>枚举值：</p><ul><li>0： 未指定</li><li>1： 只读</li><li>2： 写/删除</li></ul>
        /// </summary>
        [JsonProperty("ToolAccessMode")]
        public long? ToolAccessMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StreamMode", this.StreamMode);
            this.SetParamSimple(map, prefix + "ToolAccessMode", this.ToolAccessMode);
        }
    }
}

