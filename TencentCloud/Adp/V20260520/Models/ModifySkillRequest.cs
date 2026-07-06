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

    public class ModifySkillRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>SkillId</p>
        /// </summary>
        [JsonProperty("SkillId")]
        public string SkillId{ get; set; }

        /// <summary>
        /// <p>空间ID</p>
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// <p>skill描述</p>
        /// </summary>
        [JsonProperty("DisplayDescription")]
        public string DisplayDescription{ get; set; }

        /// <summary>
        /// <p>skill名称</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>skill包文件地址（zip）；传入则触发新版本生成，需与SkillVersion、UpdateDescription配套传入</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>图标地址</p>
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// <p>skill版本号（与FileUrl配套传入）</p>
        /// </summary>
        [JsonProperty("SkillVersion")]
        public string SkillVersion{ get; set; }

        /// <summary>
        /// <p>版本变更说明（与FileUrl配套传入）</p>
        /// </summary>
        [JsonProperty("UpdateDescription")]
        public string UpdateDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillId", this.SkillId);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "DisplayDescription", this.DisplayDescription);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "SkillVersion", this.SkillVersion);
            this.SetParamSimple(map, prefix + "UpdateDescription", this.UpdateDescription);
        }
    }
}

