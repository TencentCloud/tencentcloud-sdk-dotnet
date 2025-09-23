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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKeyPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// 密钥对 ID 列表。可通过[DescribeKeyPairs](https://cloud.tencent.com/document/product/1207/55540)接口返回值字段KeyPairSet获取。列表长度最大值为100。
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤器列表。
        /// <li>key-id</li>按照【密钥对ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>key-name</li>按照【密钥对名称】进行过滤（支持模糊匹配）。
        /// 类型：String
        /// 必选：否
        /// <li>tag-key</li>
        /// 按照【标签键】进行过滤。 类型：String 必选：否
        /// <li>tag-value</li>
        /// 按照【标签值】进行过滤。 类型：String 必选：否
        /// <li>tag:tag-key</li>
        /// 按照【标签键值对】进行过滤。 tag-key使用具体的标签键进行替换。
        /// 每次请求的 Filters 的上限为 10，Filter.Values 的上限为 5。参数不支持同时指定 KeyIds 和 Filters。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

