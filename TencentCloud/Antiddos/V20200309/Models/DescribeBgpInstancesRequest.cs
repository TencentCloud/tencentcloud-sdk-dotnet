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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBgpInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("FilterRegion")]
        public string FilterRegion{ get; set; }

        /// <summary>
        /// ["bgp-0000041i"]
        /// </summary>
        [JsonProperty("FilterInstanceIdList")]
        public string[] FilterInstanceIdList{ get; set; }

        /// <summary>
        /// [{}]
        /// </summary>
        [JsonProperty("FilterTag")]
        public TagInfo[] FilterTag{ get; set; }

        /// <summary>
        /// 分页数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterRegion", this.FilterRegion);
            this.SetParamArraySimple(map, prefix + "FilterInstanceIdList.", this.FilterInstanceIdList);
            this.SetParamArrayObj(map, prefix + "FilterTag.", this.FilterTag);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

