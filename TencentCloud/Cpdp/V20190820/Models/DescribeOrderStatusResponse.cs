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

    public class DescribeOrderStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// 交易状态 （（0：成功，1：失败，2：待确认, 5：待处理，6：处理中）
        /// </summary>
        [JsonProperty("OrderStatus")]
        public string OrderStatus{ get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("OrderAmount")]
        public string OrderAmount{ get; set; }

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
        /// 转出子账户账号
        /// </summary>
        [JsonProperty("OutSubAccountNumber")]
        public string OutSubAccountNumber{ get; set; }

        /// <summary>
        /// 转入子账户账号
        /// </summary>
        [JsonProperty("InSubAccountNumber")]
        public string InSubAccountNumber{ get; set; }

        /// <summary>
        /// 记账标志（1：登记挂账 2：支付 3：提现 4：清分5:下单预支付 6：确认并付款 7：退款 8：支付到平台 N:其他）
        /// </summary>
        [JsonProperty("BookingFlag")]
        public string BookingFlag{ get; set; }

        /// <summary>
        /// 当交易失败时，返回交易失败原因
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
            this.SetParamSimple(map, prefix + "OrderDate", this.OrderDate);
            this.SetParamSimple(map, prefix + "OrderTime", this.OrderTime);
            this.SetParamSimple(map, prefix + "OutSubAccountNumber", this.OutSubAccountNumber);
            this.SetParamSimple(map, prefix + "InSubAccountNumber", this.InSubAccountNumber);
            this.SetParamSimple(map, prefix + "BookingFlag", this.BookingFlag);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

