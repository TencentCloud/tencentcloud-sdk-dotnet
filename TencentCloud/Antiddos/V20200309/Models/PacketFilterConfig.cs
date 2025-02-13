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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PacketFilterConfig : AbstractModel
    {
        
        /// <summary>
        /// 协议，取值[tcp udp icmp all]
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 起始源端口，取值0~65535
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// 结束源端口，取值1~65535，必须大于等于起始源端口
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// 起始目的端口，取值0~65535
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// 结束目的端口，取值1~65535，必须大于等于起始目的端口
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// 最小报文长度，取值1-1500
        /// </summary>
        [JsonProperty("PktlenMin")]
        public long? PktlenMin{ get; set; }

        /// <summary>
        /// 最大报文长度，取值1-1500，必须大于等于最小报文长度
        /// </summary>
        [JsonProperty("PktlenMax")]
        public long? PktlenMax{ get; set; }

        /// <summary>
        /// 动作，取值[
        /// drop(丢弃)
        /// transmit(放行)
        /// drop_black(丢弃并拉黑)
        /// drop_rst(拦截)（已废弃，不支持drop_rst）
        /// drop_black_rst(拦截并拉黑)（已废弃，不支持drop_black_rst）
        /// forward(继续防护)
        /// ]
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 检测位置，取值[
        /// begin_l3(IP头)
        /// begin_l4(TCP/UDP头)
        /// begin_l5(T载荷)
        /// no_match(不匹配)
        /// ]
        /// </summary>
        [JsonProperty("MatchBegin")]
        public string MatchBegin{ get; set; }

        /// <summary>
        /// 检测类型，取值[
        /// sunday(关键字)
        /// pcre(正则表达式) （已废弃，仅支持sunday）
        /// ]
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// 检测值，关键字符串或正则表达式,取值[ 当检测类型为sunday时，请填写字符串或者16进制字节码，例如\x313233对应的是字符串"123"的16进制字节码; 最多支持63位; ]
        /// </summary>
        [JsonProperty("Str")]
        public string Str{ get; set; }

        /// <summary>
        /// 从检测位置开始的检测深度，取值[0,1500]
        /// </summary>
        [JsonProperty("Depth")]
        public long? Depth{ get; set; }

        /// <summary>
        /// 从检测位置开始的偏移量，取值范围[0,Depth]
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 是否包含检测值，取值[
        /// 0(包含)
        /// 1(不包含) （已废弃，仅支持0）
        /// ]
        /// </summary>
        [JsonProperty("IsNot")]
        public long? IsNot{ get; set; }

        /// <summary>
        /// 
        /// 当有第二个检测条件时，与第一检测条件的且或关系，取值[
        /// and(且的关系) （已废弃，仅支持none）
        /// none(当没有第二个检测条件时填写此值)
        /// ]
        /// </summary>
        [JsonProperty("MatchLogic")]
        public string MatchLogic{ get; set; }

        /// <summary>
        /// （已废弃）
        /// </summary>
        [JsonProperty("MatchBegin2")]
        public string MatchBegin2{ get; set; }

        /// <summary>
        /// （已废弃）
        /// </summary>
        [JsonProperty("MatchType2")]
        public string MatchType2{ get; set; }

        /// <summary>
        /// （已废弃）
        /// </summary>
        [JsonProperty("Str2")]
        public string Str2{ get; set; }

        /// <summary>
        /// （已废弃）
        /// </summary>
        [JsonProperty("Depth2")]
        public long? Depth2{ get; set; }

        /// <summary>
        /// （已废弃）
        /// </summary>
        [JsonProperty("Offset2")]
        public long? Offset2{ get; set; }

        /// <summary>
        /// （已废弃）
        /// </summary>
        [JsonProperty("IsNot2")]
        public long? IsNot2{ get; set; }

        /// <summary>
        /// 特征过滤配置添加成功后自动生成的规则ID，当添加新特征过滤配置时，此字段不用填写；当修改/删除新特征过滤配置时，此字段必填；
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 大于报文长度，取值1+
        /// </summary>
        [JsonProperty("PktLenGT")]
        public long? PktLenGT{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "PktlenMin", this.PktlenMin);
            this.SetParamSimple(map, prefix + "PktlenMax", this.PktlenMax);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "MatchBegin", this.MatchBegin);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "Str", this.Str);
            this.SetParamSimple(map, prefix + "Depth", this.Depth);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "IsNot", this.IsNot);
            this.SetParamSimple(map, prefix + "MatchLogic", this.MatchLogic);
            this.SetParamSimple(map, prefix + "MatchBegin2", this.MatchBegin2);
            this.SetParamSimple(map, prefix + "MatchType2", this.MatchType2);
            this.SetParamSimple(map, prefix + "Str2", this.Str2);
            this.SetParamSimple(map, prefix + "Depth2", this.Depth2);
            this.SetParamSimple(map, prefix + "Offset2", this.Offset2);
            this.SetParamSimple(map, prefix + "IsNot2", this.IsNot2);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PktLenGT", this.PktLenGT);
        }
    }
}

