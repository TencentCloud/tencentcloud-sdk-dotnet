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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailCapabilityLimits : AbstractModel
    {
        
        /// <summary>
        /// <p>Header 白名单最大条数。</p>
        /// </summary>
        [JsonProperty("MaxHeaderAllowList")]
        public long? MaxHeaderAllowList{ get; set; }

        /// <summary>
        /// <p>单方向关键词最大条数。</p>
        /// </summary>
        [JsonProperty("MaxKeywordsPerDirection")]
        public long? MaxKeywordsPerDirection{ get; set; }

        /// <summary>
        /// <p>直接内联送审的 Body 上限，单位字节。</p>
        /// </summary>
        [JsonProperty("InlineBodyBytes")]
        public long? InlineBodyBytes{ get; set; }

        /// <summary>
        /// <p>可接受的请求 Body 上限，单位字节。</p>
        /// </summary>
        [JsonProperty("MaxAcceptedBodyBytes")]
        public long? MaxAcceptedBodyBytes{ get; set; }

        /// <summary>
        /// <p>超大请求 Body 默认分片大小，单位字节。</p>
        /// </summary>
        [JsonProperty("TransferChunkBytes")]
        public long? TransferChunkBytes{ get; set; }

        /// <summary>
        /// <p>超大请求 Body 最大分片大小，单位字节。</p>
        /// </summary>
        [JsonProperty("MaxTransferChunkBytes")]
        public long? MaxTransferChunkBytes{ get; set; }

        /// <summary>
        /// <p>分片传输目标最大分片数。</p>
        /// </summary>
        [JsonProperty("TransferTargetMaxChunks")]
        public long? TransferTargetMaxChunks{ get; set; }

        /// <summary>
        /// <p>普通响应审核最大 Body 大小，单位字节。</p>
        /// </summary>
        [JsonProperty("MaxResponseBodyBytes")]
        public long? MaxResponseBodyBytes{ get; set; }

        /// <summary>
        /// <p>单个流式事件最大字节数，单位字节。</p>
        /// </summary>
        [JsonProperty("MaxStreamEventBytes")]
        public long? MaxStreamEventBytes{ get; set; }

        /// <summary>
        /// <p>单数据面实例 Stream Relay 默认并发槽位。</p>
        /// </summary>
        [JsonProperty("StreamRelayMaxConcurrentRequests")]
        public long? StreamRelayMaxConcurrentRequests{ get; set; }

        /// <summary>
        /// <p>审核超时最小值，单位毫秒。</p>
        /// </summary>
        [JsonProperty("MinTimeoutMs")]
        public long? MinTimeoutMs{ get; set; }

        /// <summary>
        /// <p>审核超时最大值，单位毫秒。</p>
        /// </summary>
        [JsonProperty("MaxTimeoutMs")]
        public long? MaxTimeoutMs{ get; set; }

        /// <summary>
        /// <p>审核超时默认值，单位毫秒。</p>
        /// </summary>
        [JsonProperty("DefaultTimeoutMs")]
        public long? DefaultTimeoutMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxHeaderAllowList", this.MaxHeaderAllowList);
            this.SetParamSimple(map, prefix + "MaxKeywordsPerDirection", this.MaxKeywordsPerDirection);
            this.SetParamSimple(map, prefix + "InlineBodyBytes", this.InlineBodyBytes);
            this.SetParamSimple(map, prefix + "MaxAcceptedBodyBytes", this.MaxAcceptedBodyBytes);
            this.SetParamSimple(map, prefix + "TransferChunkBytes", this.TransferChunkBytes);
            this.SetParamSimple(map, prefix + "MaxTransferChunkBytes", this.MaxTransferChunkBytes);
            this.SetParamSimple(map, prefix + "TransferTargetMaxChunks", this.TransferTargetMaxChunks);
            this.SetParamSimple(map, prefix + "MaxResponseBodyBytes", this.MaxResponseBodyBytes);
            this.SetParamSimple(map, prefix + "MaxStreamEventBytes", this.MaxStreamEventBytes);
            this.SetParamSimple(map, prefix + "StreamRelayMaxConcurrentRequests", this.StreamRelayMaxConcurrentRequests);
            this.SetParamSimple(map, prefix + "MinTimeoutMs", this.MinTimeoutMs);
            this.SetParamSimple(map, prefix + "MaxTimeoutMs", this.MaxTimeoutMs);
            this.SetParamSimple(map, prefix + "DefaultTimeoutMs", this.DefaultTimeoutMs);
        }
    }
}

