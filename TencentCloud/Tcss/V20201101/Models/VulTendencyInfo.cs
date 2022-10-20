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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulTendencyInfo : AbstractModel
    {
        
        /// <summary>
        /// 漏洞趋势列表
        /// </summary>
        [JsonProperty("VulSet")]
        public RunTimeTendencyInfo[] VulSet{ get; set; }

        /// <summary>
        /// 漏洞影响的镜像类型：
        /// LOCAL：本地镜像
        /// REGISTRY: 仓库镜像
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "VulSet.", this.VulSet);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
        }
    }
}

