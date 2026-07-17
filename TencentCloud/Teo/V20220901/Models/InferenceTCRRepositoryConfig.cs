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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceTCRRepositoryConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>TCR 服务类型。取值有：<li>Personal：个人版；</li><li>Enterprise：企业版。</li></p>
        /// </summary>
        [JsonProperty("TCRType")]
        public string TCRType{ get; set; }

        /// <summary>
        /// <p>镜像地址。</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>镜像仓库实例 ID。当 TCRType = Enterprise 时必填。</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>地域名称。</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TCRType", this.TCRType);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
        }
    }
}

