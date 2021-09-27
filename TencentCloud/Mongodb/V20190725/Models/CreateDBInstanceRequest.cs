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
        /// 每个副本集内节点个数，具体参照查询云数据库的售卖规格返回参数
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

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
        /// 版本号，具体支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果。参数与版本对应关系是MONGO_3_WT：MongoDB 3.2 WiredTiger存储引擎版本，MONGO_3_ROCKS：MongoDB 3.2 RocksDB存储引擎版本，MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本，MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本，MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 实例数量, 最小值1，最大值为10
        /// </summary>
        [JsonProperty("GoodsNum")]
        public ulong? GoodsNum{ get; set; }

        /// <summary>
        /// 实例所属区域名称，格式如：ap-guangzhou-2。注：此参数填写的是主可用区，如果选择多可用区部署，Zone必须是AvailabilityZoneList中的一个
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例时长，单位：月，可选值包括 [1,2,3,4,5,6,7,8,9,10,11,12,24,36]
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 机器类型，HIO：高IO型；HIO10G：高IO万兆型；STDS5：标准型
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }

        /// <summary>
        /// 实例类型，REPLSET-副本集，SHARD-分片集群，STANDALONE-单节点
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 副本集个数，创建副本集实例时，该参数必须设置为1；创建分片实例时，具体参照查询云数据库的售卖规格返回参数；若为单节点实例，该参数设置为0
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// 项目ID，不设置为默认项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 私有网络 ID，如果不传则默认选择基础网络，请使用 查询私有网络列表
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络下的子网 ID，如果设置了 UniqVpcId，则 UniqSubnetId 必填，请使用 查询子网列表
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例密码，不设置该参数则默认密码规则为 实例ID+"@"+主账户uin。举例实例id为cmgo-higv73ed，uin为100000001，则默认密码为"cmgo-higv73ed@100000001"。密码必须是8-16位字符，且至少包含字母、数字和字符 !@#%^*() 中的两种
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 实例标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 自动续费标记，可选值为：0 - 不自动续费；1 - 自动续费。默认为不自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 是否自动选择代金券，可选值为：1 - 是；0 - 否； 默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// 1:正式实例,2:临时实例,3:只读实例,4:灾备实例,5:克隆实例
        /// </summary>
        [JsonProperty("Clone")]
        public long? Clone{ get; set; }

        /// <summary>
        /// 若是只读，灾备实例或克隆实例，Father必须填写，即主实例ID
        /// </summary>
        [JsonProperty("Father")]
        public string Father{ get; set; }

        /// <summary>
        /// 安全组
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// 克隆实例回档时间。若是克隆实例，则必须填写，格式：2021-08-13 16:30:00。注：只能回档7天内的时间点
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }

        /// <summary>
        /// 实例名称。注：名称只支持长度为60个字符的中文、英文、数字、下划线_、分隔符-
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 多可用区部署的节点列表，具体支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果。注：1、多可用区部署节点只能部署在3个不同可用区；2、为了保障跨可用区切换，不支持将集群的大多数节点部署在同一个可用区（如3节点集群不支持2个节点部署在同一个区）；3、不支持4.2及以上版本；4、不支持只读灾备实例；5、不能选择基础网络
        /// </summary>
        [JsonProperty("AvailabilityZoneList")]
        public string[] AvailabilityZoneList{ get; set; }

        /// <summary>
        /// mongos cpu数量，购买MongoDB 4.2 WiredTiger存储引擎版本的分片集群时必须填写，具体支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果
        /// </summary>
        [JsonProperty("MongosCpu")]
        public ulong? MongosCpu{ get; set; }

        /// <summary>
        /// mongos 内存大小，购买MongoDB 4.2 WiredTiger存储引擎版本的分片集群时必须填写，具体支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果
        /// </summary>
        [JsonProperty("MongosMemory")]
        public ulong? MongosMemory{ get; set; }

        /// <summary>
        /// mongos 数量，购买MongoDB 4.2 WiredTiger存储引擎版本的分片集群时必须填写，具体支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果。注：为了保障高可用，最低需要购买3个mongos，上限为32个
        /// </summary>
        [JsonProperty("MongosNodeNum")]
        public ulong? MongosNodeNum{ get; set; }


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
        }
    }
}

