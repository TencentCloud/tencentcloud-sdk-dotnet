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
        /// <p>业务资源所在的模块id，没有资源模块先创建资源模块(只支持32位)</p>
        /// </summary>
        [JsonProperty("AreaId")]
        public long? AreaId{ get; set; }

        /// <summary>
        /// <p>业务资源协议类型, 1:UDP, 2:TCP, 3:所有协议(只支持32位)</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public long? Protocol{ get; set; }

        /// <summary>
        /// <p>业务资源名称，同一个资源模块下面不可重复</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>业务资源类型:ip,domain,ip_section，对应ip、域名、ip段</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>业务资源端口 all,1-65535</p>
        /// </summary>
        [JsonProperty("ServicePort")]
        public string ServicePort{ get; set; }

        /// <summary>
        /// <p>业务资源优先级 1-65535(只支持32位)</p>
        /// </summary>
        [JsonProperty("Levels")]
        public long? Levels{ get; set; }

        /// <summary>
        /// <p>业务资源地址(ip、域名、ip段)</p>
        /// </summary>
        [JsonProperty("ServiceAddress")]
        public string ServiceAddress{ get; set; }

        /// <summary>
        /// <p>是否走代理,该参数不传，默认为0, 2：内外网直连，1：内网直连， 0：不启用代理配置(只支持32位)</p>
        /// </summary>
        [JsonProperty("DirectConn")]
        public long? DirectConn{ get; set; }

        /// <summary>
        /// <p>连通性检查开关，0-关闭 1-开启，默认1(只支持32位)</p>
        /// </summary>
        [JsonProperty("ConnectivityCheckSwitch")]
        public long? ConnectivityCheckSwitch{ get; set; }

        /// <summary>
        /// <p>连通性检查测试间隔数值，最小为1，默认1(只支持32位)</p>
        /// </summary>
        [JsonProperty("ConnectivityCheckInterval")]
        public long? ConnectivityCheckInterval{ get; set; }

        /// <summary>
        /// <p>连通性检查测试间隔单位 minutes/hours/days，默认hours</p>
        /// </summary>
        [JsonProperty("ConnectivityCheckIntervalUnit")]
        public string ConnectivityCheckIntervalUnit{ get; set; }

        /// <summary>
        /// <p>资源网络类型：1-内网资源 2-外网资源，默认1</p>
        /// </summary>
        [JsonProperty("ServiceNetwork")]
        public long? ServiceNetwork{ get; set; }

        /// <summary>
        /// <p>是否启用L3网络：1-不启用 2-启用，默认1</p>
        /// </summary>
        [JsonProperty("WireGuardTunnel")]
        public long? WireGuardTunnel{ get; set; }

        /// <summary>
        /// <p>资源描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>URL审计开关：0-关闭 1-开启，默认0</p><p>枚举值：</p><ul><li>0： 关闭</li><li>1： 开启</li></ul>
        /// </summary>
        [JsonProperty("URLAuditState")]
        public long? URLAuditState{ get; set; }

        /// <summary>
        /// <p>URL审计证书ID列表，多个用分号分隔</p>
        /// </summary>
        [JsonProperty("URLAuditId")]
        public string URLAuditId{ get; set; }

        /// <summary>
        /// <p>URL审计路径，多个用分号分隔</p>
        /// </summary>
        [JsonProperty("URLPath")]
        public string URLPath{ get; set; }

        /// <summary>
        /// <p>证书Id</p>
        /// </summary>
        [JsonProperty("SSLCertId")]
        public string SSLCertId{ get; set; }


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
            this.SetParamSimple(map, prefix + "ConnectivityCheckSwitch", this.ConnectivityCheckSwitch);
            this.SetParamSimple(map, prefix + "ConnectivityCheckInterval", this.ConnectivityCheckInterval);
            this.SetParamSimple(map, prefix + "ConnectivityCheckIntervalUnit", this.ConnectivityCheckIntervalUnit);
            this.SetParamSimple(map, prefix + "ServiceNetwork", this.ServiceNetwork);
            this.SetParamSimple(map, prefix + "WireGuardTunnel", this.WireGuardTunnel);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "URLAuditState", this.URLAuditState);
            this.SetParamSimple(map, prefix + "URLAuditId", this.URLAuditId);
            this.SetParamSimple(map, prefix + "URLPath", this.URLPath);
            this.SetParamSimple(map, prefix + "SSLCertId", this.SSLCertId);
        }
    }
}

