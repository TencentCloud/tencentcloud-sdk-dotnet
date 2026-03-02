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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageTranslateLLMRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>图片数据的Base64字符串，经Base64编码后不超过 9M，分辨率建议600*800以上，支持PNG、JPG、JPEG格式。</p>
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// <p>目标语言，支持语言列表：</p><ul><li>中文：zh</li><li>繁体（中国台湾）：zh-TW</li><li>繁体（中国香港）：zh-HK</li><li>英文：en</li><li>日语：ja</li><li>韩语：ko</li><li>泰语：th</li><li>越南语：vi</li><li>俄语：ru</li><li>德语：de</li><li>法语：fr</li><li>阿拉伯语：ar</li><li>西班牙语：es</li><li>意大利语：it</li><li>印度尼西亚语：id</li><li>马来西亚语：ms</li><li>葡萄牙语：pt</li><li>土耳其语：tr<br>-</li></ul>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// <p>输入图 Url。 使用Url的时候，Data参数需要传入&quot;&quot;。 图片限制：小于 10MB，分辨率建议600*800以上，格式支持 jpg、jpeg、png。</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

