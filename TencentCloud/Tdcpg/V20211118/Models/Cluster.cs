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

namespace TencentCloud.Tdcpg.V20211118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，集群的唯一标识
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名字，不修改时默认和集群ID相同
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

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
        /// TDSQL-C PostgreSQL 合入的社区版本号
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 集群状态。目前包括
        ///  - creating ：创建中
        ///  - running : 运行中
        ///  - isolating : 隔离中
        ///  - isolated : 已隔离
        ///  - recovering : 恢复中
        ///  - deleting : 删除中
        ///  - deleted : 已删除
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 集群状态中文含义
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 集群创建时间。按照RFC3339标准表示，并且使用东八区时区时间，格式为：YYYY-MM-DDThh:mm:ss+08:00。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 存储当前使用量，单位GiB
        /// </summary>
        [JsonProperty("StorageUsed")]
        public float? StorageUsed{ get; set; }

        /// <summary>
        /// 存储最大使用量，单位GiB
        /// </summary>
        [JsonProperty("StorageLimit")]
        public ulong? StorageLimit{ get; set; }

        /// <summary>
        /// 付费模式：
        ///  - PREPAID : 预付费，即包年包月
        ///  - POSTPAID_BY_HOUR : 按小时结算后付费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 预付费集群到期时间。按照RFC3339标准表示，并且使用东八区时区时间，格式为：YYYY-MM-DDThh:mm:ss+08:00。
        /// </summary>
        [JsonProperty("PayPeriodEndTime")]
        public string PayPeriodEndTime{ get; set; }

        /// <summary>
        /// 预付费集群自动续费标签
        ///  - 0 : 到期不自动续费
        ///  - 1 : 到期自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 数据库字符集
        /// </summary>
        [JsonProperty("DBCharset")]
        public string DBCharset{ get; set; }

        /// <summary>
        /// 集群内实例的数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 集群内访问点信息
        /// </summary>
        [JsonProperty("EndpointSet")]
        public Endpoint[] EndpointSet{ get; set; }

        /// <summary>
        /// TDSQL-C PostgreSQL 合入的社区主要版本号
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// TDSQL-C PostgreSQL 内核版本号
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// 存储付费模式
        ///  - PREPAID：预付费，即包年包月
        ///  - POSTPAID_BY_HOUR：按小时后付费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public string StoragePayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StorageUsed", this.StorageUsed);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PayPeriodEndTime", this.PayPeriodEndTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "DBCharset", this.DBCharset);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamArrayObj(map, prefix + "EndpointSet.", this.EndpointSet);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
        }
    }
}

