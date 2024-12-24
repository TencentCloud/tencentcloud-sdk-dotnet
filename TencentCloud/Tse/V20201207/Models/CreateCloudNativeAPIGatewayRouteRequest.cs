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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudNativeAPIGatewayRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 所属服务的ID
        /// </summary>
        [JsonProperty("ServiceID")]
        public string ServiceID{ get; set; }

        /// <summary>
        /// 路由的名字，实例级别唯一，可以不提供
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// 路由的方法，其中方法可选值：
        /// - GET
        /// - POST
        /// - DELETE
        /// - PUT
        /// - OPTIONS
        /// - PATCH
        /// - HEAD
        /// - ANY
        /// - TRACE
        /// - COPY
        /// - MOVE
        /// - PROPFIND
        /// - PROPPATCH
        /// - MKCOL
        /// - LOCK
        /// - UNLOCK
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// 路由的域名
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// 路由的路径
        /// </summary>
        [JsonProperty("Paths")]
        public string[] Paths{ get; set; }

        /// <summary>
        /// 路由的协议，可选
        /// - https
        /// - http
        /// </summary>
        [JsonProperty("Protocols")]
        public string[] Protocols{ get; set; }

        /// <summary>
        /// 转发到后端时是否保留Host
        /// </summary>
        [JsonProperty("PreserveHost")]
        public bool? PreserveHost{ get; set; }

        /// <summary>
        /// https重定向状态码
        /// </summary>
        [JsonProperty("HttpsRedirectStatusCode")]
        public long? HttpsRedirectStatusCode{ get; set; }

        /// <summary>
        /// 转发到后端时是否StripPath
        /// </summary>
        [JsonProperty("StripPath")]
        public bool? StripPath{ get; set; }

        /// <summary>
        /// 是否开启强制HTTPS
        /// </summary>
        [JsonProperty("ForceHttps")]
        [System.Obsolete]
        public bool? ForceHttps{ get; set; }

        /// <summary>
        /// 四层匹配的目的端口
        /// </summary>
        [JsonProperty("DestinationPorts")]
        public ulong?[] DestinationPorts{ get; set; }

        /// <summary>
        /// 路由的Headers
        /// </summary>
        [JsonProperty("Headers")]
        public KVMapping[] Headers{ get; set; }

        /// <summary>
        /// 是否缓存请求body，默认true
        /// </summary>
        [JsonProperty("RequestBuffering")]
        public bool? RequestBuffering{ get; set; }

        /// <summary>
        /// 是否缓存响应body，默认true
        /// </summary>
        [JsonProperty("ResponseBuffering")]
        public bool? ResponseBuffering{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "ServiceID", this.ServiceID);
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
        }
    }
}

