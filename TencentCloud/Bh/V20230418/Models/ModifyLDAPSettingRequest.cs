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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLDAPSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启LDAP认证，false-不开启，true-开启</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>服务器地址</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>备用服务器地址</p>
        /// </summary>
        [JsonProperty("IpBackup")]
        public string IpBackup{ get; set; }

        /// <summary>
        /// <p>服务端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>是否开启SSL，false-不开启，true-开启</p>
        /// </summary>
        [JsonProperty("EnableSSL")]
        public bool? EnableSSL{ get; set; }

        /// <summary>
        /// <p>Base DN</p>
        /// </summary>
        [JsonProperty("BaseDN")]
        public string BaseDN{ get; set; }

        /// <summary>
        /// <p>管理员账号</p>
        /// </summary>
        [JsonProperty("AdminAccount")]
        public string AdminAccount{ get; set; }

        /// <summary>
        /// <p>管理员密码</p>
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// <p>用户属性</p>
        /// </summary>
        [JsonProperty("AttributeUser")]
        public string AttributeUser{ get; set; }

        /// <summary>
        /// <p>用户名属性</p>
        /// </summary>
        [JsonProperty("AttributeUserName")]
        public string AttributeUserName{ get; set; }

        /// <summary>
        /// <p>自动同步，false-不开启，true-开启</p>
        /// </summary>
        [JsonProperty("AutoSync")]
        public bool? AutoSync{ get; set; }

        /// <summary>
        /// <p>覆盖用户信息，false-不开启，true-开启</p>
        /// </summary>
        [JsonProperty("Overwrite")]
        public bool? Overwrite{ get; set; }

        /// <summary>
        /// <p>同步周期，30～60000之间的整数</p>
        /// </summary>
        [JsonProperty("SyncPeriod")]
        public ulong? SyncPeriod{ get; set; }

        /// <summary>
        /// <p>是否同步全部，false-不开启，true-开启</p>
        /// </summary>
        [JsonProperty("SyncAll")]
        public bool? SyncAll{ get; set; }

        /// <summary>
        /// <p>同步OU列表，SyncAll为false时必传</p>
        /// </summary>
        [JsonProperty("SyncUnitSet")]
        public string[] SyncUnitSet{ get; set; }

        /// <summary>
        /// <p>组织单元属性</p>
        /// </summary>
        [JsonProperty("AttributeUnit")]
        public string AttributeUnit{ get; set; }

        /// <summary>
        /// <p>用户姓名属性</p>
        /// </summary>
        [JsonProperty("AttributeRealName")]
        public string AttributeRealName{ get; set; }

        /// <summary>
        /// <p>手机号属性</p>
        /// </summary>
        [JsonProperty("AttributePhone")]
        public string AttributePhone{ get; set; }

        /// <summary>
        /// <p>邮箱属性</p>
        /// </summary>
        [JsonProperty("AttributeEmail")]
        public string AttributeEmail{ get; set; }

        /// <summary>
        /// <p>网络域Id</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// <p>堡垒机实例ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "IpBackup", this.IpBackup);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "BaseDN", this.BaseDN);
            this.SetParamSimple(map, prefix + "AdminAccount", this.AdminAccount);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "AttributeUser", this.AttributeUser);
            this.SetParamSimple(map, prefix + "AttributeUserName", this.AttributeUserName);
            this.SetParamSimple(map, prefix + "AutoSync", this.AutoSync);
            this.SetParamSimple(map, prefix + "Overwrite", this.Overwrite);
            this.SetParamSimple(map, prefix + "SyncPeriod", this.SyncPeriod);
            this.SetParamSimple(map, prefix + "SyncAll", this.SyncAll);
            this.SetParamArraySimple(map, prefix + "SyncUnitSet.", this.SyncUnitSet);
            this.SetParamSimple(map, prefix + "AttributeUnit", this.AttributeUnit);
            this.SetParamSimple(map, prefix + "AttributeRealName", this.AttributeRealName);
            this.SetParamSimple(map, prefix + "AttributePhone", this.AttributePhone);
            this.SetParamSimple(map, prefix + "AttributeEmail", this.AttributeEmail);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

