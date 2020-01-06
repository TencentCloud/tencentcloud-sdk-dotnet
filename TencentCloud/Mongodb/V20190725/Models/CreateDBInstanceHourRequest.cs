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

    public class CreateDBInstanceHourRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例内存大小，单位：GB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 实例硬盘大小，单位：GB
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// 副本集个数，创建副本集实例时，该参数必须设置为1；创建分片实例时，具体参照查询云数据库的售卖规格返回参数
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// 每个副本集内节点个数，当前副本集节点数固定为3，分片从节点数可选，具体参照查询云数据库的售卖规格返回参数
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 版本号，具体支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果。参数与版本对应关系是MONGO_3_WT：MongoDB 3.2 WiredTiger存储引擎版本，MONGO_3_ROCKS：MongoDB 3.2 RocksDB存储引擎版本，MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 机器类型，HIO：高IO型；HIO10G：高IO万兆
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// 实例数量，最小值1，最大值为10
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// 可用区信息，格式如：ap-guangzhou-2
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例类型，REPLSET-副本集，SHARD-分片集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 私有网络ID，如果不设置该参数则默认选择基础网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网ID，如果设置了 VpcId，则 SubnetId必填
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例密码，不设置该参数则需要在创建完成后通过设置密码接口初始化实例密码。密码必须是8-16位字符，且至少包含字母、数字和字符 !@#%^*() 中的两种
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 项目ID，不设置为默认项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 实例标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

