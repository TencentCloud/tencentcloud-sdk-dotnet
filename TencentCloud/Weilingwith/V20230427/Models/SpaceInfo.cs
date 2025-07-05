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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 项目空间id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public ulong? WorkspaceId{ get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("TenantId")]
        public ulong? TenantId{ get; set; }

        /// <summary>
        /// 英文名
        /// </summary>
        [JsonProperty("EnglishName")]
        public string EnglishName{ get; set; }

        /// <summary>
        /// 中文名
        /// </summary>
        [JsonProperty("ChineseName")]
        public string ChineseName{ get; set; }

        /// <summary>
        /// 项目空间描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 项目空间状态:0 启用 1 停用 -1 已删除
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 是否是公共空间
        /// </summary>
        [JsonProperty("IsCommWorkspace")]
        public bool? IsCommWorkspace{ get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonProperty("ValidityStartTime")]
        public string ValidityStartTime{ get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [JsonProperty("ValidityEndTime")]
        public string ValidityEndTime{ get; set; }

        /// <summary>
        /// 选中状态
        /// </summary>
        [JsonProperty("Selected")]
        public ulong? Selected{ get; set; }

        /// <summary>
        /// 系统生成状态
        /// </summary>
        [JsonProperty("IsSystem")]
        public ulong? IsSystem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "EnglishName", this.EnglishName);
            this.SetParamSimple(map, prefix + "ChineseName", this.ChineseName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsCommWorkspace", this.IsCommWorkspace);
            this.SetParamSimple(map, prefix + "ValidityStartTime", this.ValidityStartTime);
            this.SetParamSimple(map, prefix + "ValidityEndTime", this.ValidityEndTime);
            this.SetParamSimple(map, prefix + "Selected", this.Selected);
            this.SetParamSimple(map, prefix + "IsSystem", this.IsSystem);
        }
    }
}

