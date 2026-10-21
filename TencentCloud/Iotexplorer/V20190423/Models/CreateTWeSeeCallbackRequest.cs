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

    public class CreateTWeSeeCallbackRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>回调类型</p><p>枚举值：</p><ul><li>none： 不回调</li><li>http： HTTP 回调</li><li>ckafka： 投递 CKafka Topic</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>回调 URL。要求 http 或 https 协议，仅支持 80 或 443 端口</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>回调签名 Token。最大长度 128</p>
        /// </summary>
        [JsonProperty("CallbackToken")]
        public string CallbackToken{ get; set; }

        /// <summary>
        /// <p>回调 CKafka 配置</p>
        /// </summary>
        [JsonProperty("CallbackCKafka")]
        public SeeCallbackCKafkaConfig CallbackCKafka{ get; set; }

        /// <summary>
        /// <p>要创建回调目标的产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "CallbackToken", this.CallbackToken);
            this.SetParamObj(map, prefix + "CallbackCKafka.", this.CallbackCKafka);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
        }
    }
}

