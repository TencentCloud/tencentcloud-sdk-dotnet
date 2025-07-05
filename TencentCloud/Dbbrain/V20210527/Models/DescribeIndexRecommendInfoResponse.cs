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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIndexRecommendInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 索引推荐的集合数量。
        /// </summary>
        [JsonProperty("CollectionNum")]
        public long? CollectionNum{ get; set; }

        /// <summary>
        /// 索引推荐的索引数量。
        /// </summary>
        [JsonProperty("IndexNum")]
        public long? IndexNum{ get; set; }

        /// <summary>
        /// 索引项。
        /// </summary>
        [JsonProperty("Items")]
        public MongoDBIndex[] Items{ get; set; }

        /// <summary>
        /// 优化级别，1-4，优先级从高到低。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 历史优化数。
        /// </summary>
        [JsonProperty("Optimized")]
        public long? Optimized{ get; set; }

        /// <summary>
        /// 累计优化条数。
        /// </summary>
        [JsonProperty("OptimizedCount")]
        public long? OptimizedCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CollectionNum", this.CollectionNum);
            this.SetParamSimple(map, prefix + "IndexNum", this.IndexNum);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Optimized", this.Optimized);
            this.SetParamSimple(map, prefix + "OptimizedCount", this.OptimizedCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

