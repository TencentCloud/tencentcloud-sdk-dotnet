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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDisasterRecoveryProtectGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要查询的容灾保护组产品类型，枚举值：DISK / INSTANCE / CFS。
        /// </summary>
        [JsonProperty("ProtectGroupType")]
        public string ProtectGroupType{ get; set; }

        /// <summary>
        /// 要查询的容灾保护组ID列表。
        /// </summary>
        [JsonProperty("ProtectGroupIds")]
        public string[] ProtectGroupIds{ get; set; }

        /// <summary>
        /// 过滤条件（过滤项由 core handler 定义，如 disaster-recovery-protect-group-id 等）。
        /// </summary>
        [JsonProperty("Filters")]
        public FilterModel[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API 简介中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 输出结果按升序还是降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 输出结果的排序字段
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectGroupType", this.ProtectGroupType);
            this.SetParamArraySimple(map, prefix + "ProtectGroupIds.", this.ProtectGroupIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
        }
    }
}

