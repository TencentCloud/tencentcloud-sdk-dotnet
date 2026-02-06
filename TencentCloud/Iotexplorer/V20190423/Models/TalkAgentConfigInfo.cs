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

    public class TalkAgentConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 会话超时（秒），指连接会话的时间，例如30秒是指会话在30秒后断开
        /// </summary>
        [JsonProperty("SessionTimeout")]
        public long? SessionTimeout{ get; set; }

        /// <summary>
        /// 允许打断
        /// </summary>
        [JsonProperty("InterruptionEnabled")]
        public bool? InterruptionEnabled{ get; set; }

        /// <summary>
        /// 最大上下文
        /// </summary>
        [JsonProperty("MaxContextTokens")]
        public long? MaxContextTokens{ get; set; }

        /// <summary>
        /// 空闲检测配置
        /// </summary>
        [JsonProperty("IdleDetection")]
        public TalkIdleDetectionConfigInfo IdleDetection{ get; set; }

        /// <summary>
        /// 是否启用情绪识别
        /// </summary>
        [JsonProperty("EmotionEnabled")]
        public bool? EmotionEnabled{ get; set; }

        /// <summary>
        /// 是否启用语义vad
        /// </summary>
        [JsonProperty("SemanticVADEnabled")]
        public bool? SemanticVADEnabled{ get; set; }

        /// <summary>
        /// 语义vad灵敏度， 1-慢 2-适中 3-快
        /// </summary>
        [JsonProperty("SemanticVADSensitivity")]
        public long? SemanticVADSensitivity{ get; set; }

        /// <summary>
        /// VAD 静默检测时间， 当开启语义vad此配置失效
        /// </summary>
        [JsonProperty("SilenceTime")]
        public long? SilenceTime{ get; set; }

        /// <summary>
        /// 是否启用噪声过滤
        /// </summary>
        [JsonProperty("NoiseFilterEnabled")]
        public bool? NoiseFilterEnabled{ get; set; }

        /// <summary>
        /// 是否开启长记忆，默认关闭
        /// </summary>
        [JsonProperty("LongTermMemoryEnabled")]
        public bool? LongTermMemoryEnabled{ get; set; }

        /// <summary>
        /// 系统提示词，仅当未配置LLMConfig时使用
        /// </summary>
        [JsonProperty("SystemPrompt")]
        public string SystemPrompt{ get; set; }

        /// <summary>
        /// 开机问候语，如果未配置默认不开启
        /// </summary>
        [JsonProperty("GreetingMessage")]
        public string GreetingMessage{ get; set; }

        /// <summary>
        /// 系统默认音色，当配置复刻音色时，默认值为200000000
        /// </summary>
        [JsonProperty("DefaultVoiceType")]
        public long? DefaultVoiceType{ get; set; }

        /// <summary>
        /// 复刻音色
        /// </summary>
        [JsonProperty("FastVoiceType")]
        public string FastVoiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionTimeout", this.SessionTimeout);
            this.SetParamSimple(map, prefix + "InterruptionEnabled", this.InterruptionEnabled);
            this.SetParamSimple(map, prefix + "MaxContextTokens", this.MaxContextTokens);
            this.SetParamObj(map, prefix + "IdleDetection.", this.IdleDetection);
            this.SetParamSimple(map, prefix + "EmotionEnabled", this.EmotionEnabled);
            this.SetParamSimple(map, prefix + "SemanticVADEnabled", this.SemanticVADEnabled);
            this.SetParamSimple(map, prefix + "SemanticVADSensitivity", this.SemanticVADSensitivity);
            this.SetParamSimple(map, prefix + "SilenceTime", this.SilenceTime);
            this.SetParamSimple(map, prefix + "NoiseFilterEnabled", this.NoiseFilterEnabled);
            this.SetParamSimple(map, prefix + "LongTermMemoryEnabled", this.LongTermMemoryEnabled);
            this.SetParamSimple(map, prefix + "SystemPrompt", this.SystemPrompt);
            this.SetParamSimple(map, prefix + "GreetingMessage", this.GreetingMessage);
            this.SetParamSimple(map, prefix + "DefaultVoiceType", this.DefaultVoiceType);
            this.SetParamSimple(map, prefix + "FastVoiceType", this.FastVoiceType);
        }
    }
}

