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

    public class MaterialMovedEvent : AbstractModel
    {
        
        /// <summary>
        /// 要移动的媒体 Id 列表。
        /// </summary>
        [JsonProperty("MaterialIdSet")]
        public string[] MaterialIdSet{ get; set; }

        /// <summary>
        /// 源媒体归属。
        /// </summary>
        [JsonProperty("SourceOwner")]
        public Entity SourceOwner{ get; set; }

        /// <summary>
        /// 源媒体分类路径。
        /// </summary>
        [JsonProperty("SourceClassPath")]
        public string SourceClassPath{ get; set; }

        /// <summary>
        /// 目标媒体分类归属。
        /// </summary>
        [JsonProperty("DestinationOwner")]
        public Entity DestinationOwner{ get; set; }

        /// <summary>
        /// 目标媒体分类路径。
        /// </summary>
        [JsonProperty("DestinationClassPath")]
        public string DestinationClassPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MaterialIdSet.", this.MaterialIdSet);
            this.SetParamObj(map, prefix + "SourceOwner.", this.SourceOwner);
            this.SetParamSimple(map, prefix + "SourceClassPath", this.SourceClassPath);
            this.SetParamObj(map, prefix + "DestinationOwner.", this.DestinationOwner);
            this.SetParamSimple(map, prefix + "DestinationClassPath", this.DestinationClassPath);
        }
    }
}

