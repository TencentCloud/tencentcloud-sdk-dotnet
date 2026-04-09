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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVoucherInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>券总数</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>总余额（微分）</p>
        /// </summary>
        [JsonProperty("TotalBalance")]
        public long? TotalBalance{ get; set; }

        /// <summary>
        /// <p>代金券相关信息</p>
        /// </summary>
        [JsonProperty("VoucherInfos")]
        public VoucherInfos[] VoucherInfos{ get; set; }

        /// <summary>
        /// <p>接口返回的金额字段单位</p><p>默认值：micro</p><p>金额单位：micro（微分）<br>代金券发放和使用按8位高精度处理，所以金额单位默认为micro（微分），如需CNY或USD请按以下公式换算<br>CNY：1 micro = 10⁻⁸ 元<br>USD：1 micro = 10⁻⁸ 美元</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalBalance", this.TotalBalance);
            this.SetParamArrayObj(map, prefix + "VoucherInfos.", this.VoucherInfos);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

