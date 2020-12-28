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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityGroupApiRuleData : AbstractModel
    {
        
        /// <summary>
        /// 访问源，入站时为Ip/Cidr，默认为0.0.0.0/0； 出站时当RuleType为1时，支持内网Ip/Cidr, 当RuleType为2时，填实例ID
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// 访问目的，出站时为Ip/Cidr，默认为0.0.0.0/0；入站时当RuleType为1时，支持内网Ip/Cidr, 当RuleType为2时，填实例ID
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// 协议，支持ANY/TCP/UDP/ICMP
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口, 当Protocol为ANY或ICMP时，Port为-1/-1
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 策略, 1：阻断，2：放行
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 规则类型，1：VpcId+Ip/Cidr, 2: 实例ID，入站时为访问目的类型，出站时为访问源类型
        /// </summary>
        [JsonProperty("RuleType")]
        public ulong? RuleType{ get; set; }

        /// <summary>
        /// 执行顺序，中间插入必传，前插、后插非必传
        /// </summary>
        [JsonProperty("OrderIndex")]
        public ulong? OrderIndex{ get; set; }

        /// <summary>
        /// 私有网络ID，当RuleType为1时必传
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
        }
    }
}

