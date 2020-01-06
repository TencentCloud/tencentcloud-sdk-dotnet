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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppInfo : AbstractModel
    {
        
        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 应用实例ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 数据描述语言类型，如：`PROTO`,`TDR`或`MIX`
        /// </summary>
        [JsonProperty("IdlType")]
        public string IdlType{ get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 关联的用户私有网络实例ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 关联的用户子网实例ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 应用密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 密码状态
        /// </summary>
        [JsonProperty("PasswordStatus")]
        public string PasswordStatus{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入ID
        /// </summary>
        [JsonProperty("ApiAccessId")]
        public string ApiAccessId{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入地址
        /// </summary>
        [JsonProperty("ApiAccessIp")]
        public string ApiAccessIp{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入端口
        /// </summary>
        [JsonProperty("ApiAccessPort")]
        public long? ApiAccessPort{ get; set; }

        /// <summary>
        /// 如果PasswordStatus是unmodifiable说明有旧密码还未过期，此字段将显示旧密码过期的时间，否则为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdlType", this.IdlType);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PasswordStatus", this.PasswordStatus);
            this.SetParamSimple(map, prefix + "ApiAccessId", this.ApiAccessId);
            this.SetParamSimple(map, prefix + "ApiAccessIp", this.ApiAccessIp);
            this.SetParamSimple(map, prefix + "ApiAccessPort", this.ApiAccessPort);
            this.SetParamSimple(map, prefix + "OldPasswordExpireTime", this.OldPasswordExpireTime);
        }
    }
}

