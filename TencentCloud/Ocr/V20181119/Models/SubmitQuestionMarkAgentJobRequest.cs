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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitQuestionMarkAgentJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>图片/PDF的 Base64 值。要求Base64不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>图片/PDF的 Url 地址。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>不传则默认识别整个PDF，如果识别单页则输入指定页码</p>
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// <p>表示整张试卷批改需要先切题，默认为false</p>
        /// </summary>
        [JsonProperty("BoolSingleQuestion")]
        [System.Obsolete]
        public bool? BoolSingleQuestion{ get; set; }

        /// <summary>
        /// <p>默认false 表示关闭深度思考  true 表示打开深度思考，更深层次推理分析，速度更慢</p>
        /// </summary>
        [JsonProperty("EnableDeepThink")]
        [System.Obsolete]
        public bool? EnableDeepThink{ get; set; }

        /// <summary>
        /// <p>题目信息输出配置，当key对应为true表示开启配置开关。<br>当key为KnowledgePoints value为true 表示输出每道题结构信息中输出知识点内容；<br>当key为TrueAnswer value为true 表示输出每道题的正确答案 ；<br>当key为StepCorrection value为true表示启用步骤级批改；<br>当key为DisableAnswerAnalysis value为true表示不输出答案解析；<br>当key为OutputSubQuestionsAndCoords value为true表示输出子题干和插图坐标；<br>当key为UseCoordAssist value为true表示使用精调坐标辅助模型，false表示默认模型坐标（性能更优）；</p>
        /// </summary>
        [JsonProperty("QuestionConfigMap")]
        public string QuestionConfigMap{ get; set; }

        /// <summary>
        /// <p>【废弃字段】</p>
        /// </summary>
        [JsonProperty("ReferenceAnswer")]
        public string ReferenceAnswer{ get; set; }

        /// <summary>
        /// <p>批量base64图片入口，每个base64参考单独ImageBase64参数规则。</p><ol><li>当AssistMarkType为2时，用于提供题目相关的辅助批改图片信息.ImageBase64List.N/ImageUrlList.N来输入含正确解析试卷，最多1张</li><li>当AssistMarkType为0时，ImageBase64List.N/ImageUrlList.N图片会执行多图同时批改逻辑（解决单题跨页场景）</li></ol>
        /// </summary>
        [JsonProperty("ImageBase64List")]
        public string[] ImageBase64List{ get; set; }

        /// <summary>
        /// <p>批量ImageUrl图片入口，每个ImageUrl参考单独ImageUrl参数规则。</p><ol><li>当AssistMarkType为2时，用于提供题目相关的辅助批改图片信息.ImageBase64List.N/ImageUrlList.N 来输入含正确解析试卷，最多1张</li><li>当AssistMarkType为1时，ImageBase64List.N/ImageUrlList.N图片会执行多图同时批改逻辑（解决单题跨页场景）</li></ol>
        /// </summary>
        [JsonProperty("ImageUrlList")]
        public string[] ImageUrlList{ get; set; }

        /// <summary>
        /// <p>辅助批改类型</p><p>枚举值：</p><ul><li>0： 无辅助批改，直接模型批改</li><li>1： 单题文本辅助批改，配合AnswerAssistMap使用</li><li>2： 整页辅助批改，待批改试卷使用ImageUrl/ImageBase64，答案部分使用ImageBase64List.N/ImageUrlList.N</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("AssistMarkType")]
        public long? AssistMarkType{ get; set; }

        /// <summary>
        /// <p>单题辅助批改文本内容列表，当AssistMarkType为1时生效，用于提供题目相关的辅助文本信息。</p><ol><li>当key为ReferenceAnswer，value可以输入单题的辅助答案文本。</li><li>当key为QuestionAuxStem，value可以输入单题的辅助题干。</li></ol>
        /// </summary>
        [JsonProperty("AnswerAssistMap")]
        public string AnswerAssistMap{ get; set; }

        /// <summary>
        /// <p>是否开启切边、弯曲矫正、方向矫正，开启则批改之前先做图片前处理，图片url地址返回在查询接口的QuestionInfo-&gt; ReturnImageUr中l,默认为false不开启</p>
        /// </summary>
        [JsonProperty("EnableImageCrop")]
        public bool? EnableImageCrop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "BoolSingleQuestion", this.BoolSingleQuestion);
            this.SetParamSimple(map, prefix + "EnableDeepThink", this.EnableDeepThink);
            this.SetParamSimple(map, prefix + "QuestionConfigMap", this.QuestionConfigMap);
            this.SetParamSimple(map, prefix + "ReferenceAnswer", this.ReferenceAnswer);
            this.SetParamArraySimple(map, prefix + "ImageBase64List.", this.ImageBase64List);
            this.SetParamArraySimple(map, prefix + "ImageUrlList.", this.ImageUrlList);
            this.SetParamSimple(map, prefix + "AssistMarkType", this.AssistMarkType);
            this.SetParamSimple(map, prefix + "AnswerAssistMap", this.AnswerAssistMap);
            this.SetParamSimple(map, prefix + "EnableImageCrop", this.EnableImageCrop);
        }
    }
}

