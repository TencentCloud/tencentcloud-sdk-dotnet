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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，按照【集群ID】进行过滤，可通过调用DescribeClusters查询已创建的项目列表或登录控制台进行查看；也可以调用CreateCluster创建新的项目。集群ID例如：cls-6a79x94v。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群描述信息
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 备注名
        /// </summary>
        [JsonProperty("ClusterRemarkName")]
        public string ClusterRemarkName{ get; set; }

        /// <summary>
        /// 是否开启cls日志功能，true表示开启，false表示关闭
        /// </summary>
        [JsonProperty("EnableLogCollection")]
        public bool? EnableLogCollection{ get; set; }

        /// <summary>
        /// 是否修复cls日志功能，true表示修复，false表示不修复
        /// </summary>
        [JsonProperty("RepairLog")]
        public bool? RepairLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "ClusterRemarkName", this.ClusterRemarkName);
            this.SetParamSimple(map, prefix + "EnableLogCollection", this.EnableLogCollection);
            this.SetParamSimple(map, prefix + "RepairLog", this.RepairLog);
        }
    }
}

