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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSmsSignListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>是否国际/港澳台短信：<br>0：表示国内短信。<br>1：表示国际/港澳台短信。</p>
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// <p>签名 ID 数组。<br>注：默认数组最大长度100。</p>
        /// </summary>
        [JsonProperty("SignIdSet")]
        public ulong?[] SignIdSet{ get; set; }

        /// <summary>
        /// <p>最大上限，最多100。注：默认为10，SignIdSet 为空时启用。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量。注：默认为0，SignIdSet 为空时启用。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamArraySimple(map, prefix + "SignIdSet.", this.SignIdSet);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

