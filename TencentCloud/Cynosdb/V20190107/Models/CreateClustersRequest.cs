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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 所属VPC网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 所属子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 数据库类型，取值范围: 
        /// <li> MYSQL </li>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 数据库版本，取值范围: 
        /// <li> MYSQL可选值：5.7 </li>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// Cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 存储上限，单位GB
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// 所属项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 存储
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 账号密码(8-64个字符，至少包含字母、数字、字符（支持的字符：_+-&=!@#$%^*()~）中的两种)
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// 端口，默认5432
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 计费模式，按量计费：0，包年包月：1。默认按量计费。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 购买个数，目前只支持传1（不传默认为1）
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 回档类型：
        /// noneRollback：不回档；
        /// snapRollback，快照回档；
        /// timeRollback，时间点回档
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// 快照回档，表示snapshotId；时间点回档，表示queryId，为0，表示需要判断时间点是否有效
        /// </summary>
        [JsonProperty("RollbackId")]
        public ulong? RollbackId{ get; set; }

        /// <summary>
        /// 回档时，传入源集群ID，用于查找源poolId
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// 时间点回档，指定时间；快照回档，快照时间
        /// </summary>
        [JsonProperty("ExpectTime")]
        public string ExpectTime{ get; set; }

        /// <summary>
        /// 时间点回档，指定时间允许范围
        /// </summary>
        [JsonProperty("ExpectTimeThresh")]
        public ulong? ExpectTimeThresh{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// 包年包月购买时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 包年包月购买时长单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 包年包月购买是否自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 是否自动选择代金券 1是 0否 默认为0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 实例数量（该参数已不再使用，只做存量兼容处理）
        /// </summary>
        [JsonProperty("HaCount")]
        public long? HaCount{ get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// 集群创建需要绑定的tag数组信息
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "RollbackId", this.RollbackId);
            this.SetParamSimple(map, prefix + "OriginalClusterId", this.OriginalClusterId);
            this.SetParamSimple(map, prefix + "ExpectTime", this.ExpectTime);
            this.SetParamSimple(map, prefix + "ExpectTimeThresh", this.ExpectTimeThresh);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "HaCount", this.HaCount);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
        }
    }
}

