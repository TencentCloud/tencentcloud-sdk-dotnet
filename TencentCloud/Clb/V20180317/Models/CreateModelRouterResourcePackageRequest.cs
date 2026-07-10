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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateModelRouterResourcePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模型路由资源包容量</p><p>取值范围：[1000, 10000000]</p><p>单次购买的模型路由资源包容量下限为1000，上限为10000000</p>
        /// </summary>
        [JsonProperty("ModelRouterResourcePackageAmount")]
        public ulong? ModelRouterResourcePackageAmount{ get; set; }

        /// <summary>
        /// <p>是否自动续订。</p><p>0:不自动续订, 1:用尽到期续订</p>
        /// </summary>
        [JsonProperty("AutoPurchaseFlag")]
        public ulong? AutoPurchaseFlag{ get; set; }

        /// <summary>
        /// <p>该笔订单是否自动选择代金券</p><p>默认值：false（不自动选择代金券）</p><p>true时会为本笔订单自动匹配满足条件、最优惠的代金券</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelRouterResourcePackageAmount", this.ModelRouterResourcePackageAmount);
            this.SetParamSimple(map, prefix + "AutoPurchaseFlag", this.AutoPurchaseFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
        }
    }
}

