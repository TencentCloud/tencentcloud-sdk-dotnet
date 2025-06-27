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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplayEnterprise : AbstractModel
    {
        
        /// <summary>
        /// 主键Id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 公共字段
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// 子公司上级
        /// </summary>
        [JsonProperty("ParentEnterpriseUid")]
        public string ParentEnterpriseUid{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 公司简称
        /// </summary>
        [JsonProperty("Abbreviation")]
        public string Abbreviation{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("CreditCode")]
        public string CreditCode{ get; set; }

        /// <summary>
        /// 企业状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 注册资本
        /// </summary>
        [JsonProperty("RegisteredCapital")]
        public string RegisteredCapital{ get; set; }

        /// <summary>
        /// 持股比例
        /// </summary>
        [JsonProperty("ShareholdingRatio")]
        public string ShareholdingRatio{ get; set; }

        /// <summary>
        /// 法人代表
        /// </summary>
        [JsonProperty("LegalPerson")]
        public string LegalPerson{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 行业类型
        /// </summary>
        [JsonProperty("Industry")]
        public string Industry{ get; set; }

        /// <summary>
        /// 子公司唯一uid
        /// </summary>
        [JsonProperty("EnterpriseUid")]
        public string EnterpriseUid{ get; set; }

        /// <summary>
        /// 主域名数量
        /// </summary>
        [JsonProperty("DomainCount")]
        public long? DomainCount{ get; set; }

        /// <summary>
        /// 子域名数量
        /// </summary>
        [JsonProperty("SubDomainCount")]
        public long? SubDomainCount{ get; set; }

        /// <summary>
        /// 网站数量
        /// </summary>
        [JsonProperty("HttpCount")]
        public long? HttpCount{ get; set; }

        /// <summary>
        /// 漏洞数量
        /// </summary>
        [JsonProperty("VulCount")]
        public long? VulCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "ParentEnterpriseUid", this.ParentEnterpriseUid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Abbreviation", this.Abbreviation);
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RegisteredCapital", this.RegisteredCapital);
            this.SetParamSimple(map, prefix + "ShareholdingRatio", this.ShareholdingRatio);
            this.SetParamSimple(map, prefix + "LegalPerson", this.LegalPerson);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "EnterpriseUid", this.EnterpriseUid);
            this.SetParamSimple(map, prefix + "DomainCount", this.DomainCount);
            this.SetParamSimple(map, prefix + "SubDomainCount", this.SubDomainCount);
            this.SetParamSimple(map, prefix + "HttpCount", this.HttpCount);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
        }
    }
}

