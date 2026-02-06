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

    public class ModifyTWeTalkAIBotRequest : AbstractModel
    {
        
        /// <summary>
        /// 智能体ID
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 支持的语言，zh-中文；en-英文；默认zh
        /// </summary>
        [JsonProperty("TargetLanguage")]
        public string TargetLanguage{ get; set; }

        /// <summary>
        /// 自定义语音识别配置
        /// </summary>
        [JsonProperty("STTConfig")]
        public TalkSTTConfigInfo STTConfig{ get; set; }

        /// <summary>
        /// 自定义大模型配置
        /// </summary>
        [JsonProperty("LLMConfig")]
        public TalkLLMConfigInfo LLMConfig{ get; set; }

        /// <summary>
        /// 语音合成配置
        /// </summary>
        [JsonProperty("TTSConfig")]
        public TalkTTSConfigInfo TTSConfig{ get; set; }

        /// <summary>
        /// 智能体配置
        /// </summary>
        [JsonProperty("AgentConfig")]
        public TalkAgentConfigInfo AgentConfig{ get; set; }

        /// <summary>
        /// 自定义工具配置，最多可创建10个
        /// </summary>
        [JsonProperty("CustomTools")]
        public string CustomTools{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetLanguage", this.TargetLanguage);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamObj(map, prefix + "AgentConfig.", this.AgentConfig);
            this.SetParamSimple(map, prefix + "CustomTools", this.CustomTools);
        }
    }
}

