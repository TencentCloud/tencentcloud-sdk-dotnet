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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HpcClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// 高性能计算集群ID
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// 高性能计算集群名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 高性能计算集群备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 集群下设备容量
        /// </summary>
        [JsonProperty("CvmQuotaTotal")]
        public ulong? CvmQuotaTotal{ get; set; }

        /// <summary>
        /// 集群所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 集群当前已有设备量
        /// </summary>
        [JsonProperty("CurrentNum")]
        public ulong? CurrentNum{ get; set; }

        /// <summary>
        /// 集群创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 集群内实例ID列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 高性能计算集群类型。
        /// </summary>
        [JsonProperty("HpcClusterType")]
        public string HpcClusterType{ get; set; }

        /// <summary>
        /// 高性能计算集群对应的业务场景标识，当前只支持CDC。	
        /// </summary>
        [JsonProperty("HpcClusterBusinessId")]
        public string HpcClusterBusinessId{ get; set; }

        /// <summary>
        /// 高性能计算集群网络模式
        /// </summary>
        [JsonProperty("HpcClusterNetMode")]
        public ulong? HpcClusterNetMode{ get; set; }

        /// <summary>
        /// 高性能计算集群关联的标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CvmQuotaTotal", this.CvmQuotaTotal);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "HpcClusterType", this.HpcClusterType);
            this.SetParamSimple(map, prefix + "HpcClusterBusinessId", this.HpcClusterBusinessId);
            this.SetParamSimple(map, prefix + "HpcClusterNetMode", this.HpcClusterNetMode);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

