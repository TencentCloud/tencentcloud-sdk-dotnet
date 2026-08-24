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

    public class DescribeDDoSAttackDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>开始时间。时间为世界标准时间（UTC），遵循 ISO 8601 标准的日期和时间格式。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间。时间为世界标准时间（UTC），遵循 ISO 8601 标准的日期和时间格式。查询时间范围（<code>EndTime</code> - <code>StartTime</code>）需小于等于 31 天。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>统计指标列表，至少填写 1 个，且不允许重复。</p><p>枚举值：</p><ul><li>ddos_attackMaxBandwidth： 攻击带宽峰值，单位 bps；</li><li>ddos_attackMaxPackageRate： 攻击包速率峰值，单位 pps；</li><li>ddos_attackBandwidth： 攻击带宽曲线，单位 bps；</li><li>ddos_attackPackageRate： 攻击包速率曲线，单位 pps。</li></ul>
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// <p>站点 ID 集合，此参数将于2024年05月30日后由可选改为必填，详见公告：<a href="https://cloud.tencent.com/document/product/1552/104902">【腾讯云 EdgeOne】云 API 变更通知</a>。最多传入 100 个站点 ID。若需查询腾讯云主账号下所有站点数据，请用 <code>*</code> 代替，查询账号级别数据需具备本接口全部站点资源权限。</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>DDoS 策略组 ID 列表，不填默认选择全部策略 ID。</p>
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// <p>查询时间粒度，不填将根据开始时间与结束时间的间隔自动推算粒度，具体为：1 小时范围内以 min 粒度查询，2 天范围内以 5min 粒度查询，7 天范围内以 hour 粒度查询，超过 7 天以 day 粒度查询。</p><p>枚举值：</p><ul><li>min： 1 分钟；</li><li>5min： 5分钟；</li><li>hour： 1小时；</li><li>day： 1天。</li></ul>
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// <p>数据归属地区。</p><p>枚举值：</p><ul><li>overseas： 全球（除中国大陆地区）数据；</li><li>mainland： 中国大陆地区数据；</li><li>global： 全球数据。</li></ul><p>默认值：global</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>过滤条件，QueryCondition.Value 的集合数量上限为 20，详细的过滤条件 QueryCondition.Key 值如下：</p><li>ddos-attack-dip：按照 DDoS 攻击目的 IP 进行过滤，QueryCondition.Operator 仅支持 equals。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public QueryCondition[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

