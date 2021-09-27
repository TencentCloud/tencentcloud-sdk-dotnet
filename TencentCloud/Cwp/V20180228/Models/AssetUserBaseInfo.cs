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

    public class AssetUserBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 主机内网IP
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// 主机外网IP
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 操作系统信息
        /// </summary>
        [JsonProperty("OsInfo")]
        public string OsInfo{ get; set; }

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
        /// 登录方式：0-不可登录；1-只允许key登录；2只允许密码登录；3-允许key和密码，999为空，仅linux
        /// </summary>
        [JsonProperty("LoginType")]
        public ulong? LoginType{ get; set; }

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
        /// 主机业务组ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 账号类型：0访客用户，1标准用户，2管理员用户 ,999为空,仅windows
        /// </summary>
        [JsonProperty("UserType")]
        public ulong? UserType{ get; set; }

        /// <summary>
        /// 是否域账号：0否， 1是，2否, 999为空  仅windows
        /// </summary>
        [JsonProperty("IsDomain")]
        public ulong? IsDomain{ get; set; }

        /// <summary>
        /// 是否有sudo权限，1是，0否, 999为空, 仅linux
        /// </summary>
        [JsonProperty("IsSudo")]
        public ulong? IsSudo{ get; set; }

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
        /// 密码状态：1正常 2即将过期 3已过期 4已锁定 999为空 仅linux
        /// </summary>
        [JsonProperty("PasswordStatus")]
        public long? PasswordStatus{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "OsInfo", this.OsInfo);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Gid", this.Gid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsRoot", this.IsRoot);
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "LastLoginTime", this.LastLoginTime);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "IsDomain", this.IsDomain);
            this.SetParamSimple(map, prefix + "IsSudo", this.IsSudo);
            this.SetParamSimple(map, prefix + "IsSshLogin", this.IsSshLogin);
            this.SetParamSimple(map, prefix + "HomePath", this.HomePath);
            this.SetParamSimple(map, prefix + "Shell", this.Shell);
            this.SetParamSimple(map, prefix + "ShellLoginStatus", this.ShellLoginStatus);
            this.SetParamSimple(map, prefix + "PasswordChangeTime", this.PasswordChangeTime);
            this.SetParamSimple(map, prefix + "PasswordDueTime", this.PasswordDueTime);
            this.SetParamSimple(map, prefix + "PasswordLockDays", this.PasswordLockDays);
            this.SetParamSimple(map, prefix + "PasswordStatus", this.PasswordStatus);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

