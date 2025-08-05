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

    public class DescribeResourceConfigResultV2 : AbstractModel
    {
        
        /// <summary>
        /// STS参数配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sts")]
        public DescribeResourceConfigSts Sts{ get; set; }

        /// <summary>
        /// 许可信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("License")]
        public DescribeResourceConfigLicense License{ get; set; }

        /// <summary>
        /// 部署组相关的参数配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Group")]
        public GroupResourceConfig Group{ get; set; }

        /// <summary>
        /// 实例相关的参数配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Instance")]
        public InstanceResourceConfig Instance{ get; set; }

        /// <summary>
        /// Cluster相关配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cluster")]
        public DescribeResourceConfigCluster Cluster{ get; set; }

        /// <summary>
        /// 程序包相关配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Package")]
        public PackageConfig Package{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Sts.", this.Sts);
            this.SetParamObj(map, prefix + "License.", this.License);
            this.SetParamObj(map, prefix + "Group.", this.Group);
            this.SetParamObj(map, prefix + "Instance.", this.Instance);
            this.SetParamObj(map, prefix + "Cluster.", this.Cluster);
            this.SetParamObj(map, prefix + "Package.", this.Package);
        }
    }
}

