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

    public class CreateTWeTalkProductConfigV2Request : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 支持的语言，zh-中文；en-英文；默认zh
        /// </summary>
        [JsonProperty("TargetLanguage")]
        public string TargetLanguage{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 系统基础配置，当需要使用系统三段式配置时配置。
        /// </summary>
        [JsonProperty("BasicConfig")]
        public TalkBasicConfigInfo BasicConfig{ get; set; }

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
        /// 会话配置
        /// </summary>
        [JsonProperty("ConversationConfig")]
        public TalkConversationConfigInfo ConversationConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "TargetLanguage", this.TargetLanguage);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamObj(map, prefix + "BasicConfig.", this.BasicConfig);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamObj(map, prefix + "ConversationConfig.", this.ConversationConfig);
        }
    }
}

