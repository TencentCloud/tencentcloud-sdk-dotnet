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

    public class CCPolicy : AbstractModel
    {
        
        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 匹配模式，取值[matching(匹配模式), speedlimit(限速模式)]
        /// </summary>
        [JsonProperty("Smode")]
        public string Smode{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("SetId")]
        public string SetId{ get; set; }

        /// <summary>
        /// 每分钟限制的次数
        /// </summary>
        [JsonProperty("Frequency")]
        public ulong? Frequency{ get; set; }

        /// <summary>
        /// 执行策略模式，拦截或者验证码，取值[alg（验证码）, drop（拦截）]
        /// </summary>
        [JsonProperty("ExeMode")]
        public string ExeMode{ get; set; }

        /// <summary>
        /// 生效开关
        /// </summary>
        [JsonProperty("Switch")]
        public ulong? Switch{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonProperty("RuleList")]
        public CCRule[] RuleList{ get; set; }

        /// <summary>
        /// IP列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// cc防护类型，取值[http，https]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 可选字段，表示HTTPS的CC防护域名对应的转发规则ID;
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// HTTPS的CC防护域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Smode", this.Smode);
            this.SetParamSimple(map, prefix + "SetId", this.SetId);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "ExeMode", this.ExeMode);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

