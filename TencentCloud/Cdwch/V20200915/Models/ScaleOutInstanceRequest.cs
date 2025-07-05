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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleOutInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例唯一ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点类型，DATA：clickhouse节点，COMMON：为zookeeper节点
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 调整clickhouse节点数量
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// v_cluster分组，	
        /// 新增扩容节点将加入到已选择的v_cluster分组中，提交同步VIP生效.
        /// </summary>
        [JsonProperty("ScaleOutCluster")]
        public string ScaleOutCluster{ get; set; }

        /// <summary>
        /// 子网剩余ip数量，用于判断当前实例子网剩余ip数是否能扩容。需要根据实际填写
        /// </summary>
        [JsonProperty("UserSubnetIPNum")]
        public long? UserSubnetIPNum{ get; set; }

        /// <summary>
        /// 同步元数据节点IP （uip），扩容的时候必填
        /// </summary>
        [JsonProperty("ScaleOutNodeIp")]
        public string ScaleOutNodeIp{ get; set; }

        /// <summary>
        /// 缩容节点shard的节点IP （uip），其中ha集群需要主副节点ip都传入以逗号分隔，缩容的时候必填
        /// </summary>
        [JsonProperty("ReduceShardInfo")]
        public string[] ReduceShardInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "ScaleOutCluster", this.ScaleOutCluster);
            this.SetParamSimple(map, prefix + "UserSubnetIPNum", this.UserSubnetIPNum);
            this.SetParamSimple(map, prefix + "ScaleOutNodeIp", this.ScaleOutNodeIp);
            this.SetParamArraySimple(map, prefix + "ReduceShardInfo.", this.ReduceShardInfo);
        }
    }
}

