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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpecItem : AbstractModel
    {
        
        /// <summary>
        /// 规格信息标识。格式如：mongo.HIO10G.128g。由节点类型、规格类型、内存规格三部分组成。
        /// - 节点类型，如下所示。
        ///   - mongo：Mongod 节点。
        ///  - mongos：Mongos 节点。
        ///  - cfgstr：Configserver 节点。
        /// - 规格类型，如下所示。
        ///  - HIO10G：通用高HIO万兆型。
        ///  - HCD：云盘版类型。
        /// - 内存规格，如下所示：
        ///  - 支持4、8、16、32、64、128、240、512。
        ///  - 单位g：表示GB。128g则表示128GB。
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// 售卖规格有效标志，取值范围如下：
        /// - 0：停止售卖，
        /// - 1：开放售卖。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 计算资源规格，CPU核数。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存规格，单位为：MB。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 默认磁盘规格，单位为：MB。
        /// </summary>
        [JsonProperty("DefaultStorage")]
        public ulong? DefaultStorage{ get; set; }

        /// <summary>
        /// 最大磁盘规格，单位为：MB。
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// 最小磁盘规格，单位为：MB。
        /// </summary>
        [JsonProperty("MinStorage")]
        public ulong? MinStorage{ get; set; }

        /// <summary>
        /// 指每秒最大请求次数，单位为：次/秒。
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// 规格所支持的最大连接数限制。
        /// </summary>
        [JsonProperty("Conns")]
        public ulong? Conns{ get; set; }

        /// <summary>
        /// 实例存储引擎版本信息。
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本。
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本。
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// - MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。
        /// - MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。
        /// - MONGO_60_WT：MongoDB 6.0 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersionCode")]
        public string MongoVersionCode{ get; set; }

        /// <summary>
        /// 实例版本对应的数字版本。
        /// </summary>
        [JsonProperty("MongoVersionValue")]
        public ulong? MongoVersionValue{ get; set; }

        /// <summary>
        /// 实例版本信息。支持：3.6、4.2、4.4、5.0、6.0。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 存储引擎。
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// 集群类型，取值如下：
        /// - 1：分片集群。
        /// - 0：副本集集群。
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// 每个副本集最小节点数。
        /// </summary>
        [JsonProperty("MinNodeNum")]
        public ulong? MinNodeNum{ get; set; }

        /// <summary>
        /// 每个副本集最大节点数。
        /// </summary>
        [JsonProperty("MaxNodeNum")]
        public ulong? MaxNodeNum{ get; set; }

        /// <summary>
        /// 最小分片数。
        /// </summary>
        [JsonProperty("MinReplicateSetNum")]
        public ulong? MinReplicateSetNum{ get; set; }

        /// <summary>
        /// 最大分片数。
        /// </summary>
        [JsonProperty("MaxReplicateSetNum")]
        public ulong? MaxReplicateSetNum{ get; set; }

        /// <summary>
        /// 每个分片最小节点数。
        /// </summary>
        [JsonProperty("MinReplicateSetNodeNum")]
        public ulong? MinReplicateSetNodeNum{ get; set; }

        /// <summary>
        /// 每个分片最大节点数。
        /// </summary>
        [JsonProperty("MaxReplicateSetNodeNum")]
        public ulong? MaxReplicateSetNodeNum{ get; set; }

        /// <summary>
        /// 集群的规格类型，取值范围如下：
        /// - HIO10G：通用高HIO万兆型。
        /// - HCD：云盘版类型。
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "DefaultStorage", this.DefaultStorage);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "MinStorage", this.MinStorage);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Conns", this.Conns);
            this.SetParamSimple(map, prefix + "MongoVersionCode", this.MongoVersionCode);
            this.SetParamSimple(map, prefix + "MongoVersionValue", this.MongoVersionValue);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "MinNodeNum", this.MinNodeNum);
            this.SetParamSimple(map, prefix + "MaxNodeNum", this.MaxNodeNum);
            this.SetParamSimple(map, prefix + "MinReplicateSetNum", this.MinReplicateSetNum);
            this.SetParamSimple(map, prefix + "MaxReplicateSetNum", this.MaxReplicateSetNum);
            this.SetParamSimple(map, prefix + "MinReplicateSetNodeNum", this.MinReplicateSetNodeNum);
            this.SetParamSimple(map, prefix + "MaxReplicateSetNodeNum", this.MaxReplicateSetNodeNum);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
        }
    }
}

