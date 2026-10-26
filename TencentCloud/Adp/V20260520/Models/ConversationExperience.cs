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

    public class ConversationExperience : AbstractModel
    {
        
        /// <summary>
        /// <p>AI通话配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiCall")]
        public AICallConfig AiCall{ get; set; }

        /// <summary>
        /// <p>背景图片配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackgroundImage")]
        public BackgroundImage BackgroundImage{ get; set; }

        /// <summary>
        /// <p>兜底回复开关</p>
        /// </summary>
        [JsonProperty("EnableFallbackReply")]
        public bool? EnableFallbackReply{ get; set; }

        /// <summary>
        /// <p>是否使用推荐问</p>
        /// </summary>
        [JsonProperty("EnableRecommended")]
        public bool? EnableRecommended{ get; set; }

        /// <summary>
        /// <p>是否使用联网搜索</p>
        /// </summary>
        [JsonProperty("EnableWebSearch")]
        public bool? EnableWebSearch{ get; set; }

        /// <summary>
        /// <p>兜底回复语</p>
        /// </summary>
        [JsonProperty("FallbackReply")]
        public string FallbackReply{ get; set; }

        /// <summary>
        /// <p>输入框配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputBoxConfig")]
        public InputBoxConfig InputBoxConfig{ get; set; }

        /// <summary>
        /// <p>输出方式。枚举值: 1:流式, 2:非流式</p>
        /// </summary>
        [JsonProperty("Method")]
        public long? Method{ get; set; }

        /// <summary>
        /// <p>推荐问生成prompt模式。枚举值: 1:仅结合知识库输出推荐问的prompt</p>
        /// </summary>
        [JsonProperty("RecommendPromptMode")]
        public long? RecommendPromptMode{ get; set; }

        /// <summary>
        /// <p>新消息中断正在进行的消息</p>
        /// </summary>
        [JsonProperty("EnableNewMessageInterrupt")]
        public bool? EnableNewMessageInterrupt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AiCall.", this.AiCall);
            this.SetParamObj(map, prefix + "BackgroundImage.", this.BackgroundImage);
            this.SetParamSimple(map, prefix + "EnableFallbackReply", this.EnableFallbackReply);
            this.SetParamSimple(map, prefix + "EnableRecommended", this.EnableRecommended);
            this.SetParamSimple(map, prefix + "EnableWebSearch", this.EnableWebSearch);
            this.SetParamSimple(map, prefix + "FallbackReply", this.FallbackReply);
            this.SetParamObj(map, prefix + "InputBoxConfig.", this.InputBoxConfig);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "RecommendPromptMode", this.RecommendPromptMode);
            this.SetParamSimple(map, prefix + "EnableNewMessageInterrupt", this.EnableNewMessageInterrupt);
        }
    }
}

