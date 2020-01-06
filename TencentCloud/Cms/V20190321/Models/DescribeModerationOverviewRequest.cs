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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeModerationOverviewRequest : AbstractModel
    {
        
        /// <summary>
        /// 日期，如2019-01-01， 查询该日期的概览数据
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 服务类型数组，可以动态配置，Text:文本，Image:图片，Audio:音频，Video:视频, 使用"ALL"表示所有类型, 不区分大小写，如 ["Text", "Image"]查询文本和图片服务的数据，["all"]查询所有服务的数据。
        /// </summary>
        [JsonProperty("ServiceTypes")]
        public string[] ServiceTypes{ get; set; }

        /// <summary>
        /// 渠道号数组，1:直播 2:点播 3:IM 4:GME，统计指定渠道组合的汇总数据，如[1,2]表示获取直播和点播两个渠道的汇总数据，不填[]为所有渠道汇总数据
        /// </summary>
        [JsonProperty("Channels")]
        public ulong?[] Channels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamArraySimple(map, prefix + "ServiceTypes.", this.ServiceTypes);
            this.SetParamArraySimple(map, prefix + "Channels.", this.Channels);
        }
    }
}

