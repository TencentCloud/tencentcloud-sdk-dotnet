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
        /// <p>包类型，可选值：<br>0：流量包<br>1：转码包<br>2: 连麦包。</p>
        /// </summary>
        [JsonProperty("PackageType")]
        public long? PackageType{ get; set; }

        /// <summary>
        /// <p>排序规则:</p><ol><li>BuyTimeDesc： 最新购买的排在最前面</li><li>BuyTimeAsc： 最老购买的排在最前面</li><li>ExpireTimeDesc： 最后过期的排在最前面</li><li>ExpireTimeAsc：最先过期的排在最前面。</li></ol><p>注意：</p><ol><li>PackageType 为 2（连麦包） 的时候，不支持 3、4 排序。</li></ol>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>取得第几页的数据，和 PageSize 同时传递才会生效。</p>
        /// </summary>
        [JsonProperty("PageNum")]
        public long? PageNum{ get; set; }

        /// <summary>
        /// <p>分页大小，和 PageNum 同时传递才会生效。<br>取值：10 ～ 100 之间的任意整数。</p>
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

