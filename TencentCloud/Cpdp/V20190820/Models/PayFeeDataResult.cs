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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PayFeeDataResult : AbstractModel
    {
        
        /// <summary>
        /// 机构的分佣扣率扣率
        /// </summary>
        [JsonProperty("OrganizationFee")]
        public string OrganizationFee{ get; set; }

        /// <summary>
        /// 商户手续费封顶值，0为不限封顶
        /// </summary>
        [JsonProperty("PaymentClassificationLimit")]
        public string PaymentClassificationLimit{ get; set; }

        /// <summary>
        /// 机构的分佣扣率类型(1按签约扣率，2按收单收益)
        /// </summary>
        [JsonProperty("OrganizationFeeType")]
        public string OrganizationFeeType{ get; set; }

        /// <summary>
        /// 商户扣率最大值
        /// </summary>
        [JsonProperty("PaymentClassificationMaxFee")]
        public string PaymentClassificationMaxFee{ get; set; }

        /// <summary>
        /// 商户扣率最小值
        /// </summary>
        [JsonProperty("PaymentClassificationMinFee")]
        public string PaymentClassificationMinFee{ get; set; }

        /// <summary>
        /// 行业会类编号
        /// </summary>
        [JsonProperty("PaymentClassificationId")]
        public string PaymentClassificationId{ get; set; }

        /// <summary>
        /// 行业分类名称
        /// </summary>
        [JsonProperty("PaymentClassificationName")]
        public string PaymentClassificationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationFee", this.OrganizationFee);
            this.SetParamSimple(map, prefix + "PaymentClassificationLimit", this.PaymentClassificationLimit);
            this.SetParamSimple(map, prefix + "OrganizationFeeType", this.OrganizationFeeType);
            this.SetParamSimple(map, prefix + "PaymentClassificationMaxFee", this.PaymentClassificationMaxFee);
            this.SetParamSimple(map, prefix + "PaymentClassificationMinFee", this.PaymentClassificationMinFee);
            this.SetParamSimple(map, prefix + "PaymentClassificationId", this.PaymentClassificationId);
            this.SetParamSimple(map, prefix + "PaymentClassificationName", this.PaymentClassificationName);
        }
    }
}

