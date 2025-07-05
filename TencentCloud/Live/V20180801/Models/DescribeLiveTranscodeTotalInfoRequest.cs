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

    public class DescribeLiveTranscodeTotalInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间，支持最近三个月的数据查询，起始时间和结束时间跨度不能超过三个月。接口查询支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/267/38543#:~:text=I-,ISO,-%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)
        /// 2）YYYY-MM-DD hh:mm:ss：使用此格式时，默认代表北京时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间，支持最近三个月的数据查询，起始时间和结束时间跨度不能超过三个月。接口查询支持两种时间格式：
        /// 1）YYYY-MM-DDThh:mm:ssZ：UTC时间格式，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/267/38543#:~:text=I-,ISO,-%E6%97%A5%E6%9C%9F%E6%A0%BC%E5%BC%8F)
        /// 2）YYYY-MM-DD hh:mm:ss：使用此格式时，默认代表北京时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 推流域名列表，若不填，表示查询所有域名总体数据。
        /// 指定域名时返回1小时粒度数据。
        /// </summary>
        [JsonProperty("PushDomains")]
        public string[] PushDomains{ get; set; }

        /// <summary>
        /// 可选值：
        /// Mainland：查询中国大陆（境内）数据，
        /// Oversea：则查询国际/港澳台（境外）数据，
        /// 默认：查询全球地区（境内+境外）的数据。
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PushDomains.", this.PushDomains);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
        }
    }
}

