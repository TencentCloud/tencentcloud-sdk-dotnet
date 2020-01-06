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

namespace TencentCloud.Ecc.V20181213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentenceSuggest : AbstractModel
    {
        
        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// 原始单词
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 替换成 的单词
        /// </summary>
        [JsonProperty("Replace")]
        public string Replace{ get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 维度单词位置，在句子的第几个到第几个单词之间
        /// </summary>
        [JsonProperty("ErrorPosition")]
        public long?[] ErrorPosition{ get; set; }

        /// <summary>
        /// 维度单词坐标，错误单词在图片中的坐标，只有传图片时正常返回，传文字时返回[ ]
        /// </summary>
        [JsonProperty("ErrorCoordinates")]
        public ErrorCoordinate[] ErrorCoordinates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "Replace", this.Replace);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArraySimple(map, prefix + "ErrorPosition.", this.ErrorPosition);
            this.SetParamArrayObj(map, prefix + "ErrorCoordinates.", this.ErrorCoordinates);
        }
    }
}

