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

    public class Component : AbstractModel
    {
        
        /// <summary>
        /// 第三方组件的PURL
        /// </summary>
        [JsonProperty("PURL")]
        public PURL PURL{ get; set; }

        /// <summary>
        /// 第三方组件的主页
        /// </summary>
        [JsonProperty("Homepage")]
        public string Homepage{ get; set; }

        /// <summary>
        /// 第三方组件的简介
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// 第三方组件的别名列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NicknameList")]
        public string[] NicknameList{ get; set; }

        /// <summary>
        /// 第三方组件的代码位置列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeLocationList")]
        public string[] CodeLocationList{ get; set; }

        /// <summary>
        /// 第三方组件的许可证表达式
        /// </summary>
        [JsonProperty("LicenseExpression")]
        public string LicenseExpression{ get; set; }

        /// <summary>
        /// 第三方组件的版本信息(如果匹配到版本)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VersionInfo")]
        public ComponentVersionInfo VersionInfo{ get; set; }

        /// <summary>
        /// 第三方组件的最后更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// 第三方组件的类型标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public string[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PURL.", this.PURL);
            this.SetParamSimple(map, prefix + "Homepage", this.Homepage);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamArraySimple(map, prefix + "NicknameList.", this.NicknameList);
            this.SetParamArraySimple(map, prefix + "CodeLocationList.", this.CodeLocationList);
            this.SetParamSimple(map, prefix + "LicenseExpression", this.LicenseExpression);
            this.SetParamObj(map, prefix + "VersionInfo.", this.VersionInfo);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamArraySimple(map, prefix + "TagList.", this.TagList);
        }
    }
}

