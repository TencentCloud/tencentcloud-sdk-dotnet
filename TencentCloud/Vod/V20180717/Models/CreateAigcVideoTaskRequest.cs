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

    public class CreateAigcVideoTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>模型名称。取值：<br>Kling：可灵；<br>Vidu；<br>Hailuo：海螺；<br>Jimeng：即梦；<br>Hunyuan：混元；<br>Mingmou：明眸；<br>GV；<br>OS；<br>PixVerse;</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型版本。取值：<br>当 ModelName 是 Hailuo，可选值为 02、2.3、2.3-fast；<br>当 ModelName 是 Kling，可选值为 1.6、2.0、2.1、2.5、2.6、O1、3.0、3.0-Omni；<br>当 ModelName 是 Jimeng，可选值为 3.0pro；<br>当 ModelName 是 Vidu，可选值为 q2、q2-pro、q2-turbo、q3、q3-pro、q3-turbo；<br>当 ModelName 是 GV，可选值为 3.1、3.1-fast；<br>当 ModelName 是 OS，可选值为 2.0；<br>当 ModelName 是 Hunyuan，可选值为 1.5；<br>当 ModelName 是 Mingmou，可选值为 1.0；<br>当 ModelName 是 PixVerse，可选值为 v5.6、v6、c1；</p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>用于描述模型在生成视频时要使用的资源文件，分为<strong>首尾帧模式、参考图、视频参考、视频编辑等模式</strong>。</p><p><strong>首尾帧视频生成</strong>：首帧图片只支持<strong>一张</strong>图片，<strong>图片的Usage字段为FirstFrame</strong>，LastFrameFileId 或者 LastFrameUrl 表示尾帧。可以单独传首帧，不能单独传尾帧。<strong>首尾帧生成会参考图片比例</strong>。<br><strong>参考图片生成</strong>：可传入单张图片或者多张，<strong>图片的Usage字段为Reference</strong>；参考图片，可以调整生成视频的宽高比例。<br><strong>视频编辑、视频参考</strong>：Vidu、Kling可输入视频作为参考或者进行编辑。传入视频的同时也可以传入图片，<strong>图片的Usage字段为Reference</strong>。</p><p>注意：</p><ol><li>图片大小不超过10M。</li><li>支持的图片格式：jpeg、jpg、png。x0b</li><li>关于模型某个版本是否支持参考图、首尾帧、视频编辑等功能，可向我们索取文档或者参考原厂文档信息。</li></ol>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>固定主体输入信息。</p>
        /// </summary>
        [JsonProperty("SubjectInfos")]
        public AigcVideoTaskInputSubjectInfo[] SubjectInfos{ get; set; }

        /// <summary>
        /// <p>用于作为尾帧画面来生成视频的媒体文件 ID。该文件在云点播上的全局唯一标识符，在上传成功后由云点播后台分配。可以在 <a href="/document/product/266/7830">视频上传完成事件通知</a> 或 <a href="https://console.cloud.tencent.com/vod/media">云点播控制台</a> 获取该字段。</p><ol><li>指定该参数时，须同时通过 FileInfos 指定首帧画面。</li><li>图片大小需小于10M。</li><li>图片格式的取值为：jpeg，jpg, png, webp。</li></ol>
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// <p>用于作为尾帧画面来生成视频的媒体文件 URL。说明：</p><ol><li>指定该参数时，须同时通过 FileInfos 指定首帧画面。</li><li>图片大小需小于5M。</li><li>图片格式的取值为：jpeg，jpg, png, webp。</li></ol>
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// <p>生成视频的提示词。<br>当未传入参考文件，没有使用场景类型，ExtInfo不为空，Prompt 为必填。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>要阻止模型生成视频的提示词。</p>
        /// </summary>
        [JsonProperty("NegativePrompt")]
        public string NegativePrompt{ get; set; }

        /// <summary>
        /// <p>是否自动优化提示词。开启时将自动优化传入的 Prompt，以提升生成质量。取值有： <li>Enabled：开启；</li> <li>Disabled：关闭；</li></p>
        /// </summary>
        [JsonProperty("EnhancePrompt")]
        public string EnhancePrompt{ get; set; }

        /// <summary>
        /// <p>生视频任务的输出媒体文件配置。</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public AigcVideoOutputConfig OutputConfig{ get; set; }

        /// <summary>
        /// <p>输入文件的区域信息。当文件url是国外地址时候，可选Oversea。默认Mainland。</p>
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// <p>场景类型。取值如下：</p><li>当 ModelName 为 Kling 时：    motion_control 表示动作控制；    avatar_i2v 表示数字人；    lip_sync 表示对口型；</li><li>当 ModelName 为 Vidu 时：    template_effect 表示特效模板；</li><li>其他 ModelName 暂不支持。</li>
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// <p>模型随机种子。</p>
        /// </summary>
        [JsonProperty("Seed")]
        public long? Seed{ get; set; }

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
        /// <p>保留字段，特殊用途时使用。<br>可用于传入模型特殊参数、分镜prompt等</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArrayObj(map, prefix + "SubjectInfos.", this.SubjectInfos);
            this.SetParamSimple(map, prefix + "LastFrameFileId", this.LastFrameFileId);
            this.SetParamSimple(map, prefix + "LastFrameUrl", this.LastFrameUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamSimple(map, prefix + "NegativePrompt", this.NegativePrompt);
            this.SetParamSimple(map, prefix + "EnhancePrompt", this.EnhancePrompt);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

