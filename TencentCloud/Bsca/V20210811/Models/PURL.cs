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

namespace TencentCloud.Bsca.V20210811.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PURL : AbstractModel
    {
        
        /// <summary>
        /// 组件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 组件所属的类型，如：github, gitlab, generic, deb, rpm, maven 等
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 组件名的前缀名，如github和gitlab的用户名，deb的操作系统，maven包的group id等
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 修饰组件的额外属性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Qualifiers")]
        public Qualifier[] Qualifiers{ get; set; }

        /// <summary>
        /// 相对于组件包根位置的子目录
        /// </summary>
        [JsonProperty("Subpath")]
        public string Subpath{ get; set; }

        /// <summary>
        /// 组件版本号
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamArrayObj(map, prefix + "Qualifiers.", this.Qualifiers);
            this.SetParamSimple(map, prefix + "Subpath", this.Subpath);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

