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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBusinessResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务资源所在的模块id，没有资源模块先创建资源模块(只支持32位)
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// 业务资源协议类型, 1:UDP, 2:TCP, 3:所有协议(只支持32位)
        /// </summary>
        [JsonProperty("Protocol")]
        public long? Protocol{ get; set; }

        /// <summary>
        /// 业务资源名称，同一个资源模块下面不可重复
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 业务资源类型:ip,domain,ip_section，对应ip、域名、ip段
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 业务资源端口 all,1-65535
        /// </summary>
        [JsonProperty("ServicePort")]
        public string ServicePort{ get; set; }

        /// <summary>
        /// 业务资源优先级 1-65535(只支持32位)
        /// </summary>
        [JsonProperty("Levels")]
        public long? Levels{ get; set; }

        /// <summary>
        /// 业务资源地址(ip、域名、ip段)
        /// </summary>
        [JsonProperty("ServiceAddress")]
        public string ServiceAddress{ get; set; }

        /// <summary>
        /// 是否走代理,该参数不传，默认为0, 2：内外网直连，1：内网直连， 0：不启用代理配置(只支持32位)
        /// </summary>
        [JsonProperty("DirectConn")]
        public long? DirectConn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AreaId", this.AreaId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ServicePort", this.ServicePort);
            this.SetParamSimple(map, prefix + "Levels", this.Levels);
            this.SetParamSimple(map, prefix + "ServiceAddress", this.ServiceAddress);
            this.SetParamSimple(map, prefix + "DirectConn", this.DirectConn);
        }
    }
}

