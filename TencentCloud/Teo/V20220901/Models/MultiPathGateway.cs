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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiPathGateway : AbstractModel
    {
        
        /// <summary>
        /// 网关 ID。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 网关名。
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// 网关类型，取值有：
        /// <li> cloud：云上网关，腾讯云创建和管理的网关。</li>
        /// <li> private：自有网关，用户部署的私有网关。</li>
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 网关端口，范围 1～65535（除去 8888 ）。
        /// </summary>
        [JsonProperty("GatewayPort")]
        public long? GatewayPort{ get; set; }

        /// <summary>
        /// 网关状态，取值有：
        /// <li> creating : 创建中；</li>
        /// <li> online : 在线；</li>
        /// <li> offline : 离线；</li>
        /// <li> disable : 已停用。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 网关 IP， 格式为 IPv4。
        /// </summary>
        [JsonProperty("GatewayIP")]
        public string GatewayIP{ get; set; }

        /// <summary>
        /// 网关地域 Id，可以从接口 DescribeMultiPathGatewayRegions 获取 RegionId 列表。
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 线路信息，当查询网关信息详情 DescribeMultiPathGateway 的时候会返回，当查询网关列表 DescribeMultiPathGateways 的时候不会返回。
        /// </summary>
        [JsonProperty("Lines")]
        public MultiPathGatewayLine[] Lines{ get; set; }

        /// <summary>
        /// 网关回源 IP 列表发生了变化是否需要重新确认，取值有：<li>true：回源 IP 列表发生了变化，需要确认；</li><li>false：回源 IP 列表未发生变化，无需确认。</li>
        /// </summary>
        [JsonProperty("NeedConfirm")]
        public string NeedConfirm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayPort", this.GatewayPort);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GatewayIP", this.GatewayIP);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamArrayObj(map, prefix + "Lines.", this.Lines);
            this.SetParamSimple(map, prefix + "NeedConfirm", this.NeedConfirm);
        }
    }
}

