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

    public class ShardBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// 分片SerialId
        /// </summary>
        [JsonProperty("ShardSerialId")]
        public string ShardSerialId{ get; set; }

        /// <summary>
        /// 分片ID，形如shard-7vg1o339
        /// </summary>
        [JsonProperty("ShardInstanceId")]
        public string ShardInstanceId{ get; set; }

        /// <summary>
        /// 分片运行状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 分片运行状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 分片创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 分片内存大小，单位GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 分片磁盘大小，单位GB
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 分片日志磁盘空间大小，单位GB
        /// </summary>
        [JsonProperty("LogDisk")]
        public long? LogDisk{ get; set; }

        /// <summary>
        /// 分片节点个数
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 分片磁盘空间使用率
        /// </summary>
        [JsonProperty("StorageUsage")]
        public float? StorageUsage{ get; set; }

        /// <summary>
        /// 分片Proxy版本信息
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// 分片主DB可用区
        /// </summary>
        [JsonProperty("ShardMasterZone")]
        public string ShardMasterZone{ get; set; }

        /// <summary>
        /// 分片从DB可用区
        /// </summary>
        [JsonProperty("ShardSlaveZones")]
        public string[] ShardSlaveZones{ get; set; }

        /// <summary>
        /// 分片Cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// DB节点信息
        /// </summary>
        [JsonProperty("NodesInfo")]
        public NodeInfo[] NodesInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShardSerialId", this.ShardSerialId);
            this.SetParamSimple(map, prefix + "ShardInstanceId", this.ShardInstanceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "LogDisk", this.LogDisk);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "StorageUsage", this.StorageUsage);
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "ShardMasterZone", this.ShardMasterZone);
            this.SetParamArraySimple(map, prefix + "ShardSlaveZones.", this.ShardSlaveZones);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamArrayObj(map, prefix + "NodesInfo.", this.NodesInfo);
        }
    }
}

