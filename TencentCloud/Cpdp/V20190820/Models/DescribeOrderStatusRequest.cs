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

    public class DescribeOrderStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 请求类型，此接口固定填：QueryOrderStatusReq
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
        /// 交易订单号或流水号，提现，充值或会员交易请求时的CnsmrSeqNo值
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
        /// 功能标志 0：会员间交易 1：提现 2：充值
        /// </summary>
        [JsonProperty("QueryType")]
        public string QueryType{ get; set; }

        /// <summary>
        /// 银行流水号
        /// </summary>
        [JsonProperty("TransSequenceNumber")]
        public string TransSequenceNumber{ get; set; }

        /// <summary>
        /// 计费签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 聚鑫分配的支付主MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// Midas环境参数
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("ReservedMessage")]
        public string ReservedMessage{ get; set; }

        /// <summary>
        /// 子账户账号 暂未使用
        /// </summary>
        [JsonProperty("BankSubAccountNumber")]
        public string BankSubAccountNumber{ get; set; }

        /// <summary>
        /// 交易日期 暂未使用
        /// </summary>
        [JsonProperty("TransDate")]
        public string TransDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "MerchantCode", this.MerchantCode);
            this.SetParamSimple(map, prefix + "PayChannel", this.PayChannel);
            this.SetParamSimple(map, prefix + "PayChannelSubId", this.PayChannelSubId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "BankAccountNumber", this.BankAccountNumber);
            this.SetParamSimple(map, prefix + "PlatformShortNumber", this.PlatformShortNumber);
            this.SetParamSimple(map, prefix + "QueryType", this.QueryType);
            this.SetParamSimple(map, prefix + "TransSequenceNumber", this.TransSequenceNumber);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "ReservedMessage", this.ReservedMessage);
            this.SetParamSimple(map, prefix + "BankSubAccountNumber", this.BankSubAccountNumber);
            this.SetParamSimple(map, prefix + "TransDate", this.TransDate);
        }
    }
}

