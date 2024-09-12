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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileTranslateRequest : AbstractModel
    {
        
        /// <summary>
        /// 源语言，支持
        /// zh：简体中文
        /// zh-HK：繁体中文
        /// zh-TW：繁体中文
        /// zh-TR：繁体中文
        /// en：英语
        /// ar：阿拉伯语
        /// de：德语
        /// es：西班牙语
        /// fr：法语
        /// it：意大利语
        /// ja：日语
        /// pt：葡萄牙语
        /// ru：俄语
        /// ko：韩语
        /// th：泰语
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 目标语言，各源语言的目标语言支持列表如下
        /// zh（简体中文）：en（英语）、ar（阿拉伯语）、de（德语）、es（西班牙语）、fr（法语）、it（意大利语）、ja（日语）、pt（葡萄牙语）、ru（俄语）、ko（韩语）、tr（土耳其语）、vi（越南语）、th（泰语）
        /// zh-HK（繁体中文）：en（英语）、ar（阿拉伯语）、de（德语）、es（西班牙语）、fr（法语）、it（意大利语）、ja（日语）、pt（葡萄牙语）、ru（俄语）、ko（韩语）、tr（土耳其语）、vi（越南语）、th（泰语）
        /// zh-TW（繁体中文）：en（英语）、ar（阿拉伯语）、de（德语）、es（西班牙语）、fr（法语）、it（意大利语）、ja（日语）、pt（葡萄牙语）、ru（俄语）、ko（韩语）、tr（土耳其语）、vi（越南语）、th（泰语）
        /// zh-TR（繁体中文）:en（英语）、ar（阿拉伯语）、de（德语）、es（西班牙语）、fr（法语）、it（意大利语）、ja（日语）、pt（葡萄牙语）、ru（俄语）、ko（韩语）、tr（土耳其语）、vi（越南语）、th（泰语）
        /// en（英语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、ar（阿拉伯语）、de（德语）、es（西班牙语）、fr（法语）、it（意大利语）、ja（日语）、pt（葡萄牙语）、ru（俄语）、ko（韩语）、tr（土耳其语）、vi（越南语）、th（泰语）
        /// ar（阿拉伯语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// de（德语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// es（西班牙语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）、fr（法语）
        /// fr（法语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）、es（西班牙语）
        /// it（意大利语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// ja（日语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// pt（葡萄牙语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// ru（俄语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// ko（韩语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// tr（土耳其语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// vi（越南语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// th（泰语）：zh（简体中文）、zh-HK（繁体中文）、zh-TW（繁体中文）、zh-TR（繁体中文）、en（英语）
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 文档类型：可支持以下几种(pdf,docx,pptx,xlsx,txt,xml,html,markdown,properties)
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType{ get; set; }

        /// <summary>
        /// 数据来源，0：url，1：直接传文件编码后数据
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// 需要翻译文件url，URL长度不能超过1000字符。文件限制如下：docx/xIsx/html/markdown文件不超过800万字符，doc/pdf/pptx文件不超过300页，txt/po文件不超过10MB，pdf/docx/pptx/xlsx不超过40MB
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 原始文档类型。该参数为高级参数，请留空，如需使用，请与工作人员确认后再使用。
        /// </summary>
        [JsonProperty("BasicDocumentType")]
        public string BasicDocumentType{ get; set; }

        /// <summary>
        /// 回调url，URL长度不能超过256字符。文件大于10MB或字符较多时，建议采用回调方式；回调时，所有内容会放入 Body 中，具体请参见[文件翻译回调说明](https://cloud.tencent.com/document/product/551/91138)。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 文件数据，当SourceType 值为1时必须填写，为0可不写。要base64编码(采用python语言时注意读取文件应该为string而不是byte，以byte格式读取后要decode()。编码后的数据不可带有回车换行符)。数据要小于5MB。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "BasicDocumentType", this.BasicDocumentType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Data", this.Data);
        }
    }
}

