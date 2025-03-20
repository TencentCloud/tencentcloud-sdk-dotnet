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

    public class AuctionInfo : AbstractModel
    {
        
        /// <summary>
        /// 竞拍人
        /// </summary>
        [JsonProperty("Bidder")]
        public string Bidder{ get; set; }

        /// <summary>
        /// 竞拍时间
        /// </summary>
        [JsonProperty("AuctionTime")]
        public string AuctionTime{ get; set; }

        /// <summary>
        /// 竞拍价格
        /// </summary>
        [JsonProperty("AuctionPrice")]
        public float? AuctionPrice{ get; set; }

        /// <summary>
        /// 状态 up: 领先 down: 落后
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bidder", this.Bidder);
            this.SetParamSimple(map, prefix + "AuctionTime", this.AuctionTime);
            this.SetParamSimple(map, prefix + "AuctionPrice", this.AuctionPrice);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

