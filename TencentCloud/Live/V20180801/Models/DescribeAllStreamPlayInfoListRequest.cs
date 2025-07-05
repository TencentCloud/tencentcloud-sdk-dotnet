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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAllStreamPlayInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询时间点，精确到分钟粒度，接口查询支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/267/38543#:~:text=I-,ISO%20%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F,-ISO%20%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)。
        /// 2）YYYY-MM-DD hh:mm:ss：使用此格式时，默认代表北京时间。
        /// 支持最近1个月的数据查询，数据延迟为5分钟左右，如果要查询实时的数据，建议传递5分钟前的整点时间点。
        /// </summary>
        [JsonProperty("QueryTime")]
        public string QueryTime{ get; set; }

        /// <summary>
        /// 播放域名列表，若不填，表示总体数据。
        /// </summary>
        [JsonProperty("PlayDomains")]
        public string[] PlayDomains{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamArraySimple(map, prefix + "PlayDomains.", this.PlayDomains);
        }
    }
}

