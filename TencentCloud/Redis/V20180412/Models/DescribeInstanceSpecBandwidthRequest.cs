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
        /// 指定实例 ID。例如：crs-xjhsdj****。请登录[Redis控制台](https://console.cloud.tencent.com/redis)在实例列表复制实例 ID。填写实例id或者规格，两者必选其一。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 分片大小，单位：MB
        /// </summary>
        [JsonProperty("ShardSize")]
        public long? ShardSize{ get; set; }

        /// <summary>
        /// 分片数量。
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// 复制组数量。
        /// </summary>
        [JsonProperty("ReplicateNum")]
        public long? ReplicateNum{ get; set; }

        /// <summary>
        /// 只读权重。
        /// - 100：开启从只读。
        /// - 0：关闭从只读。
        /// </summary>
        [JsonProperty("ReadOnlyWeight")]
        public long? ReadOnlyWeight{ get; set; }

        /// <summary>
        /// 实例类型，同 [CreateInstances](https://cloud.tencent.com/document/api/239/20026) 的Type。
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

