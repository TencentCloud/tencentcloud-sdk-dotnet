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

    public class WithdrawBill : AbstractModel
    {
        
        /// <summary>
        /// 业务提现订单号
        /// </summary>
        [JsonProperty("WithdrawOrderId")]
        public string WithdrawOrderId{ get; set; }

        /// <summary>
        /// 提现日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 提现金额，单位： 分
        /// </summary>
        [JsonProperty("PayAmt")]
        public string PayAmt{ get; set; }

        /// <summary>
        /// 聚鑫分配转入账户appid
        /// </summary>
        [JsonProperty("InSubAppId")]
        public string InSubAppId{ get; set; }

        /// <summary>
        /// 聚鑫分配转出账户appid
        /// </summary>
        [JsonProperty("OutSubAppId")]
        public string OutSubAppId{ get; set; }

        /// <summary>
        /// ISO货币代码
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 透传字段
        /// </summary>
        [JsonProperty("MetaData")]
        public string MetaData{ get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ExtendFieldData")]
        public string ExtendFieldData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WithdrawOrderId", this.WithdrawOrderId);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "PayAmt", this.PayAmt);
            this.SetParamSimple(map, prefix + "InSubAppId", this.InSubAppId);
            this.SetParamSimple(map, prefix + "OutSubAppId", this.OutSubAppId);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "MetaData", this.MetaData);
            this.SetParamSimple(map, prefix + "ExtendFieldData", this.ExtendFieldData);
        }
    }
}

