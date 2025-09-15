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
        /// 图片数据的Base64字符串，经Base64编码后不超过 9M，分辨率建议600*800以上，支持PNG、JPG、JPEG格式。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 目标语言，支持语言列表：
        /// 
        /// - 中文：zh
        /// - 繁体（中国台湾）：zh-TW
        /// - 繁体（中国香港）：zh-HK
        /// - 英文：en
        /// - 日语：ja
        /// - 韩语：ko
        /// - 泰语：th
        /// - 越南语：vi
        /// - 俄语：ru
        /// - 德语：de
        /// - 法语：fr
        /// - 阿拉伯语：ar
        /// - 西班牙语：es
        /// - 意大利语：it
        /// - 印度尼西亚语：id
        /// - 马来西亚语：ms
        /// - 葡萄牙语：pt
        /// - 土耳其语：tr
        /// - 
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 输入图 Url。 使用Url的时候，Data参数需要传入""。 图片限制：小于 10MB，分辨率建议600*800以上，格式支持 jpg、jpeg、png。
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

