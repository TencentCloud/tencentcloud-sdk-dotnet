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

    public class InquirePriceCreateDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例所属区域及可用区信息。格式：ap-guangzhou-2。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 每个分片的主从节点数量。
        /// 取值范围：请通过接口[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询，其返回的数据结构SpecItems中的参数MinNodeNum与MaxNodeNum分别对应其最小值与最大值。
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// 实例内存大小。
        /// - 单位：GB。
        /// - 取值范围：请通过接口[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询，其返回的数据结构SpecItems中的参数CPU与Memory分别对应CPU核数与内存规格。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例硬盘大小。
        /// - 单位：GB。
        /// - 取值范围：请通过接口[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询，其返回的数据结构SpecItems中的参数MinStorage与MaxStorage分别对应其最小磁盘规格与最大磁盘规格。
        /// </summary>
        [JsonProperty("Volume")]
        public long? Volume{ get; set; }

        /// <summary>
        /// 实例版本信息。具体支持的版本，请通过接口[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询，其返回的数据结构SpecItems中的参数MongoVersionCode为实例所支持的版本信息。版本信息与版本号对应关系如下：
        /// - MONGO_3_WT：MongoDB 3.2 WiredTiger存储引擎版本。
        /// - MONGO_3_ROCKS：MongoDB 3.2 RocksDB存储引擎版本。
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本。
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本。
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// - MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。
        /// - MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 机器类型。
        /// - HIO：高IO型。
        /// - HIO10G：高IO万兆型。
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// 实例数量，取值范围为[1,10]。
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 实例类型。
        /// - REPLSET：副本集。
        /// - SHARD：分片集群。
        /// - STANDALONE：单节点。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 副本集个数。
        /// - 创建副本集实例时，该参数固定设置为1。
        /// - 创建分片集群时，指分片数量，请通过接口[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询，其返回的数据结构SpecItems中的参数MinReplicateSetNum与MaxReplicateSetNum分别对应其最小值与最大值。
        /// - 若为单节点实例，该参数固定设置为0。
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public long? ReplicateSetNum{ get; set; }

        /// <summary>
        /// 选择包年包月计费模式时，您需要设定购买实例的时长。即<b>InstanceChargeType</b>设定为<b>PREPAID</b>时，该参数必须配置。
        /// - 单位：月。
        /// - 可选值包括[1,2,3,4,5,6,7,8,9,10,11,12,24,36]。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 实例付费方式。
        /// - PREPAID：包年包月计费。
        /// - POSTPAID_BY_HOUR：按量计费。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 分片实例询价必填参数，指 Mongos CPU核数，取值范围为[1,16]。
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// 分片实例询价必填参数，指 Mongos 内存，取值范围为[2,32]，单位：GB。
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// 分片实例询价必填参数，指 Mongos 个数，取值范围为[3,32]。
        /// </summary>
        [JsonProperty("MongosNum")]
        public ulong? MongosNum{ get; set; }

        /// <summary>
        /// 分片实例询价必填参数，指 ConfigServer CPU核数，取值为1，单位：GB。
        /// </summary>
        [JsonProperty("ConfigServerCpu")]
        public ulong? ConfigServerCpu{ get; set; }

        /// <summary>
        /// 分片实例询价必填参数，指 ConfigServer 内存大小，取值为2，单位：GB。
        /// </summary>
        [JsonProperty("ConfigServerMemory")]
        public ulong? ConfigServerMemory{ get; set; }

        /// <summary>
        /// 分片实例询价必填参数，指 ConfigServer 磁盘大小，取值为 20，单位：GB。
        /// </summary>
        [JsonProperty("ConfigServerVolume")]
        public ulong? ConfigServerVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "MongosCpu", this.MongosCpu);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamSimple(map, prefix + "MongosNum", this.MongosNum);
            this.SetParamSimple(map, prefix + "ConfigServerCpu", this.ConfigServerCpu);
            this.SetParamSimple(map, prefix + "ConfigServerMemory", this.ConfigServerMemory);
            this.SetParamSimple(map, prefix + "ConfigServerVolume", this.ConfigServerVolume);
        }
    }
}

