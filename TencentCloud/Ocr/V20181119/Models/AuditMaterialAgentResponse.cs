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

    public class AuditMaterialAgentResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>商户照片类型  支持该出参的资料审核Agent类型：StorePicAudit</p>
        /// </summary>
        [JsonProperty("StoreLabel")]
        public string[] StoreLabel{ get; set; }

        /// <summary>
        /// <p>商户照片分类具体场景标签，输出3个最匹配的场景， 注：仅SceneType配置为true时支持。  支持该出参的资料审核Agent类型：StorePicAudit</p>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>商户门头名称  支持该出参的资料审核Agent类型：StorePicAudit</p>
        /// </summary>
        [JsonProperty("StoreInfo")]
        public StoreInfo[] StoreInfo{ get; set; }

        /// <summary>
        /// <p>图片旋转角度（角度制），文本的水平方向为0°，顺时针为正，逆时针为负  支持该出参的资料审核Agent类型：StorePicAudit</p>
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// <p>区域篡改提示</p>
        /// </summary>
        [JsonProperty("Tamper")]
        public SceneWarnInfo Tamper{ get; set; }

        /// <summary>
        /// <p>AIGC合成提示</p>
        /// </summary>
        [JsonProperty("Synthesis")]
        public SceneWarnInfo Synthesis{ get; set; }

        /// <summary>
        /// <p>屏幕翻拍提示</p>
        /// </summary>
        [JsonProperty("RemakeScreen")]
        public SceneWarnInfo RemakeScreen{ get; set; }

        /// <summary>
        /// <p>截图提示</p>
        /// </summary>
        [JsonProperty("Screenshot")]
        public SceneWarnInfo Screenshot{ get; set; }

        /// <summary>
        /// <p>文字水印提示</p>
        /// </summary>
        [JsonProperty("TextWatermark")]
        public SceneWarnInfo TextWatermark{ get; set; }

        /// <summary>
        /// <p>水印内容，当未检测到文字水印时不返回，返回多组水印时以 | 分隔。</p>
        /// </summary>
        [JsonProperty("WatermarkContent")]
        public string WatermarkContent{ get; set; }

        /// <summary>
        /// <p>模板图片提示</p>
        /// </summary>
        [JsonProperty("Template")]
        public SceneWarnInfo Template{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "StoreLabel.", this.StoreLabel);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamArrayObj(map, prefix + "StoreInfo.", this.StoreInfo);
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamObj(map, prefix + "Tamper.", this.Tamper);
            this.SetParamObj(map, prefix + "Synthesis.", this.Synthesis);
            this.SetParamObj(map, prefix + "RemakeScreen.", this.RemakeScreen);
            this.SetParamObj(map, prefix + "Screenshot.", this.Screenshot);
            this.SetParamObj(map, prefix + "TextWatermark.", this.TextWatermark);
            this.SetParamSimple(map, prefix + "WatermarkContent", this.WatermarkContent);
            this.SetParamObj(map, prefix + "Template.", this.Template);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

