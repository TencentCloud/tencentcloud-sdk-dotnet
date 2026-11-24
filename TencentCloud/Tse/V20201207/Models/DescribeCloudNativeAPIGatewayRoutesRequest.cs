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

    public class DescribeCloudNativeAPIGatewayRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>翻页单页查询限制数量[0,1000], 默认值0</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>翻页单页偏移量，默认值0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>按服务 ID 查询路由。</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>服务的名字，精确匹配</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>路由的名字，精确匹配</p>
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// <p>过滤条件，多个过滤条件之间是与的关系，支持 name, path, host, method, service, protocol</p>
        /// </summary>
        [JsonProperty("Filters")]
        public ListFilter[] Filters{ get; set; }

        /// <summary>
        /// <p>路由类型</p>
        /// </summary>
        [JsonProperty("RouteTypes")]
        public string[] RouteTypes{ get; set; }

        /// <summary>
        /// <p>是否将灰度规则可能带来的路由排在原始路由前</p>
        /// </summary>
        [JsonProperty("GrayRoutesFirst")]
        public bool? GrayRoutesFirst{ get; set; }

        /// <summary>
        /// <p>排序字段</p>
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// <p>排序方式</p><p>枚举值：</p><ul><li>DESC： 降序</li><li>ASC： 升序</li></ul>
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// <p>按标签 ID 过滤路由（AND 语义，需同时命中所有传入的 tag），最多 10 个。关联需求：路由/服务标签分组管理</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public long?[] TagIds{ get; set; }

        /// <summary>
        /// <p>按标签 K:V 过滤路由（AND 语义，前端下拉直传场景），最多 10 个。与 TagIds 同时传时取交集</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagKVFilter[] TagFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "RouteName", this.RouteName);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "RouteTypes.", this.RouteTypes);
            this.SetParamSimple(map, prefix + "GrayRoutesFirst", this.GrayRoutesFirst);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

