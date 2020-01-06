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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRegionAndPriceResponse : AbstractModel
    {
        
        /// <summary>
        /// 源站区域总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 源站区域详情列表
        /// </summary>
        [JsonProperty("DestRegionSet")]
        public RegionDetail[] DestRegionSet{ get; set; }

        /// <summary>
        /// 通道带宽费用梯度价格
        /// </summary>
        [JsonProperty("BandwidthUnitPrice")]
        public BandwidthPriceGradient[] BandwidthUnitPrice{ get; set; }

        /// <summary>
        /// 带宽价格货币类型：
        /// CNY 人民币
        /// USD 美元
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "DestRegionSet.", this.DestRegionSet);
            this.SetParamArrayObj(map, prefix + "BandwidthUnitPrice.", this.BandwidthUnitPrice);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

