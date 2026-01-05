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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceSpecBandwidthRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定实例 ID。请登录 <a href="https://console.cloud.tencent.com/redis">Redis控制台</a> 在实例列表复制实例 ID。同时，InstanceId 与规格参数不能同时为空，至少提供一种。</p><ul><li>若仅指定 InstanceId：查询该实例当前规格的带宽。</li><li>若指定 InstanceId + 至少一个规格参数（ShardSize、ShardNum 或 ReplicateNum）：计算变更规格后的带宽。</li><li>若指定部分或所有规格参数（ShardSize、ShardNum、ReplicateNum 与 Type），而不指定 InstanceId：根据规格组合查询理论带宽。</li></ul>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>分片大小。单位：MB。</p>
        /// </summary>
        [JsonProperty("ShardSize")]
        public long? ShardSize{ get; set; }

        /// <summary>
        /// <p>分片数量。</p>
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// <p>复制组数量。</p>
        /// </summary>
        [JsonProperty("ReplicateNum")]
        public long? ReplicateNum{ get; set; }

        /// <summary>
        /// <p>只读权重。- 100：开启从只读。- 0：关闭从只读。</p>
        /// </summary>
        [JsonProperty("ReadOnlyWeight")]
        public long? ReadOnlyWeight{ get; set; }

        /// <summary>
        /// <p>实例类型，同 <a href="https://cloud.tencent.com/document/api/239/20026">CreateInstances</a> 的Type。</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ShardSize", this.ShardSize);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ReplicateNum", this.ReplicateNum);
            this.SetParamSimple(map, prefix + "ReadOnlyWeight", this.ReadOnlyWeight);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

