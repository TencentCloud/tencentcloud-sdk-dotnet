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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSinglePaymentRequest : AbstractModel
    {
        
        /// <summary>
        /// 转账类型
        /// 1 微信企业付款 
        /// 2 支付宝转账 
        /// 3 平安银企直连代发转账
        /// </summary>
        [JsonProperty("TransferType")]
        public ulong? TransferType{ get; set; }

        /// <summary>
        /// 订单流水号
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [JsonProperty("TransferAmount")]
        public ulong? TransferAmount{ get; set; }

        /// <summary>
        /// 主播ID（与主播业务ID不能同时为空，两者都填取主播ID）
        /// </summary>
        [JsonProperty("AnchorId")]
        public string AnchorId{ get; set; }

        /// <summary>
        /// 请求预留字段，原样透传返回
        /// </summary>
        [JsonProperty("ReqReserved")]
        public string ReqReserved{ get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 主播名称。如果该字段填入，则会对AnchorName和AnchorId/Uid进行校验。
        /// </summary>
        [JsonProperty("AnchorName")]
        public string AnchorName{ get; set; }

        /// <summary>
        /// 主播业务ID（与主播ID不能同时为空，两者都填取主播ID）
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 转账结果回调通知URL。若不填，则不进行回调。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransferType", this.TransferType);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "TransferAmount", this.TransferAmount);
            this.SetParamSimple(map, prefix + "AnchorId", this.AnchorId);
            this.SetParamSimple(map, prefix + "ReqReserved", this.ReqReserved);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AnchorName", this.AnchorName);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
        }
    }
}

