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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DuplicateImagePersonalRequest : AbstractModel
    {
        
        /// <summary>
        /// 源镜像名称，不包含domain。例如： tencentyun/foo:v1
        /// </summary>
        [JsonProperty("SrcImage")]
        public string SrcImage{ get; set; }

        /// <summary>
        /// 目的镜像名称，不包含domain。例如： tencentyun/foo:latest
        /// </summary>
        [JsonProperty("DestImage")]
        public string DestImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcImage", this.SrcImage);
            this.SetParamSimple(map, prefix + "DestImage", this.DestImage);
        }
    }
}

