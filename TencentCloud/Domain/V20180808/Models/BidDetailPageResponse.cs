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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BidDetailPageResponse : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 当前域名价格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentPrice")]
        public float? CurrentPrice{ get; set; }

        /// <summary>
        /// 用户上次出价
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BidPrice")]
        public float? BidPrice{ get; set; }

        /// <summary>
        /// 当前加价幅度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentPriceScope")]
        public float? CurrentPriceScope{ get; set; }

        /// <summary>
        /// 加价幅度区间配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PriceScope")]
        public PriceScopeConf[] PriceScope{ get; set; }

        /// <summary>
        /// 用户当前已经支付了的保证金
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DepositPrice")]
        public float? DepositPrice{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CurrentPrice", this.CurrentPrice);
            this.SetParamSimple(map, prefix + "BidPrice", this.BidPrice);
            this.SetParamSimple(map, prefix + "CurrentPriceScope", this.CurrentPriceScope);
            this.SetParamArrayObj(map, prefix + "PriceScope.", this.PriceScope);
            this.SetParamSimple(map, prefix + "DepositPrice", this.DepositPrice);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

