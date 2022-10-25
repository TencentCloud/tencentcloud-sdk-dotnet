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

    public class QueryOpenBankSettleOrderResult : AbstractModel
    {
        
        /// <summary>
        /// 外部结算流水号
        /// </summary>
        [JsonProperty("OutSettleId")]
        public string OutSettleId{ get; set; }

        /// <summary>
        /// 渠道结算流水号
        /// </summary>
        [JsonProperty("ChannelSettleId")]
        public string ChannelSettleId{ get; set; }

        /// <summary>
        /// 退款状态。
        /// SUCCESS：结算成功；
        /// FAILED：结算失败；
        /// PROCESSING：结算中;
        /// INIT:初始化;
        /// ACCEPT_FAILED:受理失败,底层银行返回订单不存在
        /// ACCEPTED：受理成功
        /// _UNKNOWN：默认未知
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettleStatus")]
        public string SettleStatus{ get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [JsonProperty("SettleAmount")]
        public long? SettleAmount{ get; set; }

        /// <summary>
        /// 结算日期，格式YYYYMMdd
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettleDate")]
        public string SettleDate{ get; set; }

        /// <summary>
        /// 结算类型（T1/D1）
        /// </summary>
        [JsonProperty("SettleType")]
        public string SettleType{ get; set; }

        /// <summary>
        /// 失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 完成时间，格式yyyy-MM-dd HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeFinish")]
        public string TimeFinish{ get; set; }

        /// <summary>
        /// 结算手续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettleFee")]
        public string SettleFee{ get; set; }

        /// <summary>
        /// 账户货币。参考附录“币种类型”。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutSettleId", this.OutSettleId);
            this.SetParamSimple(map, prefix + "ChannelSettleId", this.ChannelSettleId);
            this.SetParamSimple(map, prefix + "SettleStatus", this.SettleStatus);
            this.SetParamSimple(map, prefix + "SettleAmount", this.SettleAmount);
            this.SetParamSimple(map, prefix + "SettleDate", this.SettleDate);
            this.SetParamSimple(map, prefix + "SettleType", this.SettleType);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "TimeFinish", this.TimeFinish);
            this.SetParamSimple(map, prefix + "SettleFee", this.SettleFee);
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
        }
    }
}

