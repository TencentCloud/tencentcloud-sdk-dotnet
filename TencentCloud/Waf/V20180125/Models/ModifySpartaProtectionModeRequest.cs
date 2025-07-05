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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySpartaProtectionModeRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 防护状态：
        /// 10：规则观察&&AI关闭模式，11：规则观察&&AI观察模式，12：规则观察&&AI拦截模式
        /// 20：规则拦截&&AI关闭模式，21：规则拦截&&AI观察模式，22：规则拦截&&AI拦截模式
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// WAF的版本，clb-waf代表负载均衡WAF、sparta-waf代表SaaS WAF，默认是sparta-waf。
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 0是修改规则引擎状态，1是修改AI的状态
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
        }
    }
}

