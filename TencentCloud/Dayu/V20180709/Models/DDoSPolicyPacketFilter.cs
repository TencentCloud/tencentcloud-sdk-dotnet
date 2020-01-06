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

    public class DDoSPolicyPacketFilter : AbstractModel
    {
        
        /// <summary>
        /// 协议，取值范围[tcp,udp,icmp,all]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 开始源端口，取值范围[0,65535]
        /// </summary>
        [JsonProperty("SportStart")]
        public ulong? SportStart{ get; set; }

        /// <summary>
        /// 结束源端口，取值范围[0,65535]
        /// </summary>
        [JsonProperty("SportEnd")]
        public ulong? SportEnd{ get; set; }

        /// <summary>
        /// 开始目的端口，取值范围[0,65535]
        /// </summary>
        [JsonProperty("DportStart")]
        public ulong? DportStart{ get; set; }

        /// <summary>
        /// 结束目的端口，取值范围[0,65535]
        /// </summary>
        [JsonProperty("DportEnd")]
        public ulong? DportEnd{ get; set; }

        /// <summary>
        /// 最小包长，取值范围[0,1500]
        /// </summary>
        [JsonProperty("PktlenMin")]
        public ulong? PktlenMin{ get; set; }

        /// <summary>
        /// 最大包长，取值范围[0,1500]
        /// </summary>
        [JsonProperty("PktlenMax")]
        public ulong? PktlenMax{ get; set; }

        /// <summary>
        /// 是否检测载荷，取值范围[begin_l5(表示检测), no_match(表示不检测)]
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// 是否是正则表达式，取值范围[sunday(表示关键字),pcre(表示正则表达式)]
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 关键字或正则表达式
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// 检测深度，取值范围[0,1500]
        /// </summary>
        [JsonProperty("Depth")]
        public ulong? Depth{ get; set; }

        /// <summary>
        /// 检测偏移量，取值范围[0,1500]
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 是否包括，取值范围[0(表示不包含),1(表示包含)]
        /// </summary>
        [JsonProperty("IsNot")]
        public ulong? IsNot{ get; set; }

        /// <summary>
        /// 策略动作，取值范围[drop，drop_black，drop_rst，drop_black_rst，transmit]
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "PktlenMin", this.PktlenMin);
            this.SetParamSimple(map, prefix + "PktlenMax", this.PktlenMax);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

