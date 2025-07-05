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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReconstructDocumentSSEConfig : AbstractModel
    {
        
        /// <summary>
        /// Markdown文件中表格返回的形式
        /// 0，表格以MD形式返回
        /// 1，表格以HTML形式返回
        /// 默认为0
        /// </summary>
        [JsonProperty("TableResultType")]
        public string TableResultType{ get; set; }

        /// <summary>
        /// Markdown文件中图片返回的形式
        /// 0:markdown中图片以链接形式返回
        /// 1:markdown中图片只返回图片中提取的文本内容
        /// 默认是0
        /// </summary>
        [JsonProperty("MarkdownImageResponseType")]
        public string MarkdownImageResponseType{ get; set; }

        /// <summary>
        /// Markdown文件中是否包含页码信息
        /// </summary>
        [JsonProperty("ReturnPageFormat")]
        public bool? ReturnPageFormat{ get; set; }

        /// <summary>
        /// 自定义输出页码样式,{{p}}为页码占位符，开启ReturnPageFormat生效。未填默认样式:<page_num>page {{p}}</page_num>
        /// </summary>
        [JsonProperty("PageFormat")]
        public string PageFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableResultType", this.TableResultType);
            this.SetParamSimple(map, prefix + "MarkdownImageResponseType", this.MarkdownImageResponseType);
            this.SetParamSimple(map, prefix + "ReturnPageFormat", this.ReturnPageFormat);
            this.SetParamSimple(map, prefix + "PageFormat", this.PageFormat);
        }
    }
}

