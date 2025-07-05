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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSAttackTopDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。查询时间范围（`EndTime` - `StartTime`）需小于等于 31 天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 查询的统计指标，取值有：
        /// <li>ddos_attackFlux_protocol：按各协议的攻击流量排行；</li>
        /// <li>ddos_attackPackageNum_protocol：按各协议的攻击包量排行；</li>
        /// <li>ddos_attackNum_attackType：按各攻击类型的攻击数量排行；</li>
        /// <li>ddos_attackNum_sregion：按攻击源地区的攻击数量排行；</li>
        /// <li>ddos_attackFlux_sip：按攻击源IP的攻击数量排行；</li>
        /// <li>ddos_attackFlux_sregion：按攻击源地区的攻击数量排行。</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 站点 ID 集合，此参数必填。最多传入 100 个站点 ID。若需查询腾讯云主账号下所有站点数据，请用 `*` 代替，查询账号级别数据需具备本接口全部站点资源权限。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// DDoS策略组ID集合，不填默认选择全部策略ID。
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// 攻击类型，取值有：
        /// <li>flood：洪泛攻击；</li>
        /// <li>icmpFlood：icmp洪泛攻击；</li>
        /// <li>all：所有的攻击类型。</li>不填默认为all，表示查询全部攻击类型。
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 协议类型，取值有：
        /// <li>tcp：tcp协议；</li>
        /// <li>udp：udp协议；</li>
        /// <li>all：所有的协议类型。</li>不填默认为all，表示查询所有协议。
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// 端口号。
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 查询前多少个数据，不填默认默认为10， 表示查询前top 10的数据。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 数据归属地区，取值有：
        /// <li>overseas：全球（除中国大陆地区）数据；</li>
        /// <li>mainland：中国大陆地区数据。</li>不填将根据用户所在地智能选择地区。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

