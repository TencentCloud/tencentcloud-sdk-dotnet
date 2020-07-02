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

    public class DescribeChargeDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 交易状态 （0：成功，1：失败，2：异常,3:冲正，5：待处理）
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("OrderAmount")]
        public string OrderAmount{ get; set; }

        /// <summary>
        /// 佣金费
        /// </summary>
        [JsonProperty("CommissionAmount")]
        public string CommissionAmount{ get; set; }

        /// <summary>
        /// 支付方式  0-冻结支付 1-普通支付
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 交易日期
        /// </summary>
        [JsonProperty("OrderDate")]
        public string OrderDate{ get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [JsonProperty("OrderTime")]
        public string OrderTime{ get; set; }

        /// <summary>
        /// 订单实际转入见证子账户的名称
        /// </summary>
        [JsonProperty("OrderActualInSubAccountName")]
        public string OrderActualInSubAccountName{ get; set; }

        /// <summary>
        /// 订单实际转入见证子账户的帐号
        /// </summary>
        [JsonProperty("OrderActualInSubAccountNumber")]
        public string OrderActualInSubAccountNumber{ get; set; }

        /// <summary>
        /// 订单实际转入见证子账户的帐号
        /// </summary>
        [JsonProperty("OrderInSubAccountName")]
        public string OrderInSubAccountName{ get; set; }

        /// <summary>
        /// 订单转入见证子账户的帐号
        /// </summary>
        [JsonProperty("OrderInSubAccountNumber")]
        public string OrderInSubAccountNumber{ get; set; }

        /// <summary>
        /// 银行流水号
        /// </summary>
        [JsonProperty("FrontSequenceNumber")]
        public string FrontSequenceNumber{ get; set; }

        /// <summary>
        /// 当充值失败时，返回交易失败原因
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "OrderAmount", this.OrderAmount);
            this.SetParamSimple(map, prefix + "CommissionAmount", this.CommissionAmount);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "OrderDate", this.OrderDate);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "OrderActualInSubAccountName", this.OrderActualInSubAccountName);
            this.SetParamSimple(map, prefix + "OrderActualInSubAccountNumber", this.OrderActualInSubAccountNumber);
            this.SetParamSimple(map, prefix + "OrderInSubAccountName", this.OrderInSubAccountName);
            this.SetParamSimple(map, prefix + "OrderInSubAccountNumber", this.OrderInSubAccountNumber);
            this.SetParamSimple(map, prefix + "FrontSequenceNumber", this.FrontSequenceNumber);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

