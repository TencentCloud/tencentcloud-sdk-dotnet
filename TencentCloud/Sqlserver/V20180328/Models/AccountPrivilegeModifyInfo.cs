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

    public class AccountPrivilegeModifyInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据库用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 账号权限变更信息。参数DBPrivileges和AccAllDB只能二选一
        /// </summary>
        [JsonProperty("DBPrivileges")]
        public DBPrivilegeModifyInfo[] DBPrivileges{ get; set; }

        /// <summary>
        /// 表示是否为管理员账户，当值为true，表示是 管理员。若实例 是 单节点，则管理员所在的 账号类型为超级权限账号 ，即AccountType=L0；若实例 是 双节点，则管理员所在的 账号类型为高级权限账号，即AccountType=L1；当值为false，表示 不是管理员，则账号类型为普通账号，即AccountType=L3
        /// </summary>
        [JsonProperty("IsAdmin")]
        public bool? IsAdmin{ get; set; }

        /// <summary>
        /// 账号类型，IsAdmin字段的扩展字段。 L0-超级权限(基础版独有),L1-高级权限,L2-特殊权限,L3-普通权限，默认L3
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 全量修改指定账号下的所有DB权限，只支持特殊权限账号和普通权限账号。参数DBPrivileges和AccAllDB只能二选一
        /// </summary>
        [JsonProperty("AccAllDB")]
        public SelectAllDB AccAllDB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamArrayObj(map, prefix + "DBPrivileges.", this.DBPrivileges);
            this.SetParamSimple(map, prefix + "IsAdmin", this.IsAdmin);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamObj(map, prefix + "AccAllDB.", this.AccAllDB);
        }
    }
}

