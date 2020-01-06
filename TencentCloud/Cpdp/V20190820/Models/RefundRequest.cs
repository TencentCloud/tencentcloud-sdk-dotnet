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

    public class RefundRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户Id，长度不小于5位， 仅支持字母和数字的组合
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 退款订单号，仅支持数字、 字母、下划线（_）、横杠字 符（-）、点（.）的组合
        /// </summary>
        [JsonProperty("RefundId")]
        public string RefundId{ get; set; }

        /// <summary>
        /// 聚鑫分配的支付主MidasAppid
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 退款金额，单位：分。备 注：当该字段为空或者为0 时，系统会默认使用订单当 实付金额做为退款金额
        /// </summary>
        [JsonProperty("TotalRefundAmt")]
        public long? TotalRefundAmt{ get; set; }

        /// <summary>
        /// 支持多个子订单批量退款单 个子订单退款支持传 SubOutTradeNo ，也支持传 SubOutTradeNoList ，都传的时候以 SubOutTradeNoList 为准。  如果传了子单退款细节，外 部不需要再传退款金额，平 台应退，商户应退金额，我 们可以直接根据子单退款算 出来总和。
        /// </summary>
        [JsonProperty("SubOrderRefundList")]
        public RefundOutSubOrderRefundList[] SubOrderRefundList{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 商品订单，仅支持数字、字 母、下划线（_）、横杠字符 （-）、点（.）的组合。  OutTradeNo ,TransactionId 二选一,不能都为空,优先使用 OutTradeNo
        /// </summary>
        [JsonProperty("OutTradeNo")]
        public string OutTradeNo{ get; set; }

        /// <summary>
        /// 结算应收金额，单位：分
        /// </summary>
        [JsonProperty("MchRefundAmt")]
        public long? MchRefundAmt{ get; set; }

        /// <summary>
        /// 调用下单接口获取的聚鑫交 易订单。  OutTradeNo ,TransactionId 二选一,不能都为空,优先使用 OutTradeNo
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// 平台应收金额，单位：分
        /// </summary>
        [JsonProperty("PlatformRefundAmt")]
        public long? PlatformRefundAmt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "RefundId", this.RefundId);
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "TotalRefundAmt", this.TotalRefundAmt);
            this.SetParamArrayObj(map, prefix + "SubOrderRefundList.", this.SubOrderRefundList);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "OutTradeNo", this.OutTradeNo);
            this.SetParamSimple(map, prefix + "MchRefundAmt", this.MchRefundAmt);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamSimple(map, prefix + "PlatformRefundAmt", this.PlatformRefundAmt);
        }
    }
}

