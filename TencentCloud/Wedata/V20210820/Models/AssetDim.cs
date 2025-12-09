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

    public class AssetDim : AbstractModel
    {
        
        /// <summary>
        /// 文件夹 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public ulong? FolderId{ get; set; }

        /// <summary>
        /// 维度编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimCode")]
        public string DimCode{ get; set; }

        /// <summary>
        /// 维度名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimName")]
        public string DimName{ get; set; }

        /// <summary>
        /// 维度描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 维度负责人UserId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerAccount")]
        public ulong? OwnerAccount{ get; set; }

        /// <summary>
        /// 维度负责人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 变更人ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyUserId")]
        public long? ModifyUserId{ get; set; }

        /// <summary>
        /// 维度最近修改人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyUser")]
        public string ModifyUser{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 维度录入方式， 取值：manual-手动录入；dict-关联字典表；
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimType")]
        public string DimType{ get; set; }

        /// <summary>
        /// 枚举值数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValuePairCount")]
        public ulong? ValuePairCount{ get; set; }

        /// <summary>
        /// 关联指标数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorPairCount")]
        public ulong? IndicatorPairCount{ get; set; }

        /// <summary>
        /// 关联字段数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableColumnCount")]
        public ulong? TableColumnCount{ get; set; }

        /// <summary>
        /// 维度 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimId")]
        public ulong? DimId{ get; set; }

        /// <summary>
        /// 维度关联表字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimTableLink")]
        public DimTableLink DimTableLink{ get; set; }

        /// <summary>
        /// 枚举值列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValuePairs")]
        public Pair[] ValuePairs{ get; set; }

        /// <summary>
        /// 维度关联字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableColumns")]
        public AssetDimTableColumn[] TableColumns{ get; set; }

        /// <summary>
        /// 关联指标列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceIndicatorIds")]
        public IndicatorBaseSimpleInfo[] SourceIndicatorIds{ get; set; }

        /// <summary>
        /// 权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimPermission")]
        public PermissionStatus DimPermission{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "DimCode", this.DimCode);
            this.SetParamSimple(map, prefix + "DimName", this.DimName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OwnerAccount", this.OwnerAccount);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "ModifyUserId", this.ModifyUserId);
            this.SetParamSimple(map, prefix + "ModifyUser", this.ModifyUser);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DimType", this.DimType);
            this.SetParamSimple(map, prefix + "ValuePairCount", this.ValuePairCount);
            this.SetParamSimple(map, prefix + "IndicatorPairCount", this.IndicatorPairCount);
            this.SetParamSimple(map, prefix + "TableColumnCount", this.TableColumnCount);
            this.SetParamSimple(map, prefix + "DimId", this.DimId);
            this.SetParamObj(map, prefix + "DimTableLink.", this.DimTableLink);
            this.SetParamArrayObj(map, prefix + "ValuePairs.", this.ValuePairs);
            this.SetParamArrayObj(map, prefix + "TableColumns.", this.TableColumns);
            this.SetParamArrayObj(map, prefix + "SourceIndicatorIds.", this.SourceIndicatorIds);
            this.SetParamObj(map, prefix + "DimPermission.", this.DimPermission);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
        }
    }
}

