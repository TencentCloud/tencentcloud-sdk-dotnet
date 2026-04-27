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

    public class CreateDBInstanceHourRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例内存大小，单位：GB。具体售卖的内存规格，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>实例硬盘大小，单位：GB。每一个 CPU 规格对应的最大磁盘与最小磁盘范围，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。</p>
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// <ul><li>创建副本集实例，指副本集数量，该参数只能为1。</li><li>创建分片集群实例，指分片的数量。请通过接口<a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a>查询分片数量的取值范围，其返回的数据结构SpecItems中的参数MinReplicateSetNum与MaxReplicateSetNum分别对应其最小值与最大值。</li></ul>
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// <ul><li>创建副本集实例，指每个副本集内主从节点数量。每个副本集所支持的最大节点数与最小节点数，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。</li><li>创建分片集群实例，指每个分片的主从节点数量。每个分片所支持的最大节点数与最小节点数，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。</li></ul>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>指版本信息。具体支持的版本信息 ，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。</p><ul><li>MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本。</li><li>MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。</li><li>MONGO_44_WT：MongoDB 4.4 WiredTiger存储引擎版本。</li><li>MONGO_50_WT：MongoDB 5.0 WiredTiger存储引擎版本。</li><li>MONGO_60_WT：MongoDB 6.0 WiredTiger存储引擎版本。</li><li>MONGO_70_WT：MongoDB 7.0 WiredTiger存储引擎版本。</li><li>MONGO_80_WT：MongoDB 8.0 WiredTiger存储引擎版本。</li></ul>
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// <p>产品推荐规格类型：</p><ul><li>GE.LD.T1：本地盘（通用I型）。</li><li>GE.CD.T1：云盘（通用I型）。</li></ul><p>产品白名单规格类型：</p><ul><li>HIO10G：本地盘（高IO万兆型）。</li><li>HCD：云盘（云盘版）。</li></ul><p>注意：白名单规格类型为白名单控制，如若需要，请 <a href="https://console.cloud.tencent.com/workorder/category">提交工单</a> 申请</p>
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// <p>实例数量，最小值1，最大值为30。</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// <p>可用区信息，输入格式如：ap-guangzhou-2。</p><ul><li>具体信息，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。</li><li>该参数为主可用区，如果多可用区部署，Zone必须是AvailabilityZoneList中的一个。</li></ul>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>实例架构类型。</p><ul><li>REPLSET：副本集。</li><li>SHARD：分片集群。</li></ul>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>私有网络ID。</p><ul><li>仅支持配置私有网络，必须选择一个与实例同一地域的私有网络。请登录<a href="https://console.cloud.tencent.com/vpc">私有网络控制台</a>获取可使用的私有网络 ID。</li><li>实例创建成功之后，支持更换私有网络。具体操作，请参见<a href="https://cloud.tencent.com/document/product/239/30910">更换网络</a>。</li></ul>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>私有网络 VPC 的子网 ID。</p><ul><li>必须在已选的私有网络内指定一个子网。请登录<a href="https://console.cloud.tencent.com/vpc">私有网络控制台</a>获取可使用的子网 ID。</li><li>实例创建成功之后，支持更换私有网络及子网。具体操作，请参见<a href="https://cloud.tencent.com/document/product/239/30910">更换网络</a>。</li></ul>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>实例密码。设置要求如下：</p><ul><li>字符个数为[8,32]。</li><li>可输入[A,Z]、[a,z]、[0,9]范围内的字符。</li><li>可输入的特殊字符包括：感叹号“!”，at“@”，警号“#”、百分号“%”、插入号“^”、星号“*”、括号“()”、下划线“_”。</li><li>不能设置单一的字母或者数字。</li></ul>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// <p>项目ID。</p><ul><li>若不设置该参数，则为默认项目。</li><li>在 <a href="https://console.cloud.tencent.com/project">MongoDB 控制台项目管理</a>页面，可获取项目ID。</li></ul>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>实例标签信息。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>实例类型。</p><ul><li>1：正式实例。</li><li>3：只读实例。</li><li>4：灾备实例。</li><li>5：克隆实例。注意：克隆实例 RestoreTime 为必填项。</li></ul>
        /// </summary>
        [JsonProperty("Clone")]
        public long? Clone{ get; set; }

        /// <summary>
        /// <p>父实例 ID。</p><ul><li>当参数<strong>Clone</strong>为3或者4时，即实例为只读或灾备实例时，该参数必须配置。</li><li>请登录 <a href="https://console.cloud.tencent.com/mongodb">MongoDB 控制台</a>在实例列表复制父实例 ID。</li></ul>
        /// </summary>
        [JsonProperty("Father")]
        public string Father{ get; set; }

        /// <summary>
        /// <p>安全组 ID。 请登录<a href="https://console.cloud.tencent.com/vpc/security-group">安全组控制台</a>页面获取与数据库实例同地域的安全组 ID。</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// <p>克隆实例回档时间。</p><ul><li>若为克隆实例，则必须配置该参数。输入格式示例：2021-08-13 16:30:00。</li><li>回档时间范围：仅能回档7天内时间点的数据。</li></ul>
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// <p>实例名称。仅支持长度为128个字符的中文、英文、数字、下划线_、分隔符-。批量购买数据库实例时，支持通过自定义命名模式串与数字后缀自动升序功能，高效设置实例名称。</p><ul><li>基础模式：前缀＋自动升序编号（默认从1开始），<strong>lnstanceName</strong>仅需自定义实例名称前缀，例如设置为：cmgo，设置购买数量为5，则购买后，实例名称依次分别为cmgo1、cmgo2、cmgo3、cmgo4、cmgo5。</li><li>自定义起始序号模式：前缀+｛R:x｝（x为自定义起始序号）。<strong>InstanceName</strong>需填写“前缀｛R:x｝”，例如：cmgo｛R:3｝，设置购买数量为5，则实例名称为cmgo3、cmgo4、cmgo5、cmgo6、cmgo7。</li><li>复合模式串：前缀1{R:x}+前缀2{R:y}+ ⋯+固定后缀，x与y分别为每一段前缀的起始序号。<strong>instanceName</strong>需填写复合模式串，例如：cmgo{R:10}_node{R:12}_db，设置批量购买数量为5，则实例名称为 cmgo10_node12_db, cmgo11_node13_db, cmgo12_node14_db, cmgo13_node15_db, cluster14_node16_db.</li></ul>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>若多可用区部署云数据库实例，指定多可用区列表。</p><ul><li>多可用区部署实例，参数 <strong>Zone</strong> 指定实例主可用区信息；<strong>AvailabilityZoneList</strong> 指定所有可用区信息，包含主可用区。输入格式如：[ap-guangzhou-2,ap-guangzhou-3,ap-guangzhou-4]。</li><li>通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 可获取云数据库不同地域规划的可用区信息，以便指定有效的可用区。</li><li>多可用区部署节点只能部署在3个不同可用区。不支持将集群的大多数节点部署在同一个可用区。例如：3节点集群不支持2个节点部署在同一个区。</li></ul>
        /// </summary>
        [JsonProperty("AvailabilityZoneList")]
        public string[] AvailabilityZoneList{ get; set; }

        /// <summary>
        /// <p>Mongos CPU 核数，支持1、2、4、8、16。购买分片集群时，必须填写。</p>
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// <p>Mongos 内存大小。</p><ul><li>购买分片集群时，必须填写。</li><li>单位：GB，支持1核2GB、2核4GB、4核8GB、8核16GB、16核32GB。</li></ul>
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// <p>Mongos 数量。购买分片集群时，必须填写。</p><ul><li>单可用区部署实例，其数量范围为[3,32]。</li><li>多可用区部署实例，其数量范围为[6,32]。</li></ul>
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }

        /// <summary>
        /// <p>只读节点数量，取值范围[0,5]。</p>
        /// </summary>
        [JsonProperty("ReadonlyNodeNum")]
        public ulong? ReadonlyNodeNum{ get; set; }

        /// <summary>
        /// <p>指只读节点所属可用区数组。跨可用区部署实例，参数<strong>ReadonlyNodeNum</strong>不为<strong>0</strong>时，必须配置该参数。</p>
        /// </summary>
        [JsonProperty("ReadonlyNodeAvailabilityZoneList")]
        public string[] ReadonlyNodeAvailabilityZoneList{ get; set; }

        /// <summary>
        /// <p>Hidden节点所属可用区。跨可用区部署实例，必须配置该参数。</p>
        /// </summary>
        [JsonProperty("HiddenZone")]
        public string HiddenZone{ get; set; }

        /// <summary>
        /// <p>参数模板 ID。</p><ul><li>参数模板是预置了特定参数值的集合，可用于快速配置新的 MongoDB 实例。合理使用参数模板，能有效提升数据库的部署效率与运行性能。</li><li>参数模板 ID 可通过 <a href="https://cloud.tencent.com/document/product/240/109155">DescribeDBInstanceParamTpl </a>接口获取。请选择与实例版本与架构所对应的参数模板 ID。</li></ul>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>实例CPU核大小，单位：C。具体售卖的CPU规格，请通过接口 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 获取。<br>注意：通用 I 型实例必须设置 CPU 大小。</p>
        /// </summary>
        [JsonProperty("CpuCore")]
        public long? CpuCore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "CpuCore", this.CpuCore);
        }
    }
}

