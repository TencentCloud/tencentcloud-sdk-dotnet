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

namespace TencentCloud.Ai3d.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ViewImage : AbstractModel
    {
        
        /// <summary>
        /// 视角类型。
        /// 取值：back、left、right
        /// </summary>
        [JsonProperty("ViewType")]
        public string ViewType{ get; set; }

        /// <summary>
        /// 图片Url地址
        /// </summary>
        [JsonProperty("ViewImageUrl")]
        public string ViewImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
            this.SetParamSimple(map, prefix + "ViewImageUrl", this.ViewImageUrl);
        }
    }
}

