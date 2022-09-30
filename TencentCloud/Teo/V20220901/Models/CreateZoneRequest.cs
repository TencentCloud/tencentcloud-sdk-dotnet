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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点名称。
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 接入方式，取值有：
        /// <li> full：NS接入；</li>
        /// <li> partial：CNAME接入。</li>不填写使用默认值full。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 是否跳过站点现有的DNS记录扫描。默认值：false。
        /// </summary>
        [JsonProperty("JumpStart")]
        public bool? JumpStart{ get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否允许重复接入。
        /// <li> true：允许重复接入；</li>
        /// <li> false：不允许重复接入。</li>不填写使用默认值false。
        /// </summary>
        [JsonProperty("AllowDuplicates")]
        public bool? AllowDuplicates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "JumpStart", this.JumpStart);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AllowDuplicates", this.AllowDuplicates);
        }
    }
}

