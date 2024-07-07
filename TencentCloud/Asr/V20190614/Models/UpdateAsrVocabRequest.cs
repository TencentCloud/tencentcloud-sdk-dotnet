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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAsrVocabRequest : AbstractModel
    {
        
        /// <summary>
        /// 热词表ID
        /// </summary>
        [JsonProperty("VocabId")]
        public string VocabId{ get; set; }

        /// <summary>
        /// 热词表名称，长度在1-255之间
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 词权重数组，包含全部的热词和对应的权重。每个热词的长度不大于10个汉字或30个英文字符，权重为[1,11]之间整数或100，数组长度不大于1000 (注意：如果仅更新热词表名称或者描述字段，请求不用带本参数）
        /// </summary>
        [JsonProperty("WordWeights")]
        public HotWord[] WordWeights{ get; set; }

        /// <summary>
        /// 词权重文件（纯文本文件）的二进制base64编码，以行分隔，每行的格式为word|weight，即以英文符号|为分割，左边为词，右边为权重，如：你好|5。
        /// 当用户传此参数（参数长度大于0），即以此参数解析词权重，WordWeights会被忽略
        ///  (注意：如果仅更新热词表名称或者描述字段，请求不用带本参数）
        /// </summary>
        [JsonProperty("WordWeightStr")]
        public string WordWeightStr{ get; set; }

        /// <summary>
        /// 热词表描述，长度在0-1000之间
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VocabId", this.VocabId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "WordWeights.", this.WordWeights);
            this.SetParamSimple(map, prefix + "WordWeightStr", this.WordWeightStr);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

