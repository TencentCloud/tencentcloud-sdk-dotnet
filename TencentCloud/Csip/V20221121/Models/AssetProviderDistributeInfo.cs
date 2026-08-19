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

    public class AssetProviderDistributeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>腾讯云资产总数</p>
        /// </summary>
        [JsonProperty("TencentAssetCount")]
        public ulong? TencentAssetCount{ get; set; }

        /// <summary>
        /// <p>阿里云资产总数</p>
        /// </summary>
        [JsonProperty("AliAssetCount")]
        public ulong? AliAssetCount{ get; set; }

        /// <summary>
        /// <p>亚马逊云资产总数</p>
        /// </summary>
        [JsonProperty("AwsAssetCount")]
        public ulong? AwsAssetCount{ get; set; }

        /// <summary>
        /// <p>其他云环境资产总数</p>
        /// </summary>
        [JsonProperty("OtherAssetCount")]
        public ulong? OtherAssetCount{ get; set; }

        /// <summary>
        /// <p>微软云资产数量</p>
        /// </summary>
        [JsonProperty("AzureAssetCount")]
        public ulong? AzureAssetCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TencentAssetCount", this.TencentAssetCount);
            this.SetParamSimple(map, prefix + "AliAssetCount", this.AliAssetCount);
            this.SetParamSimple(map, prefix + "AwsAssetCount", this.AwsAssetCount);
            this.SetParamSimple(map, prefix + "OtherAssetCount", this.OtherAssetCount);
            this.SetParamSimple(map, prefix + "AzureAssetCount", this.AzureAssetCount);
        }
    }
}

