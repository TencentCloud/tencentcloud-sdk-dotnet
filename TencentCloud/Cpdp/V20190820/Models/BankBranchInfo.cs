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

    public class BankBranchInfo : AbstractModel
    {
        
        /// <summary>
        /// 银行名称。
        /// </summary>
        [JsonProperty("BankName")]
        public string BankName{ get; set; }

        /// <summary>
        /// 银行简称。
        /// </summary>
        [JsonProperty("BankAbbreviation")]
        public string BankAbbreviation{ get; set; }

        /// <summary>
        /// 支行名。
        /// </summary>
        [JsonProperty("BankBranchName")]
        public string BankBranchName{ get; set; }

        /// <summary>
        /// 联行号。
        /// </summary>
        [JsonProperty("BankBranchId")]
        public string BankBranchId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BankName", this.BankName);
            this.SetParamSimple(map, prefix + "BankAbbreviation", this.BankAbbreviation);
            this.SetParamSimple(map, prefix + "BankBranchName", this.BankBranchName);
            this.SetParamSimple(map, prefix + "BankBranchId", this.BankBranchId);
        }
    }
}

