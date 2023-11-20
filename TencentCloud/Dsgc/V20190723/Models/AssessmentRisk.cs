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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssessmentRisk : AbstractModel
    {
        
        /// <summary>
        /// 风险项Id
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// 风险项描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// 评估模板Id
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 评估模板名称
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 评估项Id
        /// </summary>
        [JsonProperty("ControlItemId")]
        public string ControlItemId{ get; set; }

        /// <summary>
        /// 评估项名称
        /// </summary>
        [JsonProperty("ControlItemName")]
        public string ControlItemName{ get; set; }

        /// <summary>
        /// 评估描述
        /// </summary>
        [JsonProperty("ControlItemDesc")]
        public string ControlItemDesc{ get; set; }

        /// <summary>
        /// 风险等级，取值（high，medium，low）
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险缓解措施
        /// </summary>
        [JsonProperty("RiskMitigation")]
        public string RiskMitigation{ get; set; }

        /// <summary>
        /// 风险处理状态。(waiting待处理, processing处理中, finished已处理)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 风险生成时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 风险负责人
        /// </summary>
        [JsonProperty("RiskOwner")]
        public string RiskOwner{ get; set; }

        /// <summary>
        /// 风险涉及资产
        /// </summary>
        [JsonProperty("RelatedAsset")]
        public string RelatedAsset{ get; set; }

        /// <summary>
        /// 风险涉及资产id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 风险涉及资产名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceName")]
        public string DataSourceName{ get; set; }

        /// <summary>
        /// 资产名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 建议使用安全产品
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityProduct")]
        public SecurityProduct[] SecurityProduct{ get; set; }

        /// <summary>
        /// 风险类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// 风险面
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskSide")]
        public string RiskSide{ get; set; }

        /// <summary>
        /// 数据源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "ControlItemId", this.ControlItemId);
            this.SetParamSimple(map, prefix + "ControlItemName", this.ControlItemName);
            this.SetParamSimple(map, prefix + "ControlItemDesc", this.ControlItemDesc);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskMitigation", this.RiskMitigation);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "RiskOwner", this.RiskOwner);
            this.SetParamSimple(map, prefix + "RelatedAsset", this.RelatedAsset);
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "DataSourceName", this.DataSourceName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamArrayObj(map, prefix + "SecurityProduct.", this.SecurityProduct);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "RiskSide", this.RiskSide);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
        }
    }
}

