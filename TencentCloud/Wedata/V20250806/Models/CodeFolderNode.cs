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

    public class CodeFolderNode : AbstractModel
    {
        
        /// <summary>
        /// 唯一标识
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 类型 folder，script
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// 业务参数	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// 权限范围: SHARED, PRIVATE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessScope")]
        public string AccessScope{ get; set; }

        /// <summary>
        /// 节点路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 目录/文件责任人uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("CreateUserUin")]
        public string CreateUserUin{ get; set; }

        /// <summary>
        /// 当前用户对节点拥有的权限	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NodePermission")]
        public string NodePermission{ get; set; }

        /// <summary>
        /// 子节点列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Children")]
        public CodeFolderNode[] Children{ get; set; }

        /// <summary>
        /// 父文件夹路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentFolderPath")]
        public string ParentFolderPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreateUserUin", this.CreateUserUin);
            this.SetParamSimple(map, prefix + "NodePermission", this.NodePermission);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
            this.SetParamSimple(map, prefix + "ParentFolderPath", this.ParentFolderPath);
        }
    }
}

