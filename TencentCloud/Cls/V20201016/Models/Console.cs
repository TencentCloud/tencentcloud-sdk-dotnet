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

    public class Console : AbstractModel
    {
        
        /// <summary>
        /// <p>DataSight控制台Id</p>
        /// </summary>
        [JsonProperty("ConsoleId")]
        public string ConsoleId{ get; set; }

        /// <summary>
        /// <p>访问方式：public-公网，internal-内网</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string[] AccessMode{ get; set; }

        /// <summary>
        /// <p>登录方式：0-账号密码鉴权，1-匿名登录，2-第三方认证登录</p>
        /// </summary>
        [JsonProperty("LoginMode")]
        public ulong? LoginMode{ get; set; }

        /// <summary>
        /// <p>自定义域名前缀</p>
        /// </summary>
        [JsonProperty("DomainPrefix")]
        public string DomainPrefix{ get; set; }

        /// <summary>
        /// <p>用户账号信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Accounts")]
        public ConsoleAccount[] Accounts{ get; set; }

        /// <summary>
        /// <p>内网类型，默认为0</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntranetType")]
        public ulong? IntranetType{ get; set; }

        /// <summary>
        /// <p>内网地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntranetRegion")]
        public string IntranetRegion{ get; set; }

        /// <summary>
        /// <p>内网私有网络VpcId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>内网子网SubnetId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>匿名登录账号信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public AnonymousLoginInfo AnonymousLogin{ get; set; }

        /// <summary>
        /// <p>auth用户角色信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthRoles")]
        public AuthRoleInfo[] AuthRoles{ get; set; }

        /// <summary>
        /// <p>绑定的标签信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>自定义隐藏参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HideParams")]
        public string[] HideParams{ get; set; }

        /// <summary>
        /// <p>访问控制规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessControlRules")]
        public AccessControlRule[] AccessControlRules{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// <p>自定义显示菜单</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Menus")]
        public string[] Menus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsoleId", this.ConsoleId);
            this.SetParamArraySimple(map, prefix + "AccessMode.", this.AccessMode);
            this.SetParamSimple(map, prefix + "LoginMode", this.LoginMode);
            this.SetParamSimple(map, prefix + "DomainPrefix", this.DomainPrefix);
            this.SetParamArrayObj(map, prefix + "Accounts.", this.Accounts);
            this.SetParamSimple(map, prefix + "IntranetType", this.IntranetType);
            this.SetParamSimple(map, prefix + "IntranetRegion", this.IntranetRegion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "AnonymousLogin.", this.AnonymousLogin);
            this.SetParamArrayObj(map, prefix + "AuthRoles.", this.AuthRoles);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "HideParams.", this.HideParams);
            this.SetParamArrayObj(map, prefix + "AccessControlRules.", this.AccessControlRules);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamArraySimple(map, prefix + "Menus.", this.Menus);
        }
    }
}

