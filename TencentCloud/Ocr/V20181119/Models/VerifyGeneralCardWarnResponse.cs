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

    public class VerifyGeneralCardWarnResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>区域篡改提示</p>
        /// </summary>
        [JsonProperty("Tamper")]
        public GeneralCardWarnInfo Tamper{ get; set; }

        /// <summary>
        /// <p>AIGC合成提示</p>
        /// </summary>
        [JsonProperty("Synthesis")]
        public GeneralCardWarnInfo Synthesis{ get; set; }

        /// <summary>
        /// <p>模板图片提示</p>
        /// </summary>
        [JsonProperty("Template")]
        public GeneralCardWarnInfo Template{ get; set; }

        /// <summary>
        /// <p>屏幕翻拍提示</p>
        /// </summary>
        [JsonProperty("RemakeScreen")]
        public GeneralCardWarnInfo RemakeScreen{ get; set; }

        /// <summary>
        /// <p>截图提示</p>
        /// </summary>
        [JsonProperty("Screenshot")]
        public GeneralCardWarnInfo Screenshot{ get; set; }

        /// <summary>
        /// <p>模糊提示</p>
        /// </summary>
        [JsonProperty("Blur")]
        public GeneralCardWarnInfo Blur{ get; set; }

        /// <summary>
        /// <p>边框不完整提示</p>
        /// </summary>
        [JsonProperty("BorderIncomplete")]
        public GeneralCardWarnInfo BorderIncomplete{ get; set; }

        /// <summary>
        /// <p>复印件提示</p>
        /// </summary>
        [JsonProperty("Copy")]
        public GeneralCardWarnInfo Copy{ get; set; }

        /// <summary>
        /// <p>反光提示</p>
        /// </summary>
        [JsonProperty("Reflection")]
        public GeneralCardWarnInfo Reflection{ get; set; }

        /// <summary>
        /// <p>遮挡提示</p>
        /// </summary>
        [JsonProperty("Cover")]
        public GeneralCardWarnInfo Cover{ get; set; }

        /// <summary>
        /// <p>重叠提示</p>
        /// </summary>
        [JsonProperty("Overlap")]
        public GeneralCardWarnInfo Overlap{ get; set; }

        /// <summary>
        /// <p>电子证照提示（目前仅支持电子身份证、电子营业执照识别）</p>
        /// </summary>
        [JsonProperty("Electron")]
        public GeneralCardWarnInfo Electron{ get; set; }

        /// <summary>
        /// <p>文字水印提示</p>
        /// </summary>
        [JsonProperty("TextWatermark")]
        public GeneralCardWarnInfo TextWatermark{ get; set; }

        /// <summary>
        /// <p>水印内容，当未检测到文字水印时不返回，返回多组水印时以 | 分隔。</p>
        /// </summary>
        [JsonProperty("WatermarkContent")]
        public string WatermarkContent{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Tamper.", this.Tamper);
            this.SetParamObj(map, prefix + "Synthesis.", this.Synthesis);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamObj(map, prefix + "RemakeScreen.", this.RemakeScreen);
            this.SetParamObj(map, prefix + "Screenshot.", this.Screenshot);
            this.SetParamObj(map, prefix + "Blur.", this.Blur);
            this.SetParamObj(map, prefix + "BorderIncomplete.", this.BorderIncomplete);
            this.SetParamObj(map, prefix + "Copy.", this.Copy);
            this.SetParamObj(map, prefix + "Reflection.", this.Reflection);
            this.SetParamObj(map, prefix + "Cover.", this.Cover);
            this.SetParamObj(map, prefix + "Overlap.", this.Overlap);
            this.SetParamObj(map, prefix + "Electron.", this.Electron);
            this.SetParamObj(map, prefix + "TextWatermark.", this.TextWatermark);
            this.SetParamSimple(map, prefix + "WatermarkContent", this.WatermarkContent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

