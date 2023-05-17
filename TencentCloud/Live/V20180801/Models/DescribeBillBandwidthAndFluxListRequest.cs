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

    public class DescribeBillBandwidthAndFluxListRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间点，接口查询支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见IOS日期格式说明文档: https://cloud.tencent.com/document/product/266/11732#I
        /// 2）YYYY-MM-DD hh:mm:ss：使用此格式时，默认代表北京时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间点，接口查询支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见IOS日期格式说明文档: https://cloud.tencent.com/document/product/266/11732#I
        /// 2）YYYY-MM-DD hh:mm:ss：使用此格式时，默认代表北京时间。
        /// 起始和结束时间跨度不支持超过31天。支持最近3年的数据查询
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 直播播放域名，若不填，表示总体数据。
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }

        /// <summary>
        /// 可选值：
        /// Mainland：查询国内数据，
        /// Oversea：则查询国外数据，
        /// 默认：查询国内+国外的数据。
        /// 注：LEB（快直播）只支持国内+国外数据查询。
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
        /// 服务名称，可选值包括LVB(标准直播)，LEB(快直播)，不填则查LVB+LEB总值。
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamArraySimple(map, prefix + "RegionNames.", this.RegionNames);
        }
    }
}

