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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryContractPayFeeResult : AbstractModel
    {
        
        /// <summary>
        /// pay支付方式json数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pay")]
        public PayDataResult Pay{ get; set; }

        /// <summary>
        /// 合同扩展自定义字段
        /// </summary>
        [JsonProperty("ExtraInput")]
        public string[] ExtraInput{ get; set; }

        /// <summary>
        /// pay_fee支付方式行业分类费率json数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayFee")]
        public PayFeeDataResult[] PayFee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Pay.", this.Pay);
            this.SetParamArraySimple(map, prefix + "ExtraInput.", this.ExtraInput);
            this.SetParamArrayObj(map, prefix + "PayFee.", this.PayFee);
        }
    }
}

