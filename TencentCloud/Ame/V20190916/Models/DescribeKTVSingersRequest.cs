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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKTVSingersRequest : AbstractModel
    {
        
        /// <summary>
        /// 歌手id集合，精确匹配歌手id
        /// <li> 数组长度限制10</li>
        /// </summary>
        [JsonProperty("SingerIds")]
        public string[] SingerIds{ get; set; }

        /// <summary>
        /// 歌手性别集合，不传为全部，精确匹配歌手性别类型，
        /// <li>数组长度限制1</li>
        /// <li>取值范围：直播互动曲库歌手分类信息接口，返回性别分类信息列表中，分类英文名</li>
        /// </summary>
        [JsonProperty("Genders")]
        public string[] Genders{ get; set; }

        /// <summary>
        /// 歌手区域集合，不传为全部，精确匹配歌手区域
        /// <li>数组长度限制10</li>
        /// <li>取值范围：直播互动曲库歌手分类信息接口，返回的区域分类信息列表中，分类英文名</li>
        /// </summary>
        [JsonProperty("Areas")]
        public string[] Areas{ get; set; }

        /// <summary>
        /// 排序方式。默认按照播放数倒序
        /// <li> Sort.Field 可选 PlayCount。</li>
        /// </summary>
        [JsonProperty("Sort")]
        public SortBy Sort{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页返回的记录条数，默认值：50。将返回第 Offset 到第 Offset+Limit-1 条。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SingerIds.", this.SingerIds);
            this.SetParamArraySimple(map, prefix + "Genders.", this.Genders);
            this.SetParamArraySimple(map, prefix + "Areas.", this.Areas);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

