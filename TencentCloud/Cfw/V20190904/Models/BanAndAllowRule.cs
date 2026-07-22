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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BanAndAllowRule : AbstractModel
    {
        
        /// <summary>
        /// 规则备注，最多 200 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 自定义放通规则详情。RuleType=6 时使用；其它规则类型不读取此字段。
        /// </summary>
        [JsonProperty("CustomRule")]
        public CustomWhiteRule CustomRule{ get; set; }

        /// <summary>
        /// 生效方向，使用逗号分隔的整数：0 互联网出站、1 互联网入站、2 双向、3 东西向、4 情报误报反馈、5 内网访问源、6 内网访问目的；每项都必须属于 0 至 6。该字段不可为空；RuleType=6 时通过初始校验后，处理器会根据 CustomRule 的源、目的地址重新计算方向。
        /// </summary>
        [JsonProperty("DirectionList")]
        public string DirectionList{ get; set; }

        /// <summary>
        /// 规则截止时间，必须使用 YYYY-MM-DD HH:MM:SS 格式且不得早于服务器处理时刻；3000-01-01 00:00:00 作为长期有效时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 自定义放通规则的生效引擎位图：1 互联网边界旁路、2 NAT 防火墙、4 VPC 防火墙、8 互联网边界串行、16 NDR，组合值按位相加。处理器接受 0 至 31。RuleType=6 时，非零值会按源、目的地址组合与适用引擎位求交，并保留 NDR 位 16；归一化结果大于 0 时使用该结果，结果为 0 时与省略或传 0 相同：任一地址为 IPv6 或私网 IPv4 则实际使用 6，否则实际使用 15。其它 RuleType 仅校验该字段而不使用其值。
        /// </summary>
        [JsonProperty("FwType")]
        public long? FwType{ get; set; }

        /// <summary>
        /// 规则对象。RuleType=1 或 2 时必须是 IP 地址，RuleType=3 时必须是合法域名，RuleType=4 时不能为空，RuleType=5 时必须是资产表中存在的实例 ID；RuleType=6 时表示自定义规则 ID：新增时可省略并由处理器生成；修改时作为既有规则的查询和更新键，省略时不会命中既有规则。其它受理的 RuleType 不校验对象格式。
        /// </summary>
        [JsonProperty("Ioc")]
        public string Ioc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "CustomRule.", this.CustomRule);
            this.SetParamSimple(map, prefix + "DirectionList", this.DirectionList);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "Ioc", this.Ioc);
        }
    }
}

