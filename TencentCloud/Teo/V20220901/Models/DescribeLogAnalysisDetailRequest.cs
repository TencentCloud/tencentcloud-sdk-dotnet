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

    public class DescribeLogAnalysisDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>数据归属地区，可选值：<ul><li>mainland：中国大陆境内；</li><li>overseas：全球（不含中国大陆）。</li></ul>注意：若站点服务区域为“全球可用区”，获取全部数据需要分别查询 mainland 和 overseas 的数据。</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>开始时间，示例值：2020-04-29T00:00:00Z。套餐版本不同，支持的可查询开始时间至今的最大时间跨度不同，详情请见 <a href="https://cloud.tencent.com/document/product/1552/94165#45435466-9103-4ff6-be22-e31717044fb2">套餐选型对比</a>。</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间，示例值：2020-04-30T00:00:00Z。单次查询的开始时间到结束时间跨度最大为 31 天。</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>日志类型，可选值：<ul><li> l7-access-logs：七层访问日志；</li><li>web-attack：托管规则日志。</li></ul>默认为 l7-access-logs 。</p>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// <p><a href="https://cloud.tencent.com/document/product/1552/124662">日志匹配条件</a>，最大长度 12KB。</p>
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// <p>分页查询限制数目，默认值：20，最大值 100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>分页查询偏移量，默认为 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>原始日志是否按时间排序返回；可选值：<ul><li>asc：升序；</li><li>desc：降序。</li></ul>默认为 desc。</p>
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
        }
    }
}

