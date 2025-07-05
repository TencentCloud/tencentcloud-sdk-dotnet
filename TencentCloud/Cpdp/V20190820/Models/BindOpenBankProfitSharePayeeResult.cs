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

    public class BindOpenBankProfitSharePayeeResult : AbstractModel
    {
        
        /// <summary>
        /// 账户ID。受益人ID
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 账户号，通联渠道指客户银行账号
        /// </summary>
        [JsonProperty("AccountNo")]
        public string AccountNo{ get; set; }

        /// <summary>
        /// 账户货币。参考附录“币种类型”。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "AccountNo", this.AccountNo);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
        }
    }
}

