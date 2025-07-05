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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaterialModifiedEvent : AbstractModel
    {
        
        /// <summary>
        /// 媒体 Id。
        /// </summary>
        [JsonProperty("MaterialId")]
        public string MaterialId{ get; set; }

        /// <summary>
        /// 更新后的媒体名称。如未更新则为空。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 更新后的媒体预置标签列表。如未更新媒体预置标签，则该字段为空数组。
        /// </summary>
        [JsonProperty("PresetTagIdSet")]
        public string[] PresetTagIdSet{ get; set; }

        /// <summary>
        /// 更新后的媒体自定义标签列表。如未更新媒体自定义标签，则该字段为空数组。
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaterialId", this.MaterialId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "PresetTagIdSet.", this.PresetTagIdSet);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

