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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApplicationProxyRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 代理ID。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 规则ID。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 源站类型，取值有：
        /// <li>custom：手动添加；</li>
        /// <li>origins：源站组。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 端口，支持格式：
        /// <li>80：80端口；</li>
        /// <li>81-90：81至90端口。</li>
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// 协议，取值有：
        /// <li>TCP：TCP协议；</li>
        /// <li>UDP：UDP协议。</li>不填保持原有值。
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// 源站信息：
        /// <li>当 OriginType 为 custom 时，表示一个或多个源站，如`["8.8.8.8","9.9.9.9"]` 或 `OriginValue=["test.com"]`；</li>
        /// <li>当 OriginType 为 origins 时，要求有且仅有一个元素，表示源站组ID，如`["origin-537f5b41-162a-11ed-abaa-525400c5da15"]`。</li>
        /// 
        /// 不填保持原有值。
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// 传递客户端IP，取值有：
        /// <li>TOA：TOA（仅Proto=TCP时可选）；</li>
        /// <li>PPV1：Proxy Protocol传递，协议版本V1（仅Proto=TCP时可选）；</li>
        /// <li>PPV2：Proxy Protocol传递，协议版本V2；</li>
        /// <li>OFF：不传递。</li>不填保持原有值。
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// 是否开启会话保持，取值有：
        /// <li>true：开启；</li>
        /// <li>false：关闭。</li>不填为false。
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }

        /// <summary>
        /// 会话保持的时间，只有当SessionPersist为true时，该值才会生效。
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// 源站端口，支持格式：
        /// <li>单端口：80；</li>
        /// <li>端口段：81-90，81至90端口。</li>
        /// </summary>
        [JsonProperty("OriginPort")]
        public string OriginPort{ get; set; }

        /// <summary>
        /// 规则标签。不填保持原有值。
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "OriginPort", this.OriginPort);
            this.SetParamSimple(map, prefix + "RuleTag", this.RuleTag);
        }
    }
}

