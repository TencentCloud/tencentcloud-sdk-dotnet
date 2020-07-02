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

    public class RechargeByThirdPayRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求类型
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
        [JsonProperty("BankAccountNumber")]
        public string BankAccountNumber{ get; set; }

        /// <summary>
        /// 平台短号(银行分配)
        /// </summary>
        [JsonProperty("PlatformShortNumber")]
        public string PlatformShortNumber{ get; set; }

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
        [JsonProperty("TransSequenceNumber")]
        public string TransSequenceNumber{ get; set; }

        /// <summary>
        /// 子账户账号
        /// </summary>
        [JsonProperty("BankSubAccountNumber")]
        public string BankSubAccountNumber{ get; set; }

        /// <summary>
        /// 交易手续费
        /// </summary>
        [JsonProperty("TransFee")]
        public string TransFee{ get; set; }

        /// <summary>
        /// 第三方支付渠道类型 0001-微信 0002-支付宝 0003-京东支付
        /// </summary>
        [JsonProperty("ThirdPayChannel")]
        public string ThirdPayChannel{ get; set; }

        /// <summary>
        /// 第三方渠道商户号
        /// </summary>
        [JsonProperty("ThirdPayChannelMerchantCode")]
        public string ThirdPayChannelMerchantCode{ get; set; }

        /// <summary>
        /// 第三方渠道订单号或流水号
        /// </summary>
        [JsonProperty("ThirdPayChannelOrderId")]
        public string ThirdPayChannelOrderId{ get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("CurrencyAmount")]
        public string CurrencyAmount{ get; set; }

        /// <summary>
        /// 单位，1：元，2：角，3：分
        /// </summary>
        [JsonProperty("CurrencyUnit")]
        public string CurrencyUnit{ get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("CurrencyType")]
        public string CurrencyType{ get; set; }

        /// <summary>
        /// 交易网会员代码
        /// </summary>
        [JsonProperty("TransNetMemberCode")]
        public string TransNetMemberCode{ get; set; }

        /// <summary>
        /// midas环境参数
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

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
            this.SetParamSimple(map, prefix + "BankAccountNumber", this.BankAccountNumber);
            this.SetParamSimple(map, prefix + "PlatformShortNumber", this.PlatformShortNumber);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "TransSequenceNumber", this.TransSequenceNumber);
            this.SetParamSimple(map, prefix + "BankSubAccountNumber", this.BankSubAccountNumber);
            this.SetParamSimple(map, prefix + "TransFee", this.TransFee);
            this.SetParamSimple(map, prefix + "ThirdPayChannel", this.ThirdPayChannel);
            this.SetParamSimple(map, prefix + "ThirdPayChannelMerchantCode", this.ThirdPayChannelMerchantCode);
            this.SetParamSimple(map, prefix + "ThirdPayChannelOrderId", this.ThirdPayChannelOrderId);
            this.SetParamSimple(map, prefix + "CurrencyAmount", this.CurrencyAmount);
            this.SetParamSimple(map, prefix + "CurrencyUnit", this.CurrencyUnit);
            this.SetParamSimple(map, prefix + "CurrencyType", this.CurrencyType);
            this.SetParamSimple(map, prefix + "TransNetMemberCode", this.TransNetMemberCode);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "ReservedMessage", this.ReservedMessage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

