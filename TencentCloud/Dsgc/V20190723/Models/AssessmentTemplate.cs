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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssessmentTemplate : AbstractModel
    {
        
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

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
        /// 描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 模板来源，内置/用户自定，取值（system，user）
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 模板类型，自动化/半自动化/问卷，取值（auto，semi-auto，law）等
        /// </summary>
        [JsonProperty("UseType")]
        public string UseType{ get; set; }

        /// <summary>
        /// 评估模板创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 模板关联的评估项数量
        /// </summary>
        [JsonProperty("ControlItemCount")]
        public long? ControlItemCount{ get; set; }

        /// <summary>
        /// 模板已启用的评估项数量
        /// </summary>
        [JsonProperty("AppliedItemCount")]
        public long? AppliedItemCount{ get; set; }

        /// <summary>
        /// 模板启用状态，草稿/已启用，取值draft / launched
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 支持的数据源类型
        /// </summary>
        [JsonProperty("SupportDataSource")]
        public string[] SupportDataSource{ get; set; }

        /// <summary>
        /// 是否包含攻击面风险
        /// </summary>
        [JsonProperty("IsASMTemplate")]
        public bool? IsASMTemplate{ get; set; }

        /// <summary>
        /// 合规组id
        /// </summary>
        [JsonProperty("IdentifyComplianceId")]
        public long? IdentifyComplianceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "UseType", this.UseType);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ControlItemCount", this.ControlItemCount);
            this.SetParamSimple(map, prefix + "AppliedItemCount", this.AppliedItemCount);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SupportDataSource.", this.SupportDataSource);
            this.SetParamSimple(map, prefix + "IsASMTemplate", this.IsASMTemplate);
            this.SetParamSimple(map, prefix + "IdentifyComplianceId", this.IdentifyComplianceId);
        }
    }
}

