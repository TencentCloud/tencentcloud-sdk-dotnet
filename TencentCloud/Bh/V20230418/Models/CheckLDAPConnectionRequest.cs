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

    public class CheckLDAPConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>是否开启LDAP认证，必须为true</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>服务器地址</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

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
        /// <p>备用服务器地址</p>
        /// </summary>
        [JsonProperty("IpBackup")]
        public string IpBackup{ get; set; }

        /// <summary>
        /// <p>网络域id</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// <p>用户名称映射属性</p>
        /// </summary>
        [JsonProperty("AttributeUserName")]
        public string AttributeUserName{ get; set; }

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
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "BaseDN", this.BaseDN);
            this.SetParamSimple(map, prefix + "AdminAccount", this.AdminAccount);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "IpBackup", this.IpBackup);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "AttributeUserName", this.AttributeUserName);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
        }
    }
}

