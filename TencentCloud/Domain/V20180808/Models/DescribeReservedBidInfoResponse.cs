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

    public class DescribeReservedBidInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 竞价领先价格
        /// </summary>
        [JsonProperty("UpPrice")]
        public long? UpPrice{ get; set; }

        /// <summary>
        /// 请求用户当前价格
        /// </summary>
        [JsonProperty("Price")]
        public long? Price{ get; set; }

        /// <summary>
        /// 领先用户
        /// </summary>
        [JsonProperty("UpUser")]
        public string UpUser{ get; set; }

        /// <summary>
        /// 竞价详细数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BidList")]
        public ReserveBidInfo[] BidList{ get; set; }

        /// <summary>
        /// 竞价结束时间
        /// </summary>
        [JsonProperty("BidEndTime")]
        public string BidEndTime{ get; set; }

        /// <summary>
        /// 是否领先
        /// </summary>
        [JsonProperty("IsUp")]
        public bool? IsUp{ get; set; }

        /// <summary>
        /// 下次出价金额
        /// </summary>
        [JsonProperty("NextPrice")]
        public long? NextPrice{ get; set; }

        /// <summary>
        /// 状态：1. 等待竞价 2.竞价中 3.竞价结束
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

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
            this.SetParamSimple(map, prefix + "UpPrice", this.UpPrice);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "UpUser", this.UpUser);
            this.SetParamArrayObj(map, prefix + "BidList.", this.BidList);
            this.SetParamSimple(map, prefix + "BidEndTime", this.BidEndTime);
            this.SetParamSimple(map, prefix + "IsUp", this.IsUp);
            this.SetParamSimple(map, prefix + "NextPrice", this.NextPrice);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

