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

    public class MigrateOrderRefundQueryResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求成功状态
        /// </summary>
        [JsonProperty("IsSuccess")]
        public bool? IsSuccess{ get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [JsonProperty("TradeSerialNo")]
        public string TradeSerialNo{ get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        [JsonProperty("TradeMsg")]
        public string TradeMsg{ get; set; }

        /// <summary>
        /// 交易状态：0=交易待处理；1=交易处理中；2=交易处理成功；3=交易失败；4=状态未知
        /// </summary>
        [JsonProperty("TradeStatus")]
        public long? TradeStatus{ get; set; }

        /// <summary>
        /// 第三方支付机构支付交易号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThirdChannelOrderId")]
        public string ThirdChannelOrderId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSuccess", this.IsSuccess);
            this.SetParamSimple(map, prefix + "TradeSerialNo", this.TradeSerialNo);
            this.SetParamSimple(map, prefix + "TradeMsg", this.TradeMsg);
            this.SetParamSimple(map, prefix + "TradeStatus", this.TradeStatus);
            this.SetParamSimple(map, prefix + "ThirdChannelOrderId", this.ThirdChannelOrderId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

