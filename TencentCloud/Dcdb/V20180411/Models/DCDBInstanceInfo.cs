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

    public class DCDBInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// VPC数字ID
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// Subnet数字ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// 状态中文描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 实例状态：0 创建中，1 流程处理中， 2 运行中，3 实例未初始化，-1 实例已隔离，4 实例初始化中，5 实例删除中，6 实例重启中，7 数据迁移中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 内网端口
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 自动续费标志
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 内存大小，单位 GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 存储大小，单位 GB
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 分片个数
        /// </summary>
        [JsonProperty("ShardCount")]
        public long? ShardCount{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// 隔离时间
        /// </summary>
        [JsonProperty("IsolatedTimestamp")]
        public string IsolatedTimestamp{ get; set; }

        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 分片详情
        /// </summary>
        [JsonProperty("ShardDetail")]
        public ShardInfo[] ShardDetail{ get; set; }

        /// <summary>
        /// 节点数，2 为一主一从， 3 为一主二从
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

        /// <summary>
        /// 临时实例标记，0 为非临时实例
        /// </summary>
        [JsonProperty("IsTmp")]
        public long? IsTmp{ get; set; }

        /// <summary>
        /// 独享集群ID，为空表示非独享集群实例
        /// </summary>
        [JsonProperty("ExclusterId")]
        public string ExclusterId{ get; set; }

        /// <summary>
        /// 字符串型的私有网络ID
        /// </summary>
        [JsonProperty("UniqueVpcId")]
        public string UniqueVpcId{ get; set; }

        /// <summary>
        /// 字符串型的私有网络子网ID
        /// </summary>
        [JsonProperty("UniqueSubnetId")]
        public string UniqueSubnetId{ get; set; }

        /// <summary>
        /// 数字实例ID（过时字段，请勿依赖该值）
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

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
        /// 产品类型 ID（过时字段，请勿依赖该值）
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// 实例最后更新时间，格式为 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 数据库引擎
        /// </summary>
        [JsonProperty("DbEngine")]
        public string DbEngine{ get; set; }

        /// <summary>
        /// 数据库引擎版本
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("Paymode")]
        public string Paymode{ get; set; }

        /// <summary>
        /// 实例处于异步任务状态时，表示异步任务流程ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Locker")]
        public long? Locker{ get; set; }

        /// <summary>
        /// 外网状态，0-未开通；1-已开通；2-关闭；3-开通中
        /// </summary>
        [JsonProperty("WanStatus")]
        public long? WanStatus{ get; set; }

        /// <summary>
        /// 该实例是否支持审计。1-支持；0-不支持
        /// </summary>
        [JsonProperty("IsAuditSupported")]
        public ulong? IsAuditSupported{ get; set; }

        /// <summary>
        /// Cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 实例IPv6标志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public ulong? Ipv6Flag{ get; set; }

        /// <summary>
        /// 内网IPv6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vipv6")]
        public string Vipv6{ get; set; }

        /// <summary>
        /// 外网IPv6
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WanVipv6")]
        public string WanVipv6{ get; set; }

        /// <summary>
        /// 外网IPv6端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WanPortIpv6")]
        public ulong? WanPortIpv6{ get; set; }

        /// <summary>
        /// 外网IPv6状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WanStatusIpv6")]
        public ulong? WanStatusIpv6{ get; set; }

        /// <summary>
        /// DCN标志，0-无，1-主实例，2-灾备实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DcnFlag")]
        public long? DcnFlag{ get; set; }

        /// <summary>
        /// DCN状态，0-无，1-创建中，2-同步中，3-已断开
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DcnStatus")]
        public long? DcnStatus{ get; set; }

        /// <summary>
        /// DCN灾备实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DcnDstNum")]
        public long? DcnDstNum{ get; set; }

        /// <summary>
        /// 1： 主实例（独享型）, 2: 主实例, 3： 灾备实例, 4： 灾备实例（独享型）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "IsolatedTimestamp", this.IsolatedTimestamp);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArrayObj(map, prefix + "ShardDetail.", this.ShardDetail);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "IsTmp", this.IsTmp);
            this.SetParamSimple(map, prefix + "ExclusterId", this.ExclusterId);
            this.SetParamSimple(map, prefix + "UniqueVpcId", this.UniqueVpcId);
            this.SetParamSimple(map, prefix + "UniqueSubnetId", this.UniqueSubnetId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanVip", this.WanVip);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DbEngine", this.DbEngine);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "Paymode", this.Paymode);
            this.SetParamSimple(map, prefix + "Locker", this.Locker);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "IsAuditSupported", this.IsAuditSupported);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "Vipv6", this.Vipv6);
            this.SetParamSimple(map, prefix + "WanVipv6", this.WanVipv6);
            this.SetParamSimple(map, prefix + "WanPortIpv6", this.WanPortIpv6);
            this.SetParamSimple(map, prefix + "WanStatusIpv6", this.WanStatusIpv6);
            this.SetParamSimple(map, prefix + "DcnFlag", this.DcnFlag);
            this.SetParamSimple(map, prefix + "DcnStatus", this.DcnStatus);
            this.SetParamSimple(map, prefix + "DcnDstNum", this.DcnDstNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

