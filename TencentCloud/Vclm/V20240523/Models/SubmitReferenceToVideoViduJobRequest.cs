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

    public class SubmitReferenceToVideoViduJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文本提示词<br>生成视频的文本描述。<br>注1：字符长度不能超过 2000 个字符<br>注2：使用Subjects主体参数时，可以通过@主体id 来表示主体内容，例如：&quot;@1 和 @2 在一起吃火锅，并且旁白音说火锅大家都爱吃。&quot;</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>图像参考<br>【非主体调用时传入】<br>支持上传1～7张图片，模型将以此参数中传入的图片中的主题为参考生成具备主体一致的视频。<br>支持传入图片 Base64 编码或图片URL（确保可访问）<br>图片支持 png、jpeg、jpg、webp格式<br>图片像素不能小于 128*128，且比例需要小于1:4或者4:1，且大小不超过50M。</p>
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// <p>参考生图主体信息，支持1-7个主体，主体图片共1 ～ 7张<br>【主体调用时传入】</p>
        /// </summary>
        [JsonProperty("Subjects")]
        public ReferenceSubject[] Subjects{ get; set; }

        /// <summary>
        /// <p>视频参考支持上传1～2个视频，模型将以此参数中传入的视频作为参考，生成具备主体一致的视频。<br>注1： 仅viduq2-pro模型支持该参数<br>注2：使用视频参考功能时，最多支持上传 1个8秒 视频 或 2个5秒 视频<br>注3：视频支持 mp4、avi、mov格式<br>注4：视频像素不能小于 128*128，且比例需要小于1:4或者4:1，且大小不超过100M。</p>
        /// </summary>
        [JsonProperty("Videos")]
        public string[] Videos{ get; set; }

        /// <summary>
        /// <p>模型名称，可选值，当前仅可并且默认viduq2</p><ul><li>viduq2：最新模型</li></ul>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>是否使用音视频直出能力，默认false，可选值 true、false</p><ul><li>true：使用音视频直出能力。</li><li>false：不使用音视频直出能力。<br>仅上传主体时支持此功能</li></ul>
        /// </summary>
        [JsonProperty("Audio")]
        public bool? Audio{ get; set; }

        /// <summary>
        /// <p>音频类型，audio为true时必填，默认为all</p><p>枚举值：</p><ul><li>all： 音效+人声</li><li>speech_only： 仅人声</li><li>sound_effect_only： 仅音效</li></ul>
        /// </summary>
        [JsonProperty("AudioType")]
        public string AudioType{ get; set; }

        /// <summary>
        /// <p>是否为生成的视频添加背景音乐。<br>默认：false，可选值 true 、false<br>【仅支持非主体调用时生效】</p><ul><li>传 true 时系统将从预设 BGM 库中自动挑选合适的音乐并添加；不传或为 false 则不添加 BGM。</li><li>BGM不限制时长，系统根据视频时长自动适配</li><li>BGM参数在q2系列模型的duration为 9秒 或 10秒 时不生效</li></ul>
        /// </summary>
        [JsonProperty("Bgm")]
        public bool? Bgm{ get; set; }

        /// <summary>
        /// <p>视频时长参数：<br>默认5秒，可选：1-10（整数）</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>比例<br>默认值：16:9<br>【非主体调用时】<br>可选值如下：16:9、9:16、4:3、3:4、1:1</p><p>【主体调用时】<br>可选值如下：16:9、9:16、1:1<br>注：q2模型 支持任意宽高比</p>
        /// </summary>
        [JsonProperty("AspectRatio")]
        public string AspectRatio{ get; set; }

        /// <summary>
        /// <p>分辨率参数<br>默认 720p, 可选：540p、720p、1080p</p>
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// <p>运动幅度默认 auto，可选值：auto、small、medium、large<br>注：使用q2系列模型时该参数不生效</p>
        /// </summary>
        [JsonProperty("MovementAmplitude")]
        public string MovementAmplitude{ get; set; }

        /// <summary>
        /// <p>元数据标识，json格式字符串，透传字段，您可以 自定义格式 或使用 示例格式 ，示例如下：<br>{<br>&quot;Label&quot;: &quot;your_label&quot;,&quot;ContentProducer&quot;: &quot;yourcontentproducer&quot;,&quot;ContentPropagator&quot;: &quot;your_content_propagator&quot;,&quot;ProduceID&quot;: &quot;yourproductid&quot;, &quot;PropagateID&quot;: &quot;your_propagate_id&quot;,&quot;ReservedCode1&quot;: &quot;yourreservedcode1&quot;, &quot;ReservedCode2&quot;: &quot;your_reserved_code2&quot;<br>}<br>该参数为空时，默认使用vidu生成的元数据标识</p>
        /// </summary>
        [JsonProperty("MetaData")]
        public string MetaData{ get; set; }

        /// <summary>
        /// <p>Callback 协议<br>需要您在创建任务时主动设置 callback_url，请求方法为 POST，当视频生成完成时，将向此地址发送包含任务最新状态的回调请求。回调请求内容结构与查询任务API的返回体一致<br>回调返回的&quot;status&quot;包括以下状态：</p><ul><li>success 任务完成（如发送失败，回调三次）</li><li>failed 任务失败（如发送失败，回调三次）</li></ul>
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// <p>透传参数不做任何处理，仅数据传输注：最多 1048576个字符</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>错峰模式，默认为：false，可选值：</p><ul><li>true：错峰生成视频；</li><li>false：即时生成视频；<br>注1：错峰模式消耗的积分更低<br>注2：错峰模式下提交的任务，会在48小时内生成，未能完成的任务会被自动取消，并返还该任务的积分</li></ul>
        /// </summary>
        [JsonProperty("OffPeak")]
        public bool? OffPeak{ get; set; }

        /// <summary>
        /// <p>为生成结果图添加显式水印标识的开关，默认为1。<br>1：添加。<br>0：不添加。<br>其他数值：默认按1处理。<br>建议您使用显著标识来提示结果图使用了 AI 绘画技术，是 AI 生成的图片。<br>示例值：1</p>
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// <p>标识内容设置。<br>默认在生成结果图右下角添加“图片由 AI 生成”字样，您可根据自身需要替换为其他的标识图片。</p>
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamArrayObj(map, prefix + "Subjects.", this.Subjects);
            this.SetParamArraySimple(map, prefix + "Videos.", this.Videos);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Audio", this.Audio);
            this.SetParamSimple(map, prefix + "AudioType", this.AudioType);
            this.SetParamSimple(map, prefix + "Bgm", this.Bgm);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "AspectRatio", this.AspectRatio);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "MovementAmplitude", this.MovementAmplitude);
            this.SetParamSimple(map, prefix + "MetaData", this.MetaData);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "OffPeak", this.OffPeak);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

