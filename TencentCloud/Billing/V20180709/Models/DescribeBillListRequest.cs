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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillListRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询范围的起始时间（包含）时间格式 yyyy-MM-dd HH:mm:ss 开始时间和结束时间差值小于等于六个月
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 查询范围的结束时间（包含）时间格式 yyyy-MM-dd HH:mm:ss ，开始时间和结束时间差值小于等于六个月
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 翻页偏移量，初始值为0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 每页的限制数量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 交易类型： all所有交易类型，recharge充值，return退款，unblock解冻，agentin资金转入，advanced垫付，cash提现，deduct扣费，block冻结，agentout资金转出，repay垫付回款，repayment还款(仅国际信用账户)，adj_refund调增(仅国际信用账户)，adj_deduct调减(仅国际信用账户)
        /// </summary>
        [JsonProperty("PayType")]
        public string[] PayType{ get; set; }

        /// <summary>
        /// 扣费模式，
        /// 当所选的交易类型为扣费deduct时： 
        /// all所有扣费类型;trade预付费支付;hour_h按量小时结;hour_d按量日结;hour_m按量月结;decompensate调账扣费;other第三方扣费;panshi 线下项目扣费;offline 线下产品扣费;
        /// 
        /// 当所选的交易类型为扣费recharge时： 
        /// online 在线充值;bank-enterprice 银企直联;offline 线下充值;transfer 分成充值
        /// 
        /// 当所选的交易类型为扣费cash时： 
        /// online 线上提现;offline 线下提现;panshi 赠送金清零
        /// 
        /// 当所选的交易类型为扣费advanced时： 
        /// advanced 垫付充值
        /// 
        /// 当所选的交易类型为扣费repay时： 
        /// panshi 垫付回款
        /// 
        /// 当所选的交易类型为扣费block时： 
        /// other 第三方冻结;hour 按量冻结;month按月冻结
        /// 
        /// 当所选的交易类型为扣费return时： 
        /// compensate 调账补偿;trade 预付费退款
        /// 
        /// 当所选的交易类型为扣费unblock时：
        /// other 第三方解冻;hour 按量解冻;month 按月解冻
        /// </summary>
        [JsonProperty("SubPayType")]
        public string[] SubPayType{ get; set; }

        /// <summary>
        /// 是否返回0元交易金额的交易项，取值：0-不返回，1-返回。不传该参数则不返回
        /// </summary>
        [JsonProperty("WithZeroAmount")]
        public ulong? WithZeroAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "PayType.", this.PayType);
            this.SetParamArraySimple(map, prefix + "SubPayType.", this.SubPayType);
            this.SetParamSimple(map, prefix + "WithZeroAmount", this.WithZeroAmount);
        }
    }
}

