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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourcePathTree : AbstractModel
    {
        
        /// <summary>
        /// 资源名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否为叶子节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// 资源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 本地路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }

        /// <summary>
        /// 远程路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemotePath")]
        public string RemotePath{ get; set; }

        /// <summary>
        /// 文件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileExtensionType")]
        public string FileExtensionType{ get; set; }

        /// <summary>
        /// 文件大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 文件MD5值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Md5Value")]
        public string Md5Value{ get; set; }

        /// <summary>
        /// 文件拥有者名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

        /// <summary>
        /// 更新人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// 文件更新人uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateUserId")]
        public string UpdateUserId{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// Cos存储桶名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// Cos地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 额外信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
            this.SetParamSimple(map, prefix + "RemotePath", this.RemotePath);
            this.SetParamSimple(map, prefix + "FileExtensionType", this.FileExtensionType);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Md5Value", this.Md5Value);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "UpdateUser", this.UpdateUser);
            this.SetParamSimple(map, prefix + "UpdateUserId", this.UpdateUserId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
        }
    }
}

