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

    public class QueryItem : AbstractModel
    {
        
        /// <summary>
        /// 子商户账户
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// 子账户属性 
        /// 1：普通会员子账号 
        /// 2：挂账子账号 
        /// 3：手续费子账号 
        /// 4：利息子账号
        /// 5：平台担保子账号
        /// </summary>
        [JsonProperty("SubAcctProperty")]
        public string SubAcctProperty{ get; set; }

        /// <summary>
        /// 业务平台的子商户Id，唯一
        /// </summary>
        [JsonProperty("SubMchId")]
        public string SubMchId{ get; set; }

        /// <summary>
        /// 子账户名称
        /// </summary>
        [JsonProperty("SubAcctName")]
        public string SubAcctName{ get; set; }

        /// <summary>
        /// 账户可用余额
        /// </summary>
        [JsonProperty("AcctAvailBal")]
        public string AcctAvailBal{ get; set; }

        /// <summary>
        /// 可提现金额
        /// </summary>
        [JsonProperty("CashAmt")]
        public string CashAmt{ get; set; }

        /// <summary>
        /// 维护日期 开户日期或修改日期
        /// </summary>
        [JsonProperty("MaintenanceDate")]
        public string MaintenanceDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "SubAcctProperty", this.SubAcctProperty);
            this.SetParamSimple(map, prefix + "SubMchId", this.SubMchId);
            this.SetParamSimple(map, prefix + "SubAcctName", this.SubAcctName);
            this.SetParamSimple(map, prefix + "AcctAvailBal", this.AcctAvailBal);
            this.SetParamSimple(map, prefix + "CashAmt", this.CashAmt);
            this.SetParamSimple(map, prefix + "MaintenanceDate", this.MaintenanceDate);
        }
    }
}

