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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitVideoExtendKlingJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>视频ID  支持通过文本、图片和视频延长生成的视频的ID（原视频不能超过3分钟）  请注意，基于目前的清理策略、视频生成30天之后会被清理，则无法进行延长</p>
        /// </summary>
        [JsonProperty("VideoId")]
        public string VideoId{ get; set; }

        /// <summary>
        /// <p>正向文本提示词  不能超过2500个字符</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>负向文本提示词  不能超过2500个字符</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ExternalTaskId")]
        public string ExternalTaskId{ get; set; }

        /// <summary>
        /// <p>提示词参考强度  取值范围：[0,1]，数值越大参考强度越大</p>
        /// </summary>
        [JsonProperty("CfgScale")]
        public float? CfgScale{ get; set; }

        /// <summary>
        /// <p>本次任务结果回调通知地址，如果配置，服务端会在任务状态发生变更时主动通知</p>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>为生成视频添加标识的开关，默认为1。传0 需前往  <a href="https://console.cloud.tencent.com/vtc/setting">控制台</a>  申请开启显式标识自主完成后方可生效。<br>1：添加标识；<br>0：不添加标识；<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示，该视频是 AI 生成的视频。</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成视频的右下角添加“ AI 生成”或“视频由 AI 生成”字样，如需替换为其他的标识图片，需前往   <a href="https://console.cloud.tencent.com/vtc/setting">控制台</a>  申请开启显式标识自主完成。</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoId", this.VideoId);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "ExternalTaskId", this.ExternalTaskId);
            this.SetParamSimple(map, prefix + "CfgScale", this.CfgScale);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

