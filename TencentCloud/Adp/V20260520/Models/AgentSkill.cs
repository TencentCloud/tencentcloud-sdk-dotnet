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

    public class AgentSkill : AbstractModel
    {
        
        /// <summary>
        /// <p>skillId</p>
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// <p>skill名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>技能描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>skill展示名称</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>技能展示描述</p>
        /// </summary>
        [JsonProperty("DisplayDescription")]
        public string DisplayDescription{ get; set; }

        /// <summary>
        /// <p>skill图标url</p>
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// <p>Skill来源</p>
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// <p>Skill版本</p>
        /// </summary>
        [JsonProperty("CurrentVersion")]
        public string CurrentVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "DisplayDescription", this.DisplayDescription);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "CurrentVersion", this.CurrentVersion);
        }
    }
}

