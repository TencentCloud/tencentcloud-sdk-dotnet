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

    public class TalkWebhookAuth : AbstractModel
    {
        
        /// <summary>
        /// 鉴权类型：none、hmac、static_headers、bearer
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// HMAC签名密钥，Type=hmac时必填
        /// </summary>
        [JsonProperty("SignKey")]
        public string SignKey{ get; set; }

        /// <summary>
        /// 静态鉴权请求头，JSON对象字符串，仅允许白名单header名
        /// </summary>
        [JsonProperty("Headers")]
        public string Headers{ get; set; }

        /// <summary>
        /// Bearer Token，Type=bearer时用于生成Authorization请求头
        /// </summary>
        [JsonProperty("BearerToken")]
        public string BearerToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SignKey", this.SignKey);
            this.SetParamSimple(map, prefix + "Headers", this.Headers);
            this.SetParamSimple(map, prefix + "BearerToken", this.BearerToken);
        }
    }
}

