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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConsoleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>访问方式：public - 公网，internal - 内网</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string[] AccessMode{ get; set; }

        /// <summary>
        /// <p>登录方式：0 - 账号密码鉴权，1 - 匿名登陆，2 - 第三方认证登录</p>
        /// </summary>
        [JsonProperty("LoginMode")]
        public ulong? LoginMode{ get; set; }

        /// <summary>
        /// <p>自定义域名前缀</p>
        /// </summary>
        [JsonProperty("DomainPrefix")]
        public string DomainPrefix{ get; set; }

        /// <summary>
        /// <p>用户账号信息</p><p>“账号密码鉴权“登录方式必传</p>
        /// </summary>
        [JsonProperty("Accounts")]
        public ConsoleAccount[] Accounts{ get; set; }

        /// <summary>
        /// <p>匿名登录账号信息</p><p>“匿名登录”登录方式必传</p>
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public AnonymousLoginInfo AnonymousLogin{ get; set; }

        /// <summary>
        /// <p>内网类型，默认为0</p>
        /// </summary>
        [JsonProperty("IntranetType")]
        public ulong? IntranetType{ get; set; }

        /// <summary>
        /// <p>内网地域</p>
        /// </summary>
        [JsonProperty("IntranetRegion")]
        public string IntranetRegion{ get; set; }

        /// <summary>
        /// <p>内网私有网络VpcId</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>内网子网SubnetId</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Auth角色信息</p><p>“第三方认证登录”登录方式必传</p>
        /// </summary>
        [JsonProperty("AuthRoles")]
        public AuthRoleInfo[] AuthRoles{ get; set; }

        /// <summary>
        /// <p>标签描述列表，通过指定该参数可以同时绑定标签到相应的日志主题。最大支持10个标签键值对，同一个资源只能绑定到同一个标签键下。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>自定义隐藏参数</p>
        /// </summary>
        [JsonProperty("HideParams")]
        public string[] HideParams{ get; set; }

        /// <summary>
        /// <p>访问控制规则</p><p>“第三方认证登录”登录方式必传 AccessMode: internal &amp;&amp; Action: ACCEPT 规则</p>
        /// </summary>
        [JsonProperty("AccessControlRules")]
        public AccessControlRule[] AccessControlRules{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// <p>自定义显示菜单</p>
        /// </summary>
        [JsonProperty("Menus")]
        public string[] Menus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AccessMode.", this.AccessMode);
            this.SetParamSimple(map, prefix + "LoginMode", this.LoginMode);
            this.SetParamSimple(map, prefix + "DomainPrefix", this.DomainPrefix);
            this.SetParamArrayObj(map, prefix + "Accounts.", this.Accounts);
            this.SetParamObj(map, prefix + "AnonymousLogin.", this.AnonymousLogin);
            this.SetParamSimple(map, prefix + "IntranetType", this.IntranetType);
            this.SetParamSimple(map, prefix + "IntranetRegion", this.IntranetRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "AuthRoles.", this.AuthRoles);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "HideParams.", this.HideParams);
            this.SetParamArrayObj(map, prefix + "AccessControlRules.", this.AccessControlRules);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamArraySimple(map, prefix + "Menus.", this.Menus);
        }
    }
}

