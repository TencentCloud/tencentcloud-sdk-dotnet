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

    public class RiskItemInfo : AbstractModel
    {
        
        /// <summary>
        /// 最新风险项id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 数据源名称
        /// </summary>
        [JsonProperty("DataSourceName")]
        public string DataSourceName{ get; set; }

        /// <summary>
        /// 数据源类型
        /// </summary>
        [JsonProperty("DataSourceType")]
        public string DataSourceType{ get; set; }

        /// <summary>
        /// 资源地域
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("RiskType")]
        public string RiskType{ get; set; }

        /// <summary>
        /// 风险项
        /// </summary>
        [JsonProperty("RiskName")]
        public string RiskName{ get; set; }

        /// <summary>
        /// 风险级别
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// 建议措施
        /// </summary>
        [JsonProperty("SuggestAction")]
        public string SuggestAction{ get; set; }

        /// <summary>
        /// 安全产品（可能有多个）
        /// </summary>
        [JsonProperty("SecurityProduct")]
        public SecurityProduct[] SecurityProduct{ get; set; }

        /// <summary>
        /// 状态(waiting:待处理，processing:处理中，finished:已处理，ignored:已忽略)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 扫描时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 最后处置时间
        /// </summary>
        [JsonProperty("LastProcessTime")]
        public string LastProcessTime{ get; set; }

        /// <summary>
        /// 分类分级合规组Id
        /// </summary>
        [JsonProperty("IdentifyComplianceId")]
        public long? IdentifyComplianceId{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("ItemSubType")]
        public string ItemSubType{ get; set; }

        /// <summary>
        /// 风险面
        /// </summary>
        [JsonProperty("RiskSide")]
        public string RiskSide{ get; set; }

        /// <summary>
        /// API安全风险链接
        /// </summary>
        [JsonProperty("APIRiskLinkURL")]
        public string APIRiskLinkURL{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "DataSourceName", this.DataSourceName);
            this.SetParamSimple(map, prefix + "DataSourceType", this.DataSourceType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "SuggestAction", this.SuggestAction);
            this.SetParamArrayObj(map, prefix + "SecurityProduct.", this.SecurityProduct);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "LastProcessTime", this.LastProcessTime);
            this.SetParamSimple(map, prefix + "IdentifyComplianceId", this.IdentifyComplianceId);
            this.SetParamSimple(map, prefix + "ItemSubType", this.ItemSubType);
            this.SetParamSimple(map, prefix + "RiskSide", this.RiskSide);
            this.SetParamSimple(map, prefix + "APIRiskLinkURL", this.APIRiskLinkURL);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

