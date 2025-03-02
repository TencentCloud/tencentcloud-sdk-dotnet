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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Staff : AbstractModel
    {
        
        /// <summary>
        /// 员工在腾讯电子签平台的唯一身份标识，为32位字符串。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 显示的用户名/昵称。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 用户手机号码， 支持国内手机号11位数字(无需加+86前缀或其他字符)。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 用户邮箱。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 用户在第三方平台ID。
        /// 注：`如需在此接口提醒员工实名，该参数不传。`
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 员工角色信息。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("Roles")]
        public StaffRole[] Roles{ get; set; }

        /// <summary>
        /// 员工部门信息。
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// 员工是否实名。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("Verified")]
        public bool? Verified{ get; set; }

        /// <summary>
        /// 员工创建时间戳，单位秒。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }

        /// <summary>
        /// 员工实名时间戳，单位秒。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("VerifiedOn")]
        public long? VerifiedOn{ get; set; }

        /// <summary>
        /// 员工是否离职：
        /// <ul><li>**0**：未离职</li><li>**1**：离职</li></ul>
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("QuiteJob")]
        public long? QuiteJob{ get; set; }

        /// <summary>
        /// 员工离职交接人用户ID。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("ReceiveUserId")]
        public string ReceiveUserId{ get; set; }

        /// <summary>
        /// 员工离职交接人用户OpenId。
        /// 注：`创建和更新场景无需填写。`
        /// </summary>
        [JsonProperty("ReceiveOpenId")]
        public string ReceiveOpenId{ get; set; }

        /// <summary>
        /// 企业微信用户账号ID。
        /// 注：`仅企微类型的企业创建员工接口支持该字段。`
        /// </summary>
        [JsonProperty("WeworkOpenId")]
        public string WeworkOpenId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamArrayObj(map, prefix + "Roles.", this.Roles);
            this.SetParamObj(map, prefix + "Department.", this.Department);
            this.SetParamSimple(map, prefix + "Verified", this.Verified);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "VerifiedOn", this.VerifiedOn);
            this.SetParamSimple(map, prefix + "QuiteJob", this.QuiteJob);
            this.SetParamSimple(map, prefix + "ReceiveUserId", this.ReceiveUserId);
            this.SetParamSimple(map, prefix + "ReceiveOpenId", this.ReceiveOpenId);
            this.SetParamSimple(map, prefix + "WeworkOpenId", this.WeworkOpenId);
        }
    }
}

