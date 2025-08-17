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

    public class ModifyMPSTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 需要修改的 MPS 模板的类型。取值：
        /// <li>Transcode: 创建转码模板，目前仅支持修改增强参数。</li>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// MPS 修改模板参数。该参数用于透传至媒体处理服务（MPS），从云点播侧修改用户自定义的 MPS 任务模板。
        ///  目前仅支持通过此方式修改以下任务类型的模板：
        /// 1. 音视频增强：仅支持填写“[修改转码模板](https://cloud.tencent.com/document/api/862/37578)”接口中的 Name、Comment、RemoveVideo、RemoveAudio、VideoTemplate、AudioTemplate 和 EnhanceConfig 几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。
        /// 示例：{"Definition":24214,"Container":"mp4","Name":"test","RemoveAudio":1,"VideoTemplate":{"Codec":"h264","Fps":0,"Bitrate":0},"EnhanceConfig":{"VideoEnhance":{"FrameRate":{"Switch":"ON","Fps":50}}}}
        /// </summary>
        [JsonProperty("MPSModifyTemplateParams")]
        public string MPSModifyTemplateParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSModifyTemplateParams", this.MPSModifyTemplateParams);
        }
    }
}

