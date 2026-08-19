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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBruteAttackBanStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>是否开启智能过白模式</p>
        /// </summary>
        [JsonProperty("OpenSmartMode")]
        public bool? OpenSmartMode{ get; set; }

        /// <summary>
        /// <p>是否阻断情报黑IP</p>
        /// </summary>
        [JsonProperty("BanBlackIp")]
        public bool? BanBlackIp{ get; set; }

        /// <summary>
        /// <p>是否阻断漏洞黑IP</p>
        /// </summary>
        [JsonProperty("BanVulIp")]
        public bool? BanVulIp{ get; set; }

        /// <summary>
        /// <p>是否开启规则阻断</p>
        /// </summary>
        [JsonProperty("BanByRule")]
        public bool? BanByRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "OpenSmartMode", this.OpenSmartMode);
            this.SetParamSimple(map, prefix + "BanBlackIp", this.BanBlackIp);
            this.SetParamSimple(map, prefix + "BanVulIp", this.BanVulIp);
            this.SetParamSimple(map, prefix + "BanByRule", this.BanByRule);
        }
    }
}

