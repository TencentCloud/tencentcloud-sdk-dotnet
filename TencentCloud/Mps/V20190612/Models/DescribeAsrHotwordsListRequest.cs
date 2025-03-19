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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAsrHotwordsListRequest : AbstractModel
    {
        
        /// <summary>
        /// 检索参数，根据热词库 id 查询
        /// </summary>
        [JsonProperty("HotwordsId")]
        public string HotwordsId{ get; set; }

        /// <summary>
        /// 检索参数，根据热词库名称查询
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认返回所有热词库
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 热词排序顺序
        /// 
        /// 0：升序（默认）
        /// 1：降序
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// 根据某个字段排序，默认使用创建时间，使用非法字段视为默认情况
        /// 
        /// - CreateTime：创建时间排序
        /// - UpdateTime：更新时间排序
        /// - Name：热词库名称排序
        /// - WordCount：热词数量排序
        /// - HotwordsId：热词库 id 排序
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 0 临时热词 1 文件热词
        /// </summary>
        [JsonProperty("Types")]
        public ulong?[] Types{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HotwordsId", this.HotwordsId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
        }
    }
}

