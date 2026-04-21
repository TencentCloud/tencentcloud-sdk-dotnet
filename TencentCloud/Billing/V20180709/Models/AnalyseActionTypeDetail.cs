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

    public class AnalyseActionTypeDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>交易类型code</p><p>枚举值：</p><ul><li>prepay_purchase： 包年包月新购</li><li>prepay_renew： 包年包月续费</li><li>prepay_modify： 包年包月配置变更</li><li>prepay_return： 包年包月退款</li><li>postpay_deduct_h： 按量计费小时结</li><li>postpay_deduct_d： 按量计费日结</li><li>postpay_deduct_m： 按量计费月结</li><li>offline_deduct： 线下项目扣费</li><li>online_deduct： 线下产品扣费</li><li>recon_deduct： 调账扣费</li><li>recon_increase： 调账补偿</li><li>postpay_deduct_s： 竞价实例小时结</li><li>recon_increase_f： 线下项目调账补偿</li><li>pre_to_post： 包年包月转按量</li><li>svp_hour_pay： 节省计划小时费用</li><li>recon_guarantee： 保底扣款</li><li>billVirtualId： 月度计费精度差异</li></ul>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>交易类型Name</p>
        /// </summary>
        [JsonProperty("ActionTypeName")]
        public string ActionTypeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "ActionTypeName", this.ActionTypeName);
        }
    }
}

