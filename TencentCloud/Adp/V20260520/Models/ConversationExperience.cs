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
        /// AI通话配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiCall")]
        public AICallConfig AiCall{ get; set; }

        /// <summary>
        /// 背景图片配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackgroundImage")]
        public BackgroundImage BackgroundImage{ get; set; }

        /// <summary>
        /// 兜底回复开关
        /// </summary>
        [JsonProperty("EnableFallbackReply")]
        public bool? EnableFallbackReply{ get; set; }

        /// <summary>
        /// 是否使用推荐问
        /// </summary>
        [JsonProperty("EnableRecommended")]
        public bool? EnableRecommended{ get; set; }

        /// <summary>
        /// 是否使用联网搜索
        /// </summary>
        [JsonProperty("EnableWebSearch")]
        public bool? EnableWebSearch{ get; set; }

        /// <summary>
        /// 兜底回复语
        /// </summary>
        [JsonProperty("FallbackReply")]
        public string FallbackReply{ get; set; }

        /// <summary>
        /// 输入框配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputBoxConfig")]
        public InputBoxConfig InputBoxConfig{ get; set; }

        /// <summary>
        /// 输出方式。枚举值: 1:流式, 2:非流式
        /// </summary>
        [JsonProperty("Method")]
        public long? Method{ get; set; }

        /// <summary>
        /// 推荐问生成prompt模式。枚举值: 1:仅结合知识库输出推荐问的prompt
        /// </summary>
        [JsonProperty("RecommendPromptMode")]
        public long? RecommendPromptMode{ get; set; }


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
        }
    }
}

