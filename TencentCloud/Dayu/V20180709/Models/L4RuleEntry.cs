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

    public class L4RuleEntry : AbstractModel
    {
        
        /// <summary>
        /// 转发协议，取值[TCP, UDP]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 转发端口
        /// </summary>
        [JsonProperty("VirtualPort")]
        public ulong? VirtualPort{ get; set; }

        /// <summary>
        /// 源站端口
        /// </summary>
        [JsonProperty("SourcePort")]
        public ulong? SourcePort{ get; set; }

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
        /// 负载均衡方式，取值[1(加权轮询)，2(源IP hash)]
        /// </summary>
        [JsonProperty("LbType")]
        public ulong? LbType{ get; set; }

        /// <summary>
        /// 会话保持开关，取值[0(会话保持关闭)，1(会话保持开启)]；
        /// </summary>
        [JsonProperty("KeepEnable")]
        public ulong? KeepEnable{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 移除水印状态，取值[0(关闭)，1(开启)]
        /// </summary>
        [JsonProperty("RemoveSwitch")]
        public ulong? RemoveSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "VirtualPort", this.VirtualPort);
            this.SetParamSimple(map, prefix + "SourcePort", this.SourcePort);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "KeepTime", this.KeepTime);
            this.SetParamArrayObj(map, prefix + "SourceList.", this.SourceList);
            this.SetParamSimple(map, prefix + "LbType", this.LbType);
            this.SetParamSimple(map, prefix + "KeepEnable", this.KeepEnable);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RemoveSwitch", this.RemoveSwitch);
        }
    }
}

