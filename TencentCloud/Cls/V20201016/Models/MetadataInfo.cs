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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetadataInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据格式,rawlog/json
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 投递字段，包括\_\_SOURCE\_\_、\_\_FILENAME\_\_
        /// 、\_\_TIMESTAMP\_\_、\_\_HOSTNAME\_\_、\_\_PKG\_ID\_\_
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// 是否投递__TAG__字段
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// JSON是否平铺，投递__TAG__字段时必填
        /// </summary>
        [JsonProperty("TagJsonTiled")]
        public bool? TagJsonTiled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamSimple(map, prefix + "TagJsonTiled", this.TagJsonTiled);
        }
    }
}

