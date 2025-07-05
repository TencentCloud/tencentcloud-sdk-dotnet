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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyFlexWechatPreAuthRequest : AbstractModel
    {
        
        /// <summary>
        /// 商家核身单号
        /// </summary>
        [JsonProperty("AuthNo")]
        public string AuthNo{ get; set; }

        /// <summary>
        /// 微信用户标识
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 用工单位名称
        /// </summary>
        [JsonProperty("EmployerName")]
        public string EmployerName{ get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [JsonProperty("IdNo")]
        public string IdNo{ get; set; }

        /// <summary>
        /// 用工类型
        /// LONG_TERM_EMPLOYMENT：长期用工，
        /// SHORT_TERM_EMPLOYMENT： 短期用工，
        /// COOPERATION_EMPLOYMENT：合作关系
        /// </summary>
        [JsonProperty("EmploymentType")]
        public string EmploymentType{ get; set; }

        /// <summary>
        /// 核身类型
        /// SIGN_IN：考勤、签到打卡类型
        /// INSURANCE：投保类型
        /// CONTRACT：签约类型
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 环境类型
        /// test 测试
        /// release 生产
        /// sandbox 沙箱
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthNo", this.AuthNo);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "EmployerName", this.EmployerName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "IdNo", this.IdNo);
            this.SetParamSimple(map, prefix + "EmploymentType", this.EmploymentType);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

