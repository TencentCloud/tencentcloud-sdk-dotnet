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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTDEMSSESummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>对话次数。一条大模型对话对应一条 sse_call。</p>
        /// </summary>
        [JsonProperty("ConversationCount")]
        public long? ConversationCount{ get; set; }

        /// <summary>
        /// <p>token 总数。对话次数为 0 时为 0。</p>
        /// </summary>
        [JsonProperty("TotalTokenCount")]
        public long? TotalTokenCount{ get; set; }

        /// <summary>
        /// <p>token 吞吐率，单位 token/秒。对话次数为 0 时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenThroughput")]
        public float? TokenThroughput{ get; set; }

        /// <summary>
        /// <p>首次消息时延，单位毫秒。对话次数为 0 时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstMessageDelay")]
        public float? FirstMessageDelay{ get; set; }

        /// <summary>
        /// <p>错误率，已乘 100。对话次数为 0 时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorRate")]
        public float? ErrorRate{ get; set; }

        /// <summary>
        /// <p>卡死率，已乘 100。对话次数为 0 时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StallRate")]
        public float? StallRate{ get; set; }

        /// <summary>
        /// <p>流畅度，已乘 100。对话次数为 0 时为 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Fluency")]
        public float? Fluency{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConversationCount", this.ConversationCount);
            this.SetParamSimple(map, prefix + "TotalTokenCount", this.TotalTokenCount);
            this.SetParamSimple(map, prefix + "TokenThroughput", this.TokenThroughput);
            this.SetParamSimple(map, prefix + "FirstMessageDelay", this.FirstMessageDelay);
            this.SetParamSimple(map, prefix + "ErrorRate", this.ErrorRate);
            this.SetParamSimple(map, prefix + "StallRate", this.StallRate);
            this.SetParamSimple(map, prefix + "Fluency", this.Fluency);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

