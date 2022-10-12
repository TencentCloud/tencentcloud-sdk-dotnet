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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCRUserVerifyRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 用户身份证号
        /// </summary>
        [JsonProperty("UserID")]
        public string UserID{ get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [JsonProperty("UserPhone")]
        public string UserPhone{ get; set; }

        /// <summary>
        /// 短信验证码，接口接入可以置空
        /// </summary>
        [JsonProperty("VerificationCode")]
        public string VerificationCode{ get; set; }

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
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserID", this.UserID);
            this.SetParamSimple(map, prefix + "UserPhone", this.UserPhone);
            this.SetParamSimple(map, prefix + "VerificationCode", this.VerificationCode);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

