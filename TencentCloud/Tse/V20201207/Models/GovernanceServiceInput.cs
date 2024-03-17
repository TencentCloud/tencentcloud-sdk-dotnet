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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GovernanceServiceInput : AbstractModel
    {
        
        /// <summary>
        /// 服务名。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 服务所属命名空间。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 服务描述信息。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 服务元数据。
        /// </summary>
        [JsonProperty("Metadatas")]
        public Metadata[] Metadatas{ get; set; }

        /// <summary>
        /// 服务所属部门。
        /// </summary>
        [JsonProperty("Department")]
        public string Department{ get; set; }

        /// <summary>
        /// 服务所属业务。
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 被添加进来可以操作此命名空间的用户ID列表
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 被添加进来可以操作此命名空间的用户组ID列表
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 从操作此命名空间的用户组ID列表被移除的ID列表
        /// </summary>
        [JsonProperty("RemoveUserIds")]
        public string[] RemoveUserIds{ get; set; }

        /// <summary>
        /// 从可以操作此命名空间的用户组ID列表中被移除的ID列表
        /// </summary>
        [JsonProperty("RemoveGroupIds")]
        public string[] RemoveGroupIds{ get; set; }

        /// <summary>
        /// 该服务对哪些命名空间可见
        /// </summary>
        [JsonProperty("ExportTo")]
        public string[] ExportTo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
            this.SetParamSimple(map, prefix + "Department", this.Department);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArraySimple(map, prefix + "RemoveUserIds.", this.RemoveUserIds);
            this.SetParamArraySimple(map, prefix + "RemoveGroupIds.", this.RemoveGroupIds);
            this.SetParamArraySimple(map, prefix + "ExportTo.", this.ExportTo);
        }
    }
}

