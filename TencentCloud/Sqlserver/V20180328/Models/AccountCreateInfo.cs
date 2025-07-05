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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccountCreateInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 实例密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// DB权限列表
        /// </summary>
        [JsonProperty("DBPrivileges")]
        public DBPrivilege[] DBPrivileges{ get; set; }

        /// <summary>
        /// 账号备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否为管理员账户，当值为true 等价于单节点AccountType=L0，双节点AccountType=L1，当值为false，等价于AccountType=L3
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }

        /// <summary>
        /// win-windows鉴权,sql-sqlserver鉴权，不填默认值为sql-sqlserver鉴权
        /// </summary>
        [JsonProperty("Authentication")]
        public string Authentication{ get; set; }

        /// <summary>
        /// 账号类型，IsAdmin的扩展字段。 L0-超级权限(基础版独有),L1-高级权限,L2-特殊权限,L3-普通权限，默认L3
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 是否开启CAM验证
        /// </summary>
        [JsonProperty("IsCam")]
        public bool? IsCam{ get; set; }

        /// <summary>
        /// 加密密钥版本号，0表示不使用加密
        /// </summary>
        [JsonProperty("EncryptedVersion")]
        public long? EncryptedVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "DBPrivileges.", this.DBPrivileges);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
            this.SetParamSimple(map, prefix + "Authentication", this.Authentication);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "IsCam", this.IsCam);
            this.SetParamSimple(map, prefix + "EncryptedVersion", this.EncryptedVersion);
        }
    }
}

