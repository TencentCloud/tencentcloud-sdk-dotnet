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

    public class BatchPublishMessageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品名称</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名称</p>
        /// </summary>
        [JsonProperty("DeviceNames")]
        public string[] DeviceNames{ get; set; }

        /// <summary>
        /// <p>主题</p>
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// <p>消息体</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>服务质量</p>
        /// </summary>
        [JsonProperty("Qos")]
        public long? Qos{ get; set; }

        /// <summary>
        /// <p>消息体编码</p>
        /// </summary>
        [JsonProperty("PayloadEncoding")]
        public string PayloadEncoding{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArraySimple(map, prefix + "DeviceNames.", this.DeviceNames);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "PayloadEncoding", this.PayloadEncoding);
        }
    }
}

