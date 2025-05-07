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

    public class UserRole : AbstractModel
    {
        
        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("RoleId")]
        public long? RoleId{ get; set; }

        /// <summary>
        /// 用户app ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 角色权限
        /// </summary>
        [JsonProperty("Arn")]
        public string Arn{ get; set; }

        /// <summary>
        /// 最近修改时间戳
        /// </summary>
        [JsonProperty("ModifyTime")]
        public long? ModifyTime{ get; set; }

        /// <summary>
        /// 角色描述信息
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 创建者UIN
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// cos授权路径列表
        /// </summary>
        [JsonProperty("CosPermissionList")]
        public CosPermission[] CosPermissionList{ get; set; }

        /// <summary>
        /// cam策略json
        /// </summary>
        [JsonProperty("PermissionJson")]
        public string PermissionJson{ get; set; }

        /// <summary>
        /// 是否设置为常驻：1非常驻（默认）、2常驻（仅能设置一个常驻）
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Arn", this.Arn);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamArrayObj(map, prefix + "CosPermissionList.", this.CosPermissionList);
            this.SetParamSimple(map, prefix + "PermissionJson", this.PermissionJson);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
        }
    }
}

