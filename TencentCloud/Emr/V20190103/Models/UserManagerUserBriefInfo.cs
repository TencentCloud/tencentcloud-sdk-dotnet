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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserManagerUserBriefInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>用户所属的组</p>
        /// </summary>
        [JsonProperty("UserGroup")]
        public string UserGroup{ get; set; }

        /// <summary>
        /// <p>Manager表示管理员、NormalUser表示普通用户</p>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }

        /// <summary>
        /// <p>用户创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>是否可以下载用户对应的keytab文件，对开启kerberos的集群才有意义</p>
        /// </summary>
        [JsonProperty("SupportDownLoadKeyTab")]
        public bool? SupportDownLoadKeyTab{ get; set; }

        /// <summary>
        /// <p>keytab文件的下载地址</p>
        /// </summary>
        [JsonProperty("DownLoadKeyTabUrl")]
        public string DownLoadKeyTabUrl{ get; set; }

        /// <summary>
        /// <p>用户组</p>
        /// </summary>
        [JsonProperty("Groups")]
        public string[] Groups{ get; set; }

        /// <summary>
        /// <p>客户UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>用户状态</p>
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// <p>是否展示密码更新时间</p>
        /// </summary>
        [JsonProperty("DisplayPasswdUpdateTime")]
        public bool? DisplayPasswdUpdateTime{ get; set; }

        /// <summary>
        /// <p>密码最近更新时间</p>
        /// </summary>
        [JsonProperty("PasswdUpdateTime")]
        public string PasswdUpdateTime{ get; set; }

        /// <summary>
        /// <p>已经使用的天数</p><p>单位：天</p>
        /// </summary>
        [JsonProperty("PasswdUsedDay")]
        public long? PasswdUsedDay{ get; set; }

        /// <summary>
        /// <p>已经使用的小时数</p><p>单位：时</p>
        /// </summary>
        [JsonProperty("PasswdUsedHour")]
        public long? PasswdUsedHour{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UserGroup", this.UserGroup);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SupportDownLoadKeyTab", this.SupportDownLoadKeyTab);
            this.SetParamSimple(map, prefix + "DownLoadKeyTabUrl", this.DownLoadKeyTabUrl);
            this.SetParamArraySimple(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "DisplayPasswdUpdateTime", this.DisplayPasswdUpdateTime);
            this.SetParamSimple(map, prefix + "PasswdUpdateTime", this.PasswdUpdateTime);
            this.SetParamSimple(map, prefix + "PasswdUsedDay", this.PasswdUsedDay);
            this.SetParamSimple(map, prefix + "PasswdUsedHour", this.PasswdUsedHour);
        }
    }
}

