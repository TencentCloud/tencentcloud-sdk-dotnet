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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 克隆的源实例ID。可通过[DescribeDBInstances](https://cloud.tencent.com/document/api/409/16773)接口获取
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 售卖规格码。该参数可以通过调用[DescribeClasses](https://cloud.tencent.com/document/api/409/89019)的返回值中的SpecCode字段来获取。
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// 实例磁盘容量大小，设置步长限制为10。单位：GB。
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 购买时长，单位：月。
        /// 
        /// - 预付费：支持1,2,3,4,5,6,7,8,9,10,11,12,24,36
        /// - 后付费：只支持1
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 续费标记。仅当计费模式为预付费时生效。
        /// 枚举值：
        /// 
        /// - 0：手动续费
        /// - 1：自动续费
        /// 
        /// 默认值：0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 私有网络ID，形如vpc-xxxxxxxx。有效的VpcId可通过登录控制台查询；也可以调用接口 [DescribeVpcEx](https://cloud.tencent.com/document/api/215/1372) ，从接口返回中的unVpcId字段获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络子网ID，形如subnet-xxxxxxxx。有效的私有网络子网ID可通过登录控制台查询；也可以调用接口 [DescribeSubnets ](https://cloud.tencent.com/document/api/215/15784)，从接口返回中的unSubnetId字段获取。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 新购的实例名称，仅支持长度小于60的中文/英文/数字/"_"/"-"，不指定实例名称则默认显示"源实例名-Copy"。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 实例计费类型，目前支持：
        /// 
        /// - PREPAID：预付费，即包年包月
        /// - POSTPAID_BY_HOUR：后付费，即按量计费
        /// 
        /// 默认值：PREPAID
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 实例所属安全组。该参数可以通过调用[DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808)的返回值中的SecurityGroupId字段来获取。若不指定该参数，则绑定默认安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 项目ID。默认值为0，表示所属默认项目。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 实例需要绑定的Tag信息，默认为空；可以通过调用 [DescribeTags](https://cloud.tencent.com/document/api/651/35316) 返回值中的 Tags 字段来获取。
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 实例节点部署信息，必须填写主备节点可用区。支持多可用区部署时需要指定每个节点的部署可用区信息。
        /// 可用区信息可以通过调用 [DescribeZones](https://cloud.tencent.com/document/api/409/16769) 接口的返回值中的Zone字段来获取。
        /// </summary>
        [JsonProperty("DBNodeSet")]
        public DBNode[] DBNodeSet{ get; set; }

        /// <summary>
        /// 是否自动使用代金券：
        /// 
        /// - 0：否
        /// - 1：是
        /// 
        /// 默认值：0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表。
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string VoucherIds{ get; set; }

        /// <summary>
        /// 活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 基础备份集ID。参数BackupSetId、RecoveryTargetTime两者必须填写一项，且不能同时填写。
        /// </summary>
        [JsonProperty("BackupSetId")]
        public string BackupSetId{ get; set; }

        /// <summary>
        /// 恢复时间点。参数BackupSetId、RecoveryTargetTime两者必须填写一项，且不能同时填写。
        /// </summary>
        [JsonProperty("RecoveryTargetTime")]
        public string RecoveryTargetTime{ get; set; }

        /// <summary>
        /// 主从同步方式，支持： 
        /// <li>Semi-sync：半同步</li>
        /// <li>Async：异步</li>
        /// 主实例默认值：Semi-sync
        /// 只读实例默认值：Async
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// 实例是否开启删除保护: true-开启删除保护；false-关闭删除保护。
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArrayObj(map, prefix + "DBNodeSet.", this.DBNodeSet);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "VoucherIds", this.VoucherIds);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "BackupSetId", this.BackupSetId);
            this.SetParamSimple(map, prefix + "RecoveryTargetTime", this.RecoveryTargetTime);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
        }
    }
}

