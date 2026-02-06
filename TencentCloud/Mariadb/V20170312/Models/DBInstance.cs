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

    public class DBInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID，唯一标识一个 TDSQL 实例</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称，用户可修改</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例所属应用 ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>实例所属项目 ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>实例所在地域名称，如 ap-shanghai</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>实例所在可用区名称，如 ap-shanghai-2</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>私有网络 ID，基础网络时为 0</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public long? VpcId{ get; set; }

        /// <summary>
        /// <p>子网 ID，基础网络时为 0</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public long? SubnetId{ get; set; }

        /// <summary>
        /// <p>实例状态：0 创建中，1 流程处理中， 2 运行中，3 实例未初始化，-1 实例已隔离，4 实例初始化中，5 实例删除中，6 实例重启中，7 数据迁移中</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>内网 IP 地址</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>内网端口</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>外网访问的域名，公网可解析</p>
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// <p>外网 IP 地址，公网可访问</p>
        /// </summary>
        [JsonProperty("WanVip")]
        public string WanVip{ get; set; }

        /// <summary>
        /// <p>外网端口</p>
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// <p>实例创建时间，格式为 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>实例最后更新时间，格式为 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>自动续费标志：0 否，1 是</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>实例到期时间，格式为 2006-01-02 15:04:05</p>
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// <p>实例所属账号</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>TDSQL 版本信息</p>
        /// </summary>
        [JsonProperty("TdsqlVersion")]
        public string TdsqlVersion{ get; set; }

        /// <summary>
        /// <p>实例内存大小，单位 GB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>实例存储大小，单位 GB</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>字符串型的私有网络ID</p>
        /// </summary>
        [JsonProperty("UniqueVpcId")]
        public string UniqueVpcId{ get; set; }

        /// <summary>
        /// <p>字符串型的私有网络子网ID</p>
        /// </summary>
        [JsonProperty("UniqueSubnetId")]
        public string UniqueSubnetId{ get; set; }

        /// <summary>
        /// <p>原始实例ID（过时字段，请勿依赖该值）</p>
        /// </summary>
        [JsonProperty("OriginSerialId")]
        public string OriginSerialId{ get; set; }

        /// <summary>
        /// <p>节点数，2为一主一从，3为一主二从</p>
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// <p>是否临时实例，0为否，非0为是</p>
        /// </summary>
        [JsonProperty("IsTmp")]
        public ulong? IsTmp{ get; set; }

        /// <summary>
        /// <p>独享集群ID，为空表示为普通实例</p>
        /// </summary>
        [JsonProperty("ExclusterId")]
        public string ExclusterId{ get; set; }

        /// <summary>
        /// <p>数字实例ID（过时字段，请勿依赖该值）</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>产品类型 ID</p>
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// <p>最大 Qps 值</p>
        /// </summary>
        [JsonProperty("Qps")]
        public long? Qps{ get; set; }

        /// <summary>
        /// <p>付费模式</p>
        /// </summary>
        [JsonProperty("Paymode")]
        public string Paymode{ get; set; }

        /// <summary>
        /// <p>实例处于异步任务时的异步任务流程ID</p>
        /// </summary>
        [JsonProperty("Locker")]
        public long? Locker{ get; set; }

        /// <summary>
        /// <p>实例目前运行状态描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>外网状态，0-未开通；1-已开通；2-关闭；3-开通中</p>
        /// </summary>
        [JsonProperty("WanStatus")]
        public long? WanStatus{ get; set; }

        /// <summary>
        /// <p>该实例是否支持审计。1-支持；0-不支持</p>
        /// </summary>
        [JsonProperty("IsAuditSupported")]
        public ulong? IsAuditSupported{ get; set; }

        /// <summary>
        /// <p>机器型号</p>
        /// </summary>
        [JsonProperty("Machine")]
        public string Machine{ get; set; }

        /// <summary>
        /// <p>是否支持数据加密。1-支持；0-不支持</p>
        /// </summary>
        [JsonProperty("IsEncryptSupported")]
        public long? IsEncryptSupported{ get; set; }

        /// <summary>
        /// <p>实例CPU核数</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>实例IPv6标志</p>
        /// </summary>
        [JsonProperty("Ipv6Flag")]
        public ulong? Ipv6Flag{ get; set; }

        /// <summary>
        /// <p>内网IPv6</p>
        /// </summary>
        [JsonProperty("Vipv6")]
        public string Vipv6{ get; set; }

        /// <summary>
        /// <p>外网IPv6</p>
        /// </summary>
        [JsonProperty("WanVipv6")]
        public string WanVipv6{ get; set; }

        /// <summary>
        /// <p>外网IPv6端口</p>
        /// </summary>
        [JsonProperty("WanPortIpv6")]
        public ulong? WanPortIpv6{ get; set; }

        /// <summary>
        /// <p>外网IPv6状态</p>
        /// </summary>
        [JsonProperty("WanStatusIpv6")]
        public ulong? WanStatusIpv6{ get; set; }

        /// <summary>
        /// <p>数据库引擎</p>
        /// </summary>
        [JsonProperty("DbEngine")]
        public string DbEngine{ get; set; }

        /// <summary>
        /// <p>数据库版本</p>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// <p>DCN标志，0-无，1-主实例，2-灾备实例</p>
        /// </summary>
        [JsonProperty("DcnFlag")]
        public long? DcnFlag{ get; set; }

        /// <summary>
        /// <p>DCN状态，0-无，1-创建中，2-同步中，3-已断开</p>
        /// </summary>
        [JsonProperty("DcnStatus")]
        public long? DcnStatus{ get; set; }

        /// <summary>
        /// <p>DCN灾备实例数</p>
        /// </summary>
        [JsonProperty("DcnDstNum")]
        public long? DcnDstNum{ get; set; }

        /// <summary>
        /// <p>1： 主实例（独享型）, 2: 主实例, 3： 灾备实例, 4： 灾备实例（独享型）</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// <p>实例标签信息</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>数据库版本</p>
        /// </summary>
        [JsonProperty("DbVersionId")]
        public string DbVersionId{ get; set; }

        /// <summary>
        /// <p>实例删除保护标签，1: 已开启删除保护，0: 未开启删除保护</p>
        /// </summary>
        [JsonProperty("ProtectedProperty")]
        public long? ProtectedProperty{ get; set; }


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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanVip", this.WanVip);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "TdsqlVersion", this.TdsqlVersion);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "UniqueVpcId", this.UniqueVpcId);
            this.SetParamSimple(map, prefix + "UniqueSubnetId", this.UniqueSubnetId);
            this.SetParamSimple(map, prefix + "OriginSerialId", this.OriginSerialId);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "IsTmp", this.IsTmp);
            this.SetParamSimple(map, prefix + "ExclusterId", this.ExclusterId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Paymode", this.Paymode);
            this.SetParamSimple(map, prefix + "Locker", this.Locker);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "IsAuditSupported", this.IsAuditSupported);
            this.SetParamSimple(map, prefix + "Machine", this.Machine);
            this.SetParamSimple(map, prefix + "IsEncryptSupported", this.IsEncryptSupported);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Ipv6Flag", this.Ipv6Flag);
            this.SetParamSimple(map, prefix + "Vipv6", this.Vipv6);
            this.SetParamSimple(map, prefix + "WanVipv6", this.WanVipv6);
            this.SetParamSimple(map, prefix + "WanPortIpv6", this.WanPortIpv6);
            this.SetParamSimple(map, prefix + "WanStatusIpv6", this.WanStatusIpv6);
            this.SetParamSimple(map, prefix + "DbEngine", this.DbEngine);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "DcnFlag", this.DcnFlag);
            this.SetParamSimple(map, prefix + "DcnStatus", this.DcnStatus);
            this.SetParamSimple(map, prefix + "DcnDstNum", this.DcnDstNum);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DbVersionId", this.DbVersionId);
            this.SetParamSimple(map, prefix + "ProtectedProperty", this.ProtectedProperty);
        }
    }
}

