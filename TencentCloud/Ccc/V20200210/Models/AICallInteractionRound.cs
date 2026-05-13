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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallInteractionRound : AbstractModel
    {
        
        /// <summary>
        /// <p>本轮对话的唯一标识 Id</p>
        /// </summary>
        [JsonProperty("RoundId")]
        public string RoundId{ get; set; }

        /// <summary>
        /// <p>轮次</p>
        /// </summary>
        [JsonProperty("RoundIndex")]
        public long? RoundIndex{ get; set; }

        /// <summary>
        /// <p>用户回复分类的标签， json序列化后的表示</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// <p>本轮涉及到的消息内容</p>
        /// </summary>
        [JsonProperty("Messages")]
        public AIRoundMessage[] Messages{ get; set; }

        /// <summary>
        /// <p>本轮对话在画布中经过的节点路径</p>
        /// </summary>
        [JsonProperty("Paths")]
        public AIRoundPath[] Paths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoundId", this.RoundId);
            this.SetParamSimple(map, prefix + "RoundIndex", this.RoundIndex);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamArrayObj(map, prefix + "Paths.", this.Paths);
        }
    }
}

