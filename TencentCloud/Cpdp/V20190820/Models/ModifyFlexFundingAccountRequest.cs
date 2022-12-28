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

    public class ModifyFlexFundingAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// 收款用户ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 收款用户资金账户ID
        /// </summary>
        [JsonProperty("FundingAccountBindSerialNo")]
        public string FundingAccountBindSerialNo{ get; set; }

        /// <summary>
        /// 资金账户类型
        /// PINGAN_BANK:平安银行
        /// </summary>
        [JsonProperty("FundingAccountType")]
        public string FundingAccountType{ get; set; }

        /// <summary>
        /// 收款资金账户手机号
        /// </summary>
        [JsonProperty("PhoneNo")]
        public string PhoneNo{ get; set; }

        /// <summary>
        /// 收款资金账户姓名
        /// </summary>
        [JsonProperty("FundingAccountName")]
        public string FundingAccountName{ get; set; }

        /// <summary>
        /// 收款资金账户号
        /// </summary>
        [JsonProperty("FundingAccountNo")]
        public string FundingAccountNo{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// __test__:测试环境
        /// 缺省默认为生产环境
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }

        /// <summary>
        /// 开户支行名
        /// </summary>
        [JsonProperty("BankBranchName")]
        public string BankBranchName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "FundingAccountBindSerialNo", this.FundingAccountBindSerialNo);
            this.SetParamSimple(map, prefix + "FundingAccountType", this.FundingAccountType);
            this.SetParamSimple(map, prefix + "PhoneNo", this.PhoneNo);
            this.SetParamSimple(map, prefix + "FundingAccountName", this.FundingAccountName);
            this.SetParamSimple(map, prefix + "FundingAccountNo", this.FundingAccountNo);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
            this.SetParamSimple(map, prefix + "BankBranchName", this.BankBranchName);
        }
    }
}

