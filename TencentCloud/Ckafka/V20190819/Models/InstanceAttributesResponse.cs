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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceAttributesResponse : AbstractModel
    {
        
        /// <summary>
        /// ckafka集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// ckafka集群实例Name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 接入点 VIP 列表信息
        /// </summary>
        [JsonProperty("VipList")]
        public VipEntity[] VipList{ get; set; }

        /// <summary>
        /// 虚拟IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 虚拟端口
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// 实例的状态。0: 创建中，1: 运行中，2: 删除中,  3: 已删除,  5: 隔离中,  7: 升级中,  -1: 创建失败 
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例带宽，单位：Mbps
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 实例的存储大小，单位：GB
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// VPC 的 ID，为空表示是基础网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网 ID， 为空表示基础网络
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例健康状态， 1：健康，2：告警，3：异常
        /// </summary>
        [JsonProperty("Healthy")]
        public long? Healthy{ get; set; }

        /// <summary>
        /// 实例健康信息，当前会展示磁盘利用率，最大长度为256
        /// </summary>
        [JsonProperty("HealthyMessage")]
        public string HealthyMessage{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 消息保存时间,单位为分钟
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// 自动创建 Topic 配置， 若该字段为空，则表示未开启自动创建
        /// </summary>
        [JsonProperty("Config")]
        public InstanceConfigDO Config{ get; set; }

        /// <summary>
        /// 剩余创建分区数
        /// </summary>
        [JsonProperty("RemainderPartitions")]
        public long? RemainderPartitions{ get; set; }

        /// <summary>
        /// 剩余创建主题数
        /// </summary>
        [JsonProperty("RemainderTopics")]
        public long? RemainderTopics{ get; set; }

        /// <summary>
        /// 当前创建分区数
        /// </summary>
        [JsonProperty("CreatedPartitions")]
        public long? CreatedPartitions{ get; set; }

        /// <summary>
        /// 当前创建主题数
        /// </summary>
        [JsonProperty("CreatedTopics")]
        public long? CreatedTopics{ get; set; }

        /// <summary>
        /// 标签数组
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// ckafka集群实例版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 最大分组数
        /// </summary>
        [JsonProperty("MaxGroupNum")]
        public long? MaxGroupNum{ get; set; }

        /// <summary>
        /// 售卖类型,0:标准版,1:专业版
        /// </summary>
        [JsonProperty("Cvm")]
        public long? Cvm{ get; set; }

        /// <summary>
        /// 实例类型  枚举列表: 
        /// profession  :专业版    
        /// standards2  :标准版
        /// premium   :高级版
        /// serverless  :serverless版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 表示该实例支持的特性。FEATURE_SUBNET_ACL:表示acl策略支持设置子网。
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }

        /// <summary>
        /// 动态消息保留策略
        /// </summary>
        [JsonProperty("RetentionTimeConfig")]
        public DynamicRetentionTime RetentionTimeConfig{ get; set; }

        /// <summary>
        /// 最大连接数
        /// </summary>
        [JsonProperty("MaxConnection")]
        public ulong? MaxConnection{ get; set; }

        /// <summary>
        /// 公网带宽
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public long? PublicNetwork{ get; set; }

        /// <summary>
        /// 该字段已废弃,无实际含义
        /// </summary>
        [JsonProperty("DeleteRouteTimestamp")]
        public string DeleteRouteTimestamp{ get; set; }

        /// <summary>
        /// 剩余创建分区数
        /// </summary>
        [JsonProperty("RemainingPartitions")]
        public long? RemainingPartitions{ get; set; }

        /// <summary>
        /// 剩余创建主题数
        /// </summary>
        [JsonProperty("RemainingTopics")]
        public long? RemainingTopics{ get; set; }

        /// <summary>
        /// 动态硬盘扩容策略
        /// </summary>
        [JsonProperty("DynamicDiskConfig")]
        public DynamicDiskConfig DynamicDiskConfig{ get; set; }

        /// <summary>
        /// 实例计费类型  POSTPAID_BY_HOUR 按小时付费; PREPAID 包年包月
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 是否开启弹性带宽白名单   
        /// 1:已开启弹性带宽白名单;
        /// 0:未开启弹性带宽白名单;
        /// </summary>
        [JsonProperty("ElasticBandwidthSwitch")]
        public long? ElasticBandwidthSwitch{ get; set; }

        /// <summary>
        /// 弹性带宽开通状态
        /// 1:未开启弹性带宽;
        /// 16: 开启弹性带宽中;
        /// 32:开启弹性带宽成功;
        /// 33:关闭弹性带宽中;
        /// 34:关闭弹性带宽成功;
        /// 64:开启弹性带宽失败;
        /// 65:关闭弹性带宽失败;
        /// </summary>
        [JsonProperty("ElasticBandwidthOpenStatus")]
        public long? ElasticBandwidthOpenStatus{ get; set; }

        /// <summary>
        /// 集群类型  
        /// CLOUD_IDC IDC集群
        /// CLOUD_CVM_SHARE CVM共享集群
        /// CLOUD_CVM_YUNTI 云梯CVM集群
        /// CLOUD_CVM    CVM集群
        /// CLOUD_CDC CDC集群
        /// CLOUD_EKS_TSE EKS集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 免费分区数量
        /// </summary>
        [JsonProperty("FreePartitionNumber")]
        public long? FreePartitionNumber{ get; set; }

        /// <summary>
        /// 弹性带宽上浮值
        /// </summary>
        [JsonProperty("ElasticFloatBandwidth")]
        public long? ElasticFloatBandwidth{ get; set; }

        /// <summary>
        /// ssl自定义证书id  仅自定义证书实例集群返回
        /// </summary>
        [JsonProperty("CustomCertId")]
        public string CustomCertId{ get; set; }

        /// <summary>
        /// 集群topic默认 unclean.leader.election.enable配置: 1 开启 0 关闭
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// 实例删除保护开关: 1 开启 0 关闭
        /// </summary>
        [JsonProperty("DeleteProtectionEnable")]
        public long? DeleteProtectionEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArrayObj(map, prefix + "VipList.", this.VipList);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "HealthyMessage", this.HealthyMessage);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "RemainderPartitions", this.RemainderPartitions);
            this.SetParamSimple(map, prefix + "RemainderTopics", this.RemainderTopics);
            this.SetParamSimple(map, prefix + "CreatedPartitions", this.CreatedPartitions);
            this.SetParamSimple(map, prefix + "CreatedTopics", this.CreatedTopics);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "MaxGroupNum", this.MaxGroupNum);
            this.SetParamSimple(map, prefix + "Cvm", this.Cvm);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
            this.SetParamObj(map, prefix + "RetentionTimeConfig.", this.RetentionTimeConfig);
            this.SetParamSimple(map, prefix + "MaxConnection", this.MaxConnection);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "DeleteRouteTimestamp", this.DeleteRouteTimestamp);
            this.SetParamSimple(map, prefix + "RemainingPartitions", this.RemainingPartitions);
            this.SetParamSimple(map, prefix + "RemainingTopics", this.RemainingTopics);
            this.SetParamObj(map, prefix + "DynamicDiskConfig.", this.DynamicDiskConfig);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ElasticBandwidthSwitch", this.ElasticBandwidthSwitch);
            this.SetParamSimple(map, prefix + "ElasticBandwidthOpenStatus", this.ElasticBandwidthOpenStatus);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "FreePartitionNumber", this.FreePartitionNumber);
            this.SetParamSimple(map, prefix + "ElasticFloatBandwidth", this.ElasticFloatBandwidth);
            this.SetParamSimple(map, prefix + "CustomCertId", this.CustomCertId);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "DeleteProtectionEnable", this.DeleteProtectionEnable);
        }
    }
}

