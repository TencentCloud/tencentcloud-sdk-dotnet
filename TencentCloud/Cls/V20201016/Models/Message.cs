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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Message : AbstractModel
    {
        
        /// <summary>
        /// <p>角色</p><p>枚举值：</p><ul><li>user： 用户</li><li>assistant： AI助手</li></ul>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>文本内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>思维链内容。<br>用于展示模型思考过程，仅深度思考模式可用。仅作为输出参数返回，在进行多轮对话时，无需传入输入参数中。</p>
        /// </summary>
        [JsonProperty("ReasoningContent")]
        public string ReasoningContent{ get; set; }

        /// <summary>
        /// <p>模型生成的工具调用。仅支持输出参数返回。</p>
        /// </summary>
        [JsonProperty("ToolCalls")]
        public ToolCall[] ToolCalls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "ReasoningContent", this.ReasoningContent);
            this.SetParamArrayObj(map, prefix + "ToolCalls.", this.ToolCalls);
        }
    }
}

