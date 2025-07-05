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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLivePackageInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 包类型，可选值：
        /// 0：流量包
        /// 1：转码包
        /// 2: 连麦包。
        /// </summary>
        [JsonProperty("PackageType")]
        public long? PackageType{ get; set; }

        /// <summary>
        /// 排序规则:
        /// 1. BuyTimeDesc： 最新购买的排在最前面
        /// 2. BuyTimeAsc： 最老购买的排在最前面
        /// 3. ExpireTimeDesc： 最后过期的排在最前面
        /// 4. ExpireTimeAsc：最先过期的排在最前面。
        /// 
        /// 注意：
        /// 1. PackageType 为 2（连麦包） 的时候，不支持 3、4 排序。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 取得第几页的数据，和 PageSize 同时传递才会生效。
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// 分页大小，和 PageNum 同时传递才会生效。
        /// 取值：10 ～ 100 之间的任意整数。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "PageNum", this.PageNum);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

