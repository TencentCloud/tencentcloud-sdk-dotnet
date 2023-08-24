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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClbHostResult : AbstractModel
    {
        
        /// <summary>
        /// WAF绑定的监听器实例
        /// </summary>
        [JsonProperty("LoadBalancer")]
        public LoadBalancer LoadBalancer{ get; set; }

        /// <summary>
        /// WAF绑定的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// WAF绑定的实例ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 是否有绑定WAF，1：绑定了WAF，0：没有绑定WAF
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 绑定了WAF的情况下，WAF流量模式，1：清洗模式，0：镜像模式（默认）
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LoadBalancer.", this.LoadBalancer);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
        }
    }
}

