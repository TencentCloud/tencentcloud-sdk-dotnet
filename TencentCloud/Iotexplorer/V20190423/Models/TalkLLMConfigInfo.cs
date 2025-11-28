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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TalkLLMConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 支持的LLM类型，openai-OPENAI格式。
        /// </summary>
        [JsonProperty("LLMType")]
        public string LLMType{ get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 模型
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 是否开启
        /// </summary>
        [JsonProperty("Streaming")]
        public bool? Streaming{ get; set; }

        /// <summary>
        /// 配置信息JSON字符串，根据`LLMType`进行不同的值匹配。例如`LLMType`是`openai`，`Config`值是`{\"ApiKey\":\"sk-09***\",\"ApiUrl\":\"base_url\",\"SystemPrompt\":\"你是一个语音助手\",\"Timeout\":30,\"History\":0,\"MetaInfo\":{\"productID\":\"test\"}}`
        /// 
        /// ## openai
        /// ```
        /// {
        ///    "ApiKey": "sk-XXXXXXXXXXXX",
        ///    "ApiUrl": "https://api.openai.com/v1",
        ///    "SystemPrompt": "一个小小助手",
        ///   "Timeout":20,
        ///   "History":10,
        ///   "MetaInfo":{}
        /// }
        /// ```
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 温度
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 最大token数
        /// </summary>
        [JsonProperty("MaxTokens")]
        public long? MaxTokens{ get; set; }

        /// <summary>
        /// topP
        /// </summary>
        [JsonProperty("TopP")]
        public float? TopP{ get; set; }

        /// <summary>
        /// 工具ID列表
        /// </summary>
        [JsonProperty("Tools")]
        public string[] Tools{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LLMType", this.LLMType);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Streaming", this.Streaming);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
            this.SetParamSimple(map, prefix + "TopP", this.TopP);
            this.SetParamArraySimple(map, prefix + "Tools.", this.Tools);
        }
    }
}

