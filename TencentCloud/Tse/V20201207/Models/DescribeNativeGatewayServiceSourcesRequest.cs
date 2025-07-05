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

    public class DescribeNativeGatewayServiceSourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关实例ID
        /// </summary>
        [JsonProperty("GatewayID")]
        public string GatewayID{ get; set; }

        /// <summary>
        /// 单页条数，最大100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 服务来源实例名称，模糊搜索
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 微服务引擎类型：TSE-Nacos｜TSE-Consul｜TSE-PolarisMesh｜Customer-Nacos｜Customer-Consul｜Customer-PolarisMesh
        /// </summary>
        [JsonProperty("SourceTypes")]
        public string[] SourceTypes{ get; set; }

        /// <summary>
        /// 排序字段类型，当前仅支持SourceName
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// 排序类型，AES/DESC
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayID", this.GatewayID);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamArraySimple(map, prefix + "SourceTypes.", this.SourceTypes);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
        }
    }
}

