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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScalingConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>活跃 Sandbox Instance 下限，必须大于等于 0。</p>
        /// </summary>
        [JsonProperty("MinInstanceCount")]
        public long? MinInstanceCount{ get; set; }

        /// <summary>
        /// <p>活跃 Sandbox Instance 上限，必须大于等于 1，并且不小于 MinInstanceCount。</p>
        /// </summary>
        [JsonProperty("MaxInstanceCount")]
        public long? MaxInstanceCount{ get; set; }

        /// <summary>
        /// <p>每个活跃 Sandbox Instance 同时持有的 Deployment 请求或连接 Lease 上限，必须大于等于 1。</p>
        /// </summary>
        [JsonProperty("MaxInstanceRequestConcurrency")]
        public long? MaxInstanceRequestConcurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinInstanceCount", this.MinInstanceCount);
            this.SetParamSimple(map, prefix + "MaxInstanceCount", this.MaxInstanceCount);
            this.SetParamSimple(map, prefix + "MaxInstanceRequestConcurrency", this.MaxInstanceRequestConcurrency);
        }
    }
}

