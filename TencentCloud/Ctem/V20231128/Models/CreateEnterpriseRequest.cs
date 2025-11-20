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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEnterpriseRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CustomerId")]
        public long? CustomerId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 上一级企业
        /// </summary>
        [JsonProperty("ParentEnterpriseUid")]
        public string ParentEnterpriseUid{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("CreditCode")]
        public string CreditCode{ get; set; }

        /// <summary>
        /// 企业状态:存续、已注销
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 注册资本（单位:元）
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
        /// 子公司ID
        /// </summary>
        [JsonProperty("EnterpriseUid")]
        public string EnterpriseUid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ParentEnterpriseUid", this.ParentEnterpriseUid);
            this.SetParamSimple(map, prefix + "CreditCode", this.CreditCode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RegisteredCapital", this.RegisteredCapital);
            this.SetParamSimple(map, prefix + "ShareholdingRatio", this.ShareholdingRatio);
            this.SetParamSimple(map, prefix + "LegalPerson", this.LegalPerson);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "EnterpriseUid", this.EnterpriseUid);
        }
    }
}

