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

namespace TencentCloud.Iotvideo.V20201215.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BalanceTransaction : AbstractModel
    {
        
        /// <summary>
        /// 账户类型：1-设备接入 2-云存。
        /// </summary>
        [JsonProperty("AccountType")]
        public ulong? AccountType{ get; set; }

        /// <summary>
        /// 账户变更类型：Rechareg-充值；CreateOrder-新购。
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 流水ID。
        /// </summary>
        [JsonProperty("DealId")]
        public string DealId{ get; set; }

        /// <summary>
        /// 变更金额，单位：分（人民币）。
        /// </summary>
        [JsonProperty("Amount")]
        public ulong? Amount{ get; set; }

        /// <summary>
        /// 变更后账户余额，单位：分（人民币）。
        /// </summary>
        [JsonProperty("Balance")]
        public ulong? Balance{ get; set; }

        /// <summary>
        /// 变更时间。
        /// </summary>
        [JsonProperty("OperationTime")]
        public long? OperationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "DealId", this.DealId);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
        }
    }
}

