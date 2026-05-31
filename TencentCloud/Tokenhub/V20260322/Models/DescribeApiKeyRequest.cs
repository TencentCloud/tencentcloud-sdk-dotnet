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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApiKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台类型。当前支持填值：maas
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// API 密钥 ID，与 ApiKey 至少需传入其一，优先使用 ApiKeyId。
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// API 密钥明文，与 ApiKeyId 至少需传入其一。
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
        }
    }
}

