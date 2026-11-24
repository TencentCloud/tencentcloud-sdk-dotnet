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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PromptTemplateSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>提示词模板Profile</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Profile")]
        public PromptTemplateProfile Profile{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("LabelList")]
        public PromptTemplateLabel[] LabelList{ get; set; }

        /// <summary>
        /// <p>是否已收藏</p>
        /// </summary>
        [JsonProperty("IsFavorite")]
        public bool? IsFavorite{ get; set; }

        /// <summary>
        /// <p>权限列表</p>
        /// </summary>
        [JsonProperty("PermissionIdList")]
        public string[] PermissionIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Profile.", this.Profile);
            this.SetParamArrayObj(map, prefix + "LabelList.", this.LabelList);
            this.SetParamSimple(map, prefix + "IsFavorite", this.IsFavorite);
            this.SetParamArraySimple(map, prefix + "PermissionIdList.", this.PermissionIdList);
        }
    }
}

