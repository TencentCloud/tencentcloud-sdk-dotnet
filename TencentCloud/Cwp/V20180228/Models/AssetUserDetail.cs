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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetUserDetail : AbstractModel
    {
        
        /// <summary>
        /// 主机内网IP
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 主机Uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 主机Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 账号UID
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 账号GID
        /// </summary>
        [JsonProperty("Gid")]
        public string Gid{ get; set; }

        /// <summary>
        /// 账号状态：0-禁用；1-启用
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 是否有root权限：0-否；1是，999为空: 仅linux
        /// </summary>
        [JsonProperty("IsRoot")]
        public ulong? IsRoot{ get; set; }

        /// <summary>
        /// 上次登录时间
        /// </summary>
        [JsonProperty("LastLoginTime")]
        public string LastLoginTime{ get; set; }

        /// <summary>
        /// 账号名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 账号类型：0访客用户，1标准用户，2管理员用户 ,999为空,仅Windows
        /// </summary>
        [JsonProperty("UserType")]
        public ulong? UserType{ get; set; }

        /// <summary>
        /// 是否域账号：0否， 1是, 999为空  仅Windows
        /// </summary>
        [JsonProperty("IsDomain")]
        public ulong? IsDomain{ get; set; }

        /// <summary>
        /// 是否允许ssh登录，1是，0否, 999为空, 仅linux
        /// </summary>
        [JsonProperty("IsSshLogin")]
        public ulong? IsSshLogin{ get; set; }

        /// <summary>
        /// Home目录
        /// </summary>
        [JsonProperty("HomePath")]
        public string HomePath{ get; set; }

        /// <summary>
        /// Shell路径  仅linux
        /// </summary>
        [JsonProperty("Shell")]
        public string Shell{ get; set; }

        /// <summary>
        /// 是否shell登录性，0不是；1是 仅linux
        /// </summary>
        [JsonProperty("ShellLoginStatus")]
        public ulong? ShellLoginStatus{ get; set; }

        /// <summary>
        /// 密码修改时间
        /// </summary>
        [JsonProperty("PasswordChangeTime")]
        public string PasswordChangeTime{ get; set; }

        /// <summary>
        /// 密码过期时间  仅linux
        /// </summary>
        [JsonProperty("PasswordDueTime")]
        public string PasswordDueTime{ get; set; }

        /// <summary>
        /// 密码锁定时间：单位天, -1为永不锁定 999为空，仅linux
        /// </summary>
        [JsonProperty("PasswordLockDays")]
        public long? PasswordLockDays{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 用户组名
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 账号到期时间
        /// </summary>
        [JsonProperty("DisableTime")]
        public string DisableTime{ get; set; }

        /// <summary>
        /// 最近登录终端
        /// </summary>
        [JsonProperty("LastLoginTerminal")]
        public string LastLoginTerminal{ get; set; }

        /// <summary>
        /// 最近登录位置
        /// </summary>
        [JsonProperty("LastLoginLoc")]
        public string LastLoginLoc{ get; set; }

        /// <summary>
        /// 最近登录IP
        /// </summary>
        [JsonProperty("LastLoginIp")]
        public string LastLoginIp{ get; set; }

        /// <summary>
        /// 密码过期提醒：单位天
        /// </summary>
        [JsonProperty("PasswordWarnDays")]
        public ulong? PasswordWarnDays{ get; set; }

        /// <summary>
        /// 密码修改设置：0-不可修改，1-可修改
        /// </summary>
        [JsonProperty("PasswordChangeType")]
        public ulong? PasswordChangeType{ get; set; }

        /// <summary>
        /// 用户公钥列表
        /// </summary>
        [JsonProperty("Keys")]
        public AssetUserKeyInfo[] Keys{ get; set; }

        /// <summary>
        /// 数据更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Gid", this.Gid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsRoot", this.IsRoot);
            this.SetParamSimple(map, prefix + "LastLoginTime", this.LastLoginTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "IsDomain", this.IsDomain);
            this.SetParamSimple(map, prefix + "IsSshLogin", this.IsSshLogin);
            this.SetParamSimple(map, prefix + "HomePath", this.HomePath);
            this.SetParamSimple(map, prefix + "Shell", this.Shell);
            this.SetParamSimple(map, prefix + "ShellLoginStatus", this.ShellLoginStatus);
            this.SetParamSimple(map, prefix + "PasswordChangeTime", this.PasswordChangeTime);
            this.SetParamSimple(map, prefix + "PasswordDueTime", this.PasswordDueTime);
            this.SetParamSimple(map, prefix + "PasswordLockDays", this.PasswordLockDays);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "DisableTime", this.DisableTime);
            this.SetParamSimple(map, prefix + "LastLoginTerminal", this.LastLoginTerminal);
            this.SetParamSimple(map, prefix + "LastLoginLoc", this.LastLoginLoc);
            this.SetParamSimple(map, prefix + "LastLoginIp", this.LastLoginIp);
            this.SetParamSimple(map, prefix + "PasswordWarnDays", this.PasswordWarnDays);
            this.SetParamSimple(map, prefix + "PasswordChangeType", this.PasswordChangeType);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

