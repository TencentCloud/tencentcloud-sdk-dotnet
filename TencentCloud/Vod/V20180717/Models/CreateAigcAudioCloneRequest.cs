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

    public class CreateAigcAudioCloneRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>点播<a href="https://cloud.tencent.com/document/product/266/14574">应用</a> ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>原音频文件（需要确保可访问） 模型将以此参数中传入的音频音色为示例对音色进行复刻。  </p><p>入参限制：注1：音频仅支持格式：mp3、m4a、wav； 注2：上传的音频文件的时长最少应不低于 10 秒，最长应不超过 5 分钟； 注3：上传的音频文件大小需不超过20mb； 注4：音频内容免涉版权，否则会被下架或销毁。</p>
        /// </summary>
        [JsonProperty("AudioFileInfo")]
        public AigcAudioCloneInputFileInfo AudioFileInfo{ get; set; }

        /// <summary>
        /// <p>自定义的声音ID，示例：&quot;vidu01&quot;。</p><p>入参限制：</p><ul><li>自定义的 voice_id 长度范围[8,256];</li><li>首字符必须为英文字母;</li><li>允许数字、字母、横线、下划线;</li><li>末位字符不可为 -、_</li><li>voice_id 不可与已有 id 重复，否则会报错.</li></ul>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>复刻试听参数。</p><p>参数格式：限制 1000 字符以内，模型将使用复刻后的音色朗读本段文本内容，并返回试听音频链接。 注：试听将根据字符数正常收取语音合成费用。</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>音色复刻示例音频。提供本参数将有助于增强语音合成的音色相似度和稳定性，若使用本参数，需同时上传一小段示例音频。</p><p>入参限制：注1：音频仅支持格式：mp3、m4a、wav； 注2：上传的音频文件的时长最少应小于 8 秒； 注3：上传的音频文件大小需不超过20mb。</p>
        /// </summary>
        [JsonProperty("PromptAudioFileInfo")]
        public AigcAudioCloneInputFileInfo PromptAudioFileInfo{ get; set; }

        /// <summary>
        /// <p>示例音频对应的文本内容 需确保和音频内容一致，句末需有标点符号做结尾。</p>
        /// </summary>
        [JsonProperty("PromptText")]
        public string PromptText{ get; set; }

        /// <summary>
        /// <p>透传参数。  入参限制：不做任何处理，仅数据传输 注：最多 1048576个字符</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>用于去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>来源上下文，用于透传用户请求信息，音画质重生完成回调将返回该字段值，最长 1000 个字符。</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>任务的优先级，数值越大优先级越高，取值范围是 -10 到 10，不填代表 0。</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>保留字段，特殊用途时使用。</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "AudioFileInfo.", this.AudioFileInfo);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "PromptAudioFileInfo.", this.PromptAudioFileInfo);
            this.SetParamSimple(map, prefix + "PromptText", this.PromptText);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

