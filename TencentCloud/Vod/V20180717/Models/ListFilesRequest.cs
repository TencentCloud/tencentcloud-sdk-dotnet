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

    public class ListFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 点播[应用](/document/product/266/14574) ID。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 对象键匹配前缀，限定响应中只包含指定前缀的对象键。
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// 一个字符的分隔符，用于对对象键进行分组。所有对象键中从 prefix 或从头（如未指定 prefix）到首个 delimiter 之间相同的部分将作为 CommonPrefixes 下的一个 Prefix 节点。被分组的对象键不再出现在后续对象列表中。
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// ys 	 单次返回最大的条目数量，默认值为100，最小为1，最大为100。
        /// </summary>
        [JsonProperty("MaxKeys")]
        public long? MaxKeys{ get; set; }

        /// <summary>
        /// 起始对象键标记
        /// </summary>
        [JsonProperty("Marker")]
        public string Marker{ get; set; }

        /// <summary>
        /// 文件类型。匹配集合中的任意元素： <li>Video: 视频文件</li> <li>Audio: 音频文件</li> <li>Image: 图片文件</li>
        /// </summary>
        [JsonProperty("Categories")]
        public string[] Categories{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "MaxKeys", this.MaxKeys);
            this.SetParamSimple(map, prefix + "Marker", this.Marker);
            this.SetParamArraySimple(map, prefix + "Categories.", this.Categories);
        }
    }
}

