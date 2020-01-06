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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextResult : AbstractModel
    {
        
        /// <summary>
        /// 该识别场景的错误码：
        /// 0表示成功，
        /// -1表示系统错误，
        /// -2表示引擎错误，
        /// -1400表示图片解码失败，
        /// -1401表示图片不符合规范。
        /// -1402表示图片文件太大。
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 错误码描述信息。
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 识别场景的审核结论：
        /// PASS：正常
        /// REVIEW：疑似
        /// BLOCK：违规
        /// 
        /// Suggestion由Type决定：
        /// Type为 NOTEXT/NORMAL 时，Suggestion为PASS；
        /// Type为 POLITICS/PORN/TERRORISM/ADS 时，Suggestion为BLOCK；
        /// 其他情况下Suggestion为REVIEW。
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 算法对于识别结果的置信度，0-100之间，值越高，表示对于结论越确定。
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 识别到的关键词数组
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 图片中是否包含敏感文本内容。
        /// 包含：
        /// NOTEXT：无文本
        /// NORMAL：内容正常
        /// ADS：广告推广
        /// POLITICS：政治
        /// PORN：色情
        /// DRUGS：涉毒
        /// CURSE：谩骂
        /// TERRORISM：暴恐
        /// OTHERS：其他
        /// 
        /// 本服务利用微信团队提供的算法，可以准确识别图片中是否包含二维码。当图片中存在二维码时，分类为ADS，关键词输出为“二维码”。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 预留字段，后期用于展示更多识别信息。
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
        }
    }
}

