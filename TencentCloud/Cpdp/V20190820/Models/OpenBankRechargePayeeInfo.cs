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

    public class OpenBankRechargePayeeInfo : AbstractModel
    {
        
        /// <summary>
        /// 收款方标识
        /// 收款方类型为电子记账本时，上送渠道电子记账本ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 收款方标识类型
        /// ACCOUNT_BOOK_ID：电子记账本ID
        /// </summary>
        [JsonProperty("PayeeIdType")]
        public string PayeeIdType{ get; set; }

        /// <summary>
        /// 收款方名称
        /// </summary>
        [JsonProperty("PayeeName")]
        public string PayeeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "PayeeIdType", this.PayeeIdType);
            this.SetParamSimple(map, prefix + "PayeeName", this.PayeeName);
        }
    }
}

