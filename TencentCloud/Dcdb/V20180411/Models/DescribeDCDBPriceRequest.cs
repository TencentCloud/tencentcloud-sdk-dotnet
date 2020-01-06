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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDCDBPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// 欲新购实例的可用区ID。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 欲购买实例的数量，目前只支持购买1个实例
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 欲购买的时长，单位：月。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 单个分片节点个数大小，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardNodeCount")]
        public long? ShardNodeCount{ get; set; }

        /// <summary>
        /// 分片内存大小，单位：GB，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// 分片存储空间大小，单位：GB，可以通过 DescribeShardSpec
        ///  查询实例规格获得。
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }

        /// <summary>
        /// 实例分片个数，可选范围2-8，可以通过升级实例进行新增分片到最多64个分片。
        /// </summary>
        [JsonProperty("ShardCount")]
        public long? ShardCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "ShardNodeCount", this.ShardNodeCount);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
        }
    }
}

