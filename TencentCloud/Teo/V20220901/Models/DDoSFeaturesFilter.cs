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

    public class DDoSFeaturesFilter : AbstractModel
    {
        
        /// <summary>
        /// 执行动作，取值有：
        /// <li>drop ：丢弃 ；</li>
        /// <li>transmit ：放行 ；</li>
        /// <li>drop_block ：丢弃并拉黑 ；</li>
        /// <li>forward ：继续防护 。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 协议，取值有：
        /// <li>tcp ：tcp协议 ；</li>
        /// <li>udp ：udp协议 ；</li>
        /// <li>icmp ：icmp协议 ；</li>
        /// <li>all ：全部协议 。</li>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 目标端口开始，取值范围0-65535。
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// 目标端口结束，取值范围0-65535。
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// 最小包长，取值范围0-1500。
        /// </summary>
        [JsonProperty("PacketMin")]
        public long? PacketMin{ get; set; }

        /// <summary>
        /// 最大包长，取值范围0-1500。
        /// </summary>
        [JsonProperty("PacketMax")]
        public long? PacketMax{ get; set; }

        /// <summary>
        /// 源端口开始，取值范围0-65535。
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// 源端口结束，取值范围0-65535。
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// 匹配方式1，【特征1】，取值有：
        /// <li>pcre ：正则匹配 ；</li>
        /// <li>sunday ：字符串匹配 。</li>默认为空字符串。
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 取非判断，该参数对MatchType配合使用，【特征1】，取值有：
        /// <li>0 ：匹配 ；</li>
        /// <li>1 ：不匹配 。</li>
        /// </summary>
        [JsonProperty("IsNot")]
        public long? IsNot{ get; set; }

        /// <summary>
        /// 偏移量1，【特征1】，取值范围0-1500。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 检测包字符深度，【特征1】，取值范围1-1500。
        /// </summary>
        [JsonProperty("Depth")]
        public long? Depth{ get; set; }

        /// <summary>
        /// 匹配开始层级，层级参考计算机网络结构，取值有：
        /// <li>begin_l5 ：载荷开始检测 ；</li>
        /// <li>begin_l4 ：tcp/udp首部开始检测 ；</li>
        /// <li>begin_l3 ：ip首部开始检测 。</li>
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// 正则或字符串匹配的内容，【特征1】。
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// 匹配方式2，【特征2】，取值有：
        /// <li>pcre ：正则匹配 ；</li>
        /// <li>sunday ：字符串匹配 。</li>默认为空字符串。
        /// </summary>
        [JsonProperty("MatchType2")]
        public string MatchType2{ get; set; }

        /// <summary>
        /// 取非判断2，该参数对MatchType2配合使用，【特征2】，取值有：
        /// <li>0 ：匹配 ；</li>
        /// <li>1 ：不匹配 。</li>
        /// </summary>
        [JsonProperty("IsNot2")]
        public long? IsNot2{ get; set; }

        /// <summary>
        /// 偏移量2，【特征2】，取值范围0-1500。
        /// </summary>
        [JsonProperty("Offset2")]
        public long? Offset2{ get; set; }

        /// <summary>
        /// 检测包字符深度，【特征2】，取值范围1-1500。
        /// </summary>
        [JsonProperty("Depth2")]
        public long? Depth2{ get; set; }

        /// <summary>
        /// 匹配开始层级，层级参考计算机网络结构，取值有：
        /// <li>begin_l5 ：载荷开始检测 ；</li>
        /// <li>begin_l4 ：tcp/udp首部开始检测；</li>
        /// <li>begin_l3 ：ip首部开始检测 。</li>
        /// </summary>
        [JsonProperty("MatchBegin2")]
        public string MatchBegin2{ get; set; }

        /// <summary>
        /// 正则或字符串匹配的内容，【特征2】。
        /// </summary>
        [JsonProperty("Str2")]
        public string Str2{ get; set; }

        /// <summary>
        /// 多特征关系，仅配置【特征1】时填 none，存在【特征2】配置可不填。
        /// </summary>
        [JsonProperty("MatchLogic")]
        public string MatchLogic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "PacketMin", this.PacketMin);
            this.SetParamSimple(map, prefix + "PacketMax", this.PacketMax);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "MatchType2", this.MatchType2);
            this.SetParamSimple(map, prefix + "IsNot2", this.IsNot2);
            this.SetParamSimple(map, prefix + "Offset2", this.Offset2);
            this.SetParamSimple(map, prefix + "Depth2", this.Depth2);
            this.SetParamSimple(map, prefix + "MatchBegin2", this.MatchBegin2);
            this.SetParamSimple(map, prefix + "Str2", this.Str2);
            this.SetParamSimple(map, prefix + "MatchLogic", this.MatchLogic);
        }
    }
}

