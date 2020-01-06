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

    public class AssessQualityResponse : AbstractModel
    {
        
        /// <summary>
        /// 取值为TRUE或FALSE，TRUE为长图，FALSE为正常图，长图定义为长宽比大于等于3或小于等于1/3的图片。
        /// </summary>
        [JsonProperty("LongImage")]
        public bool? LongImage{ get; set; }

        /// <summary>
        /// 取值为TRUE或FALSE，TRUE为黑白图，FALSE为否。黑白图即灰度图，指红绿蓝三个通道都是以灰度色阶显示的图片，并非视觉上的“黑白图片”。
        /// </summary>
        [JsonProperty("BlackAndWhite")]
        public bool? BlackAndWhite{ get; set; }

        /// <summary>
        /// 取值为TRUE或FALSE，TRUE为小图，FALSE为否, 小图定义为最长边小于179像素的图片。当一张图片被判断为小图时，不建议做推荐和展示，其他字段统一输出为0或FALSE。
        /// </summary>
        [JsonProperty("SmallImage")]
        public bool? SmallImage{ get; set; }

        /// <summary>
        /// 取值为TRUE或FALSE，TRUE为大图，FALSE为否，定义为最短边大于1000像素的图片
        /// </summary>
        [JsonProperty("BigImage")]
        public bool? BigImage{ get; set; }

        /// <summary>
        /// 取值为TRUE或FALSE，TRUE为纯色图或纯文字图，即没有内容或只有简单内容的图片，FALSE为正常图片。
        /// </summary>
        [JsonProperty("PureImage")]
        public bool? PureImage{ get; set; }

        /// <summary>
        /// 综合评分。图像清晰度的得分，对图片的噪声、曝光、模糊、压缩等因素进行综合评估，取值为[0, 100]，值越大，越清晰。一般大于50为较清晰图片，标准可以自行把握。
        /// </summary>
        [JsonProperty("ClarityScore")]
        public long? ClarityScore{ get; set; }

        /// <summary>
        /// 综合评分。图像美观度得分， 从构图、色彩等多个艺术性维度评价图片，取值为[0, 100]，值越大，越美观。一般大于50为较美观图片，标准可以自行把握。
        /// </summary>
        [JsonProperty("AestheticScore")]
        public long? AestheticScore{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LongImage", this.LongImage);
            this.SetParamSimple(map, prefix + "BlackAndWhite", this.BlackAndWhite);
            this.SetParamSimple(map, prefix + "SmallImage", this.SmallImage);
            this.SetParamSimple(map, prefix + "BigImage", this.BigImage);
            this.SetParamSimple(map, prefix + "PureImage", this.PureImage);
            this.SetParamSimple(map, prefix + "ClarityScore", this.ClarityScore);
            this.SetParamSimple(map, prefix + "AestheticScore", this.AestheticScore);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

