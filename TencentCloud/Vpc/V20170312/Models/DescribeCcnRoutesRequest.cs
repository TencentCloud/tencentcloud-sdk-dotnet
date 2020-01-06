/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DescribeCcnRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// CCN实例ID，形如：ccn-gree226l。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// CCN路由策略唯一ID。形如：ccnr-f49l6u0z。
        /// </summary>
        [JsonProperty("RouteIds")]
        public string[] RouteIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定RouteIds和Filters。
        /// <li>route-id - String -（过滤条件）路由策略ID。</li>
        /// <li>cidr-block - String -（过滤条件）目的端。</li>
        /// <li>instance-type - String -（过滤条件）下一跳类型。</li>
        /// <li>instance-region - String -（过滤条件）下一跳所属地域。</li>
        /// <li>instance-id - String -（过滤条件）下一跳实例ID。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArraySimple(map, prefix + "RouteIds.", this.RouteIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

