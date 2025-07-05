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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReserveBidInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 出价
        /// </summary>
        [JsonProperty("Price")]
        public long? Price{ get; set; }

        /// <summary>
        /// 出价时间
        /// </summary>
        [JsonProperty("BidTime")]
        public string BidTime{ get; set; }

        /// <summary>
        /// 当前状态
        /// </summary>
        [JsonProperty("BidStatus")]
        public string BidStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "BidTime", this.BidTime);
            this.SetParamSimple(map, prefix + "BidStatus", this.BidStatus);
        }
    }
}

