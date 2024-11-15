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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPFilterPolicy : AbstractModel
    {
        
        /// <summary>
        /// IP 访问限制状态，可选值：
        /// <li>Enabled：启用；</li>
        /// <li>Disabled：禁用。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// IP 访问限制类型：  <li>Black：黑名单方式校验。只有来自 IPList 列表中的 IP 请求会被拦截。</li>
        /// <li>White：白名单方式校验。只有来自 IPList 列表中的 IP 请求会被放行。</li>当 Status 取值为 Enabled 时，FilterType  必须赋值。
        /// </summary>
        [JsonProperty("FilterType")]
        public string FilterType{ get; set; }

        /// <summary>
        /// IP 列表，支持 X.X.X.X 格式 IPV4 地址，或 X:X:X:X:X:X:X:X 格式 IPV6 地址，或网段格式 /N（IPV4:1≤N≤32；IPV6:1≤N≤128）；最多可填充 200 个 IP 或网段。当 Status 取值为 Enabled 时，IPList 必须赋值。
        /// </summary>
        [JsonProperty("IPList")]
        public string[] IPList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamArraySimple(map, prefix + "IPList.", this.IPList);
        }
    }
}

