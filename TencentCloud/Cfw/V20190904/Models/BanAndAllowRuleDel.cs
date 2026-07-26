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

    public class BanAndAllowRuleDel : AbstractModel
    {
        
        /// <summary>
        /// 规则的完整适用方向列表，多个值以逗号分隔：0 互联网出站，1 互联网入站，2 双向，3 东西向，4 情报误报反馈，5 内网访问源，6 内网访问目的。通过 DescribeBlockIgnoreList 查询时传顶层 Direction=""，并使用目标 Data[].DirectionList。
        /// </summary>
        [JsonProperty("DirectionList")]
        public string DirectionList{ get; set; }

        /// <summary>
        /// 封禁或放通对象值。通过 DescribeBlockIgnoreList 查询并使用完全匹配目标的 Data[].Ioc。
        /// </summary>
        [JsonProperty("Ioc")]
        public string Ioc{ get; set; }

        /// <summary>
        /// 规则类型标识。通过 DescribeBlockIgnoreList 查询并使用目标 Data[].RuleType。常用值：1 封禁 IP，2 放通 IP，3 放通域名，4 威胁情报地址，5 资产实例，6 自定义策略，7 入侵防御规则，8 扩展 IP 规则，9 扩展自定义规则。
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectionList", this.DirectionList);
            this.SetParamSimple(map, prefix + "Ioc", this.Ioc);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
        }
    }
}

