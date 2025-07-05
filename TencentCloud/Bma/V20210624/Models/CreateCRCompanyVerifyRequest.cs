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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCRCompanyVerifyRequest : AbstractModel
    {
        
        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 企业证件号码
        /// </summary>
        [JsonProperty("CompanyID")]
        public string CompanyID{ get; set; }

        /// <summary>
        /// 企业法人姓名
        /// </summary>
        [JsonProperty("CompanyLegalName")]
        public string CompanyLegalName{ get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [JsonProperty("ManagerName")]
        public string ManagerName{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonProperty("ManagerPhone")]
        public string ManagerPhone{ get; set; }

        /// <summary>
        /// 手机验证码，接口接入可以置空
        /// </summary>
        [JsonProperty("VerificationCode")]
        public string VerificationCode{ get; set; }

        /// <summary>
        /// 字段已废弃，企业认证号码类型 1：社会信用代码 2：组织机构代码 3：企业工商注册码 4：其他 默认为1
        /// </summary>
        [JsonProperty("CompanyIDType")]
        public string CompanyIDType{ get; set; }

        /// <summary>
        /// 字段已废弃，认证类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyID", this.CompanyID);
            this.SetParamSimple(map, prefix + "CompanyLegalName", this.CompanyLegalName);
            this.SetParamSimple(map, prefix + "ManagerName", this.ManagerName);
            this.SetParamSimple(map, prefix + "ManagerPhone", this.ManagerPhone);
            this.SetParamSimple(map, prefix + "VerificationCode", this.VerificationCode);
            this.SetParamSimple(map, prefix + "CompanyIDType", this.CompanyIDType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

