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

    public class CreateDedicatedClusterDCDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 分配实例个数
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 分片数量
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// 分片內存大小, 单位GB
        /// </summary>
        [JsonProperty("ShardMemory")]
        public long? ShardMemory{ get; set; }

        /// <summary>
        /// 分片磁盘大小, 单位GB
        /// </summary>
        [JsonProperty("ShardStorage")]
        public long? ShardStorage{ get; set; }

        /// <summary>
        /// 独享集群集群uuid
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// （废弃）可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// （废弃）cpu大小，单位：核
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// （废弃）分片机型
        /// </summary>
        [JsonProperty("ShardMachine")]
        public string ShardMachine{ get; set; }

        /// <summary>
        /// 分片的节点个数
        /// </summary>
        [JsonProperty("ShardNodeNum")]
        public long? ShardNodeNum{ get; set; }

        /// <summary>
        /// （废弃）节点cpu核数，单位：1/100核
        /// </summary>
        [JsonProperty("ShardNodeCpu")]
        public long? ShardNodeCpu{ get; set; }

        /// <summary>
        /// （废弃）节点內存大小，单位：GB
        /// </summary>
        [JsonProperty("ShardNodeMemory")]
        public long? ShardNodeMemory{ get; set; }

        /// <summary>
        /// （废弃）节点磁盘大小，单位：GB
        /// </summary>
        [JsonProperty("ShardNodeStorage")]
        public long? ShardNodeStorage{ get; set; }

        /// <summary>
        /// db版本
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// DCN源实例ID
        /// </summary>
        [JsonProperty("DcnInstanceId")]
        public string DcnInstanceId{ get; set; }

        /// <summary>
        /// DCN源实例地域名
        /// </summary>
        [JsonProperty("DcnRegion")]
        public string DcnRegion{ get; set; }

        /// <summary>
        /// 自定义实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// 支持IPv6标志：1 支持， 0 不支持
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public long? Ipv6Flag{ get; set; }

        /// <summary>
        /// （废弃）Pid，可通过获取独享集群售卖配置接口得到
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// 参数列表。本接口的可选值为：character_set_server（字符集，必传），lower_case_table_names（表名大小写敏感，必传，0 - 敏感；1-不敏感），innodb_page_size（innodb数据页，默认16K），sync_mode（同步模式：0 - 异步； 1 - 强同步；2 - 强同步可退化。默认为强同步可退化）。
        /// </summary>
        [JsonProperty("InitParams")]
        public DBParamValue InitParams{ get; set; }

        /// <summary>
        /// 指定主节点uuid，不填随机分配
        /// </summary>
        [JsonProperty("MasterHostId")]
        public string MasterHostId{ get; set; }

        /// <summary>
        /// 指定从节点uuid，不填随机分配
        /// </summary>
        [JsonProperty("SlaveHostIds")]
        public string[] SlaveHostIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ShardMemory", this.ShardMemory);
            this.SetParamSimple(map, prefix + "ShardStorage", this.ShardStorage);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ShardMachine", this.ShardMachine);
            this.SetParamSimple(map, prefix + "ShardNodeNum", this.ShardNodeNum);
            this.SetParamSimple(map, prefix + "ShardNodeCpu", this.ShardNodeCpu);
            this.SetParamSimple(map, prefix + "ShardNodeMemory", this.ShardNodeMemory);
            this.SetParamSimple(map, prefix + "ShardNodeStorage", this.ShardNodeStorage);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamSimple(map, prefix + "DcnInstanceId", this.DcnInstanceId);
            this.SetParamSimple(map, prefix + "DcnRegion", this.DcnRegion);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamSimple(map, prefix + "MasterHostId", this.MasterHostId);
            this.SetParamArraySimple(map, prefix + "SlaveHostIds.", this.SlaveHostIds);
        }
    }
}

