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

    public class DescribeBandwidthPackagesRequest : AbstractModel
    {
        
        /// <summary>
        /// 带宽包唯一ID列表
        /// </summary>
        [JsonProperty("BandwidthPackageIds")]
        public string[] BandwidthPackageIds{ get; set; }

        /// <summary>
        /// 每次请求的`Filters`的上限为10。参数不支持同时指定`BandwidthPackageIds`和`Filters`。详细的过滤条件如下：
        /// <li> bandwidth-package-id - String - 是否必填：否 - （过滤条件）按照带宽包的唯一标识ID过滤。</li>
        /// <li> bandwidth-package-name - String - 是否必填：否 - （过滤条件）按照 带宽包名称过滤。不支持模糊过滤。</li>
        /// <li> network-type - String - 是否必填：否 - （过滤条件）按照带宽包的类型过滤。类型包括'HIGH_QUALITY_BGP','BGP','SINGLEISP'和'ANYCAST'。</li>
        /// <li> charge-type - String - 是否必填：否 - （过滤条件）按照带宽包的计费类型过滤。计费类型包括: <li>'TOP5_POSTPAID_BY_MONTH':按月后付费TOP5计费</li><li> 'PERCENT95_POSTPAID_BY_MONTH':按月后付费月95计费</li><li>'ENHANCED95_POSTPAID_BY_MONTH':按月后付费增强型95计费</li><li>'FIXED_PREPAID_BY_MONTH':包月预付费计费</li><li>‘PEAK_BANDWIDTH_POSTPAID_BY_DAY’: 后付费日结按带宽计费</li>
        /// <li> resource.resource-type - String - 是否必填：否 - （过滤条件）按照带宽包资源类型过滤。资源类型包括'Address'和'LoadBalance'</li>
        /// <li> resource.resource-id - String - 是否必填：否 - （过滤条件）按照带宽包资源Id过滤。资源Id形如'eip-xxxx','lb-xxxx'</li>
        /// <li> resource.address-ip - String - 是否必填：否 - （过滤条件）按照带宽包资源Ip过滤。</li>
        /// <li> tag-key - String - 是否必填：否 - （过滤条件）按照标签键进行过滤。</li>
        /// <li> tag-value - String - 是否必填：否 - （过滤条件）按照标签值进行过滤。</li>
        /// <li> tag:tag-key - String - 是否必填：否 - （过滤条件）按照标签键值对进行过滤。tag-key使用具体的标签键进行替换。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 查询带宽包偏移量，默认为0。关于Offset的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小结。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 查询带宽包返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小结。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "BandwidthPackageIds.", this.BandwidthPackageIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

