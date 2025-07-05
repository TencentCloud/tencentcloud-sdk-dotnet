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

    public class Vpc : AbstractModel
    {
        
        /// <summary>
        /// 子网(只支持32位)
        /// </summary>
        [JsonProperty("Subnet")]
        public ulong? Subnet{ get; set; }

        /// <summary>
        /// 互通vpc(只支持32位)
        /// </summary>
        [JsonProperty("ConnectedVpc")]
        public ulong? ConnectedVpc{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// region区域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 云服务器(只支持32位)
        /// </summary>
        [JsonProperty("CVM")]
        public ulong? CVM{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// dns域名
        /// </summary>
        [JsonProperty("DNS")]
        public string[] DNS{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// cidr网段
        /// </summary>
        [JsonProperty("CIDR")]
        public string CIDR{ get; set; }

        /// <summary>
        /// 资产创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 是否新资产 1新
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// 是否核心资产1是 2不是
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Subnet", this.Subnet);
            this.SetParamSimple(map, prefix + "ConnectedVpc", this.ConnectedVpc);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CVM", this.CVM);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamArraySimple(map, prefix + "DNS.", this.DNS);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "CIDR", this.CIDR);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
        }
    }
}

