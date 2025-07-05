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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaClassInfo : AbstractModel
    {
        
        /// <summary>
        /// 分类 ID。
        /// </summary>
        [JsonProperty("ClassId")]
        public long? ClassId{ get; set; }

        /// <summary>
        /// 父类 ID，一级分类的父类 ID 为 -1。
        /// </summary>
        [JsonProperty("ParentId")]
        public long? ParentId{ get; set; }

        /// <summary>
        /// 分类名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 分类级别，一级分类为 0，最大值为 3，即最多允许 4 级分类层次。
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 当前分类的第一级子类 ID 集合。
        /// </summary>
        [JsonProperty("SubClassIdSet")]
        public long?[] SubClassIdSet{ get; set; }

        /// <summary>
        /// 分类名称（该字段已不推荐使用，建议使用新的分类名称字段 Name）。
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "SubClassIdSet.", this.SubClassIdSet);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
        }
    }
}

