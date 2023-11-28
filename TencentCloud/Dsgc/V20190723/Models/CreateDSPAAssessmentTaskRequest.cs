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

    public class CreateDSPAAssessmentTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// DSPA实例Id，格式“dspa-xxxxxxxx”
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 评估任务名称。1-20个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 评估模板Id，格式“template-xxxxxxxx”
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 评估业务名称。1-60个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字
        /// </summary>
        [JsonProperty("BusinessName")]
        [System.Obsolete]
        public string BusinessName{ get; set; }

        /// <summary>
        /// 业务所属部门。1-60个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字
        /// </summary>
        [JsonProperty("BusinessDept")]
        [System.Obsolete]
        public string BusinessDept{ get; set; }

        /// <summary>
        /// 业务负责人。1-60个字符，仅允许输入中文、英文字母、数字、'_'、'-'，并且开头和结尾需为中文、英文字母或者数字
        /// </summary>
        [JsonProperty("BusinessOwner")]
        [System.Obsolete]
        public string BusinessOwner{ get; set; }

        /// <summary>
        /// 分类分级模板Id
        /// </summary>
        [JsonProperty("ComplianceId")]
        public long? ComplianceId{ get; set; }

        /// <summary>
        /// 敏感数据扫描数据源条件。
        /// </summary>
        [JsonProperty("DiscoveryCondition")]
        public DiscoveryCondition DiscoveryCondition{ get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "BusinessName", this.BusinessName);
            this.SetParamSimple(map, prefix + "BusinessDept", this.BusinessDept);
            this.SetParamSimple(map, prefix + "BusinessOwner", this.BusinessOwner);
            this.SetParamSimple(map, prefix + "ComplianceId", this.ComplianceId);
            this.SetParamObj(map, prefix + "DiscoveryCondition.", this.DiscoveryCondition);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

