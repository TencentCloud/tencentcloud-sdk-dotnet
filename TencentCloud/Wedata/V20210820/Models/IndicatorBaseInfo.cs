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

    public class IndicatorBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 指标编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorCode")]
        public string IndicatorCode{ get; set; }

        /// <summary>
        /// 指标类型（1-原子指标 2-衍生指标 3-复合指标）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorType")]
        public long? IndicatorType{ get; set; }

        /// <summary>
        /// 业务负责人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizOwner")]
        public string BizOwner{ get; set; }

        /// <summary>
        /// 技术负责人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TechOwner")]
        public string TechOwner{ get; set; }

        /// <summary>
        /// 业务口径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizCaliber")]
        public string BizCaliber{ get; set; }

        /// <summary>
        /// 指标描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 等级：40-L4核心 30-L3重要 20-L2一般 10-L1临时
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 计算逻辑
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalLogic")]
        public string CalLogic{ get; set; }

        /// <summary>
        /// 计算频次
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalFreq")]
        public string CalFreq{ get; set; }

        /// <summary>
        /// 度量单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MeasureUnit")]
        public long? MeasureUnit{ get; set; }

        /// <summary>
        /// 精度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Accuracy")]
        public long? Accuracy{ get; set; }

        /// <summary>
        /// 关联指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceIndicatorIds")]
        public IndicatorBaseSimpleInfo[] SourceIndicatorIds{ get; set; }

        /// <summary>
        /// ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 维度列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DimensionIds")]
        public AssetDimSimpleVO[] DimensionIds{ get; set; }

        /// <summary>
        /// 文件夹ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FolderId")]
        public long? FolderId{ get; set; }

        /// <summary>
        /// 状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 业务负责人名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizOwnerName")]
        public string BizOwnerName{ get; set; }

        /// <summary>
        /// 技术负责人名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TechOwnerName")]
        public string TechOwnerName{ get; set; }

        /// <summary>
        /// 发布时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishTime")]
        public string PublishTime{ get; set; }

        /// <summary>
        /// 发布人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishAccount")]
        public string PublishAccount{ get; set; }

        /// <summary>
        /// 发布人名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublishAccountName")]
        public string PublishAccountName{ get; set; }

        /// <summary>
        /// 最后修订时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public string LastModifyTime{ get; set; }

        /// <summary>
        /// 最后修订人ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifyAccount")]
        public string LastModifyAccount{ get; set; }

        /// <summary>
        /// 最后修订人名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifyAccountName")]
        public string LastModifyAccountName{ get; set; }

        /// <summary>
        /// 变更日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChangeLogList")]
        public ChangeLog[] ChangeLogList{ get; set; }

        /// <summary>
        /// 字段列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableColumns")]
        public AssetDimTableColumn[] TableColumns{ get; set; }

        /// <summary>
        /// 关联指标(包含多层级关联指标)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllSourceIndicatorIds")]
        public IndicatorBaseInfo[] AllSourceIndicatorIds{ get; set; }

        /// <summary>
        /// 资产guid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 资产编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetCode")]
        public string AssetCode{ get; set; }

        /// <summary>
        /// 被关联的指标
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelatedIndicatorIds")]
        public IndicatorBaseInfo[] RelatedIndicatorIds{ get; set; }

        /// <summary>
        /// 数据目录ID列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizCatalogIds")]
        public long?[] BizCatalogIds{ get; set; }

        /// <summary>
        /// 数据目录名称列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizCatalogNames")]
        public string[] BizCatalogNames{ get; set; }

        /// <summary>
        /// 资产等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetLevel")]
        public long? AssetLevel{ get; set; }

        /// <summary>
        /// 资产发布状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetStatus")]
        public long? AssetStatus{ get; set; }

        /// <summary>
        /// 资产发布时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetPublishTime")]
        public string AssetPublishTime{ get; set; }

        /// <summary>
        /// 资产发布人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetPublishAccount")]
        public string AssetPublishAccount{ get; set; }

        /// <summary>
        /// 资产发布人名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetPublishAccountName")]
        public string AssetPublishAccountName{ get; set; }

        /// <summary>
        /// 指标权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorPermission")]
        public PermissionStatus IndicatorPermission{ get; set; }

        /// <summary>
        /// 资产权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateOption")]
        public DataAssetOption OperateOption{ get; set; }

        /// <summary>
        /// 项目 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 项目名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IndicatorCode", this.IndicatorCode);
            this.SetParamSimple(map, prefix + "IndicatorType", this.IndicatorType);
            this.SetParamSimple(map, prefix + "BizOwner", this.BizOwner);
            this.SetParamSimple(map, prefix + "TechOwner", this.TechOwner);
            this.SetParamSimple(map, prefix + "BizCaliber", this.BizCaliber);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "CalLogic", this.CalLogic);
            this.SetParamSimple(map, prefix + "CalFreq", this.CalFreq);
            this.SetParamSimple(map, prefix + "MeasureUnit", this.MeasureUnit);
            this.SetParamSimple(map, prefix + "Accuracy", this.Accuracy);
            this.SetParamArrayObj(map, prefix + "SourceIndicatorIds.", this.SourceIndicatorIds);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "DimensionIds.", this.DimensionIds);
            this.SetParamSimple(map, prefix + "FolderId", this.FolderId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BizOwnerName", this.BizOwnerName);
            this.SetParamSimple(map, prefix + "TechOwnerName", this.TechOwnerName);
            this.SetParamSimple(map, prefix + "PublishTime", this.PublishTime);
            this.SetParamSimple(map, prefix + "PublishAccount", this.PublishAccount);
            this.SetParamSimple(map, prefix + "PublishAccountName", this.PublishAccountName);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "LastModifyAccount", this.LastModifyAccount);
            this.SetParamSimple(map, prefix + "LastModifyAccountName", this.LastModifyAccountName);
            this.SetParamArrayObj(map, prefix + "ChangeLogList.", this.ChangeLogList);
            this.SetParamArrayObj(map, prefix + "TableColumns.", this.TableColumns);
            this.SetParamArrayObj(map, prefix + "AllSourceIndicatorIds.", this.AllSourceIndicatorIds);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetCode", this.AssetCode);
            this.SetParamArrayObj(map, prefix + "RelatedIndicatorIds.", this.RelatedIndicatorIds);
            this.SetParamArraySimple(map, prefix + "BizCatalogIds.", this.BizCatalogIds);
            this.SetParamArraySimple(map, prefix + "BizCatalogNames.", this.BizCatalogNames);
            this.SetParamSimple(map, prefix + "AssetLevel", this.AssetLevel);
            this.SetParamSimple(map, prefix + "AssetStatus", this.AssetStatus);
            this.SetParamSimple(map, prefix + "AssetPublishTime", this.AssetPublishTime);
            this.SetParamSimple(map, prefix + "AssetPublishAccount", this.AssetPublishAccount);
            this.SetParamSimple(map, prefix + "AssetPublishAccountName", this.AssetPublishAccountName);
            this.SetParamObj(map, prefix + "IndicatorPermission.", this.IndicatorPermission);
            this.SetParamObj(map, prefix + "OperateOption.", this.OperateOption);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
        }
    }
}

