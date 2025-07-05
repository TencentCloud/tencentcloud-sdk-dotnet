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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIRecognitionTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// 视频内容识别模板唯一标识。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 视频内容识别模板名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 视频内容识别模板描述信息。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 人脸识别控制参数。
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfo FaceConfigure{ get; set; }

        /// <summary>
        /// 文本全文识别控制参数。
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfo OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// 文本关键词识别控制参数。
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfo OcrWordsConfigure{ get; set; }

        /// <summary>
        /// 语音全文识别控制参数。
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfo AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// 语音关键词识别控制参数。
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfo AsrWordsConfigure{ get; set; }

        /// <summary>
        /// 语音翻译控制参数。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TranslateConfigure")]
        public TranslateConfigureInfo TranslateConfigure{ get; set; }

        /// <summary>
        /// 模板创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/862/37710#52)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 模板最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/862/37710#52)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 模板类型，取值范围：
        /// * Preset：系统预置模板；
        /// * Custom：用户自定义模板。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "FaceConfigure.", this.FaceConfigure);
            this.SetParamObj(map, prefix + "OcrFullTextConfigure.", this.OcrFullTextConfigure);
            this.SetParamObj(map, prefix + "OcrWordsConfigure.", this.OcrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrFullTextConfigure.", this.AsrFullTextConfigure);
            this.SetParamObj(map, prefix + "AsrWordsConfigure.", this.AsrWordsConfigure);
            this.SetParamObj(map, prefix + "TranslateConfigure.", this.TranslateConfigure);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

