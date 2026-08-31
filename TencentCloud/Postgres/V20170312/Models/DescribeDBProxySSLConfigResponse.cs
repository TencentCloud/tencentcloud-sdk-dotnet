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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBProxySSLConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>SSL 是否开启。true 表示已开启，false 表示未开启。</p>
        /// </summary>
        [JsonProperty("SSLEnabled")]
        public bool? SSLEnabled{ get; set; }

        /// <summary>
        /// <p>SSL 连接的地址（VIP 或域名）。</p>
        /// </summary>
        [JsonProperty("ConnectAddress")]
        public string ConnectAddress{ get; set; }

        /// <summary>
        /// <p>CA 证书下载地址。仅在 SSL 开启时有值。</p>
        /// </summary>
        [JsonProperty("CAUrl")]
        public string CAUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "SSLEnabled", this.SSLEnabled);
            this.SetParamSimple(map, prefix + "ConnectAddress", this.ConnectAddress);
            this.SetParamSimple(map, prefix + "CAUrl", this.CAUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

