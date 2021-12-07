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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImagesVul : AbstractModel
    {
        
        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 组件
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 分类2
        /// </summary>
        [JsonProperty("CategoryType")]
        public string CategoryType{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Des")]
        public string Des{ get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [JsonProperty("OfficialSolution")]
        public string OfficialSolution{ get; set; }

        /// <summary>
        /// 引用
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// 防御方案
        /// </summary>
        [JsonProperty("DefenseSolution")]
        public string DefenseSolution{ get; set; }

        /// <summary>
        /// 提交时间
        /// </summary>
        [JsonProperty("SubmitTime")]
        public string SubmitTime{ get; set; }

        /// <summary>
        /// CVSS V3分数
        /// </summary>
        [JsonProperty("CVSSV3Score")]
        public float? CVSSV3Score{ get; set; }

        /// <summary>
        /// CVSS V3描述
        /// </summary>
        [JsonProperty("CVSSV3Desc")]
        public string CVSSV3Desc{ get; set; }

        /// <summary>
        /// 是否是重点关注：true：是，false：不是
        /// </summary>
        [JsonProperty("IsSuggest")]
        public bool? IsSuggest{ get; set; }

        /// <summary>
        /// 修复版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FixedVersions")]
        public string FixedVersions{ get; set; }

        /// <summary>
        /// 漏洞标签:"CanBeFixed","DynamicLevelPoc","DynamicLevelExp"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Des", this.Des);
            this.SetParamSimple(map, prefix + "OfficialSolution", this.OfficialSolution);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "DefenseSolution", this.DefenseSolution);
            this.SetParamSimple(map, prefix + "SubmitTime", this.SubmitTime);
            this.SetParamSimple(map, prefix + "CVSSV3Score", this.CVSSV3Score);
            this.SetParamSimple(map, prefix + "CVSSV3Desc", this.CVSSV3Desc);
            this.SetParamSimple(map, prefix + "IsSuggest", this.IsSuggest);
            this.SetParamSimple(map, prefix + "FixedVersions", this.FixedVersions);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
        }
    }
}

