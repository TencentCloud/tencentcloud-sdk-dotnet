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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillTransactionInfo : AbstractModel
    {
        
        /// <summary>
        /// 收支类型：deduct 扣费, recharge 充值, return 退费， block 冻结, unblock 解冻
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 流水金额，单位（分）；正数表示入账，负数表示出账
        /// </summary>
        [JsonProperty("Amount")]
        public long? Amount{ get; set; }

        /// <summary>
        /// 可用余额，单位（分）；正数表示入账，负数表示出账
        /// </summary>
        [JsonProperty("Balance")]
        public long? Balance{ get; set; }

        /// <summary>
        /// 流水号，如20190131020000236005203583326401
        /// </summary>
        [JsonProperty("BillId")]
        public string BillId{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("OperationInfo")]
        public string OperationInfo{ get; set; }

        /// <summary>
        /// 操作时间"2019-01-31 23:35:10.000"
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }

        /// <summary>
        /// 现金账户余额，单位（分）
        /// </summary>
        [JsonProperty("Cash")]
        public long? Cash{ get; set; }

        /// <summary>
        /// 赠送金余额，单位（分）
        /// </summary>
        [JsonProperty("Incentive")]
        public long? Incentive{ get; set; }

        /// <summary>
        /// 冻结余额，单位（分）
        /// </summary>
        [JsonProperty("Freezing")]
        public long? Freezing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "BillId", this.BillId);
            this.SetParamSimple(map, prefix + "OperationInfo", this.OperationInfo);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
            this.SetParamSimple(map, prefix + "Cash", this.Cash);
            this.SetParamSimple(map, prefix + "Incentive", this.Incentive);
            this.SetParamSimple(map, prefix + "Freezing", this.Freezing);
        }
    }
}

