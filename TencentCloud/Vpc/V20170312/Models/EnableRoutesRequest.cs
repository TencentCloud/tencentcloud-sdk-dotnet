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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由表唯一ID。
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// 路由策略ID。不能和RouteItemIds同时使用，但至少输入一个。单次处理上限100个。该参数取值可通过查询路由列表（[DescribeRouteTables](https://cloud.tencent.com/document/product/215/15763)）获取。
        /// </summary>
        [JsonProperty("RouteIds")]
        public ulong?[] RouteIds{ get; set; }

        /// <summary>
        /// 路由策略唯一ID。不能和RouteIds同时使用，但至少输入一个。单次处理上限100个。该参数取值可通过查询路由列表（[DescribeRouteTables](https://cloud.tencent.com/document/product/215/15763)）获取。
        /// </summary>
        [JsonProperty("RouteItemIds")]
        public string[] RouteItemIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamArraySimple(map, prefix + "RouteIds.", this.RouteIds);
            this.SetParamArraySimple(map, prefix + "RouteItemIds.", this.RouteItemIds);
        }
    }
}

