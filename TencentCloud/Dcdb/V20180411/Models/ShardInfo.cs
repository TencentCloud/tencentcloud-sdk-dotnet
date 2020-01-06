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

    public class ShardInfo : AbstractModel
    {
        
        /// <summary>
        /// 分片ID
        /// </summary>
        [JsonProperty("ShardInstanceId")]
        public string ShardInstanceId{ get; set; }

        /// <summary>
        /// 分片Set ID
        /// </summary>
        [JsonProperty("ShardSerialId")]
        public string ShardSerialId{ get; set; }

        /// <summary>
        /// 状态：0 创建中，1 流程处理中， 2 运行中，3 分片未初始化，-2 分片已删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("Createtime")]
        public string Createtime{ get; set; }

        /// <summary>
        /// 内存大小，单位 GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 存储大小，单位 GB
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 分片数字ID
        /// </summary>
        [JsonProperty("ShardId")]
        public long? ShardId{ get; set; }

        /// <summary>
        /// 节点数，2 为一主一从， 3 为一主二从
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 产品类型 Id（过时字段，请勿依赖该值）
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShardInstanceId", this.ShardInstanceId);
            this.SetParamSimple(map, prefix + "ShardSerialId", this.ShardSerialId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Createtime", this.Createtime);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "ShardId", this.ShardId);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
        }
    }
}

