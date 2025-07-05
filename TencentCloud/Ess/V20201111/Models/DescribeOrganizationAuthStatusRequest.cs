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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationAuthStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。使用此接口时，必须填写userId。 支持填入集团子公司经办人 userId 代发合同。  注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 组织机构名称。 请确认该名称与企业营业执照中注册的名称一致。 如果名称中包含英文括号()，请使用中文括号（）代替。
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 企业统一社会信用代码
        /// 注意：OrganizationName和UniformSocialCreditCode不能同时为空
        /// </summary>
        [JsonProperty("UniformSocialCreditCode")]
        public string UniformSocialCreditCode{ get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [JsonProperty("LegalName")]
        public string LegalName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "UniformSocialCreditCode", this.UniformSocialCreditCode);
            this.SetParamSimple(map, prefix + "LegalName", this.LegalName);
        }
    }
}

