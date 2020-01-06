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

    public class CMEExportInfo : AbstractModel
    {
        
        /// <summary>
        /// 导出的归属者。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 导出的素材名称，不得超过30个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 导出的素材信息，不得超过50个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 导出的素材分类路径，长度不能超过15字符。
        /// </summary>
        [JsonProperty("ClassPath")]
        public string ClassPath{ get; set; }

        /// <summary>
        /// 导出的素材标签，单个标签不得超过10个字符。
        /// </summary>
        [JsonProperty("TagSet")]
        public string[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ClassPath", this.ClassPath);
            this.SetParamArraySimple(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

