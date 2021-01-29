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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReadOnlyDBInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 售卖规格ID。该参数可以通过调用DescribeProductConfig的返回值中的SpecCode字段来获取。
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// PostgreSQL内核版本，目前强制和主实例保持一致
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 实例容量大小，单位：GB。
        /// </summary>
        [JsonProperty("Storage")]
        public ulong? Storage{ get; set; }

        /// <summary>
        /// 一次性购买的实例数量。取值1-100
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 购买时长，单位：月。目前只支持1,2,3,4,5,6,7,8,9,10,11,12,24,36这些值，按量计费模式下该参数传1。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 只读实例的主实例ID
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// 可用区ID。该参数可以通过调用 DescribeZones 接口的返回值中的Zone字段来获取。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 实例计费类型。目前支持：PREPAID（预付费，即包年包月），POSTPAID_BY_HOUR（后付费，即按量计费）。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 是否自动使用代金券。1（是），0（否），默认不使用。
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表，目前仅支持指定一张代金券。
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 续费标记：0-正常续费（默认）；1-自动续费；
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 私有网络ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络子网ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 优惠活动ID
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 实例名(后续支持)
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否需要支持Ipv6，1：是，0：否
        /// </summary>
        [JsonProperty("NeedSupportIpv6")]
        public ulong? NeedSupportIpv6{ get; set; }

        /// <summary>
        /// 只读组ID。
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// 实例需要绑定的Tag信息，默认为空
        /// </summary>
        [JsonProperty("TagList")]
        public Tag TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NeedSupportIpv6", this.NeedSupportIpv6);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamObj(map, prefix + "TagList.", this.TagList);
        }
    }
}

