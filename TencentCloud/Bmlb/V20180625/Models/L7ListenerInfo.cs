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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L7ListenerInfo : AbstractModel
    {
        
        /// <summary>
        /// 七层监听器实例ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 七层监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 七层监听器协议类型，可选值：http,https。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 七层监听器的监听端口。
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public long? LoadBalancerPort{ get; set; }

        /// <summary>
        /// 计费模式为按固定带宽方式时监听器的限速值，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 监听器的类别：L4Listener（四层监听器），L7Listener（七层监听器）。
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// 七层监听器的认证方式：0（不认证，用于http），1（单向认证，用于https），2（双向认证，用于https）。
        /// </summary>
        [JsonProperty("SslMode")]
        public long? SslMode{ get; set; }

        /// <summary>
        /// 七层监听器关联的服务端证书ID。
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// 七层监听器关联的客户端证书ID。
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// 当前绑定关系的健康检查状态（Dead代表不健康，Alive代表健康）。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间戳。
        /// </summary>
        [JsonProperty("AddTimestamp")]
        public string AddTimestamp{ get; set; }

        /// <summary>
        /// 返回的转发规则列表。
        /// </summary>
        [JsonProperty("RuleSet")]
        public L7ListenerInfoRule[] RuleSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "LoadBalancerPort", this.LoadBalancerPort);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "SslMode", this.SslMode);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddTimestamp", this.AddTimestamp);
            this.SetParamArrayObj(map, prefix + "RuleSet.", this.RuleSet);
        }
    }
}

