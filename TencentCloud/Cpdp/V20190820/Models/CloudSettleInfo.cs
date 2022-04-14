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

    public class CloudSettleInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否需要支付确认。
        /// 0: 不需要支付确认
        /// 1: 需要支付确认
        /// 传1时，需要在支付完成后成功调用了《支付确认》接口，该笔订单才会被清分出去
        /// </summary>
        [JsonProperty("NeedToBeConfirmed")]
        public long? NeedToBeConfirmed{ get; set; }

        /// <summary>
        /// 是否指定分账。
        /// 0: 不指定分账
        /// 1: 指定分账
        /// </summary>
        [JsonProperty("ProfitSharing")]
        public long? ProfitSharing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NeedToBeConfirmed", this.NeedToBeConfirmed);
            this.SetParamSimple(map, prefix + "ProfitSharing", this.ProfitSharing);
        }
    }
}

