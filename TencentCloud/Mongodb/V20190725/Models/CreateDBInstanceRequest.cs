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

    public class CreateDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// - 创建副本集实例，指每个副本集内主从节点数量。每个副本集所支持的最大节点数与最小节点数，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
        /// - 创建分片集群实例，指每个分片的主从节点数量。每个分片所支持的最大节点数与最小节点数，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 实例内存大小，单位：GB。具体售卖的内存规格，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 实例硬盘大小，单位：GB。每一个 CPU 规格对应的最大磁盘与最小磁盘范围，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// 指版本信息。具体支持的版本信息 ，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
        /// - MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本。
        /// - MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本。
        /// - MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。
        /// - MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。
        /// - MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。
        /// - MONGO_60_WT：MongoDB 6.0 WiredTiger存储引擎版本。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 实例数量, 最小值1，最大值为10。
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// 可用区信息，输入格式如：ap-guangzhou-2。
        /// - 具体信息，请通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 获取。
        /// - 该参数为主可用区，如果多可用区部署，Zone必须是AvailabilityZoneList中的一个。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 指定购买实例的购买时长。取值可选：[1,2,3,4,5,6,7,8,9,10,11,12,24,36]；单位：月。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 产品规格类型。
        /// - HIO10G：通用高HIO万兆型。
        /// - HCD：云盘版类型。
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// 实例架构类型。
        /// - REPLSET：副本集。
        /// - SHARD：分片集群。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// - 创建副本集实例，指副本集数量，该参数只能为1。
        /// - 创建分片集群实例，指分片的数量。请通过接口[DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567)查询分片数量的取值范围，其返回的数据结构SpecItems中的参数MinReplicateSetNum与MaxReplicateSetNum分别对应其最小值与最大值。
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// 项目ID。
        /// - 若不设置该参数，则为默认项目。
        /// - 在 [MongoDB 控制台项目管理](https://console.cloud.tencent.com/project)页面，可获取项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 私有网络ID。如果不设置该参数，则默认选择基础网络。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网 ID，如果配置参数 VpcId，则 SubnetId必须配置。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例密码。自定义密码长度为8-32个字符，至少包含字母、数字和字符（!@#%^*()_）中的两种。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 实例标签信息。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 自动续费标记。
        /// - 0：不自动续费。
        /// - 1：自动续费。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 是否自动选择代金券。
        /// - 1：是。
        /// - 0：否。默认为0。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// 实例类型。- 1：正式实例。- 3：只读实例。- 4：灾备实例。-5：整实例克隆，注意：克隆实例时，RestoreTime为必填项。
        /// </summary>
        [JsonProperty("Clone")]
        public long? Clone{ get; set; }

        /// <summary>
        /// 父实例 ID。当参数**Clone**为3或者4时，即实例为只读或灾备实例时，该参数必须配置。
        /// </summary>
        [JsonProperty("Father")]
        public string Father{ get; set; }

        /// <summary>
        /// 安全组 ID。 
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// 克隆实例回档时间，当Clone取值为5或6时为必填。- 若为克隆实例，则必须配置该参数。输入格式示例：2021-08-13 16:30:00。- 回档时间范围：仅能回档7天内时间点的数据。
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// 实例名称。仅支持长度为60个字符的中文、英文、数字、下划线_、分隔符- 。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 若多可用区部署云数据库实例，指定多可用区列表。
        /// - 多可用区部署实例，参数 **Zone** 指定实例主可用区信息；**AvailabilityZoneList** 指定所有可用区信息，包含主可用区。输入格式如：[ap-guangzhou-2,ap-guangzhou-3,ap-guangzhou-4]。
        /// - 通过接口 [DescribeSpecInfo](https://cloud.tencent.com/document/product/240/38567) 可获取云数据库不同地域规划的可用区信息，以便指定有效的可用区。
        /// - 多可用区部署节点只能部署在3个不同可用区。不支持将集群的大多数节点部署在同一个可用区。例如：3节点集群不支持2个节点部署在同一个区。
        /// </summary>
        [JsonProperty("AvailabilityZoneList")]
        public string[] AvailabilityZoneList{ get; set; }

        /// <summary>
        /// Mongos CPU 核数，支持1、2、4、8、16。购买分片集群时，必须填写。
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// Mongos 内存大小。
        /// -  购买分片集群时，必须填写。
        /// - 单位：GB，支持1核2GB、2核4GB、4核8GB、8核16GB、16核32GB。
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// Mongos 数量。购买分片集群时，必须填写。
        /// - 单可用区部署实例，其数量范围为[3,32]。
        /// - 多可用区部署实例，其数量范围为[6,32]。
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }

        /// <summary>
        /// 只读节点数量，取值范围[0,5]。
        /// </summary>
        [JsonProperty("ReadonlyNodeNum")]
        public ulong? ReadonlyNodeNum{ get; set; }

        /// <summary>
        /// 指只读节点所属可用区数组。跨可用区部署实例，参数**ReadonlyNodeNum**不为**0**时，必须配置该参数。
        /// </summary>
        [JsonProperty("ReadonlyNodeAvailabilityZoneList")]
        public string[] ReadonlyNodeAvailabilityZoneList{ get; set; }

        /// <summary>
        /// Hidden节点所属可用区。跨可用区部署实例，必须配置该参数。
        /// </summary>
        [JsonProperty("HiddenZone")]
        public string HiddenZone{ get; set; }

        /// <summary>
        /// 参数模板 ID。参数模板是一组 MongoDB 的参数并为预设置了参数值的集合，将一组有相同诉求的参数及值 存为模板，在创建实例时，可直接引用参数值到新实例。合理使用参数模板，可以提高MongoDB数据库的效率。模板列表从 DescribeDBInstanceParamTpl 接口获取，注意模板支持的版本及实例类型。
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "Clone", this.Clone);
            this.SetParamSimple(map, prefix + "Father", this.Father);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "RestoreTime", this.RestoreTime);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "AvailabilityZoneList.", this.AvailabilityZoneList);
            this.SetParamSimple(map, prefix + "MongosCpu", this.MongosCpu);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamSimple(map, prefix + "MongosNodeNum", this.MongosNodeNum);
            this.SetParamSimple(map, prefix + "ReadonlyNodeNum", this.ReadonlyNodeNum);
            this.SetParamArraySimple(map, prefix + "ReadonlyNodeAvailabilityZoneList.", this.ReadonlyNodeAvailabilityZoneList);
            this.SetParamSimple(map, prefix + "HiddenZone", this.HiddenZone);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
        }
    }
}

