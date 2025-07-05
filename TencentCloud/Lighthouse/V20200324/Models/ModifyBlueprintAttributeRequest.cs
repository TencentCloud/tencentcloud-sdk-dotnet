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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBlueprintAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像 ID。可通过[DescribeBlueprints](https://cloud.tencent.com/document/product/1207/47689)接口返回值中的BlueprintId获取。
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// 设置新的镜像名称。最大长度60。
        /// </summary>
        [JsonProperty("BlueprintName")]
        public string BlueprintName{ get; set; }

        /// <summary>
        /// 设置新的镜像描述。最大长度60。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamSimple(map, prefix + "BlueprintName", this.BlueprintName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

