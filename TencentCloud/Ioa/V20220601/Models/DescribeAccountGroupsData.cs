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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccountGroupsData : AbstractModel
    {
        
        /// <summary>
        /// 账号分组名全路径，点分格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NamePath")]
        public string NamePath{ get; set; }

        /// <summary>
        /// 账号分组ID全路径，数组格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdPathArr")]
        public long?[] IdPathArr{ get; set; }

        /// <summary>
        /// 扩展信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Utime")]
        public string Utime{ get; set; }

        /// <summary>
        /// 父分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// 源账号组织ID。使用第三方导入用户源时，记录该分组在源组织架构下的分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgId")]
        public string OrgId{ get; set; }

        /// <summary>
        /// 分组名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 分组描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 同步数据源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 账号分组ID全路径，点分格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdPath")]
        public string IdPath{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Itime")]
        public string Itime{ get; set; }

        /// <summary>
        /// 父源账号组织ID。使用第三方导入用户源时，记录该分组在源组织架构下的分组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentOrgId")]
        public string ParentOrgId{ get; set; }

        /// <summary>
        /// 导入类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// miniIAM id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniIamId")]
        public string MiniIamId{ get; set; }

        /// <summary>
        /// 该分组下含子组的所有用户总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserTotal")]
        public long? UserTotal{ get; set; }

        /// <summary>
        /// 是否叶子节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// 是否该账户的直接权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// 最新一次同步任务的结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestSyncResult")]
        public string LatestSyncResult{ get; set; }

        /// <summary>
        /// 最新一次同步任务的结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestSyncTime")]
        public string LatestSyncTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamePath", this.NamePath);
            this.SetParamArraySimple(map, prefix + "IdPathArr.", this.IdPathArr);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "Utime", this.Utime);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "IdPath", this.IdPath);
            this.SetParamSimple(map, prefix + "Itime", this.Itime);
            this.SetParamSimple(map, prefix + "ParentOrgId", this.ParentOrgId);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "MiniIamId", this.MiniIamId);
            this.SetParamSimple(map, prefix + "UserTotal", this.UserTotal);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "LatestSyncResult", this.LatestSyncResult);
            this.SetParamSimple(map, prefix + "LatestSyncTime", this.LatestSyncTime);
        }
    }
}

