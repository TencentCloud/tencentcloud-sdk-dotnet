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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SslClientConfig : AbstractModel
    {
        
        /// <summary>
        /// 客户端配置
        /// </summary>
        [JsonProperty("SslVpnClientConfiguration")]
        public string SslVpnClientConfiguration{ get; set; }

        /// <summary>
        /// 更证书
        /// </summary>
        [JsonProperty("SslVpnRootCert")]
        public string SslVpnRootCert{ get; set; }

        /// <summary>
        /// 客户端密钥
        /// </summary>
        [JsonProperty("SslVpnKey")]
        public string SslVpnKey{ get; set; }

        /// <summary>
        /// 客户端证书
        /// </summary>
        [JsonProperty("SslVpnCert")]
        public string SslVpnCert{ get; set; }

        /// <summary>
        /// SSL-VPN-CLIENT 实例ID。
        /// </summary>
        [JsonProperty("SslVpnClientId")]
        public string SslVpnClientId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SslVpnClientConfiguration", this.SslVpnClientConfiguration);
            this.SetParamSimple(map, prefix + "SslVpnRootCert", this.SslVpnRootCert);
            this.SetParamSimple(map, prefix + "SslVpnKey", this.SslVpnKey);
            this.SetParamSimple(map, prefix + "SslVpnCert", this.SslVpnCert);
            this.SetParamSimple(map, prefix + "SslVpnClientId", this.SslVpnClientId);
        }
    }
}

