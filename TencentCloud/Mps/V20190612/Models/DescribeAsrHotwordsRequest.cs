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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAsrHotwordsRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要查询的热词库 id
        /// **注意：HotwordsId 与 Name 必须选择填写一个，如果同时填写，HotwordsId 优先级高于 Name**
        /// </summary>
        [JsonProperty("HotwordsId")]
        public string HotwordsId{ get; set; }

        /// <summary>
        /// 热词库名称，
        /// **注意：HotwordsId 与 Name 必须选择填写一个，如果同时填写，HotwordsId 优先级高于 Name**
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：10，最大值：100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 热词排序字段，目前可选值为
        /// 
        /// - Default：默认文件中的顺序
        /// - Weight：权重排序
        /// - Lexical：热词文本排序
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 热词排序顺序 0：升序（默认） 1：降序
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HotwordsId", this.HotwordsId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
        }
    }
}

