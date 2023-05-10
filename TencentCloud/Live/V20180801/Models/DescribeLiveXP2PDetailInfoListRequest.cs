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

    public class DescribeLiveXP2PDetailInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// utc分钟粒度查询时间，查询某一分钟的用量数据，格式为：yyyy-mm-ddTHH:MM:00Z，参考https://cloud.tencent.com/document/product/266/11732#I，
        /// 例如：北京时间2019-01-08 10:00:00，对应utc时间为：2019-01-08T10:00:00+08:00。
        /// 
        /// 支持最近六个月的查询。
        /// </summary>
        [JsonProperty("QueryTime")]
        public string QueryTime{ get; set; }

        /// <summary>
        /// 类型数组，分直播live和点播vod，不传默认查全部。
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }

        /// <summary>
        /// 查询流数组，不传默认查所有流。
        /// </summary>
        [JsonProperty("StreamNames")]
        public string[] StreamNames{ get; set; }

        /// <summary>
        /// 查询维度，不传该参数则默认查询流维度的数据，传递该参数则只查对应维度的数据，和返回值的字段相关，目前支持AppId维度查询。
        /// </summary>
        [JsonProperty("Dimension")]
        public string[] Dimension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueryTime", this.QueryTime);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
            this.SetParamArraySimple(map, prefix + "StreamNames.", this.StreamNames);
            this.SetParamArraySimple(map, prefix + "Dimension.", this.Dimension);
        }
    }
}

