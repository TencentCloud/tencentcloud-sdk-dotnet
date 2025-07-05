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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKnowledgeUsageResponse : AbstractModel
    {
        
        /// <summary>
        /// 可用字符数上限
        /// </summary>
        [JsonProperty("AvailableCharSize")]
        public string AvailableCharSize{ get; set; }

        /// <summary>
        /// 超过可用字符数上限的字符数
        /// </summary>
        [JsonProperty("ExceedCharSize")]
        public string ExceedCharSize{ get; set; }

        /// <summary>
        /// 知识库使用字符总数
        /// </summary>
        [JsonProperty("UsedCharSize")]
        public string UsedCharSize{ get; set; }

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
            this.SetParamSimple(map, prefix + "AvailableCharSize", this.AvailableCharSize);
            this.SetParamSimple(map, prefix + "ExceedCharSize", this.ExceedCharSize);
            this.SetParamSimple(map, prefix + "UsedCharSize", this.UsedCharSize);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

