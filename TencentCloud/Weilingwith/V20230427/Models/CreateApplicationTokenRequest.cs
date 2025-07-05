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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateApplicationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public ulong? ApplicationId{ get; set; }

        /// <summary>
        /// 一个随机数或者时间戳，用于防止重放攻击，每个请求唯一，建议用uuid
        /// </summary>
        [JsonProperty("Nonce")]
        public string Nonce{ get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("TenantId")]
        public ulong? TenantId{ get; set; }

        /// <summary>
        /// 请求时间，当前时间的unix毫秒时间戳
        /// </summary>
        [JsonProperty("RequestTime")]
        public ulong? RequestTime{ get; set; }

        /// <summary>
        /// 签名方法见用户使用文档
        /// </summary>
        [JsonProperty("Signature")]
        public string Signature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "Nonce", this.Nonce);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "RequestTime", this.RequestTime);
            this.SetParamSimple(map, prefix + "Signature", this.Signature);
        }
    }
}

