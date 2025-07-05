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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanIgnoreVul : AbstractModel
    {
        
        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 漏洞CVEID
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// 漏洞PocID
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }

        /// <summary>
        /// 忽略的仓库镜像数
        /// </summary>
        [JsonProperty("RegistryImageCount")]
        public long? RegistryImageCount{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否忽略所有镜像：0：否/1：是
        /// </summary>
        [JsonProperty("IsIgnoreAll")]
        public long? IsIgnoreAll{ get; set; }

        /// <summary>
        /// 忽略的本地镜像数
        /// </summary>
        [JsonProperty("LocalImageCount")]
        public long? LocalImageCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
            this.SetParamSimple(map, prefix + "RegistryImageCount", this.RegistryImageCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsIgnoreAll", this.IsIgnoreAll);
            this.SetParamSimple(map, prefix + "LocalImageCount", this.LocalImageCount);
        }
    }
}

