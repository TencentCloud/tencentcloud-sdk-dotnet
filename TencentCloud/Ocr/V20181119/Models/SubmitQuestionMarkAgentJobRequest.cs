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
        /// 图片/PDF的 Base64 值。要求Base64不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。  示例值：/9j/4AAQSkZJRg.....s97n//2Q==
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片/PDF的 Url 地址。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。  示例值：https://ocr-demo-1254418846.cos.ap-guangzhou.myqcloud.com/general/GeneralAccurateOCR/GeneralAccurateOCR1.jpg
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 需要识别的PDF页面的对应页码，仅支持PDF单页识别，默认值为1。
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// 表示整张试卷批改需要先切题，默认为false
        /// </summary>
        [JsonProperty("BoolSingleQuestion")]
        [System.Obsolete]
        public bool? BoolSingleQuestion{ get; set; }

        /// <summary>
        /// 默认false 表示关闭深度思考  true 表示打开深度思考，更深层次推理分析，速度更慢
        /// </summary>
        [JsonProperty("EnableDeepThink")]
        [System.Obsolete]
        public bool? EnableDeepThink{ get; set; }

        /// <summary>
        /// 题目信息输出配置，当key对应为true表示开启配置开关。     当key为KnowledgePoints value为true 表示输出每道题结构信息中输出知识点内容；当key为TrueAnswer  value为true 表示输出每道题的正确答案 ；当key为ReturnAnswerPosition  value为false表示不输出手写答案坐标（降低处理耗时，按需输出）； 设置方式参考  {"KnowledgePoints":true,"TrueAnswer":true}
        /// </summary>
        [JsonProperty("QuestionConfigMap")]
        public string QuestionConfigMap{ get; set; }

        /// <summary>
        /// 仅有单题有效，如果切题有多题则不生效，单题批改的时候作为参考答案输入到批改模型中
        /// </summary>
        [JsonProperty("ReferenceAnswer")]
        public string ReferenceAnswer{ get; set; }


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
        }
    }
}

