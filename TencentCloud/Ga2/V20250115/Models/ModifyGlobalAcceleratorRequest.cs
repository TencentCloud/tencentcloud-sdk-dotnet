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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGlobalAcceleratorRequest : AbstractModel
    {
        
        /// <summary>
        /// 全球加速实例ID。
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// 名称，最大长度不能超过60个字节。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述信息，最大长度不能超过100个字节。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 跨境类型。
        /// </summary>
        [JsonProperty("CrossBorderType")]
        public string CrossBorderType{ get; set; }

        /// <summary>
        /// 代表是否跨境服务承诺。
        /// </summary>
        [JsonProperty("CrossBorderPromiseFlag")]
        public bool? CrossBorderPromiseFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CrossBorderType", this.CrossBorderType);
            this.SetParamSimple(map, prefix + "CrossBorderPromiseFlag", this.CrossBorderPromiseFlag);
        }
    }
}

