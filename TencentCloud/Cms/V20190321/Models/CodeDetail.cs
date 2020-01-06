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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CodeDetail : AbstractModel
    {
        
        /// <summary>
        /// 二维码在图片中的位置，由4个点的坐标表示
        /// </summary>
        [JsonProperty("CodePosition")]
        public CodePosition[] CodePosition{ get; set; }

        /// <summary>
        /// 二维码文本的编码格式
        /// </summary>
        [JsonProperty("CodeCharset")]
        public string CodeCharset{ get; set; }

        /// <summary>
        /// 二维码的文本内容
        /// </summary>
        [JsonProperty("CodeText")]
        public string CodeText{ get; set; }

        /// <summary>
        /// 二维码的类型：1：ONED_BARCODE，2：QRCOD，3:WXCODE，4：PDF417，5:DATAMATRIX
        /// </summary>
        [JsonProperty("CodeType")]
        public long? CodeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CodePosition.", this.CodePosition);
            this.SetParamSimple(map, prefix + "CodeCharset", this.CodeCharset);
            this.SetParamSimple(map, prefix + "CodeText", this.CodeText);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
        }
    }
}

