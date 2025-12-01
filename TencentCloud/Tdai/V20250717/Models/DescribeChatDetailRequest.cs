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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeChatDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 智能体ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 会话Id
        /// </summary>
        [JsonProperty("ChatId")]
        public string ChatId{ get; set; }

        /// <summary>
        /// 流ID
        /// </summary>
        [JsonProperty("StreamingId")]
        public string StreamingId{ get; set; }

        /// <summary>
        /// 开始拉取的流式TokenID。0表示从该流最早的TokenID开始获取
        /// </summary>
        [JsonProperty("BeginStreamingTokenId")]
        public string BeginStreamingTokenId{ get; set; }

        /// <summary>
        /// 单次获取的token数量，默认2000
        /// </summary>
        [JsonProperty("TokenLimit")]
        public long? TokenLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ChatId", this.ChatId);
            this.SetParamSimple(map, prefix + "StreamingId", this.StreamingId);
            this.SetParamSimple(map, prefix + "BeginStreamingTokenId", this.BeginStreamingTokenId);
            this.SetParamSimple(map, prefix + "TokenLimit", this.TokenLimit);
        }
    }
}

