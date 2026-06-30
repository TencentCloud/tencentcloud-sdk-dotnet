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

    public class CreateCloudReadOnlyDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>主实例ID，格式如：mssql-3l3fgqn7</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例可用区，类似ap-guangzhou-1（广州一区）；实例可售卖区域可以通过接口DescribeZones获取</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>只读组类型选项，1-按照一个实例一个只读组的方式发货，2-新建只读组后发货，所有实例都在这个只读组下面， 3-发货的所有实例都在已有的只读组下面</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupType")]
        public long? ReadOnlyGroupType{ get; set; }

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
        /// <p>0-默认不升级主实例，1-强制升级主实例完成ro部署；主实例为非集群版时需要填1，强制升级为集群版。填1 说明您已同意将主实例升级到集群版实例。</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupForcedUpgrade")]
        public long? ReadOnlyGroupForcedUpgrade{ get; set; }

        /// <summary>
        /// <p>ReadOnlyGroupType=3时必填,已存在的只读组ID</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// <p>ReadOnlyGroupType=2时必填，新建的只读组名称</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// <p>ReadOnlyGroupType=2时必填，新建的只读组是否开启延迟剔除功能，1-开启，0-关闭。当只读副本与主实例延迟大于阈值后，自动剔除。</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupIsOfflineDelay")]
        public long? ReadOnlyGroupIsOfflineDelay{ get; set; }

        /// <summary>
        /// <p>ReadOnlyGroupType=2 且 ReadOnlyGroupIsOfflineDelay=1时必填，新建的只读组延迟剔除的阈值。</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupMaxDelayTime")]
        public long? ReadOnlyGroupMaxDelayTime{ get; set; }

        /// <summary>
        /// <p>ReadOnlyGroupType=2 且 ReadOnlyGroupIsOfflineDelay=1时必填，新建的只读组延迟剔除后至少保留只读副本的个数。</p>
        /// </summary>
        [JsonProperty("ReadOnlyGroupMinInGroup")]
        public long? ReadOnlyGroupMinInGroup{ get; set; }

        /// <summary>
        /// <p>付费模式，取值支持 PREPAID（预付费），POSTPAID（后付费）。</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>本次即将购买的实例数量，默认取值2。</p>
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
        /// <p>安全组列表，填写形如sg-xxx的安全组ID</p>
        /// </summary>
        [JsonProperty("SecurityGroupList")]
        public string[] SecurityGroupList{ get; set; }

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
        /// <p>磁盘加密标识，0-不加密，1-加密</p>
        /// </summary>
        [JsonProperty("DiskEncryptFlag")]
        public long? DiskEncryptFlag{ get; set; }

        /// <summary>
        /// <p>额外磁盘 IO 吞吐量，仅 CLOUD_HSSD 支持</p><p>取值范围：[0, 650]</p><p>单位：MB/s</p>
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupType", this.ReadOnlyGroupType);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupForcedUpgrade", this.ReadOnlyGroupForcedUpgrade);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupIsOfflineDelay", this.ReadOnlyGroupIsOfflineDelay);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupMaxDelayTime", this.ReadOnlyGroupMaxDelayTime);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupMinInGroup", this.ReadOnlyGroupMinInGroup);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "SecurityGroupList.", this.SecurityGroupList);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "Collation", this.Collation);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "DiskEncryptFlag", this.DiskEncryptFlag);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
        }
    }
}

