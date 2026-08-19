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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserCSPMInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>APPID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>账号昵称</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>CSPM扫描配额</p>
        /// </summary>
        [JsonProperty("CSPMNum")]
        public long? CSPMNum{ get; set; }

        /// <summary>
        /// <p>已消耗CSPM扫描配额</p>
        /// </summary>
        [JsonProperty("UsedCount")]
        public long? UsedCount{ get; set; }

        /// <summary>
        /// <p>赠送CSPM扫描配额</p>
        /// </summary>
        [JsonProperty("GrantedCSPMNum")]
        public long? GrantedCSPMNum{ get; set; }

        /// <summary>
        /// <p>是否被共享，1-被共享，2-未被共享</p>
        /// </summary>
        [JsonProperty("IsShared")]
        public long? IsShared{ get; set; }

        /// <summary>
        /// <p>是否单独购买，1-单独购买，2-未单独购买</p>
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public long? IsSelfBuy{ get; set; }

        /// <summary>
        /// <p>配额来源账号</p>
        /// </summary>
        [JsonProperty("ShareFromAppID")]
        public long? ShareFromAppID{ get; set; }

        /// <summary>
        /// <p>角色:member:成员;admin:管理员;delegatedAdmin:委派管理员</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>所在部门</p>
        /// </summary>
        [JsonProperty("Department")]
        public string Department{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "CSPMNum", this.CSPMNum);
            this.SetParamSimple(map, prefix + "UsedCount", this.UsedCount);
            this.SetParamSimple(map, prefix + "GrantedCSPMNum", this.GrantedCSPMNum);
            this.SetParamSimple(map, prefix + "IsShared", this.IsShared);
            this.SetParamSimple(map, prefix + "IsSelfBuy", this.IsSelfBuy);
            this.SetParamSimple(map, prefix + "ShareFromAppID", this.ShareFromAppID);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Department", this.Department);
        }
    }
}

