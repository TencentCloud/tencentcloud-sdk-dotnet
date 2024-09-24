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

    public class L4ProxyRule : AbstractModel
    {
        
        /// <summary>
        /// 转发规则 ID。
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数请勿填写；在 ModifyL4ProxyRules 作为入参使用时，该参数必填。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 转发协议。取值有：
        /// <li>TCP：TCP 协议；</li>
        /// <li>UDP：UDP 协议。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数必填；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写时表示不修改。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 转发端口，支持按照以下形式填写：
        /// <li>单端口，如：80；</li>
        /// <li>端口段，如：81-85。表示 81、82、83、84、85 五个端口。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数必填；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写时表示不修改。
        /// </summary>
        [JsonProperty("PortRange")]
        public string[] PortRange{ get; set; }

        /// <summary>
        /// 源站类型，取值有：
        /// <li>IP_DOMAIN：IP/域名源站；</li>
        /// <li>ORIGIN_GROUP：源站组；</li>
        /// <li>LB：负载均衡，当前仅白名单开放。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数必填；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写时表示不修改。
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站地址：
        /// <li>当 OriginType 为 IP_DOMAIN 时，填写 IP 或域名，如 8.8.8.8 或 test.com ；</li>
        /// <li>当 OriginType 为 ORIGIN_GROUP 时，填写源站组 ID，如 og-537y24vf5b41；</li>
        /// <li>当 OriginType 为 LB 时，填写负载均衡实例 ID，如 lb-2qwk30xf7s9g。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数必填；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写时表示不修改。
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// 源站端口，支持按照以下形式填写：
        /// <li>单端口，如：80；</li>
        /// <li>端口段，如：81-85，表示 81、82、83、84、85 五个端口。填写端口段时，则需要与转发端口段长度保持一致，例如转发端口：80-90，则转发端口：90-100。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数必填；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写时表示不修改。
        /// </summary>
        [JsonProperty("OriginPortRange")]
        public string OriginPortRange{ get; set; }

        /// <summary>
        /// 传递客户端 IP 的形式，取值有：
        /// <li>TOA：TOA（仅 Protocol = TCP 时可选）；</li> 
        /// <li>PPV1：Proxy Protocol 传递，协议版本 V1（仅 Protocol = TCP 时可选）；</li>
        /// <li>PPV2：Proxy Protocol 传递，协议版本 V2；</li> 
        /// <li>SPP：Simple Proxy Protocol 传递，（仅 Protocol = UDP 时可选）；</li> 
        /// <li>OFF：不传递。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数选填，不填写时默认为 OFF；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写表示不修改。
        /// </summary>
        [JsonProperty("ClientIPPassThroughMode")]
        public string ClientIPPassThroughMode{ get; set; }

        /// <summary>
        /// 是否开启会话保持，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数选填，不填写时默认为 off；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写表示不修改。
        /// </summary>
        [JsonProperty("SessionPersist")]
        public string SessionPersist{ get; set; }

        /// <summary>
        /// 会话保持时间，取值范围为 30-3600，单位为秒。
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数选填，仅当 SessionPersist = on 时，该值才会生效，且当 SessionPersist = on ，该值不填写默认为 3600；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写表示不修改。
        /// </summary>
        [JsonProperty("SessionPersistTime")]
        public ulong? SessionPersistTime{ get; set; }

        /// <summary>
        /// 规则标签。可输入1-50 个任意字符。
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules 作为入参使用时，该参数选填；在 ModifyL4ProxyRules 作为入参使用时，该参数选填，不填写表示不修改。
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }

        /// <summary>
        /// 规则状态，取值有：
        /// <li>online：已启用；</li>
        /// <li>offline：已停用；</li>
        /// <li>progress：部署中；</li>
        /// <li>stopping：停用中；</li>
        /// <li>fail：部署失败/停用失败。</li>
        /// 注意：L4ProxyRule 在 CreateL4ProxyRules、ModifyL4ProxyRules 作为入参使用时，该参数请勿填写。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// BuID。
        /// </summary>
        [JsonProperty("BuId")]
        public string BuId{ get; set; }

        /// <summary>
        /// 远程鉴权信息。
        /// 注意：RemoteAuth 在 CreateL4ProxyRules 或 ModifyL4ProxyRules 不可作为入参使用，如有传此参数，会忽略。在 DescribeL4ProxyRules 返回为空时，表示没有开启远程鉴权。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteAuth")]
        public L4ProxyRemoteAuth RemoteAuth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArraySimple(map, prefix + "PortRange.", this.PortRange);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "OriginPortRange", this.OriginPortRange);
            this.SetParamSimple(map, prefix + "ClientIPPassThroughMode", this.ClientIPPassThroughMode);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamSimple(map, prefix + "SessionPersistTime", this.SessionPersistTime);
            this.SetParamSimple(map, prefix + "RuleTag", this.RuleTag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BuId", this.BuId);
            this.SetParamObj(map, prefix + "RemoteAuth.", this.RemoteAuth);
        }
    }
}

