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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePlanRequest : AbstractModel
    {
        
        /// <summary>
        /// 订阅的套餐类型，取值有：<li> personal：个人版套餐，预付费套餐；</li><li> basic：基础版套餐，预付费套餐；</li><li> standard：标准版套餐，预付费套餐；</li><li> enterprise：企业版套餐，后付费套餐。</li>订阅预付费套餐时，请确保账号内有足够余额，余额不足会产生一个待支付的订单。
        /// 计费概述参考 [Edgeone计费概述](https://cloud.tencent.com/document/product/1552/94156)
        /// 不同套餐区别参考 [Edgeone计费套餐选型对比](https://cloud.tencent.com/document/product/1552/94165)
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// 是否自动使用代金券，取值有：<li> true：是；</li><li> false：否。</li>该参数仅在 PlanType 为 personal, basic, standard 时有效。
        /// 不填写使用默认值 false。
        /// </summary>
        [JsonProperty("AutoUseVoucher")]
        public string AutoUseVoucher{ get; set; }

        /// <summary>
        /// 订阅预付费套餐参数，PlanType 为 personal, basic, standard 时，可以选填该参数，用于传入套餐的订阅时长和是否开启自动续费。
        /// 不填该参数时，默认开通套餐时长为 1 个月，不开启自动续费。
        /// </summary>
        [JsonProperty("PrepaidPlanParam")]
        public PrepaidPlanParam PrepaidPlanParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "AutoUseVoucher", this.AutoUseVoucher);
            this.SetParamObj(map, prefix + "PrepaidPlanParam.", this.PrepaidPlanParam);
        }
    }
}

