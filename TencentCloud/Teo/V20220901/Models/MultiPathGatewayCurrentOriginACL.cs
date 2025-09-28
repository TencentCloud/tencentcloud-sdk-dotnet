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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiPathGatewayCurrentOriginACL : AbstractModel
    {
        
        /// <summary>
        /// 回源 IP 网段详情。
        /// </summary>
        [JsonProperty("EntireAddresses")]
        public Addresses EntireAddresses{ get; set; }

        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// 本参数用于记录当前版本生效前是否完成「我已更新至最新回源 IP 网段」的确认。取值有：
        /// <li>true：已完成更新至最新回源 IP 的确认；</li>
        /// <li>false：未完成更新至最新回源 IP 的确认；</li>
        /// 注意：本参数返回 false 时，请及时确认您的源站防火墙配置是否已更新至最新的回源 IP 网段，以避免出现回源失败。
        /// </summary>
        [JsonProperty("IsPlaned")]
        public string IsPlaned{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "EntireAddresses.", this.EntireAddresses);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "IsPlaned", this.IsPlaned);
        }
    }
}

