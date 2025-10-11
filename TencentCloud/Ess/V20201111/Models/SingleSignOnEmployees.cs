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

    public class SingleSignOnEmployees : AbstractModel
    {
        
        /// <summary>
        /// 用户在idp分配的唯一值，需要保持跟在电子签应用集成->单点登录配置->端点配置中配置的。
        /// 如下图配置![image](https://qcloudimg.tencent-cloud.cn/raw/6ff22248c930b2a7684322cac9401a9c.png)。
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 企业员工姓名。 员工的姓名将用于身份认证和电子签名，请确保填写的姓名为签署方的真实姓名，而非昵称等代名。	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户手机号码， 支持中国大陆手机号11位数字(无需加+86前缀或其他字符)。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户邮箱。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 员工角色信息。
        /// 此处roleId为电子签配置的 RoleId，可通过接口[查询企业角色列表](https://qian.tencent.com/developers/companyApis/roles/DescribeIntegrationRoles) 获取
        /// </summary>
        [JsonProperty("RoleIds")]
        public string[] RoleIds{ get; set; }

        /// <summary>
        /// 员工是否实名。
        /// </summary>
        [JsonProperty("IsVerified")]
        public bool? IsVerified{ get; set; }

        /// <summary>
        /// 员工创建时间戳，单位秒。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamArraySimple(map, prefix + "RoleIds.", this.RoleIds);
            this.SetParamSimple(map, prefix + "IsVerified", this.IsVerified);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
        }
    }
}

