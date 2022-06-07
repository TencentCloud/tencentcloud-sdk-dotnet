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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSFeaturesFilter : AbstractModel
    {
        
        /// <summary>
        /// 动作 drop-丢弃；transmit-放行；drop_block-丢弃并拉黑；forward-继续防护
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 深度值1
        /// </summary>
        [JsonProperty("Depth")]
        public long? Depth{ get; set; }

        /// <summary>
        /// 深度值2
        /// </summary>
        [JsonProperty("Depth2")]
        public long? Depth2{ get; set; }

        /// <summary>
        /// 目标端口结束
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// 目标端口开始
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// 取非判断1
        /// </summary>
        [JsonProperty("IsNot")]
        public long? IsNot{ get; set; }

        /// <summary>
        /// 取非判断2
        /// </summary>
        [JsonProperty("IsNot2")]
        public long? IsNot2{ get; set; }

        /// <summary>
        /// 多特征关系（单特征时(none)，第二特征相关配置可不填） none；and；or
        /// </summary>
        [JsonProperty("MatchLogic")]
        public string MatchLogic{ get; set; }

        /// <summary>
        /// 匹配方式1 pcre-正则匹配, sunday-字符串匹配
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 匹配方式2 pcre-正则匹配, sunday-字符串匹配
        /// </summary>
        [JsonProperty("MatchType2")]
        public string MatchType2{ get; set; }

        /// <summary>
        /// 偏移量1
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 偏移量2
        /// </summary>
        [JsonProperty("Offset2")]
        public long? Offset2{ get; set; }

        /// <summary>
        /// 最大包长
        /// </summary>
        [JsonProperty("PacketMax")]
        public long? PacketMax{ get; set; }

        /// <summary>
        /// 最小包长
        /// </summary>
        [JsonProperty("PacketMin")]
        public long? PacketMin{ get; set; }

        /// <summary>
        /// 协议 tcp；udp；icmp；all
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 源端口结束
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// 源端口开始
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// 匹配字符串1
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// 匹配字符串2
        /// </summary>
        [JsonProperty("Str2")]
        public string Str2{ get; set; }

        /// <summary>
        /// 匹配开始层级，层级参考计算机网络结构 begin_l5, no_match, begin_l3, begin_l4
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// 匹配开始层级，层级参考计算机网络结构 begin_l5, no_match, begin_l3, begin_l4
        /// </summary>
        [JsonProperty("MatchBegin2")]
        public string MatchBegin2{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "Depth2", this.Depth2);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "IsNot2", this.IsNot2);
            this.SetParamSimple(map, prefix + "MatchLogic", this.MatchLogic);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "MatchType2", this.MatchType2);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Offset2", this.Offset2);
            this.SetParamSimple(map, prefix + "PacketMax", this.PacketMax);
            this.SetParamSimple(map, prefix + "PacketMin", this.PacketMin);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "Str2", this.Str2);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "MatchBegin2", this.MatchBegin2);
        }
    }
}

