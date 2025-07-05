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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDNUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始日期，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束日期，需大于开始日期，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// CDN 统计数据类型，有效值：
        /// <li>Flux：流量，单位为 byte。</li>
        /// <li>Bandwidth：带宽，单位为 bps。</li>
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 用量数据的时间粒度，单位：分钟，取值有：
        /// <li>5：5 分钟粒度，返回指定查询时间内5分钟粒度的明细数据。</li>
        /// <li>60：小时粒度，返回指定查询时间内1小时粒度的数据。</li>
        /// <li>1440：天粒度，返回指定查询时间内1天粒度的数据。</li>
        /// 默认值为1440，返回天粒度的数据。
        /// </summary>
        [JsonProperty("DataInterval")]
        public ulong? DataInterval{ get; set; }

        /// <summary>
        /// 域名列表。一次最多查询20个域名的用量数据。可以指定多个域名，查询这些域名叠加的用量数据。默认返回所有域名叠加的用量数据。
        /// </summary>
        [JsonProperty("DomainNames")]
        public string[] DomainNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "DataInterval", this.DataInterval);
            this.SetParamArraySimple(map, prefix + "DomainNames.", this.DomainNames);
        }
    }
}

