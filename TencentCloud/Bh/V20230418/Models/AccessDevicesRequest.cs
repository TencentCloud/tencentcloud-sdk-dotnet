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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资产的登录账号
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// 运维端登录账号
        /// </summary>
        [JsonProperty("LoginAccount")]
        [System.Obsolete]
        public string LoginAccount{ get; set; }

        /// <summary>
        /// 运维端登录密码
        /// </summary>
        [JsonProperty("LoginPassword")]
        [System.Obsolete]
        public string LoginPassword{ get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public ulong? DeviceId{ get; set; }

        /// <summary>
        /// 资源id(优先使用DeviceId)
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 未托管密码私钥时，填入
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 未托管密码私钥时，填入
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// 未托管密码私钥时，填入
        /// </summary>
        [JsonProperty("PrivateKeyPassword")]
        public string PrivateKeyPassword{ get; set; }

        /// <summary>
        /// 客户端工具
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// RDP挂载盘符驱动（mstsc支持）
        /// </summary>
        [JsonProperty("Drivers")]
        public string[] Drivers{ get; set; }

        /// <summary>
        /// 窗口宽度（RDP支持）
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 窗口高度（RDP支持）
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 是否内网访问（默认不是）
        /// </summary>
        [JsonProperty("IntranetAccess")]
        public bool? IntranetAccess{ get; set; }

        /// <summary>
        /// 是否自动管理访问串，删掉过期的，新建可用的（默认false）
        /// </summary>
        [JsonProperty("AutoManageAccessCredential")]
        public bool? AutoManageAccessCredential{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "LoginAccount", this.LoginAccount);
            this.SetParamSimple(map, prefix + "LoginPassword", this.LoginPassword);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "PrivateKeyPassword", this.PrivateKeyPassword);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamArraySimple(map, prefix + "Drivers.", this.Drivers);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "IntranetAccess", this.IntranetAccess);
            this.SetParamSimple(map, prefix + "AutoManageAccessCredential", this.AutoManageAccessCredential);
        }
    }
}

