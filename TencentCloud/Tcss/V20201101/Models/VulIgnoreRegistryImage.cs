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

    public class VulIgnoreRegistryImage : AbstractModel
    {
        
        /// <summary>
        /// 记录ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        [JsonProperty("RegistryName")]
        public string RegistryName{ get; set; }

        /// <summary>
        /// 镜像版本
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [JsonProperty("RegistryPath")]
        public string RegistryPath{ get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 漏洞PocID
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RegistryName", this.RegistryName);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
            this.SetParamSimple(map, prefix + "RegistryPath", this.RegistryPath);
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
        }
    }
}

