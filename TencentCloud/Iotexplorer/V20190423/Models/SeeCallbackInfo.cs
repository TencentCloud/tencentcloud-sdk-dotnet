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

    public class SeeCallbackInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>回调目标 ID</p>
        /// </summary>
        [JsonProperty("CallbackId")]
        public string CallbackId{ get; set; }

        /// <summary>
        /// <p>回调类型</p><p>枚举值：</p><ul><li>none： 不回调</li><li>http： HTTP 回调</li><li>ckafka： 投递 CKafka Topic</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>回调 URL</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>回调签名 token</p>
        /// </summary>
        [JsonProperty("CallbackToken")]
        public string CallbackToken{ get; set; }

        /// <summary>
        /// <p>回调 CKafka 配置</p>
        /// </summary>
        [JsonProperty("CallbackCKafka")]
        public SeeCallbackCKafkaConfig CallbackCKafka{ get; set; }

        /// <summary>
        /// <p>创建时间（秒级时间戳）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（秒级时间戳）</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackId", this.CallbackId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "CallbackToken", this.CallbackToken);
            this.SetParamObj(map, prefix + "CallbackCKafka.", this.CallbackCKafka);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

