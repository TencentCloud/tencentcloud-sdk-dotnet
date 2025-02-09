/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChatCompletionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 模型名称
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 聊天上下文信息。
        /// 说明：
        /// 1. 长度最多为 40，按对话时间从旧到新在数组中排列。
        /// 2. Message.Role 可选值：system、user、assistant。
        /// 其中，system 角色可选，如存在则必须位于列表的最开始。user（tool） 和 assistant 需交替出现（一问一答），以 user 提问开始，user（tool）提问结束，其中tool可以连续出现多次，且 Content 不能为空。Role 的顺序示例：[system（可选） user assistant user（tool tool ...） assistant user（tool tool ...） ...]。
        /// </summary>
        [JsonProperty("Messages")]
        public Message[] Messages{ get; set; }

        /// <summary>
        /// 是否流式输出
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 控制生成的随机性，较高的值会产生更多样化的输出。
        /// </summary>
        [JsonProperty("Temperature")]
        public float? Temperature{ get; set; }

        /// <summary>
        /// 最大生成的token数量
        /// </summary>
        [JsonProperty("MaxTokens")]
        public long? MaxTokens{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "Temperature", this.Temperature);
            this.SetParamSimple(map, prefix + "MaxTokens", this.MaxTokens);
        }
    }
}

