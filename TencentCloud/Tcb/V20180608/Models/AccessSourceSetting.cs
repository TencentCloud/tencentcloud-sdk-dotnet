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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessSourceSetting : AbstractModel
    {
        
        /// <summary>
        /// <p>来源类型</p><p>枚举值：</p><ul><li>PUBLIC： 公网请求</li><li>VPC： VPC 请求</li><li>WOA： 办公网请求</li></ul>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>来源请求状态</p><p>枚举值：</p><ul><li>OPEN： 放通</li><li>CLOSE： 拦截</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>是否开启 WOA 鉴权</p><p>枚举值：</p><ul><li>FORCE_AUTH： 强制鉴权</li><li>NO_AUTH： 不鉴权</li></ul><p>默认值：NO_AUTH</p><p>仅 SourceType = WOA 且 Action= OPEN 时生效</p>
        /// </summary>
        [JsonProperty("WOAAuth")]
        public string WOAAuth{ get; set; }

        /// <summary>
        /// <p>WOA 鉴权需要的 Token</p><p>仅 Source Type=WOA 且 WOAAuth = FORCE_AUTH 时必填</p>
        /// </summary>
        [JsonProperty("AuthToken")]
        public string AuthToken{ get; set; }

        /// <summary>
        /// <p>VPC 白名单信息</p><p>仅 SourceType = VPC 时有效; 不传表示不修改</p>
        /// </summary>
        [JsonProperty("VPCWhiteList")]
        public VPCWhiteListConfig VPCWhiteList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "WOAAuth", this.WOAAuth);
            this.SetParamSimple(map, prefix + "AuthToken", this.AuthToken);
            this.SetParamObj(map, prefix + "VPCWhiteList.", this.VPCWhiteList);
        }
    }
}

