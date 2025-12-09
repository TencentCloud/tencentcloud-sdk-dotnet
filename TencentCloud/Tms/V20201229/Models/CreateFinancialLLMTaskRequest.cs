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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFinancialLLMTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 接口使用的识别策略 ID，请参考 [快速指引](https://cloud.tencent.com/document/product/1124/124604) 获取该值。  
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 送审内容的格式，有两个可选值：
        /// - 1：代表送审内容为**文档**，如DOC文档
        /// - 2：代表送审内容为**纯文本**
        /// </summary>
        [JsonProperty("ContentType")]
        public long? ContentType{ get; set; }

        /// <summary>
        /// 若送审内容为文档（ContentType=1），需要传入具体格式，当前支持：DOC、DOCX、PDF。  
        /// 说明：若送审内容为纯文本（ContentType=2），则本字段传空（FileType=""）。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 送审内容的传入方式如下：
        /// - 若为文档类，需传入文档的URL（原文档文字数不超过10,000字），例如：http://xxxxxxxxxxxx/financial_test.doc
        /// - 若为纯文本类，请以UTF-8格式进行Base64编码后传入（编码后字符数不超过10,000字），例如：5piO5aSpNjAz5LiA5a6a5rao
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

