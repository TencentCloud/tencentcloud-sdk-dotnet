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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDailyMostPlayedStatRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询日期，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。该参数仅日期部分有效。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 域名。查询该域名播放 Top100 的媒体文件的统计数据。默认查询所有域名的播放统计数据。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Top 数据的统计指标，取值有：
        /// <li>Traffic：播放流量，按播放流量统计 Top100 的数据。</li>
        /// <li>PlayTimes：播放次数，按播放次数统计播放 Top100 的数据。</li>
        /// </summary>
        [JsonProperty("Metric")]
        public string Metric{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Metric", this.Metric);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

