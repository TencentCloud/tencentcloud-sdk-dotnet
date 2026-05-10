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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMPSTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>需要创建的 MPS 模板的类型。取值：</p><li>AIAnalysis: 创建智能分析模板。</li><li>SmartSubtitle: 创建智能字幕模板。</li><li>SmartErase: 创建智能擦除模板。</li>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// <p>MPS 创建模板参数。该参数用于透传至媒体处理服务（MPS），从云点播侧创建用户自定义的 MPS 任务模板。<br>目前仅支持通过此方式创建以下任务类型的模板：</p><ol><li>智能分析：仅支持填写“<a href="https://cloud.tencent.com/document/api/862/40249">创建内容分析模板</a>”接口中的Name、Comment、ClassificationConfigure、TagConfigure、CoverConfigure、FrameTagConfigure几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。</li><li>智能字幕：仅支持填写“<a href="https://cloud.tencent.com/document/api/862/117004">创建智能字幕模板</a>”接口中的Name、Comment、TranslateSwitch、VideoSrcLanguage、SubtitleFormat、SubtitleType、AsrHotWordsConfigure、TranslateDstLanguage、ProcessType几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。</li><li>智能擦除：仅支持填写“<a href="https://cloud.tencent.com/document/api/862/123735">创建智能擦除模板</a>”接口中的Name、Comment、EraseType、EraseSubtitleConfig、EraseWatermarkConfig、ErasePrivacyConfig几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。</li></ol><p>目前模板中仅支持配置以上参数，其他参数无需填写。若包含其它参数，系统将自动忽略。以上透传参数以JSON形式表示。</p>
        /// </summary>
        [JsonProperty("MPSCreateTemplateParams")]
        public string MPSCreateTemplateParams{ get; set; }

        /// <summary>
        /// <p>智能分析模板参数，MPSCreateTemplateParams为空时有效。</p>
        /// </summary>
        [JsonProperty("AIAnalysisTemplate")]
        public MPSAIAnalysisTemplate AIAnalysisTemplate{ get; set; }

        /// <summary>
        /// <p>智能字幕模板参数，MPSCreateTemplateParams为空时有效。</p>
        /// </summary>
        [JsonProperty("SmartSubtitleTemplate")]
        public MPSSmartSubtitleTemplate SmartSubtitleTemplate{ get; set; }

        /// <summary>
        /// <p>智能擦除模板参数，MPSCreateTemplateParams为空时有效。</p>
        /// </summary>
        [JsonProperty("SmartEraseTemplate")]
        public MPSSmartEraseTemplate SmartEraseTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSCreateTemplateParams", this.MPSCreateTemplateParams);
            this.SetParamObj(map, prefix + "AIAnalysisTemplate.", this.AIAnalysisTemplate);
            this.SetParamObj(map, prefix + "SmartSubtitleTemplate.", this.SmartSubtitleTemplate);
            this.SetParamObj(map, prefix + "SmartEraseTemplate.", this.SmartEraseTemplate);
        }
    }
}

