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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例目前运行状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 内网 IP 地址
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 内网端口
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 是否临时实例，0为否，非0为是
        /// </summary>
        [JsonProperty("IsTmp")]
        public long? IsTmp{ get; set; }

        /// <summary>
        /// 节点数，2为一主一从，3为一主二从
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 实例所在地域名称，如 ap-shanghai
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例所在可用区名称，如 ap-shanghai-1
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 字符串型的私有网络Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 字符串型的私有网络子网Id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 外网状态，0-未开通；1-已开通；2-关闭；3-开通中；4-关闭中
        /// </summary>
        [JsonProperty("WanStatus")]
        public long? WanStatus{ get; set; }

        /// <summary>
        /// 外网访问的域名，公网可解析
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// 外网 IP 地址，公网可访问
        /// </summary>
        [JsonProperty("WanVip")]
        public string WanVip{ get; set; }

        /// <summary>
        /// 外网端口
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// 实例所属项目 Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// TDSQL 版本信息
        /// </summary>
        [JsonProperty("TdsqlVersion")]
        public string TdsqlVersion{ get; set; }

        /// <summary>
        /// 实例内存大小，单位 GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例存储大小，单位 GB
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 主可用区，如 ap-shanghai-1
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// 从可用区列表，如 [ap-shanghai-2]
        /// </summary>
        [JsonProperty("SlaveZones")]
        public string[] SlaveZones{ get; set; }

        /// <summary>
        /// 自动续费标志：0 否，1 是
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 独享集群Id，普通实例为空
        /// </summary>
        [JsonProperty("ExclusterId")]
        public string ExclusterId{ get; set; }

        /// <summary>
        /// 付费模式：prepaid 表示预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 实例创建时间，格式为 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例是否支持审计
        /// </summary>
        [JsonProperty("IsAuditSupported")]
        public bool? IsAuditSupported{ get; set; }

        /// <summary>
        /// 实例到期时间，格式为 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// 机型信息
        /// </summary>
        [JsonProperty("Machine")]
        public string Machine{ get; set; }

        /// <summary>
        /// 存储空间使用率
        /// </summary>
        [JsonProperty("StorageUsage")]
        public string StorageUsage{ get; set; }

        /// <summary>
        /// 日志存储空间大小，单位 GB
        /// </summary>
        [JsonProperty("LogStorage")]
        public long? LogStorage{ get; set; }

        /// <summary>
        /// 是否支持数据加密。1-支持；0-不支持
        /// </summary>
        [JsonProperty("IsEncryptSupported")]
        public long? IsEncryptSupported{ get; set; }

        /// <summary>
        /// 内网IPv6
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// 实例Cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 产品类型ID
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// 最大QPS
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// 是否支持IPv6
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public long? Ipv6Flag{ get; set; }

        /// <summary>
        /// 外网IPv6地址，公网可访问
        /// </summary>
        [JsonProperty("WanVipv6")]
        public string WanVipv6{ get; set; }

        /// <summary>
        /// 外网状态，0-未开通；1-已开通；2-关闭；3-开通中；4-关闭中
        /// </summary>
        [JsonProperty("WanStatusIpv6")]
        public long? WanStatusIpv6{ get; set; }

        /// <summary>
        /// 外网IPv6端口
        /// </summary>
        [JsonProperty("WanPortIpv6")]
        public long? WanPortIpv6{ get; set; }

        /// <summary>
        /// 数据库引擎
        /// </summary>
        [JsonProperty("DbEngine")]
        public string DbEngine{ get; set; }

        /// <summary>
        /// 数据库版本
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// DCN标志，0-无，1-主实例，2-灾备实例
        /// </summary>
        [JsonProperty("DcnFlag")]
        public long? DcnFlag{ get; set; }

        /// <summary>
        /// DCN状态，0-无，1-创建中，2-同步中，3-已断开
        /// </summary>
        [JsonProperty("DcnStatus")]
        public long? DcnStatus{ get; set; }

        /// <summary>
        /// DCN灾备实例数
        /// </summary>
        [JsonProperty("DcnDstNum")]
        public long? DcnDstNum{ get; set; }

        /// <summary>
        /// 1： 主实例（独享型）, 2: 主实例, 3： 灾备实例, 4： 灾备实例（独享型）
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 实例的各个DB节点信息
        /// </summary>
        [JsonProperty("NodesInfo")]
        public NodeInfo[] NodesInfo{ get; set; }

        /// <summary>
        /// 实例是否支持设置用户连接数限制，内核为10.1暂不支持。
        /// </summary>
        [JsonProperty("IsMaxUserConnectionsSupported")]
        public bool? IsMaxUserConnectionsSupported{ get; set; }

        /// <summary>
        /// 对外显示的数据库版本
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// 加密状态, 0-未开启，1-已开启
        /// </summary>
        [JsonProperty("EncryptStatus")]
        public long? EncryptStatus{ get; set; }

        /// <summary>
        /// DCN的配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicaConfig")]
        public DCNReplicaConfig ReplicaConfig{ get; set; }

        /// <summary>
        /// DCN的运行状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicaStatus")]
        public DCNReplicaStatus ReplicaStatus{ get; set; }

        /// <summary>
        /// 独享集群类型，0:公有云, 1:金融围笼, 2:CDC集群
        /// </summary>
        [JsonProperty("ExclusterType")]
        public long? ExclusterType{ get; set; }

        /// <summary>
        /// VPC就近访问
        /// </summary>
        [JsonProperty("RsAccessStrategy")]
        public long? RsAccessStrategy{ get; set; }

        /// <summary>
        /// 尚未回收的网络资源
        /// </summary>
        [JsonProperty("ReservedNetResources")]
        public ReservedNetResource[] ReservedNetResources{ get; set; }

        /// <summary>
        /// 是否支持物理复制
        /// </summary>
        [JsonProperty("IsPhysicalReplicationSupported")]
        public bool? IsPhysicalReplicationSupported{ get; set; }

        /// <summary>
        /// 是否支持强同步DCN
        /// </summary>
        [JsonProperty("IsDcnStrongSyncSupported")]
        public long? IsDcnStrongSyncSupported{ get; set; }

        /// <summary>
        /// 是否支持DCN切换
        /// </summary>
        [JsonProperty("IsDcnSwitchSupported")]
        public long? IsDcnSwitchSupported{ get; set; }

        /// <summary>
        /// proxy版本号
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// Cpu类型，如：英特尔：Intel/AMD，海光：Hygon
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "IsTmp", this.IsTmp);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanVip", this.WanVip);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TdsqlVersion", this.TdsqlVersion);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamArraySimple(map, prefix + "SlaveZones.", this.SlaveZones);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ExclusterId", this.ExclusterId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsAuditSupported", this.IsAuditSupported);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "Machine", this.Machine);
            this.SetParamSimple(map, prefix + "StorageUsage", this.StorageUsage);
            this.SetParamSimple(map, prefix + "LogStorage", this.LogStorage);
            this.SetParamSimple(map, prefix + "IsEncryptSupported", this.IsEncryptSupported);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "WanVipv6", this.WanVipv6);
            this.SetParamSimple(map, prefix + "WanStatusIpv6", this.WanStatusIpv6);
            this.SetParamSimple(map, prefix + "WanPortIpv6", this.WanPortIpv6);
            this.SetParamSimple(map, prefix + "DbEngine", this.DbEngine);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DcnFlag", this.DcnFlag);
            this.SetParamSimple(map, prefix + "DcnStatus", this.DcnStatus);
            this.SetParamSimple(map, prefix + "DcnDstNum", this.DcnDstNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "NodesInfo.", this.NodesInfo);
            this.SetParamSimple(map, prefix + "IsMaxUserConnectionsSupported", this.IsMaxUserConnectionsSupported);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "EncryptStatus", this.EncryptStatus);
            this.SetParamObj(map, prefix + "ReplicaConfig.", this.ReplicaConfig);
            this.SetParamObj(map, prefix + "ReplicaStatus.", this.ReplicaStatus);
            this.SetParamSimple(map, prefix + "ExclusterType", this.ExclusterType);
            this.SetParamSimple(map, prefix + "RsAccessStrategy", this.RsAccessStrategy);
            this.SetParamArrayObj(map, prefix + "ReservedNetResources.", this.ReservedNetResources);
            this.SetParamSimple(map, prefix + "IsPhysicalReplicationSupported", this.IsPhysicalReplicationSupported);
            this.SetParamSimple(map, prefix + "IsDcnStrongSyncSupported", this.IsDcnStrongSyncSupported);
            this.SetParamSimple(map, prefix + "IsDcnSwitchSupported", this.IsDcnSwitchSupported);
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

