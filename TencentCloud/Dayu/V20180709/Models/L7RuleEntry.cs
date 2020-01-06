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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L7RuleEntry : AbstractModel
    {
        
        /// <summary>
        /// 转发协议，取值[http, https]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 转发域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 回源方式，取值[1(域名回源)，2(IP回源)]
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 会话保持时间，单位秒
        /// </summary>
        [JsonProperty("KeepTime")]
        public ulong? KeepTime{ get; set; }

        /// <summary>
        /// 回源列表
        /// </summary>
        [JsonProperty("SourceList")]
        public L4RuleSource[] SourceList{ get; set; }

        /// <summary>
        /// 负载均衡方式，取值[1(加权轮询)]
        /// </summary>
        [JsonProperty("LbType")]
        public ulong? LbType{ get; set; }

        /// <summary>
        /// 会话保持开关，取值[0(会话保持关闭)，1(会话保持开启)]
        /// </summary>
        [JsonProperty("KeepEnable")]
        public ulong? KeepEnable{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 证书来源，当转发协议为https时必须填，取值[2(腾讯云托管证书)]，当转发协议为http时也可以填0
        /// </summary>
        [JsonProperty("CertType")]
        public ulong? CertType{ get; set; }

        /// <summary>
        /// 当证书来源为腾讯云托管证书时，此字段必须填写托管证书ID
        /// </summary>
        [JsonProperty("SSLId")]
        public string SSLId{ get; set; }

        /// <summary>
        /// 当证书来源为自有证书时，此字段必须填写证书内容；(因已不再支持自有证书，此字段已弃用，请不用填写此字段)
        /// </summary>
        [JsonProperty("Cert")]
        public string Cert{ get; set; }

        /// <summary>
        /// 当证书来源为自有证书时，此字段必须填写证书密钥；(因已不再支持自有证书，此字段已弃用，请不用填写此字段)
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则状态，取值[0(规则配置成功)，1(规则配置生效中)，2(规则配置失败)，3(规则删除生效中)，5(规则删除失败)，6(规则等待配置)，7(规则等待删除)，8(规则待配置证书)]
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// cc防护状态，取值[0(关闭), 1(开启)]
        /// </summary>
        [JsonProperty("CCStatus")]
        public ulong? CCStatus{ get; set; }

        /// <summary>
        /// HTTPS协议的CC防护状态，取值[0(关闭), 1(开启)]
        /// </summary>
        [JsonProperty("CCEnable")]
        public ulong? CCEnable{ get; set; }

        /// <summary>
        /// HTTPS协议的CC防护阈值
        /// </summary>
        [JsonProperty("CCThreshold")]
        public ulong? CCThreshold{ get; set; }

        /// <summary>
        /// HTTPS协议的CC防护等级
        /// </summary>
        [JsonProperty("CCLevel")]
        public string CCLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "KeepTime", this.KeepTime);
            this.SetParamArrayObj(map, prefix + "SourceList.", this.SourceList);
            this.SetParamSimple(map, prefix + "LbType", this.LbType);
            this.SetParamSimple(map, prefix + "KeepEnable", this.KeepEnable);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "SSLId", this.SSLId);
            this.SetParamSimple(map, prefix + "Cert", this.Cert);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CCStatus", this.CCStatus);
            this.SetParamSimple(map, prefix + "CCEnable", this.CCEnable);
            this.SetParamSimple(map, prefix + "CCThreshold", this.CCThreshold);
            this.SetParamSimple(map, prefix + "CCLevel", this.CCLevel);
        }
    }
}

