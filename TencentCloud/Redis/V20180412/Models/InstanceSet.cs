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

    public class InstanceSet : AbstractModel
    {
        
        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 用户APPID。APPID是与账号ID有唯一对应关系的应用 ID，部分腾讯云产品会使用此 APPID。
        /// </summary>
        [JsonProperty("Appid")]
        public long? Appid{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 地域 ID。<ul><li>1：广州。</li><li>4：上海。</li><li>5：中国香港。</li><li>7：上海金融。</li> <li>8：北京。</li> <li>9：新加坡。</li> <li>11：深圳金融。</li> <li>15：美西（硅谷）。</li><li>16：成都。</li><li>17：法兰克福。</li><li>18：首尔。</li><li>19：重庆。</li><li>21：孟买。</li><li>22：美东（弗吉尼亚）。</li><li>23：曼谷。</li><li>25：东京。</li></ul>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 区域 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// vpc网络 ID，例如75101。
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// vpc网络下子网ID，如：46315。
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// 实例当前状态。<ul><li>0：待初始化。</li><li>1：实例在流程中。</li><li>2：实例运行中。</li><li>-2：实例已隔离。</li><li>-3：实例待删除。</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例 VIP。
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 实例端口号。
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 实例创建时间。格式如：2020-01-15 10:20:00。
        /// </summary>
        [JsonProperty("Createtime")]
        public string Createtime{ get; set; }

        /// <summary>
        /// 实例内存容量大小。单位：MB，1MB=1024KB。
        /// </summary>
        [JsonProperty("Size")]
        public float? Size{ get; set; }

        /// <summary>
        /// 该字段已废弃。请使用腾讯云可观测平台API 接口 [GetMonitorData](https://cloud.tencent.com/document/product/248/31014) 获取实例已使用的内存容量。
        /// </summary>
        [JsonProperty("SizeUsed")]
        public float? SizeUsed{ get; set; }

        /// <summary>
        /// 实例类型。
        /// - 2：Redis 2.8 内存版（标准架构）。
        /// - 3：CKV 3.2 内存版（标准架构）。
        /// - 4：CKV 3.2 内存版（集群架构）。
        /// - 5：Redis 2.8 内存版（单机）。
        /// - 6：Redis 4.0 内存版（标准架构）。
        /// - 7：Redis 4.0 内存版（集群架构）。
        /// - 8：Redis 5.0 内存版（标准架构）。
        /// - 9：Redis 5.0 内存版（集群架构）。
        /// - 15：Redis 6.2 内存版（标准架构）。
        /// - 16：Redis 6.2 内存版（集群架构）。
        /// - 17：Redis 7.0 内存版（标准架构）。
        /// - 18：Redis 7.0 内存版（集群架构）。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 实例是否设置自动续费标识。<ul><li>1：设置自动续费。</li><li>0：未设置自动续费。</li></ul>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 包年包月计费实例到期的时间。
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// 引擎：社区版Redis、腾讯云CKV。
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 产品类型。<ul><li>standalone：标准版。</li><li>cluster ：集群版。</li></ul>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// vpc网络id，例如vpc-fk33jsf43kgv。
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// vpc网络下子网id，例如：subnet-fd3j6l35mm0。
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 计费模式。<ul><li>0：按量计费。</li><li>1：包年包月。</li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public long? BillingMode{ get; set; }

        /// <summary>
        /// 实例运行状态描述：如”实例运行中“。
        /// </summary>
        [JsonProperty("InstanceTitle")]
        public string InstanceTitle{ get; set; }

        /// <summary>
        /// 已隔离实例默认下线时间。按量计费实例隔离后默认两小时后下线，包年包月默认7天后下线。格式如：2020-02-15 10:20:00。
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// 流程中的实例返回的子状态。
        /// - 0：磁盘读写状态。
        /// - 1：磁盘超限只读状态。
        /// </summary>
        [JsonProperty("SubStatus")]
        public long? SubStatus{ get; set; }

        /// <summary>
        /// 反亲和性标签。
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 实例节点信息。
        /// </summary>
        [JsonProperty("InstanceNode")]
        public InstanceNode[] InstanceNode{ get; set; }

        /// <summary>
        /// 分片大小。
        /// </summary>
        [JsonProperty("RedisShardSize")]
        public long? RedisShardSize{ get; set; }

        /// <summary>
        /// 分片数量。
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// 副本数量。
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public long? RedisReplicasNum{ get; set; }

        /// <summary>
        /// 计费 ID。
        /// </summary>
        [JsonProperty("PriceId")]
        public long? PriceId{ get; set; }

        /// <summary>
        /// 实例隔离开始的时间。
        /// </summary>
        [JsonProperty("CloseTime")]
        public string CloseTime{ get; set; }

        /// <summary>
        /// 从节点读取权重。
        /// </summary>
        [JsonProperty("SlaveReadWeight")]
        public long? SlaveReadWeight{ get; set; }

        /// <summary>
        /// 实例关联的标签信息。
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTagInfo[] InstanceTags{ get; set; }

        /// <summary>
        /// 项目名称。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 是否为免密实例。<ul><li>true：免密实例。</li><li>false：非免密实例。</li></ul>
        /// </summary>
        [JsonProperty("NoAuth")]
        public bool? NoAuth{ get; set; }

        /// <summary>
        /// 客户端连接数。
        /// </summary>
        [JsonProperty("ClientLimit")]
        public long? ClientLimit{ get; set; }

        /// <summary>
        /// DTS状态（内部参数，用户可忽略）。
        /// </summary>
        [JsonProperty("DtsStatus")]
        public long? DtsStatus{ get; set; }

        /// <summary>
        /// 分片带宽上限，单位MB。
        /// </summary>
        [JsonProperty("NetLimit")]
        public long? NetLimit{ get; set; }

        /// <summary>
        /// 免密实例标识（内部参数，用户可忽略）。
        /// </summary>
        [JsonProperty("PasswordFree")]
        public long? PasswordFree{ get; set; }

        /// <summary>
        /// 该参数存在命名不规范问题，建议用参数IPv6取代。内部参数，用户可忽略。
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// 内部参数，用户可忽略。
        /// </summary>
        [JsonProperty("IPv6")]
        public string IPv6{ get; set; }

        /// <summary>
        /// 实例只读标识（内部参数，用户可忽略）。
        /// </summary>
        [JsonProperty("ReadOnly")]
        public long? ReadOnly{ get; set; }

        /// <summary>
        /// 内部参数，用户可忽略。
        /// </summary>
        [JsonProperty("RemainBandwidthDuration")]
        public string RemainBandwidthDuration{ get; set; }

        /// <summary>
        /// Redis实例请忽略该参数。
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 监控版本。<ul><li>1m：1分钟粒度监控。目前该监控粒度已下线，具体信息，请参见[云数据库 Redis 1分钟粒度下线公告](https://cloud.tencent.com/document/product/239/80653)。</li><li>5s：5秒粒度监控。</li></ul>
        /// </summary>
        [JsonProperty("MonitorVersion")]
        public string MonitorVersion{ get; set; }

        /// <summary>
        /// 客户端最大连接数可设置的最小值。
        /// </summary>
        [JsonProperty("ClientLimitMin")]
        public long? ClientLimitMin{ get; set; }

        /// <summary>
        /// 客户端最大连接数可设置的最大值。
        /// </summary>
        [JsonProperty("ClientLimitMax")]
        public long? ClientLimitMax{ get; set; }

        /// <summary>
        /// 实例的节点详细信息。
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// 实例所在的地域信息，比如ap-guangzhou。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 外网地址。
        /// </summary>
        [JsonProperty("WanAddress")]
        public string WanAddress{ get; set; }

        /// <summary>
        /// 北极星服务地址，内部使用。
        /// </summary>
        [JsonProperty("PolarisServer")]
        public string PolarisServer{ get; set; }

        /// <summary>
        /// CDC Redis集群ID。
        /// </summary>
        [JsonProperty("RedisClusterId")]
        public string RedisClusterId{ get; set; }

        /// <summary>
        /// CDC 集群ID。
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// 产品版本。<ul><li>local：本地盘。</li><li>cloud：云盘版。</li><li>cdc：CDC 集群版本。</li></ul>
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }

        /// <summary>
        /// 实例当前Proxy版本。
        /// </summary>
        [JsonProperty("CurrentProxyVersion")]
        public string CurrentProxyVersion{ get; set; }

        /// <summary>
        /// 实例当前Cache小版本。如果实例加入全球复制组，显示全球复制的内核版本。
        /// </summary>
        [JsonProperty("CurrentRedisVersion")]
        public string CurrentRedisVersion{ get; set; }

        /// <summary>
        /// 实例可升级Proxy版本。
        /// </summary>
        [JsonProperty("UpgradeProxyVersion")]
        public string UpgradeProxyVersion{ get; set; }

        /// <summary>
        /// 实例可升级Cache小版本。
        /// </summary>
        [JsonProperty("UpgradeRedisVersion")]
        public string UpgradeRedisVersion{ get; set; }

        /// <summary>
        /// 备份模式：- SecondLevelBackup   秒级备份- NormalLevelBackup    普通备份
        /// </summary>
        [JsonProperty("BackupMode")]
        public string BackupMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Createtime", this.Createtime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "SizeUsed", this.SizeUsed);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "InstanceTitle", this.InstanceTitle);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "InstanceNode.", this.InstanceNode);
            this.SetParamSimple(map, prefix + "RedisShardSize", this.RedisShardSize);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "PriceId", this.PriceId);
            this.SetParamSimple(map, prefix + "CloseTime", this.CloseTime);
            this.SetParamSimple(map, prefix + "SlaveReadWeight", this.SlaveReadWeight);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "NoAuth", this.NoAuth);
            this.SetParamSimple(map, prefix + "ClientLimit", this.ClientLimit);
            this.SetParamSimple(map, prefix + "DtsStatus", this.DtsStatus);
            this.SetParamSimple(map, prefix + "NetLimit", this.NetLimit);
            this.SetParamSimple(map, prefix + "PasswordFree", this.PasswordFree);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "IPv6", this.IPv6);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "RemainBandwidthDuration", this.RemainBandwidthDuration);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MonitorVersion", this.MonitorVersion);
            this.SetParamSimple(map, prefix + "ClientLimitMin", this.ClientLimitMin);
            this.SetParamSimple(map, prefix + "ClientLimitMax", this.ClientLimitMax);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "WanAddress", this.WanAddress);
            this.SetParamSimple(map, prefix + "PolarisServer", this.PolarisServer);
            this.SetParamSimple(map, prefix + "RedisClusterId", this.RedisClusterId);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
            this.SetParamSimple(map, prefix + "CurrentProxyVersion", this.CurrentProxyVersion);
            this.SetParamSimple(map, prefix + "CurrentRedisVersion", this.CurrentRedisVersion);
            this.SetParamSimple(map, prefix + "UpgradeProxyVersion", this.UpgradeProxyVersion);
            this.SetParamSimple(map, prefix + "UpgradeRedisVersion", this.UpgradeRedisVersion);
            this.SetParamSimple(map, prefix + "BackupMode", this.BackupMode);
        }
    }
}

