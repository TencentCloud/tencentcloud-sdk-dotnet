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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>7层监听器ID</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>转发规则的域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>转发规则的路径</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>转发规则对应源站的类型，支持IP和DOMAIN类型。</p>
        /// </summary>
        [JsonProperty("RealServerType")]
        public string RealServerType{ get; set; }

        /// <summary>
        /// <p>监听器源站访问策略，其中：rr表示轮询；wrr表示加权轮询；lc表示最小连接数。</p>
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// <p>规则是否开启健康检查，1开启，0关闭。</p>
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// <p>源站健康检查相关参数</p>
        /// </summary>
        [JsonProperty("CheckParams")]
        public RuleCheckParams CheckParams{ get; set; }

        /// <summary>
        /// <p>加速通道转发到源站的协议类型：支持HTTP或HTTPS。不传递该字段时表示使用对应监听器的ForwardProtocol。</p>
        /// </summary>
        [JsonProperty("ForwardProtocol")]
        public string ForwardProtocol{ get; set; }

        /// <summary>
        /// <p>回源Host。加速通道转发到源站的host，不设置该参数时，使用默认的host设置，即客户端发起的http请求的host。</p>
        /// </summary>
        [JsonProperty("ForwardHost")]
        public string ForwardHost{ get; set; }

        /// <summary>
        /// <p>服务器名称指示（ServerNameIndication，简称SNI）开关。ON表示开启，OFF表示关闭。创建HTTP监听器转发规则时，SNI功能默认关闭。</p>
        /// </summary>
        [JsonProperty("ServerNameIndicationSwitch")]
        public string ServerNameIndicationSwitch{ get; set; }

        /// <summary>
        /// <p>服务器名称指示（ServerNameIndication，简称SNI），当SNI开关打开时，该字段必填。</p>
        /// </summary>
        [JsonProperty("ServerNameIndication")]
        public string ServerNameIndication{ get; set; }

        /// <summary>
        /// <p>HTTP强制跳转HTTPS。输入当前规则对应的域名与地址。</p>
        /// </summary>
        [JsonProperty("ForcedRedirect")]
        public string ForcedRedirect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "RealServerType", this.RealServerType);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamObj(map, prefix + "CheckParams.", this.CheckParams);
            this.SetParamSimple(map, prefix + "ForwardProtocol", this.ForwardProtocol);
            this.SetParamSimple(map, prefix + "ForwardHost", this.ForwardHost);
            this.SetParamSimple(map, prefix + "ServerNameIndicationSwitch", this.ServerNameIndicationSwitch);
            this.SetParamSimple(map, prefix + "ServerNameIndication", this.ServerNameIndication);
            this.SetParamSimple(map, prefix + "ForcedRedirect", this.ForcedRedirect);
        }
    }
}

