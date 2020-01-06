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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceClusterShard : AbstractModel
    {
        
        /// <summary>
        /// 分片节点名称
        /// </summary>
        [JsonProperty("ShardName")]
        public string ShardName{ get; set; }

        /// <summary>
        /// 分片节点Id
        /// </summary>
        [JsonProperty("ShardId")]
        public string ShardId{ get; set; }

        /// <summary>
        /// 角色
        /// </summary>
        [JsonProperty("Role")]
        public long? Role{ get; set; }

        /// <summary>
        /// Key数量
        /// </summary>
        [JsonProperty("Keys")]
        public long? Keys{ get; set; }

        /// <summary>
        /// slot信息
        /// </summary>
        [JsonProperty("Slots")]
        public string Slots{ get; set; }

        /// <summary>
        /// 使用容量
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 容量倾斜率
        /// </summary>
        [JsonProperty("StorageSlope")]
        public float? StorageSlope{ get; set; }

        /// <summary>
        /// 实例运行时节点Id
        /// </summary>
        [JsonProperty("Runid")]
        public string Runid{ get; set; }

        /// <summary>
        /// 服务状态：0-down；1-on
        /// </summary>
        [JsonProperty("Connected")]
        public long? Connected{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShardName", this.ShardName);
            this.SetParamSimple(map, prefix + "ShardId", this.ShardId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Keys", this.Keys);
            this.SetParamSimple(map, prefix + "Slots", this.Slots);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageSlope", this.StorageSlope);
            this.SetParamSimple(map, prefix + "Runid", this.Runid);
            this.SetParamSimple(map, prefix + "Connected", this.Connected);
        }
    }
}

