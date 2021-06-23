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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageModerationResponse : AbstractModel
    {
        
        /// <summary>
        /// 该字段用于返回Label标签下的后续操作建议。当您获取到判定结果后，返回值表示系统推荐的后续操作；建议您按照业务所需，对不同违规类型与建议值进行处理。<br>返回值：**Block**：建议屏蔽，**Review** ：建议人工复审，**Pass**：建议通过
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 该字段用于返回检测结果（LabelResults）中所对应的**优先级最高的恶意标签**，表示模型推荐的审核结果，建议您按照业务所需，对不同违规类型与建议值进行处理。<br>返回值：**Normal**：正常，**Porn**：色情，**Abuse**：谩骂，**Ad**：广告，**Custom**：自定义违规；以及其他令人反感、不安全或不适宜的内容类型。
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 该字段用于返回检测结果所命中优先级最高的恶意标签下的子标签名称，如：*色情--性行为*；若未命中任何子标签则返回空字符串。
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// 该字段用于返回当前标签（Label）下的置信度，取值范围：0（**置信度最低**）-100（**置信度最高** ），越高代表文本越有可能属于当前返回的标签；如：*色情 99*，则表明该文本非常有可能属于色情内容；*色情 0*，则表明该文本不属于色情内容。
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 该字段用于返回分类模型命中的恶意标签的详细识别结果，包括涉黄、广告等令人反感、不安全或不适宜的内容类型识别结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelResults")]
        public LabelResult[] LabelResults{ get; set; }

        /// <summary>
        /// 该字段用于返回物体检测模型的详细检测结果；包括：实体、广告台标、二维码等内容命中的标签名称、标签分数、坐标信息、场景识别结果、建议操作等内容审核信息；详细返回值信息可参阅对应的数据结构（ObjectResults）描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectResults")]
        public ObjectResult[] ObjectResults{ get; set; }

        /// <summary>
        /// 该字段用于返回OCR文本识别的详细检测结果；包括：文本坐标信息、文本识别结果、建议操作等内容审核信息；详细返回值信息可参阅对应的数据结构（OcrResults）描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OcrResults")]
        public OcrResult[] OcrResults{ get; set; }

        /// <summary>
        /// 该字段用于返回基于图片风险库（风险黑库与正常白库）识别的结果,详细返回值信息可参阅对应的数据结构（LibResults）描述。<br>备注：图片风险库目前**暂不支持自定义库**。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LibResults")]
        public LibResult[] LibResults{ get; set; }

        /// <summary>
        /// 该字段用于返回检测对象对应请求参数中的DataId。
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 该字段用于返回检测对象对应请求参数中的BizType。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 该字段用于返回根据您的需求配置的额外附加信息（Extra），如未配置则默认返回值为空。<br>备注：不同客户或Biztype下返回信息不同，如需配置该字段请提交工单咨询或联系售后专员处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 该字段用于返回检测对象对应的MD5校验值，以方便校验文件完整性。
        /// </summary>
        [JsonProperty("FileMD5")]
        public string FileMD5{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArrayObj(map, prefix + "LabelResults.", this.LabelResults);
            this.SetParamArrayObj(map, prefix + "ObjectResults.", this.ObjectResults);
            this.SetParamArrayObj(map, prefix + "OcrResults.", this.OcrResults);
            this.SetParamArrayObj(map, prefix + "LibResults.", this.LibResults);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "FileMD5", this.FileMD5);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

