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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoleBasicInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>角色ID，可通过 ListWorkspaceRoles / ListConsoleRoles 接口获取；创建/更新角色时无需填写（由系统自动生成，创建成功后从响应 Data.RoleId 获取）</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>角色名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>角色描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>显示名称</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>角色类型：workspace=工作空间系统角色，workspace_custom=工作空间自定义角色，console=控制台角色；查询时返回，创建时无需填写（系统固定创建自定义角色）</p>
        /// </summary>
        [JsonProperty("RoleType")]
        public string RoleType{ get; set; }

        /// <summary>
        /// <p>角色来源（查询侧字段，创建时无需填写）：0=未指定，1=用户直绑，2=用户组继承，3=两者都有</p>
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// <p>继承来源的用户组名称列表（查询侧字段，创建时无需填写），Source=1 时为空</p>
        /// </summary>
        [JsonProperty("GroupNames")]
        public string[] GroupNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArraySimple(map, prefix + "GroupNames.", this.GroupNames);
        }
    }
}

