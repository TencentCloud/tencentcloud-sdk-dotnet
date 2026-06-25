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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RateLimitConfigForKey : AbstractModel
    {
        
        /// <summary>
        /// <p>最大并发请求数量</p><p>单位：次</p>
        /// </summary>
        [JsonProperty("MaxParallelRequest")]
        public ulong? MaxParallelRequest{ get; set; }

        /// <summary>
        /// <p>每分钟限制的请求数量</p><p>单位：次/分钟</p>
        /// </summary>
        [JsonProperty("RPM")]
        public ulong? RPM{ get; set; }

        /// <summary>
        /// <p>每分钟限制的Token数量</p><p>单位：个/分钟</p>
        /// </summary>
        [JsonProperty("TPM")]
        public ulong? TPM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxParallelRequest", this.MaxParallelRequest);
            this.SetParamSimple(map, prefix + "RPM", this.RPM);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
        }
    }
}

