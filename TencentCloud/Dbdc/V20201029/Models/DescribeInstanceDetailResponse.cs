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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 独享集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 独享集群实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 产品ID, 0:CDB, 1:TDSQL
        /// </summary>
        [JsonProperty("ProductId")]
        public long? ProductId{ get; set; }

        /// <summary>
        /// 集群类型, 0:公有云, 1:金融围笼
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 主机类型, 0:物理机, 1:cvm本地盘, 2:cvm云盘
        /// </summary>
        [JsonProperty("HostType")]
        public long? HostType{ get; set; }

        /// <summary>
        /// 自动续费标志, 0:未设置, 1:自动续费, 2:到期不续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 集群状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// 主机数
        /// </summary>
        [JsonProperty("HostNum")]
        public long? HostNum{ get; set; }

        /// <summary>
        /// Db实例数
        /// </summary>
        [JsonProperty("DbNum")]
        public long? DbNum{ get; set; }

        /// <summary>
        /// 分配策略, 0:紧凑, 1:均匀
        /// </summary>
        [JsonProperty("AssignStrategy")]
        public long? AssignStrategy{ get; set; }

        /// <summary>
        /// 总主机CPU(单位:核)
        /// </summary>
        [JsonProperty("CpuSpec")]
        public long? CpuSpec{ get; set; }

        /// <summary>
        /// 总已分配CPU(单位:核)
        /// </summary>
        [JsonProperty("CpuAssigned")]
        public long? CpuAssigned{ get; set; }

        /// <summary>
        /// 总可分配CPU(单位:核)
        /// </summary>
        [JsonProperty("CpuAssignable")]
        public long? CpuAssignable{ get; set; }

        /// <summary>
        /// 总主机内存(单位:GB)
        /// </summary>
        [JsonProperty("MemorySpec")]
        public long? MemorySpec{ get; set; }

        /// <summary>
        /// 总已分配内存(单位:GB)
        /// </summary>
        [JsonProperty("MemoryAssigned")]
        public long? MemoryAssigned{ get; set; }

        /// <summary>
        /// 总可分配内存(单位:GB)
        /// </summary>
        [JsonProperty("MemoryAssignable")]
        public long? MemoryAssignable{ get; set; }

        /// <summary>
        /// 总机器磁盘(单位:GB)
        /// </summary>
        [JsonProperty("DiskSpec")]
        public long? DiskSpec{ get; set; }

        /// <summary>
        /// 总已分配磁盘(单位:GB)
        /// </summary>
        [JsonProperty("DiskAssigned")]
        public long? DiskAssigned{ get; set; }

        /// <summary>
        /// 总可分配磁盘(单位:GB)
        /// </summary>
        [JsonProperty("DiskAssignable")]
        public long? DiskAssignable{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 金融围笼ID
        /// </summary>
        [JsonProperty("FenceId")]
        public string FenceId{ get; set; }

        /// <summary>
        /// 所属集群ID(默认集群为空)
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 独享集群的标签信息
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// CPU类型，Intel/AMD,Hygon
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

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
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "HostNum", this.HostNum);
            this.SetParamSimple(map, prefix + "DbNum", this.DbNum);
            this.SetParamSimple(map, prefix + "AssignStrategy", this.AssignStrategy);
            this.SetParamSimple(map, prefix + "CpuSpec", this.CpuSpec);
            this.SetParamSimple(map, prefix + "CpuAssigned", this.CpuAssigned);
            this.SetParamSimple(map, prefix + "CpuAssignable", this.CpuAssignable);
            this.SetParamSimple(map, prefix + "MemorySpec", this.MemorySpec);
            this.SetParamSimple(map, prefix + "MemoryAssigned", this.MemoryAssigned);
            this.SetParamSimple(map, prefix + "MemoryAssignable", this.MemoryAssignable);
            this.SetParamSimple(map, prefix + "DiskSpec", this.DiskSpec);
            this.SetParamSimple(map, prefix + "DiskAssigned", this.DiskAssigned);
            this.SetParamSimple(map, prefix + "DiskAssignable", this.DiskAssignable);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "FenceId", this.FenceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

