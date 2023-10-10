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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportAssetUserListRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询指定Quuid主机的信息
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li>Name - String - 是否必填：否 - 账户名</li>
        /// <li>Uid - uint64 - 是否必填：否 - Uid</li>
        /// <li>Guid - uint64 - 是否必填：否 - Guid</li>
        /// <li>LoginTimeStart - String - 是否必填：否 - 开始时间，如：2021-01-11</li>
        /// <li>LoginTimeEnd - String - 是否必填：否 - 结束时间，如：2021-01-11</li>
        /// <li>LoginType - uint64 - 是否必填：否 - 0-不可登录；1-只允许key登录；2只允许密码登录；3-允许key和密码 仅linux</li>
        /// <li>OsType - String - 是否必填：否 - windows或linux</li>
        /// <li>Status - uint64 - 是否必填：否 - 账号状态：0-禁用；1-启用</li>
        /// <li>Type - uint64 - 是否必填：否 - 账号类型：0访客用户，1标准用户，2管理员用户 仅windows</li>
        /// <li>IsDomain - uint64 - 是否必填：否 - 是否域账号：0 不是，1是 仅windows
        /// <li>IsRoot - uint64 - 是否必填：否 - 是否Root权限：0 不是，1是 仅linux
        /// <li>IsSudo - uint64 - 是否必填：否 - 是否Sudo权限：0 不是，1是 仅linux</li>
        /// <li>IsSshLogin - uint64 - 是否必填：否 - 是否ssh登录：0 不是，1是 仅linux</li>
        /// <li>ShellLoginStatus - uint64 - 是否必填：否 - 是否shell登录性，0不是；1是 仅linux</li>
        /// <li>PasswordStatus - uint64 - 是否必填：否 - 密码状态：1正常 2即将过期 3已过期 4已锁定 仅linux</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 排序方式，asc升序 或 desc降序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 可选排序：[FirstTime|LoginTime|ChangePasswordTime|PasswordDuaTime]
        /// PasswordLockDays
        /// </summary>
        [JsonProperty("By")]
        public string By{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "By", this.By);
        }
    }
}

