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

    public class RegisterBillRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求类型此接口固定填：RegBillSupportWithdrawReq
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MerchantCode")]
        public string MerchantCode{ get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        [JsonProperty("PayChannel")]
        public string PayChannel{ get; set; }

        /// <summary>
        /// 子渠道
        /// </summary>
        [JsonProperty("PayChannelSubId")]
        public long? PayChannelSubId{ get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 父账户账号，资金汇总账号
        /// </summary>
        [JsonProperty("BankAccountNo")]
        public string BankAccountNo{ get; set; }

        /// <summary>
        /// 平台短号(银行分配)
        /// </summary>
        [JsonProperty("PlatformShortNo")]
        public string PlatformShortNo{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 计费签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonProperty("TransSeqNo")]
        public string TransSeqNo{ get; set; }

        /// <summary>
        /// 暂未使用，默认传0.0
        /// </summary>
        [JsonProperty("TranFee")]
        public string TranFee{ get; set; }

        /// <summary>
        /// 挂账金额
        /// </summary>
        [JsonProperty("OrderAmt")]
        public string OrderAmt{ get; set; }

        /// <summary>
        /// 子账户账号
        /// </summary>
        [JsonProperty("BankSubAccountNo")]
        public string BankSubAccountNo{ get; set; }

        /// <summary>
        /// 交易网会员代码
        /// </summary>
        [JsonProperty("TranNetMemberCode")]
        public string TranNetMemberCode{ get; set; }

        /// <summary>
        /// 0,登记挂账，1，撤销挂账
        /// </summary>
        [JsonProperty("TranType")]
        public string TranType{ get; set; }

        /// <summary>
        /// 保留域
        /// </summary>
        [JsonProperty("ReservedMessage")]
        public string ReservedMessage{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "MerchantCode", this.MerchantCode);
            this.SetParamSimple(map, prefix + "PayChannel", this.PayChannel);
            this.SetParamSimple(map, prefix + "PayChannelSubId", this.PayChannelSubId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "BankAccountNo", this.BankAccountNo);
            this.SetParamSimple(map, prefix + "PlatformShortNo", this.PlatformShortNo);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "TransSeqNo", this.TransSeqNo);
            this.SetParamSimple(map, prefix + "TranFee", this.TranFee);
            this.SetParamSimple(map, prefix + "OrderAmt", this.OrderAmt);
            this.SetParamSimple(map, prefix + "BankSubAccountNo", this.BankSubAccountNo);
            this.SetParamSimple(map, prefix + "TranNetMemberCode", this.TranNetMemberCode);
            this.SetParamSimple(map, prefix + "TranType", this.TranType);
            this.SetParamSimple(map, prefix + "ReservedMessage", this.ReservedMessage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

