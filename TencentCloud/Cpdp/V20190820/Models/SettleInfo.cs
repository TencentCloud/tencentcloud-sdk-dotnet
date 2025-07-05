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

    public class SettleInfo : AbstractModel
    {
        
        /// <summary>
        /// 结算账户类型 
        /// PRIVATE：对私 
        /// BUSINESS：对公
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("SettleAccountType")]
        public string SettleAccountType{ get; set; }

        /// <summary>
        /// 结算账号
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("SettleAccountNumber")]
        public string SettleAccountNumber{ get; set; }

        /// <summary>
        /// 结算账户名称
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("SettleAccountName")]
        public string SettleAccountName{ get; set; }

        /// <summary>
        /// 支行号
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("BankBranchId")]
        public string BankBranchId{ get; set; }

        /// <summary>
        /// 支行名称
        /// </summary>
        [JsonProperty("BankBranchName")]
        public string BankBranchName{ get; set; }

        /// <summary>
        /// 结算方式 
        /// AUTO：自动结算 
        /// SELF：自主结算
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("SettleMode")]
        public string SettleMode{ get; set; }

        /// <summary>
        /// 结算周期 
        /// T1：工作日隔天结算 
        /// D1：自然日隔天结算 
        /// D0：当日结算
        /// HELIPAY渠道必传
        /// </summary>
        [JsonProperty("SettlePeriod")]
        public string SettlePeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SettleAccountType", this.SettleAccountType);
            this.SetParamSimple(map, prefix + "SettleAccountNumber", this.SettleAccountNumber);
            this.SetParamSimple(map, prefix + "SettleAccountName", this.SettleAccountName);
            this.SetParamSimple(map, prefix + "BankBranchId", this.BankBranchId);
            this.SetParamSimple(map, prefix + "BankBranchName", this.BankBranchName);
            this.SetParamSimple(map, prefix + "SettleMode", this.SettleMode);
            this.SetParamSimple(map, prefix + "SettlePeriod", this.SettlePeriod);
        }
    }
}

