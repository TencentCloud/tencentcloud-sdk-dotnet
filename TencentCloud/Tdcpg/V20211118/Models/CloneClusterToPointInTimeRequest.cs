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

    public class CloneClusterToPointInTimeRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 数据库版本，目前仅支持 10.17
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// CPU核数。取值参考文档【购买指南】
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// 内存大小，单位GiB。取值参考文档【购买指南】
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 已配置的私有网络中的子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 集群付费模式
        /// - PREPAID：预付费，即包年包月
        /// - POSTPAID_BY_HOUR：按小时后付费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 对应的备份数据来源集群ID
        /// </summary>
        [JsonProperty("SourceClusterId")]
        public string SourceClusterId{ get; set; }

        /// <summary>
        /// 对应的备份数据时间点。按照RFC3339标准表示，并且使用东八区时区时间。格式为：YYYY-MM-DDThh:mm:ss+08:00。
        /// </summary>
        [JsonProperty("SourceDataPoint")]
        public string SourceDataPoint{ get; set; }

        /// <summary>
        /// 集群名，1-60个字符，可以包含中文、英文、数字和符号"-"、"_"、"."。不输入此参数时默认与ClusterId保持一致。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 项目Id，默认为0表示默认项目
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 连接数据库时，Endpoint使用的端口。取值范围为[1,65534]，默认值为5432
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 集群下实例数量。取值范围为[1,4]，默认值为1
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 购买时长，单位：月。取值范围为[1,60]，默认值为1。
        /// 只有当PayMode为PREPAID时生效。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 是否自动续费，0-不 1-是。默认为0，只有当PayMode为PREPAID时生效。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 存储付费模式
        ///  - PREPAID：预付费，即包年包月
        ///  - POSTPAID_BY_HOUR：按小时后付费
        /// 默认为POSTPAID_BY_HOUR，实例付费模式为按小时付费时，存储付费模式不支持包年包月
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public string StoragePayMode{ get; set; }

        /// <summary>
        /// 存储最大使用量，单位GB。取值参考文档【购买指南】。存储使用预付费模式时必须设置，存储使用按小时后付费时不可设置
        /// </summary>
        [JsonProperty("Storage")]
        public ulong? Storage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "SourceClusterId", this.SourceClusterId);
            this.SetParamSimple(map, prefix + "SourceDataPoint", this.SourceDataPoint);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
        }
    }
}

