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

    public class CallDeviceRRPCSyncResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>平台为本次调用分配的关联 token（v2{instanceId}::{reqId} 形式）</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>调用状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>平台分配的 messageID</p>
        /// </summary>
        [JsonProperty("MessageId")]
        public ulong? MessageId{ get; set; }

        /// <summary>
        /// <p>设备回包原始字节的 base64 编码（仅 Status=Replied 有值）</p>
        /// </summary>
        [JsonProperty("PayloadBase64")]
        public string PayloadBase64{ get; set; }

        /// <summary>
        /// <p>实际生效的 reply topic 模板（默认模式由平台生成，自定义模式为入参原值）</p>
        /// </summary>
        [JsonProperty("ReplyTopic")]
        public string ReplyTopic{ get; set; }

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
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "PayloadBase64", this.PayloadBase64);
            this.SetParamSimple(map, prefix + "ReplyTopic", this.ReplyTopic);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

