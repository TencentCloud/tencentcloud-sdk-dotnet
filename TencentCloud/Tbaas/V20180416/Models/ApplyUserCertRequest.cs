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

namespace TencentCloud.Tbaas.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyUserCertRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，固定字段：cert_mng
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名，固定字段：cert_apply_for_user
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 区块链网络ID，可在区块链网络详情或列表中获取
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 申请证书的组织名称，可以在组织管理列表中获取当前组织的名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 用户证书标识，用于标识用户证书，要求由纯小写字母组成，长度小于10
        /// </summary>
        [JsonProperty("UserIdentity")]
        public string UserIdentity{ get; set; }

        /// <summary>
        /// 证书申请实体，使用腾讯云账号实名认证的名称
        /// </summary>
        [JsonProperty("Applicant")]
        public string Applicant{ get; set; }

        /// <summary>
        /// 证件号码。如果腾讯云账号对应的实名认证类型为企业认证，填入“0”；如果腾讯云账号对应的实名认证类型为个人认证，填入个人身份证号码
        /// </summary>
        [JsonProperty("IdentityNum")]
        public string IdentityNum{ get; set; }

        /// <summary>
        /// csr p10证书文件。需要用户根据文档生成证书的CSR文件
        /// </summary>
        [JsonProperty("CsrData")]
        public string CsrData{ get; set; }

        /// <summary>
        /// 证书备注信息
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "UserIdentity", this.UserIdentity);
            this.SetParamSimple(map, prefix + "Applicant", this.Applicant);
            this.SetParamSimple(map, prefix + "IdentityNum", this.IdentityNum);
            this.SetParamSimple(map, prefix + "CsrData", this.CsrData);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
        }
    }
}

