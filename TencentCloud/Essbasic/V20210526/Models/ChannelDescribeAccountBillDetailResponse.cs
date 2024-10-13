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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelDescribeAccountBillDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 当前绑定中账号数量
        /// </summary>
        [JsonProperty("BoundAccountsNumber")]
        public long? BoundAccountsNumber{ get; set; }

        /// <summary>
        /// 剩余可绑定账号数量
        /// </summary>
        [JsonProperty("RemainAvailableAccountsNumber")]
        public long? RemainAvailableAccountsNumber{ get; set; }

        /// <summary>
        /// 已失效账号数量
        /// </summary>
        [JsonProperty("InvalidAccountsNumber")]
        public long? InvalidAccountsNumber{ get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        [JsonProperty("TotalBuyAccountsNumber")]
        public long? TotalBuyAccountsNumber{ get; set; }

        /// <summary>
        /// 赠送数量
        /// </summary>
        [JsonProperty("TotalGiftAccountsNumber")]
        public long? TotalGiftAccountsNumber{ get; set; }

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
            this.SetParamSimple(map, prefix + "BoundAccountsNumber", this.BoundAccountsNumber);
            this.SetParamSimple(map, prefix + "RemainAvailableAccountsNumber", this.RemainAvailableAccountsNumber);
            this.SetParamSimple(map, prefix + "InvalidAccountsNumber", this.InvalidAccountsNumber);
            this.SetParamSimple(map, prefix + "TotalBuyAccountsNumber", this.TotalBuyAccountsNumber);
            this.SetParamSimple(map, prefix + "TotalGiftAccountsNumber", this.TotalGiftAccountsNumber);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

