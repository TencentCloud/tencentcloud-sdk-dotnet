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

    public class TerrorismResult : AbstractModel
    {
        
        /// <summary>
        /// 该识别场景的错误码：
        /// 0表示成功，
        /// -1表示系统错误，
        /// -2表示引擎错误，
        /// -1400表示图片解码失败。
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
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 图像涉恐的分数，0-100之间，分数越高涉恐几率越大。
        /// Type为LABEL时：
        /// 0到86，Suggestion建议为PASS
        /// 86到91，Suggestion建议为REVIEW
        /// 91到100，Suggestion建议为BLOCK
        /// Type为FACE时：
        /// 0到70，Suggestion建议为PASS
        /// 70到80，Suggestion建议为REVIEW
        /// 80到100，Suggestion建议为BLOCK
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// Type取值为‘FACE’时，人脸识别的结果列表。基于图片中实际检测到的人脸数，返回数组最大值不超过5个。
        /// </summary>
        [JsonProperty("FaceResults")]
        public FaceResult[] FaceResults{ get; set; }

        /// <summary>
        /// 暴恐识别返回的详细标签后期开放。
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// 取值'LABEL' 或‘FACE’，LABEL表示结论和置信度来自标签分类，FACE表示结论和置信度来自人脸识别。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamArrayObj(map, prefix + "FaceResults.", this.FaceResults);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

