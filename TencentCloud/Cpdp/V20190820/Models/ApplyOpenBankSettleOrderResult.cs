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

    public class ApplyOpenBankSettleOrderResult : AbstractModel
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
        /// </summary>
        [JsonProperty("SettleStatus")]
        public string SettleStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutSettleId", this.OutSettleId);
            this.SetParamSimple(map, prefix + "ChannelSettleId", this.ChannelSettleId);
            this.SetParamSimple(map, prefix + "SettleStatus", this.SettleStatus);
        }
    }
}

