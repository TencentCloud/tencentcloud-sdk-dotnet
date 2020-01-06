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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWordSamplesRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>关键词应用场景，可选值：</b>
        /// 1. Recognition.Ocr：通过光学字符识别技术，进行内容识别；
        /// 2. Recognition.Asr：通过语音识别技术，进行内容识别；
        /// 3. Review.Ocr：通过光学字符识别技术，进行内容审核；
        /// 4. Review.Asr：通过语音识别技术，进行内容审核；
        /// <b>可合并简写为：</b>
        /// 5. Recognition：通过光学字符识别技术、语音识别技术，进行内容识别，等价于 1+2；
        /// 6. Review：通过光学字符识别技术、语音识别技术，进行内容审核，等价于 3+4；
        /// 7. All：通过光学字符识别技术、语音识别技术，进行内容识别、内容审核，等价于 1+2+3+4。
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// 关键词，数组长度限制：100。
        /// </summary>
        [JsonProperty("Words")]
        public AiSampleWordInfo[] Words{ get; set; }

        /// <summary>
        /// 点播[子应用](/document/product/266/14574) ID。如果要访问子应用中的资源，则将该字段填写为子应用 ID；否则无需填写该字段。
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamArrayObj(map, prefix + "Words.", this.Words);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

