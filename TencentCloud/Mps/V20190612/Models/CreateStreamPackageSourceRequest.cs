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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStreamPackageSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 该source所属的location id，必填且唯一绑定一个location。
        /// </summary>
        [JsonProperty("AttachedLocation")]
        public string AttachedLocation{ get; set; }

        /// <summary>
        /// Source名称，在location下面全局唯一。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 区分直播Live和点播VOD source类型，可选值：Live、VOD。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// source具体配置。
        /// </summary>
        [JsonProperty("PackageConfs")]
        public SourcePackageConf[] PackageConfs{ get; set; }

        /// <summary>
        /// sourcetag标签，ADS可以根据Source Tag信息，返回更精准的广告
        /// </summary>
        [JsonProperty("SourceTags")]
        public SourceTag[] SourceTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AttachedLocation", this.AttachedLocation);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "PackageConfs.", this.PackageConfs);
            this.SetParamArrayObj(map, prefix + "SourceTags.", this.SourceTags);
        }
    }
}

