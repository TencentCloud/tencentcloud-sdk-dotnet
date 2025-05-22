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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DependencyPackage : AbstractModel
    {
        
        /// <summary>
        /// 依赖包类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageSource")]
        public string PackageSource{ get; set; }

        /// <summary>
        /// 依赖包信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MavenPackage")]
        public string MavenPackage{ get; set; }

        /// <summary>
        /// 依赖包仓库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MavenRepository")]
        public string MavenRepository{ get; set; }

        /// <summary>
        /// maven包exclusion信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MavenExclusion")]
        public string MavenExclusion{ get; set; }

        /// <summary>
        /// pypi包信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PypiPackage")]
        public string PypiPackage{ get; set; }

        /// <summary>
        /// pypi索引地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PypiIndexUrl")]
        public string PypiIndexUrl{ get; set; }

        /// <summary>
        /// 文件包的类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 文件包的路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PackagePath")]
        public string PackagePath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageSource", this.PackageSource);
            this.SetParamSimple(map, prefix + "MavenPackage", this.MavenPackage);
            this.SetParamSimple(map, prefix + "MavenRepository", this.MavenRepository);
            this.SetParamSimple(map, prefix + "MavenExclusion", this.MavenExclusion);
            this.SetParamSimple(map, prefix + "PypiPackage", this.PypiPackage);
            this.SetParamSimple(map, prefix + "PypiIndexUrl", this.PypiIndexUrl);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackagePath", this.PackagePath);
        }
    }
}

