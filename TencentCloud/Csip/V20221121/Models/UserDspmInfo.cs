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

    public class UserDspmInfo : AbstractModel
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
        /// <p>账号下数据库资产数量</p>
        /// </summary>
        [JsonProperty("AssetNum")]
        public long? AssetNum{ get; set; }

        /// <summary>
        /// <p>账号下开启安全分析数据库资产数量</p>
        /// </summary>
        [JsonProperty("UsedAssetNum")]
        public long? UsedAssetNum{ get; set; }

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
        /// <p>云类型（0：腾讯云 1:亚马逊云 2:微软云 3:谷歌云 4:阿里云 5:华为云）</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>账号是否隔离中</p>
        /// </summary>
        [JsonProperty("IsIsolating")]
        public bool? IsIsolating{ get; set; }

        /// <summary>
        /// <p>是否正在数据清理</p>
        /// </summary>
        [JsonProperty("IsDataCleaning")]
        public bool? IsDataCleaning{ get; set; }

        /// <summary>
        /// <p>集团账号角色（member-普通成员/admin-管理员/delegatedAdmin-委派管理员），非集团账号为空</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>所属部门名称，未分配部门或非集团账号为空</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "AssetNum", this.AssetNum);
            this.SetParamSimple(map, prefix + "UsedAssetNum", this.UsedAssetNum);
            this.SetParamSimple(map, prefix + "IsShared", this.IsShared);
            this.SetParamSimple(map, prefix + "IsSelfBuy", this.IsSelfBuy);
            this.SetParamSimple(map, prefix + "ShareFromAppID", this.ShareFromAppID);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "IsIsolating", this.IsIsolating);
            this.SetParamSimple(map, prefix + "IsDataCleaning", this.IsDataCleaning);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
        }
    }
}

