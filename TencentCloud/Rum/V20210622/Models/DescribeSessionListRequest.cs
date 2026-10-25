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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSessionListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>开始时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>session类型</p><p>枚举值：</p><ul><li>all： 所有</li><li>error： 错</li><li>slow： 慢</li></ul>
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// <p>页面号</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// <p>每一页的数量</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>排序字段</p>
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// <p>排序方式，ASC或DESC</p>
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// <p>用户id</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>session id</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>设备类型</p>
        /// </summary>
        [JsonProperty("DeviceTypes")]
        public string[] DeviceTypes{ get; set; }

        /// <summary>
        /// <p>浏览器</p>
        /// </summary>
        [JsonProperty("Browsers")]
        public string[] Browsers{ get; set; }

        /// <summary>
        /// <p>操作系统</p>
        /// </summary>
        [JsonProperty("OSList")]
        public string[] OSList{ get; set; }

        /// <summary>
        /// <p>平台</p>
        /// </summary>
        [JsonProperty("Platforms")]
        public string[] Platforms{ get; set; }

        /// <summary>
        /// <p>应用版本</p>
        /// </summary>
        [JsonProperty("AppVersions")]
        public string[] AppVersions{ get; set; }

        /// <summary>
        /// <p>国家</p>
        /// </summary>
        [JsonProperty("Countries")]
        public string[] Countries{ get; set; }

        /// <summary>
        /// <p>是否有挣扎事件</p>
        /// </summary>
        [JsonProperty("HasStruggle")]
        public bool? HasStruggle{ get; set; }

        /// <summary>
        /// <p>挣扎等级</p>
        /// </summary>
        [JsonProperty("StruggleRanks")]
        public string[] StruggleRanks{ get; set; }

        /// <summary>
        /// <p>挣扎事件类型</p>
        /// </summary>
        [JsonProperty("StruggleTypes")]
        public string[] StruggleTypes{ get; set; }

        /// <summary>
        /// <p>是否有错误</p>
        /// </summary>
        [JsonProperty("HasError")]
        public bool? HasError{ get; set; }

        /// <summary>
        /// <p>访问页面</p>
        /// </summary>
        [JsonProperty("VisitedPage")]
        public string VisitedPage{ get; set; }

        /// <summary>
        /// <p>包含事件</p>
        /// </summary>
        [JsonProperty("ContainsEvent")]
        public string ContainsEvent{ get; set; }

        /// <summary>
        /// <p>最小持续时间</p>
        /// </summary>
        [JsonProperty("MinDuration")]
        public long? MinDuration{ get; set; }

        /// <summary>
        /// <p>最大持续时间</p>
        /// </summary>
        [JsonProperty("MaxDuration")]
        public long? MaxDuration{ get; set; }

        /// <summary>
        /// <p>性能过滤</p>
        /// </summary>
        [JsonProperty("PerfFilter")]
        public string PerfFilter{ get; set; }

        /// <summary>
        /// <p>地区</p>
        /// </summary>
        [JsonProperty("Regions")]
        public string[] Regions{ get; set; }

        /// <summary>
        /// <p>环境</p>
        /// </summary>
        [JsonProperty("Environments")]
        public string[] Environments{ get; set; }

        /// <summary>
        /// <p>筛选</p>
        /// </summary>
        [JsonProperty("Filters")]
        public string Filters{ get; set; }

        /// <summary>
        /// <p>旅程起点页面。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("StartPage")]
        public string StartPage{ get; set; }

        /// <summary>
        /// <p>旅程终点页面。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("EndPage")]
        public string EndPage{ get; set; }

        /// <summary>
        /// <p>旅程筛选条件 JSON 字符串，格式与 Filters 相同：[{Key,Op,Values}]。可选。不传表示不过滤。</p>
        /// </summary>
        [JsonProperty("JourneyFilters")]
        public string JourneyFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamArraySimple(map, prefix + "DeviceTypes.", this.DeviceTypes);
            this.SetParamArraySimple(map, prefix + "Browsers.", this.Browsers);
            this.SetParamArraySimple(map, prefix + "OSList.", this.OSList);
            this.SetParamArraySimple(map, prefix + "Platforms.", this.Platforms);
            this.SetParamArraySimple(map, prefix + "AppVersions.", this.AppVersions);
            this.SetParamArraySimple(map, prefix + "Countries.", this.Countries);
            this.SetParamSimple(map, prefix + "HasStruggle", this.HasStruggle);
            this.SetParamArraySimple(map, prefix + "StruggleRanks.", this.StruggleRanks);
            this.SetParamArraySimple(map, prefix + "StruggleTypes.", this.StruggleTypes);
            this.SetParamSimple(map, prefix + "HasError", this.HasError);
            this.SetParamSimple(map, prefix + "VisitedPage", this.VisitedPage);
            this.SetParamSimple(map, prefix + "ContainsEvent", this.ContainsEvent);
            this.SetParamSimple(map, prefix + "MinDuration", this.MinDuration);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamSimple(map, prefix + "PerfFilter", this.PerfFilter);
            this.SetParamArraySimple(map, prefix + "Regions.", this.Regions);
            this.SetParamArraySimple(map, prefix + "Environments.", this.Environments);
            this.SetParamSimple(map, prefix + "Filters", this.Filters);
            this.SetParamSimple(map, prefix + "StartPage", this.StartPage);
            this.SetParamSimple(map, prefix + "EndPage", this.EndPage);
            this.SetParamSimple(map, prefix + "JourneyFilters", this.JourneyFilters);
        }
    }
}

