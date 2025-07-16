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

    public class ModifyMultiPathGatewayLineRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 多通道安全加速网关 ID 。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 线路 ID ， 取值有:
        /// <li> line-1： EdgeOne 四层代理线路，支持修改实例和规则，不支持删除；</li>
        /// <li> line-2 及以上：EdgeOne 四层代理线路或者自定义线路，支持修改、删除实例和规则。</li>
        /// </summary>
        [JsonProperty("LineId")]
        public string LineId{ get; set; }

        /// <summary>
        /// 线路类型，取值有： 
        /// <li>proxy ：EdgeOne 四层代理线路，支持修改实例和规则，不支持删除；</li> 
        /// <li>custom ：自定义线路，支持编辑、删除实例和规则。</li>
        /// </summary>
        [JsonProperty("LineType")]
        public string LineType{ get; set; }

        /// <summary>
        /// 线路地址，格式为 host:port，直连线路（ LineType 取值为 direct ）不允许修改，其余类型支持修改。
        /// </summary>
        [JsonProperty("LineAddress")]
        public string LineAddress{ get; set; }

        /// <summary>
        /// 四层代理实例 ID  ，当线路类型 LineType  取值为 proxy（EdgeOne 四层代理）可传入，进行修改。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 转发规则 ID ，当线路类型 LineType 取值为 proxy（EdgeOne 四层代理）可传入，进行修改。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "LineId", this.LineId);
            this.SetParamSimple(map, prefix + "LineType", this.LineType);
            this.SetParamSimple(map, prefix + "LineAddress", this.LineAddress);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

