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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WeChatBillDetail : AbstractModel
    {
        
        /// <summary>
        /// token
        /// </summary>
        [JsonProperty("BizToken")]
        public string BizToken{ get; set; }

        /// <summary>
        /// 本token收费次数。（说明：一次核身过程用户可能会重试多次，因此一个biztoken可能会对应多次计费，如需配置重试上限，请[联系我们](https://cloud.tencent.com/document/product/1007/56130)配置。）
        /// </summary>
        [JsonProperty("ChargeCount")]
        public ulong? ChargeCount{ get; set; }

        /// <summary>
        /// 本token计费详情
        /// </summary>
        [JsonProperty("ChargeDetails")]
        public ChargeDetail[] ChargeDetails{ get; set; }

        /// <summary>
        /// 业务RuleId
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizToken", this.BizToken);
            this.SetParamSimple(map, prefix + "ChargeCount", this.ChargeCount);
            this.SetParamArrayObj(map, prefix + "ChargeDetails.", this.ChargeDetails);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

