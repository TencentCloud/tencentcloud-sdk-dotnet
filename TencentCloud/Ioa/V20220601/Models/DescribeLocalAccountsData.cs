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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLocalAccountsData : AbstractModel
    {
        
        /// <summary>
        /// <p>uid，数据库中唯一</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>账号，登录账号</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>账号id，同Id字段</p>
        /// </summary>
        [JsonProperty("AccountId")]
        public long? AccountId{ get; set; }

        /// <summary>
        /// <p>账号所在的分组id</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// <p>账号所在的分组名称</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>账号所在的分组名称路径，用英文.分割</p>
        /// </summary>
        [JsonProperty("NamePath")]
        public string NamePath{ get; set; }

        /// <summary>
        /// <p>账号来源,0表示本地账号(只支持32位)</p>
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// <p>账号状态,0禁用，1启用(只支持32位)</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>账号的创建时间</p>
        /// </summary>
        [JsonProperty("Itime")]
        public string Itime{ get; set; }

        /// <summary>
        /// <p>账号的最后更新时间</p>
        /// </summary>
        [JsonProperty("Utime")]
        public string Utime{ get; set; }

        /// <summary>
        /// <p>账号的扩展信息，包含邮箱、手机号、身份证、职位等信息</p>
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// <p>用户风险等级，枚举：none, low, middle, high</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>所属组</p>
        /// </summary>
        [JsonProperty("AccountGroups")]
        public DescribeLocalAccountAccountGroupsData[] AccountGroups{ get; set; }

        /// <summary>
        /// <p>绑定手机端设备数</p>
        /// </summary>
        [JsonProperty("MobileBindNum")]
        public long? MobileBindNum{ get; set; }

        /// <summary>
        /// <p>绑定Pc端设备数</p>
        /// </summary>
        [JsonProperty("PcBindNum")]
        public long? PcBindNum{ get; set; }

        /// <summary>
        /// <p>账号在线状态 1：在线 2：离线</p>
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// <p>账号活跃状态 1：活跃 2：非活跃</p>
        /// </summary>
        [JsonProperty("ActiveStatus")]
        public long? ActiveStatus{ get; set; }

        /// <summary>
        /// <p>账号登录时间</p>
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }

        /// <summary>
        /// <p>账号登出时间</p>
        /// </summary>
        [JsonProperty("LogoutTime")]
        public string LogoutTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "NamePath", this.NamePath);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Itime", this.Itime);
            this.SetParamSimple(map, prefix + "Utime", this.Utime);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArrayObj(map, prefix + "AccountGroups.", this.AccountGroups);
            this.SetParamSimple(map, prefix + "MobileBindNum", this.MobileBindNum);
            this.SetParamSimple(map, prefix + "PcBindNum", this.PcBindNum);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamSimple(map, prefix + "ActiveStatus", this.ActiveStatus);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "LogoutTime", this.LogoutTime);
        }
    }
}

