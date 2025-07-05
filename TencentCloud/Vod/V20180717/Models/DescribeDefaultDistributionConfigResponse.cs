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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDefaultDistributionConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 分发配置的域名(已废弃）。
        /// </summary>
        [JsonProperty("DomainName")]
        [System.Obsolete]
        public string DomainName{ get; set; }

        /// <summary>
        /// 分发配置的域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 分发配置的协议，为 HTTP 或 HTTPS。
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// 播放密钥，由大小写字母（a - Z）或者数字（0 - 9）组成，长度在8 - 20个字符之间。
        /// </summary>
        [JsonProperty("PlayKey")]
        public string PlayKey{ get; set; }

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
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "PlayKey", this.PlayKey);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

