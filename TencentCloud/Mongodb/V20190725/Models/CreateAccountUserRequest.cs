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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAccountUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 新账号名称。其格式要求如下：
        /// - 字符范围[1,64]。
        /// - 可输入[A,Z]、[a,z]、[1,9]范围的字符以及下划线“\_”与短划线“-”。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 新账号密码。密码复杂度要求如下：
        /// - 字符长度范围[8,32]。
        /// - 至少包含字母、数字和特殊字符（叹号“!”、at"@"、井号“#”、百分号“%”、插入符“^”、星号“\*”、小括号“()”、下划线“\_”）中的两种。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// mongouser 账号对应的密码。mongouser 为系统默认账号，即为创建实例时，设置的密码。
        /// </summary>
        [JsonProperty("MongoUserPassword")]
        public string MongoUserPassword{ get; set; }

        /// <summary>
        /// 账号备注信息。
        /// </summary>
        [JsonProperty("UserDesc")]
        public string UserDesc{ get; set; }

        /// <summary>
        /// 账号的读写权限信息。
        /// </summary>
        [JsonProperty("AuthRole")]
        public Auth[] AuthRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "MongoUserPassword", this.MongoUserPassword);
            this.SetParamSimple(map, prefix + "UserDesc", this.UserDesc);
            this.SetParamArrayObj(map, prefix + "AuthRole.", this.AuthRole);
        }
    }
}

