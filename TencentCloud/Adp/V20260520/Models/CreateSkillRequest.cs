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

    public class CreateSkillRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Skill 创建方式，必填；仅允许</p><p>枚举值：</p><ul><li>1： FILE_UPLOAD（文件上传）</li><li>3： AIGC（AIGC生成）</li></ul>
        /// </summary>
        [JsonProperty("CreateType")]
        public long? CreateType{ get; set; }

        /// <summary>
        /// <p>skill包文件地址（zip）；FILE_UPLOAD / AIGC 均必填</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>空间ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>skill展示描述</p>
        /// </summary>
        [JsonProperty("DisplayDescription")]
        public string DisplayDescription{ get; set; }

        /// <summary>
        /// <p>skill展示名称</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>图标地址</p>
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// <p>skill业务唯一标识名（同企业下唯一）；未传时从skill包解析</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>版本号</p>
        /// </summary>
        [JsonProperty("SkillVersion")]
        public string SkillVersion{ get; set; }

        /// <summary>
        /// <p>版本变更说明</p>
        /// </summary>
        [JsonProperty("UpdateDescription")]
        public string UpdateDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateType", this.CreateType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "DisplayDescription", this.DisplayDescription);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SkillVersion", this.SkillVersion);
            this.SetParamSimple(map, prefix + "UpdateDescription", this.UpdateDescription);
        }
    }
}

