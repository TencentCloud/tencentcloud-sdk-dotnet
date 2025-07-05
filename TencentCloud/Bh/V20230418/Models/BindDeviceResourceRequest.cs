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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindDeviceResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 资产ID集合
        /// </summary>
        [JsonProperty("DeviceIdSet")]
        public ulong?[] DeviceIdSet{ get; set; }

        /// <summary>
        /// 堡垒机服务ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 网络域ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// K8S集群托管账号维度。1-集群，2-命名空间，3-工作负载
        /// </summary>
        [JsonProperty("ManageDimension")]
        public ulong? ManageDimension{ get; set; }

        /// <summary>
        /// K8S集群托管账号id
        /// </summary>
        [JsonProperty("ManageAccountId")]
        public long? ManageAccountId{ get; set; }

        /// <summary>
        /// K8S集群托管账号名称
        /// </summary>
        [JsonProperty("ManageAccount")]
        public string ManageAccount{ get; set; }

        /// <summary>
        /// K8S集群托管账号凭证
        /// </summary>
        [JsonProperty("ManageKubeconfig")]
        public string ManageKubeconfig{ get; set; }

        /// <summary>
        /// K8S集群托管的namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// K8S集群托管的workload
        /// </summary>
        [JsonProperty("Workload")]
        public string Workload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DeviceIdSet.", this.DeviceIdSet);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "ManageDimension", this.ManageDimension);
            this.SetParamSimple(map, prefix + "ManageAccountId", this.ManageAccountId);
            this.SetParamSimple(map, prefix + "ManageAccount", this.ManageAccount);
            this.SetParamSimple(map, prefix + "ManageKubeconfig", this.ManageKubeconfig);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Workload", this.Workload);
        }
    }
}

