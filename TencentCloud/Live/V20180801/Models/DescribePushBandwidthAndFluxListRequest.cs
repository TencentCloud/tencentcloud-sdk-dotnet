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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePushBandwidthAndFluxListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间点，格式为 yyyy-mm-dd HH:MM:SS。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间点，格式为 yyyy-mm-dd HH:MM:SS，起始和结束时间跨度不支持超过31天。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 域名，可以填多个，若不填，表示总体数据。
        /// </summary>
        [JsonProperty("PushDomains")]
        public string[] PushDomains{ get; set; }

        /// <summary>
        /// 可选值：
        /// Mainland：查询中国大陆（境内）数据，
        /// Oversea：则查询国际/港澳台（境外）数据，
        /// 不填则默认查询全球地区（境内+境外）的数据。
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// 数据粒度，支持如下粒度：
        /// 5：5分钟粒度，（跨度不支持超过1天），
        /// 60：1小时粒度（跨度不支持超过一个月），
        /// 1440：天粒度（跨度不支持超过一个月）。
        /// 默认值：5。
        /// </summary>
        [JsonProperty("Granularity")]
        public ulong? Granularity{ get; set; }

        /// <summary>
        /// 大区，映射表如下：
        /// China Mainland 中国大陆
        /// Asia Pacific I 亚太一区
        /// Asia Pacific II 亚太二区
        /// Asia Pacific III 亚太三区
        /// Europe 欧洲
        /// North America 北美
        /// South America 南美
        /// Middle East 中东
        /// Africa 非洲。
        /// </summary>
        [JsonProperty("RegionNames")]
        public string[] RegionNames{ get; set; }

        /// <summary>
        /// 国家，映射表参照如下文档：
        /// https://cloud.tencent.com/document/product/267/34019。
        /// </summary>
        [JsonProperty("CountryNames")]
        public string[] CountryNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PushDomains.", this.PushDomains);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamArraySimple(map, prefix + "RegionNames.", this.RegionNames);
            this.SetParamArraySimple(map, prefix + "CountryNames.", this.CountryNames);
        }
    }
}

