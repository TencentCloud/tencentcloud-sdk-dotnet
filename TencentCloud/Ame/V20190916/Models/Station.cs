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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Station : AbstractModel
    {
        
        /// <summary>
        /// StationID
        /// </summary>
        [JsonProperty("CategoryID")]
        public string CategoryID{ get; set; }

        /// <summary>
        /// Station MCCode
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryCode")]
        public string CategoryCode{ get; set; }

        /// <summary>
        /// Category Name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Station的排序值，供参考（返回结果已按其升序）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rank")]
        public long? Rank{ get; set; }

        /// <summary>
        /// station图片集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImagePathMap")]
        public ImagePath[] ImagePathMap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryID", this.CategoryID);
            this.SetParamSimple(map, prefix + "CategoryCode", this.CategoryCode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Rank", this.Rank);
            this.SetParamArrayObj(map, prefix + "ImagePathMap.", this.ImagePathMap);
        }
    }
}

