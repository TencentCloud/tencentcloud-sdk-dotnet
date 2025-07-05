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

namespace TencentCloud.Bda.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SegmentationOptions : AbstractModel
    {
        
        /// <summary>
        /// 分割选项-背景
        /// </summary>
        [JsonProperty("Background")]
        public bool? Background{ get; set; }

        /// <summary>
        /// 分割选项-头发
        /// </summary>
        [JsonProperty("Hair")]
        public bool? Hair{ get; set; }

        /// <summary>
        /// 分割选项-左眉
        /// </summary>
        [JsonProperty("LeftEyebrow")]
        public bool? LeftEyebrow{ get; set; }

        /// <summary>
        /// 分割选项-右眉
        /// </summary>
        [JsonProperty("RightEyebrow")]
        public bool? RightEyebrow{ get; set; }

        /// <summary>
        /// 分割选项-左眼
        /// </summary>
        [JsonProperty("LeftEye")]
        public bool? LeftEye{ get; set; }

        /// <summary>
        /// 分割选项-右眼
        /// </summary>
        [JsonProperty("RightEye")]
        public bool? RightEye{ get; set; }

        /// <summary>
        /// 分割选项-鼻子
        /// </summary>
        [JsonProperty("Nose")]
        public bool? Nose{ get; set; }

        /// <summary>
        /// 分割选项-上唇
        /// </summary>
        [JsonProperty("UpperLip")]
        public bool? UpperLip{ get; set; }

        /// <summary>
        /// 分割选项-下唇
        /// </summary>
        [JsonProperty("LowerLip")]
        public bool? LowerLip{ get; set; }

        /// <summary>
        /// 分割选项-牙齿
        /// </summary>
        [JsonProperty("Tooth")]
        public bool? Tooth{ get; set; }

        /// <summary>
        /// 分割选项-口腔（不包含牙齿）
        /// </summary>
        [JsonProperty("Mouth")]
        public bool? Mouth{ get; set; }

        /// <summary>
        /// 分割选项-左耳
        /// </summary>
        [JsonProperty("LeftEar")]
        public bool? LeftEar{ get; set; }

        /// <summary>
        /// 分割选项-右耳
        /// </summary>
        [JsonProperty("RightEar")]
        public bool? RightEar{ get; set; }

        /// <summary>
        /// 分割选项-面部(不包含眼、耳、口、鼻等五官及头发。)
        /// </summary>
        [JsonProperty("Face")]
        public bool? Face{ get; set; }

        /// <summary>
        /// 复合分割选项-头部(包含所有的头部元素，相关装饰除外)
        /// </summary>
        [JsonProperty("Head")]
        public bool? Head{ get; set; }

        /// <summary>
        /// 分割选项-身体（包含脖子）
        /// </summary>
        [JsonProperty("Body")]
        public bool? Body{ get; set; }

        /// <summary>
        /// 分割选项-帽子
        /// </summary>
        [JsonProperty("Hat")]
        public bool? Hat{ get; set; }

        /// <summary>
        /// 分割选项-头饰
        /// </summary>
        [JsonProperty("Headdress")]
        public bool? Headdress{ get; set; }

        /// <summary>
        /// 分割选项-耳环
        /// </summary>
        [JsonProperty("Earrings")]
        public bool? Earrings{ get; set; }

        /// <summary>
        /// 分割选项-项链
        /// </summary>
        [JsonProperty("Necklace")]
        public bool? Necklace{ get; set; }

        /// <summary>
        /// 分割选项-随身物品（ 例如伞、包、手机等。 ）
        /// </summary>
        [JsonProperty("Belongings")]
        public bool? Belongings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Background", this.Background);
            this.SetParamSimple(map, prefix + "Hair", this.Hair);
            this.SetParamSimple(map, prefix + "LeftEyebrow", this.LeftEyebrow);
            this.SetParamSimple(map, prefix + "RightEyebrow", this.RightEyebrow);
            this.SetParamSimple(map, prefix + "LeftEye", this.LeftEye);
            this.SetParamSimple(map, prefix + "RightEye", this.RightEye);
            this.SetParamSimple(map, prefix + "Nose", this.Nose);
            this.SetParamSimple(map, prefix + "UpperLip", this.UpperLip);
            this.SetParamSimple(map, prefix + "LowerLip", this.LowerLip);
            this.SetParamSimple(map, prefix + "Tooth", this.Tooth);
            this.SetParamSimple(map, prefix + "Mouth", this.Mouth);
            this.SetParamSimple(map, prefix + "LeftEar", this.LeftEar);
            this.SetParamSimple(map, prefix + "RightEar", this.RightEar);
            this.SetParamSimple(map, prefix + "Face", this.Face);
            this.SetParamSimple(map, prefix + "Head", this.Head);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "Hat", this.Hat);
            this.SetParamSimple(map, prefix + "Headdress", this.Headdress);
            this.SetParamSimple(map, prefix + "Earrings", this.Earrings);
            this.SetParamSimple(map, prefix + "Necklace", this.Necklace);
            this.SetParamSimple(map, prefix + "Belongings", this.Belongings);
        }
    }
}

