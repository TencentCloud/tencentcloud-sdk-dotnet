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

    public class ClusterServiceListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>资产id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>selector标签</p>
        /// </summary>
        [JsonProperty("SelectorLabel")]
        public AssetTag[] SelectorLabel{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>service 唯一 ID</p>
        /// </summary>
        [JsonProperty("ServiceUniqueID")]
        public string ServiceUniqueID{ get; set; }

        /// <summary>
        /// <p>service 类型</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>集群IP</p>
        /// </summary>
        [JsonProperty("ClusterIP")]
        public string ClusterIP{ get; set; }

        /// <summary>
        /// <p>外网IP</p>
        /// </summary>
        [JsonProperty("ExternalIP")]
        public string[] ExternalIP{ get; set; }

        /// <summary>
        /// <p>端口</p>
        /// </summary>
        [JsonProperty("Ports")]
        public string[] Ports{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "SelectorLabel.", this.SelectorLabel);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ServiceUniqueID", this.ServiceUniqueID);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "ClusterIP", this.ClusterIP);
            this.SetParamArraySimple(map, prefix + "ExternalIP.", this.ExternalIP);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
        }
    }
}

