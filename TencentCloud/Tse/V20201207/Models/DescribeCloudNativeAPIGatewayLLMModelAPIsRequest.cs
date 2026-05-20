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

    public class DescribeCloudNativeAPIGatewayLLMModelAPIsRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关 id。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 返回数量，默认为 10，最大值为 1000。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 过滤条件，多个过滤条件之间是“与”的关系
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 搜索关键词，模糊匹配 name 和 description
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 通过消费者组Id筛选，UseToBind 为 true 时ConsumerGroupId不为空
        /// </summary>
        [JsonProperty("ConsumerGroupId")]
        public string ConsumerGroupId{ get; set; }

        /// <summary>
        /// 筛选可被绑定的数据， 比如模型API里面绑定模型服务筛选时，如果设置true, 返回结果只会有可以被绑定的数据。
        /// </summary>
        [JsonProperty("UseToBind")]
        public bool? UseToBind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "ConsumerGroupId", this.ConsumerGroupId);
            this.SetParamSimple(map, prefix + "UseToBind", this.UseToBind);
        }
    }
}

