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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkConfig : AbstractModel
    {
        
        /// <summary>
        /// 高防EIP地址
        /// </summary>
        [JsonProperty("AntiDDosEip")]
        public string AntiDDosEip{ get; set; }

        /// <summary>
        /// 高防EIP绑定状态。
        /// 0：解绑
        /// 1：绑定
        /// </summary>
        [JsonProperty("AntiDDosEipStatus")]
        public ulong? AntiDDosEipStatus{ get; set; }

        /// <summary>
        /// WAF原生VIP绑定状态。
        /// 0：解绑
        /// 1：绑定
        /// </summary>
        [JsonProperty("VipStatus")]
        public ulong? VipStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AntiDDosEip", this.AntiDDosEip);
            this.SetParamSimple(map, prefix + "AntiDDosEipStatus", this.AntiDDosEipStatus);
            this.SetParamSimple(map, prefix + "VipStatus", this.VipStatus);
        }
    }
}

