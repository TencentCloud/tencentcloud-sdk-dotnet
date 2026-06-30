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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例可用区，类似ap-guangzhou-1（广州一区）；实例可售卖区域可以通过接口DescribeZones获取</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>实例内存大小，单位GB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>实例磁盘大小，单位GB</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>实例核心数</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// <p>购买实例的宿主机磁盘类型,CLOUD_HSSD-虚拟机加强型SSD云盘，CLOUD_TSSD-虚拟机极速型SSD云盘，CLOUD_BSSD-虚拟机通用型SSD云盘</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>付费模式，取值支持 PREPAID（预付费），POSTPAID（后付费）。</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>本次购买几个实例，默认值为1。取值不超过10</p>
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// <p>VPC子网ID，形如subnet-bdoe83fa；SubnetId和VpcId需同时设置或者同时不设置</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>VPC网络ID，形如vpc-dsp338hz；SubnetId和VpcId需同时设置或者同时不设置</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>购买实例周期，默认取值为1，表示一个月。取值不超过48</p>
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// <p>是否自动使用代金券；1 - 是，0 - 否，默认不使用</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>代金券ID数组，目前单个订单只能使用一张</p>
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// <p>sqlserver版本，目前所有支持的版本有：2008R2 (SQL Server 2008 R2 Enterprise)，2012SP3 (SQL Server 2012 Enterprise)，201202 (SQL Server 2012 Standard)，2014SP2 (SQL Server 2014 Enterprise)，201402 (SQL Server 2014 Standard)，2016SP1 (SQL Server 2016 Enterprise)，201602 (SQL Server 2016 Standard)，2017 (SQL Server 2017 Enterprise)，201702 (SQL Server 2017 Standard)，2019 (SQL Server 2019 Enterprise)，201902 (SQL Server 2019 Standard)。每个地域支持售卖的版本不同，可通过DescribeProductConfig接口来拉取每个地域可售卖的版本信息。不填，默认为版本2017。</p>
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// <p>自动续费标志：0-正常续费  1-自动续费，默认为1自动续费。只在购买预付费实例时有效。</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>安全组列表，填写形如sg-xxx的安全组ID</p>
        /// </summary>
        [JsonProperty("SecurityGroupList")]
        public string[] SecurityGroupList{ get; set; }

        /// <summary>
        /// <p>可维护时间窗配置，以周为单位，表示周几允许维护，1-7分别代表周一到周末</p>
        /// </summary>
        [JsonProperty("Weekly")]
        public long?[] Weekly{ get; set; }

        /// <summary>
        /// <p>可维护时间窗配置，每天可维护的开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>可维护时间窗配置，持续时间，单位：小时</p>
        /// </summary>
        [JsonProperty("Span")]
        public long? Span{ get; set; }

        /// <summary>
        /// <p>是否跨可用区部署，默认值为false</p>
        /// </summary>
        [JsonProperty("MultiZones")]
        public bool? MultiZones{ get; set; }

        /// <summary>
        /// <p>新建实例绑定的标签集合</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>系统字符集排序规则，默认：Chinese_PRC_CI_AS</p>
        /// </summary>
        [JsonProperty("Collation")]
        public string Collation{ get; set; }

        /// <summary>
        /// <p>系统时区，默认：China Standard Time</p>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>是否多节点架构实例，默认值为false。当MultiNodes = true时，参数MultiZones必须取值为true。</p>
        /// </summary>
        [JsonProperty("MultiNodes")]
        public bool? MultiNodes{ get; set; }

        /// <summary>
        /// <p>备节点可用区，默认为空。当MultiNodes = true时，主节点和备节点可用区不能全部相同。备机可用区集合最小为2个，最大不超过5个。</p>
        /// </summary>
        [JsonProperty("DrZones")]
        public string[] DrZones{ get; set; }

        /// <summary>
        /// <p>磁盘加密标识，0-不加密，1-加密</p>
        /// </summary>
        [JsonProperty("DiskEncryptFlag")]
        public long? DiskEncryptFlag{ get; set; }

        /// <summary>
        /// <p>额外磁盘 IO 性能，仅 CLOUD_HSSD 支持</p><p>取值范围：[0, 650]</p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// <p>可用性策略</p><p>枚举值：</p><ul><li>Async： 可用性优先（异步传输）</li><li>Sync： 可靠性优先（同步传输）</li></ul><p>默认值：Async</p><p>仅 AlwaysOn 双节点架构生效，单节点/多节点/MIRROR 架构忽略此参数</p>
        /// </summary>
        [JsonProperty("AvailabilityStrategy")]
        public string AvailabilityStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamArraySimple(map, prefix + "SecurityGroupList.", this.SecurityGroupList);
            this.SetParamArraySimple(map, prefix + "Weekly.", this.Weekly);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Span", this.Span);
            this.SetParamSimple(map, prefix + "MultiZones", this.MultiZones);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Collation", this.Collation);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "MultiNodes", this.MultiNodes);
            this.SetParamArraySimple(map, prefix + "DrZones.", this.DrZones);
            this.SetParamSimple(map, prefix + "DiskEncryptFlag", this.DiskEncryptFlag);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "AvailabilityStrategy", this.AvailabilityStrategy);
        }
    }
}

