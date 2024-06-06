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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationalFunction : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 层级路径
        /// </summary>
        [JsonProperty("LayerPath")]
        public string LayerPath{ get; set; }

        /// <summary>
        /// 上级层级路径
        /// </summary>
        [JsonProperty("ParentLayerPath")]
        public string ParentLayerPath{ get; set; }

        /// <summary>
        /// 函数类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 函数分类：窗口函数、聚合函数、日期函数......
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 函数种类：系统函数、自定义函数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 函数状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 函数说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 函数用法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// 函数参数说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamDesc")]
        public string ParamDesc{ get; set; }

        /// <summary>
        /// 函数返回值说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReturnDesc")]
        public string ReturnDesc{ get; set; }

        /// <summary>
        /// 函数示例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Example")]
        public string Example{ get; set; }

        /// <summary>
        /// 集群实例引擎 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterIdentifier")]
        public string ClusterIdentifier{ get; set; }

        /// <summary>
        /// 函数 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FuncId")]
        public string FuncId{ get; set; }

        /// <summary>
        /// 函数类名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// 函数资源列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceList")]
        public FunctionVersion[] ResourceList{ get; set; }

        /// <summary>
        /// 操作人 ID 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorUserIds")]
        public long?[] OperatorUserIds{ get; set; }

        /// <summary>
        /// 公有云 Owner ID 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUserIds")]
        public long?[] OwnerUserIds{ get; set; }

        /// <summary>
        /// 数据库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 提交失败错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubmitErrorMsg")]
        public string SubmitErrorMsg{ get; set; }

        /// <summary>
        /// 模式名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 函数命令格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommandFormat")]
        public string CommandFormat{ get; set; }

        /// <summary>
        /// 名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

        /// <summary>
        /// 时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubmitTimestamp")]
        public string SubmitTimestamp{ get; set; }

        /// <summary>
        /// 函数tag
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 操作人 ID 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorUserIdsStr")]
        public string[] OperatorUserIdsStr{ get; set; }

        /// <summary>
        /// 公有云 Owner ID 列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerUserIdsStr")]
        public string[] OwnerUserIdsStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "LayerPath", this.LayerPath);
            this.SetParamSimple(map, prefix + "ParentLayerPath", this.ParentLayerPath);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "ParamDesc", this.ParamDesc);
            this.SetParamSimple(map, prefix + "ReturnDesc", this.ReturnDesc);
            this.SetParamSimple(map, prefix + "Example", this.Example);
            this.SetParamSimple(map, prefix + "ClusterIdentifier", this.ClusterIdentifier);
            this.SetParamSimple(map, prefix + "FuncId", this.FuncId);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamArrayObj(map, prefix + "ResourceList.", this.ResourceList);
            this.SetParamArraySimple(map, prefix + "OperatorUserIds.", this.OperatorUserIds);
            this.SetParamArraySimple(map, prefix + "OwnerUserIds.", this.OwnerUserIds);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "SubmitErrorMsg", this.SubmitErrorMsg);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "CommandFormat", this.CommandFormat);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "SubmitTimestamp", this.SubmitTimestamp);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamArraySimple(map, prefix + "OperatorUserIdsStr.", this.OperatorUserIdsStr);
            this.SetParamArraySimple(map, prefix + "OwnerUserIdsStr.", this.OwnerUserIdsStr);
        }
    }
}

