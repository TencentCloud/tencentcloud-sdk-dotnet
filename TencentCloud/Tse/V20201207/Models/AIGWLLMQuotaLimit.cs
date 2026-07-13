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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWLLMQuotaLimit : AbstractModel
    {
        
        /// <summary>
        /// <p>该模型服务每分钟请求数上限，0 表示该维度不限</p>
        /// </summary>
        [JsonProperty("RPMLimit")]
        public long? RPMLimit{ get; set; }

        /// <summary>
        /// <p>该模型服务每分钟 Token 数上限，0 表示该维度不限</p>
        /// </summary>
        [JsonProperty("TPMLimit")]
        public long? TPMLimit{ get; set; }

        /// <summary>
        /// <p>并发限流数</p>
        /// </summary>
        [JsonProperty("ConcurrentCountLimit")]
        public long? ConcurrentCountLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RPMLimit", this.RPMLimit);
            this.SetParamSimple(map, prefix + "TPMLimit", this.TPMLimit);
            this.SetParamSimple(map, prefix + "ConcurrentCountLimit", this.ConcurrentCountLimit);
        }
    }
}

