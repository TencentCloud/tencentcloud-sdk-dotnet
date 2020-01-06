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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShardInfo : AbstractModel
    {
        
        /// <summary>
        /// 分片已使用容量
        /// </summary>
        [JsonProperty("UsedVolume")]
        public float? UsedVolume{ get; set; }

        /// <summary>
        /// 分片ID
        /// </summary>
        [JsonProperty("ReplicaSetId")]
        public string ReplicaSetId{ get; set; }

        /// <summary>
        /// 分片名
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// 分片内存规格，单位为MB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 分片磁盘规格，单位为MB
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// 分片Oplog大小，单位为MB
        /// </summary>
        [JsonProperty("OplogSize")]
        public ulong? OplogSize{ get; set; }

        /// <summary>
        /// 分片从节点数
        /// </summary>
        [JsonProperty("SecondaryNum")]
        public ulong? SecondaryNum{ get; set; }

        /// <summary>
        /// 分片物理id
        /// </summary>
        [JsonProperty("RealReplicaSetId")]
        public string RealReplicaSetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsedVolume", this.UsedVolume);
            this.SetParamSimple(map, prefix + "ReplicaSetId", this.ReplicaSetId);
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "OplogSize", this.OplogSize);
            this.SetParamSimple(map, prefix + "SecondaryNum", this.SecondaryNum);
            this.SetParamSimple(map, prefix + "RealReplicaSetId", this.RealReplicaSetId);
        }
    }
}

