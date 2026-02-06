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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteUserPermissionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要授权的用户的唯一标识符（支持子账号 UIN和角色UIN）
        /// </summary>
        [JsonProperty("TargetUin")]
        public string TargetUin{ get; set; }

        /// <summary>
        /// 用户最终应拥有的完整权限列表。采用声明式语义，传入的列表代表用户最终应该拥有的全部权限，系统会自动计算差异并执行必要的创建/删除操作。为空或不提供时将清除该用户的所有权限。最大支持 100 个权限项。
        /// </summary>
        [JsonProperty("Permissions")]
        public PermissionItem[] Permissions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamArrayObj(map, prefix + "Permissions.", this.Permissions);
        }
    }
}

