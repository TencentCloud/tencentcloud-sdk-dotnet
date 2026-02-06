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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RevokePrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源数组，数据来源于ListPermissions接口返回的Resource中的ResourceType和ResourceUri
        /// </summary>
        [JsonProperty("Resources")]
        public PrivilegeResource[] Resources{ get; set; }

        /// <summary>
        /// 授权回收主体数组，参数组装需要注意：
        /// 1.SubjectType 和SubjectValues的取值参考ListPermissions接口中返回SubjectDetails中的SubjectType和SubjectValue
        /// 2.批量回收时，Subjects数组长度需要与权限点Privileges长度一致，并且数据一一对应
        /// </summary>
        [JsonProperty("Subjects")]
        public Subject[] Subjects{ get; set; }

        /// <summary>
        /// 权限点，Name来源于ListPermissions接口返回的PermissionDetails中的Name，例如：BROWSE 、GRANT_PRIVILEGES
        /// </summary>
        [JsonProperty("Privileges")]
        public PrivilegeInfo[] Privileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamArrayObj(map, prefix + "Subjects.", this.Subjects);
            this.SetParamArrayObj(map, prefix + "Privileges.", this.Privileges);
        }
    }
}

