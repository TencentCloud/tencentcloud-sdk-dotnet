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

    public class DescribeAccountBalanceResponse : AbstractModel
    {
        
        /// <summary>
        /// 接口做过变更,为兼容老接口,本字段与RealBalance相同,为当前真实可用余额,单位 分
        /// </summary>
        [JsonProperty("Balance")]
        public long? Balance{ get; set; }

        /// <summary>
        /// 查询的用户Uin
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// 当前真实可用余额,单位 分
        /// </summary>
        [JsonProperty("RealBalance")]
        public float? RealBalance{ get; set; }

        /// <summary>
        /// 现金账户余额,单位 分
        /// </summary>
        [JsonProperty("CashAccountBalance")]
        public float? CashAccountBalance{ get; set; }

        /// <summary>
        /// 收益转入账户余额,单位 分
        /// </summary>
        [JsonProperty("IncomeIntoAccountBalance")]
        public float? IncomeIntoAccountBalance{ get; set; }

        /// <summary>
        /// 赠送账户余额,单位 分
        /// </summary>
        [JsonProperty("PresentAccountBalance")]
        public float? PresentAccountBalance{ get; set; }

        /// <summary>
        /// 冻结金额,单位 分
        /// </summary>
        [JsonProperty("FreezeAmount")]
        public float? FreezeAmount{ get; set; }

        /// <summary>
        /// 欠费金额,单位 分
        /// </summary>
        [JsonProperty("OweAmount")]
        public float? OweAmount{ get; set; }

        /// <summary>
        /// 是否允许欠费消费
        /// </summary>
        [JsonProperty("IsAllowArrears")]
        [System.Obsolete]
        public bool? IsAllowArrears{ get; set; }

        /// <summary>
        /// 是否限制信用额度
        /// </summary>
        [JsonProperty("IsCreditLimited")]
        [System.Obsolete]
        public bool? IsCreditLimited{ get; set; }

        /// <summary>
        /// 信用额度,单位 分
        /// </summary>
        [JsonProperty("CreditAmount")]
        public float? CreditAmount{ get; set; }

        /// <summary>
        /// 可用信用额度,单位 分
        /// </summary>
        [JsonProperty("CreditBalance")]
        public float? CreditBalance{ get; set; }

        /// <summary>
        /// 真实可用信用额度,单位 分
        /// </summary>
        [JsonProperty("RealCreditBalance")]
        public float? RealCreditBalance{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Balance", this.Balance);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "RealBalance", this.RealBalance);
            this.SetParamSimple(map, prefix + "CashAccountBalance", this.CashAccountBalance);
            this.SetParamSimple(map, prefix + "IncomeIntoAccountBalance", this.IncomeIntoAccountBalance);
            this.SetParamSimple(map, prefix + "PresentAccountBalance", this.PresentAccountBalance);
            this.SetParamSimple(map, prefix + "FreezeAmount", this.FreezeAmount);
            this.SetParamSimple(map, prefix + "OweAmount", this.OweAmount);
            this.SetParamSimple(map, prefix + "IsAllowArrears", this.IsAllowArrears);
            this.SetParamSimple(map, prefix + "IsCreditLimited", this.IsCreditLimited);
            this.SetParamSimple(map, prefix + "CreditAmount", this.CreditAmount);
            this.SetParamSimple(map, prefix + "CreditBalance", this.CreditBalance);
            this.SetParamSimple(map, prefix + "RealCreditBalance", this.RealCreditBalance);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

