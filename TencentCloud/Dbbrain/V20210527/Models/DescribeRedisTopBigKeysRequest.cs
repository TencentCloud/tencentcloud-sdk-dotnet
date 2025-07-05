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

    public class DescribeRedisTopBigKeysRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 查询日期，如2021-05-27，最早可为前30天的日期。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值包括 "redis" - 云数据库 Redis。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 排序字段，取值包括Capacity - 内存，ItemCount - 元素数量，默认为Capacity。
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// key类型筛选条件，默认为不进行筛选，取值包括string, list, set, hash, sortedset, stream。
        /// </summary>
        [JsonProperty("KeyType")]
        public string KeyType{ get; set; }

        /// <summary>
        /// 查询数目，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 异步任务ID。当为空时，选择最近任务的ID。
        /// </summary>
        [JsonProperty("AsyncRequestId")]
        public long? AsyncRequestId{ get; set; }

        /// <summary>
        /// 分片节点序号列表。当列表为空时，选择所有分片节点。
        /// </summary>
        [JsonProperty("ShardIds")]
        public long?[] ShardIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "AsyncRequestId", this.AsyncRequestId);
            this.SetParamArraySimple(map, prefix + "ShardIds.", this.ShardIds);
        }
    }
}

