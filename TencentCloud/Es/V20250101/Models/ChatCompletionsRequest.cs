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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 会话内容，按对话时间从旧到新在数组中排列，长度受模型窗口大小限制。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 模型名称，可选模型列表：hunyuan-turbo，hunyuan-large，hunyuan-large-longcontext，hunyuan-standard，hunyuan-standard-256K，deepseek-r1，deepseek-v3，deepseek-r1-distill-qwen-32b。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 是否以流式接口的形式返回数据，默认true。
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 取值区间为[0.0, 1.0], 非必要不建议使用, 不合理的取值会影响效果 。
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 取值区间为[0.0, 2.0], 非必要不建议使用, 不合理的取值会影响效果 。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 是否开启联网搜索。默认为 false。
        /// </summary>
        [JsonProperty("OnlineSearch")]
        public bool? OnlineSearch{ get; set; }

        /// <summary>
        /// 当 OnlineSearch 为 true 时，指定的搜索引擎，默认为 bing。
        /// </summary>
        [JsonProperty("OnlineSearchOptions")]
        public OnlineSearchOptions OnlineSearchOptions{ get; set; }

        /// <summary>
        /// 可调用的工具列表，当前支持模型：hunyuan-turbo, deepseek-v3。
        /// </summary>
        [JsonProperty("Tools")]
        public Tool[] Tools{ get; set; }

        /// <summary>
        /// 工具使用选项，可选值包括 none、auto、custom。说明：1. 仅对 hunyuan-turbo、deepseek-v3 模型生效。2. none：不调用工具；auto：模型自行选择生成回复或调用工具；custom：强制模型调用指定的工具。3. 未设置时，默认值为auto
        /// </summary>
        [JsonProperty("ToolChoice")]
        public string ToolChoice{ get; set; }

        /// <summary>
        /// 强制模型调用指定的工具，当参数ToolChoice为custom时，此参数为必填
        /// </summary>
        [JsonProperty("CustomTool")]
        public Tool CustomTool{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "OnlineSearch", this.OnlineSearch);
            this.SetParamObj(map, prefix + "OnlineSearchOptions.", this.OnlineSearchOptions);
            this.SetParamArrayObj(map, prefix + "Tools.", this.Tools);
            this.SetParamSimple(map, prefix + "ToolChoice", this.ToolChoice);
            this.SetParamObj(map, prefix + "CustomTool.", this.CustomTool);
        }
    }
}

