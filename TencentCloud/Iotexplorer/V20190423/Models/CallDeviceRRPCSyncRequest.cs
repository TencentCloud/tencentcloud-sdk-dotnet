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

    public class CallDeviceRRPCSyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>业务原始 payload，透传给设备</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>下行传输层编码标识；base64 时下发到 broker 的 payload 会做一次 base64 编码</p>
        /// </summary>
        [JsonProperty("Encoding")]
        public string Encoding{ get; set; }

        /// <summary>
        /// <p>自定义下行 topic；为空则用 <code>$iotrrpc/down/{ProductId}/{DeviceName}/{mid}</code></p>
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// <p>自定义上行 topic 模板（支持通配符）；可留空，留空时仅依赖 clientToken 关联 ack</p>
        /// </summary>
        [JsonProperty("ReplyTopic")]
        public string ReplyTopic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "ReplyTopic", this.ReplyTopic);
        }
    }
}

