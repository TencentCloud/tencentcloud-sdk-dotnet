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

    public class TalkConversationConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// 会话超时（秒）
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
        /// 是否启用噪声过滤
        /// </summary>
        [JsonProperty("NoiseFilterEnabled")]
        public bool? NoiseFilterEnabled{ get; set; }


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
            this.SetParamSimple(map, prefix + "NoiseFilterEnabled", this.NoiseFilterEnabled);
        }
    }
}

