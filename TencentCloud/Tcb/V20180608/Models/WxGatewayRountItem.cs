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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WxGatewayRountItem : AbstractModel
    {
        
        /// <summary>
        /// 安全网关路由名称
        /// </summary>
        [JsonProperty("GatewayRouteName")]
        public string GatewayRouteName{ get; set; }

        /// <summary>
        /// 安全网关路由协议
        /// </summary>
        [JsonProperty("GatewayRouteProtocol")]
        public string GatewayRouteProtocol{ get; set; }

        /// <summary>
        /// 安全网关路由地址
        /// </summary>
        [JsonProperty("GatewayRouteAddr")]
        public string GatewayRouteAddr{ get; set; }

        /// <summary>
        /// 安全网关路由描述
        /// </summary>
        [JsonProperty("GatewayRouteDesc")]
        public string GatewayRouteDesc{ get; set; }

        /// <summary>
        /// 安全网关后端集群id，如果是外网服务，该id与GatewayRountName相同
        /// </summary>
        [JsonProperty("GatewayRouteClusterId")]
        public string GatewayRouteClusterId{ get; set; }

        /// <summary>
        /// 安全网关创建时间
        /// </summary>
        [JsonProperty("GatewayRouteCreateTime")]
        public string GatewayRouteCreateTime{ get; set; }

        /// <summary>
        /// 安全网关路由限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrequencyLimitConfig")]
        public FrequencyLimitConfig[] FrequencyLimitConfig{ get; set; }

        /// <summary>
        /// ip代表绑定后端ip。cbr代表云托管服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayRouteServerType")]
        public string GatewayRouteServerType{ get; set; }

        /// <summary>
        /// 服务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayRouteServerName")]
        public string GatewayRouteServerName{ get; set; }

        /// <summary>
        /// ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayRewriteHost")]
        public string GatewayRewriteHost{ get; set; }

        /// <summary>
        /// 网关版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayVersion")]
        public string GatewayVersion{ get; set; }

        /// <summary>
        /// 请求路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayRoutePath")]
        public string GatewayRoutePath{ get; set; }

        /// <summary>
        /// 请求模式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayRouteMethod")]
        public string GatewayRouteMethod{ get; set; }

        /// <summary>
        /// 4层端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayRoutePort")]
        public long? GatewayRoutePort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayRouteName", this.GatewayRouteName);
            this.SetParamSimple(map, prefix + "GatewayRouteProtocol", this.GatewayRouteProtocol);
            this.SetParamSimple(map, prefix + "GatewayRouteAddr", this.GatewayRouteAddr);
            this.SetParamSimple(map, prefix + "GatewayRouteDesc", this.GatewayRouteDesc);
            this.SetParamSimple(map, prefix + "GatewayRouteClusterId", this.GatewayRouteClusterId);
            this.SetParamSimple(map, prefix + "GatewayRouteCreateTime", this.GatewayRouteCreateTime);
            this.SetParamArrayObj(map, prefix + "FrequencyLimitConfig.", this.FrequencyLimitConfig);
            this.SetParamSimple(map, prefix + "GatewayRouteServerType", this.GatewayRouteServerType);
            this.SetParamSimple(map, prefix + "GatewayRouteServerName", this.GatewayRouteServerName);
            this.SetParamSimple(map, prefix + "GatewayRewriteHost", this.GatewayRewriteHost);
            this.SetParamSimple(map, prefix + "GatewayVersion", this.GatewayVersion);
            this.SetParamSimple(map, prefix + "GatewayRoutePath", this.GatewayRoutePath);
            this.SetParamSimple(map, prefix + "GatewayRouteMethod", this.GatewayRouteMethod);
            this.SetParamSimple(map, prefix + "GatewayRoutePort", this.GatewayRoutePort);
        }
    }
}

