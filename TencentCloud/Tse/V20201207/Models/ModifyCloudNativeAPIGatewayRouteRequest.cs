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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCloudNativeAPIGatewayRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>所属服务的ID</p>
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// <p>路由的ID，实例级别唯一</p>
        /// </summary>
        [JsonProperty("RouteID")]
        public string RouteID{ get; set; }

        /// <summary>
        /// <p>路由的名字，实例级别唯一，可以不提供</p>
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// <p>路由的方法，其中方法可选值：</p><ul><li>GET</li><li>POST</li><li>DELETE</li><li>PUT</li><li>OPTIONS</li><li>PATCH</li><li>HEAD</li><li>ANY</li><li>TRACE</li><li>COPY</li><li>MOVE</li><li>PROPFIND</li><li>PROPPATCH</li><li>MKCOL</li><li>LOCK</li><li>UNLOCK</li></ul>
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// <p>路由的域名</p>
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// <p>路由的路径</p>
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// <p>路由的协议，可选</p><ul><li>https</li><li>http</li></ul>
        /// </summary>
        [JsonProperty("Protocols")]
        public string[] Protocols{ get; set; }

        /// <summary>
        /// <p>转发到后端时是否保留Host</p>
        /// </summary>
        [JsonProperty("PreserveHost")]
        public bool? PreserveHost{ get; set; }

        /// <summary>
        /// <p>https重定向状态码</p>
        /// </summary>
        [JsonProperty("HttpsRedirectStatusCode")]
        public long? HttpsRedirectStatusCode{ get; set; }

        /// <summary>
        /// <p>转发到后端时是否StripPath</p>
        /// </summary>
        [JsonProperty("StripPath")]
        public bool? StripPath{ get; set; }

        /// <summary>
        /// <p>是否开启强制HTTPS</p>
        /// </summary>
        [JsonProperty("ForceHttps")]
        [System.Obsolete]
        public bool? ForceHttps{ get; set; }

        /// <summary>
        /// <p>四层匹配的目的端口</p>
        /// </summary>
        [JsonProperty("DestinationPorts")]
        public ulong?[] DestinationPorts{ get; set; }

        /// <summary>
        /// <p>路由的Headers</p>
        /// </summary>
        [JsonProperty("Headers")]
        public KVMapping[] Headers{ get; set; }

        /// <summary>
        /// <p>是否缓存请求body，默认true</p>
        /// </summary>
        [JsonProperty("RequestBuffering")]
        public bool? RequestBuffering{ get; set; }

        /// <summary>
        /// <p>是否缓存响应body，默认true</p>
        /// </summary>
        [JsonProperty("ResponseBuffering")]
        public bool? ResponseBuffering{ get; set; }

        /// <summary>
        /// <p>增加优先级</p>
        /// </summary>
        [JsonProperty("RegexPriority")]
        public long? RegexPriority{ get; set; }

        /// <summary>
        /// <p>querysring参数</p>
        /// </summary>
        [JsonProperty("QueryStringParameters")]
        public KVMapping[] QueryStringParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
            this.SetParamSimple(map, prefix + "RouteID", this.RouteID);
            this.SetParamSimple(map, prefix + "RouteName", this.RouteName);
            this.SetParamArraySimple(map, prefix + "Methods.", this.Methods);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamArraySimple(map, prefix + "Paths.", this.Paths);
            this.SetParamArraySimple(map, prefix + "Protocols.", this.Protocols);
            this.SetParamSimple(map, prefix + "PreserveHost", this.PreserveHost);
            this.SetParamSimple(map, prefix + "HttpsRedirectStatusCode", this.HttpsRedirectStatusCode);
            this.SetParamSimple(map, prefix + "StripPath", this.StripPath);
            this.SetParamSimple(map, prefix + "ForceHttps", this.ForceHttps);
            this.SetParamArraySimple(map, prefix + "DestinationPorts.", this.DestinationPorts);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
            this.SetParamSimple(map, prefix + "RequestBuffering", this.RequestBuffering);
            this.SetParamSimple(map, prefix + "ResponseBuffering", this.ResponseBuffering);
            this.SetParamSimple(map, prefix + "RegexPriority", this.RegexPriority);
            this.SetParamArrayObj(map, prefix + "QueryStringParameters.", this.QueryStringParameters);
        }
    }
}

