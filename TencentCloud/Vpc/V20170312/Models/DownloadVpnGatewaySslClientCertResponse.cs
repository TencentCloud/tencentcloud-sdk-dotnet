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

    public class DownloadVpnGatewaySslClientCertResponse : AbstractModel
    {
        
        /// <summary>
        /// SSL-VPN 客户端配置。
        /// </summary>
        [JsonProperty("SslClientConfigsSet")]
        public string SslClientConfigsSet{ get; set; }

        /// <summary>
        /// SSL-VPN 客户端配置。
        /// </summary>
        [JsonProperty("SslClientConfig")]
        public SslClientConfig[] SslClientConfig{ get; set; }

        /// <summary>
        /// 是否鉴权成功 只有传入SamlToken 才生效，1为成功，0为失败。
        /// </summary>
        [JsonProperty("Authenticated")]
        public ulong? Authenticated{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SslClientConfigsSet", this.SslClientConfigsSet);
            this.SetParamArrayObj(map, prefix + "SslClientConfig.", this.SslClientConfig);
            this.SetParamSimple(map, prefix + "Authenticated", this.Authenticated);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

