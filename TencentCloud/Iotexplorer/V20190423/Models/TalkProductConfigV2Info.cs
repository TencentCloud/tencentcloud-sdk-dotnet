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

    public class TalkProductConfigV2Info : AbstractModel
    {
        
        /// <summary>
        /// UIN
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }

        /// <summary>
        /// APPID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

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
        /// 配置名称
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 语言，默认zh；zh-中文；en-英文
        /// </summary>
        [JsonProperty("TargetLanguage")]
        public string TargetLanguage{ get; set; }

        /// <summary>
        /// 基础配置
        /// </summary>
        [JsonProperty("BasicConfig")]
        public TalkBasicConfigInfo BasicConfig{ get; set; }

        /// <summary>
        /// 语音识别配置
        /// </summary>
        [JsonProperty("STTConfig")]
        public TalkSTTConfigInfo STTConfig{ get; set; }

        /// <summary>
        /// 大模型配置
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
        /// 版本号
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// 创建时间，秒级时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间，秒级时间戳
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "TargetLanguage", this.TargetLanguage);
            this.SetParamObj(map, prefix + "BasicConfig.", this.BasicConfig);
            this.SetParamObj(map, prefix + "STTConfig.", this.STTConfig);
            this.SetParamObj(map, prefix + "LLMConfig.", this.LLMConfig);
            this.SetParamObj(map, prefix + "TTSConfig.", this.TTSConfig);
            this.SetParamObj(map, prefix + "ConversationConfig.", this.ConversationConfig);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

