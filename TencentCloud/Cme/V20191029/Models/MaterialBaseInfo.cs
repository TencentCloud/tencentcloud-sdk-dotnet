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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaterialBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 素材名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 分类路径。
        /// </summary>
        [JsonProperty("ClassPath")]
        public string ClassPath{ get; set; }

        /// <summary>
        /// 标签集合。
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }

        /// <summary>
        /// 归属者。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 素材类型。
        /// </summary>
        [JsonProperty("MaterialType")]
        public string MaterialType{ get; set; }

        /// <summary>
        /// 素材 URL。
        /// </summary>
        [JsonProperty("MaterialUrl")]
        public string MaterialUrl{ get; set; }

        /// <summary>
        /// 云点播媒资 FileId。
        /// </summary>
        [JsonProperty("VodFileId")]
        public string VodFileId{ get; set; }

        /// <summary>
        /// 创建时间，格式按照 ISO 8601 标准表示。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ClassPath", this.ClassPath);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "MaterialType", this.MaterialType);
            this.SetParamSimple(map, prefix + "MaterialUrl", this.MaterialUrl);
            this.SetParamSimple(map, prefix + "VodFileId", this.VodFileId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

