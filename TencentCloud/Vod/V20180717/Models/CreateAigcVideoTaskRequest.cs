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
        /// <p>模型名称。取值：<li>Hailuo：海螺；</li><li>Kling：可灵；</li><li> Jimeng：即梦；</li><li>Vidu；</li><li>Hunyuan：混元；</li><li>Mingmou：明眸；</li></p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型版本。取值：<li>当 ModelName 是 Hailuo，可选值为 02、2.3、2.3-fast；</li><li>当 ModelName 是 Kling，可选值为 1.6、2.0、2.1、2.5、O1；</li><li>当 ModelName 是 Jimeng，可选值为 3.0pro；</li><li>当 ModelName 是 Vidu，可选值为 q2、q2-pro、q2-turbo、q3-pro、q3-turbo；</li><li>当 ModelName 是 GV，可选值为 3.1、3.1-fast；</li><li>当 ModelName 是 OS，可选值为 2.0；</li><li>当 ModelName 是 Hunyuan，可选值为 1.5；</li><li>当 ModelName 是 Mingmou，可选值为 1.0；</li></p>
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>最多包含三张素材资源文件的列表，用于描述模型在生成视频时要使用的资源文件。</p><p>首尾帧视频生成：用 FileInfos 第一张表示首帧（此时 FileInfos 最多包含一张图片），LastFrameFileId 或者 LastFrameUrl 表示尾帧。</p><p>支持多图输入的模型：</p><ol><li>GV，使用多图输入时，不可使用 LastFrameFileId 和 LastFrameUrl。</li><li>Vidu，支持多图参考生视频。q2 模型1-7张图片，可通过 FileInfos 里面的 ObjectId 作为主体 id 来传入。</li></ol><p>注意：</p><ol><li>图片大小不超过10M。</li><li>支持的图片格式：jpeg、png。</li></ol>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskInputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>固定主体输入信息。</p>
        /// </summary>
        [JsonProperty("SubjectInfos")]
        public AigcVideoTaskInputSubjectInfo[] SubjectInfos{ get; set; }

        /// <summary>
        /// <p>用于作为尾帧画面来生成视频的媒体文件 ID。该文件在云点播上的全局唯一标识符，在上传成功后由云点播后台分配。可以在 <a href="/document/product/266/7830">视频上传完成事件通知</a> 或 <a href="https://console.cloud.tencent.com/vod/media">云点播控制台</a> 获取该字段。说明：</p><ol><li>只支持模型 GV 、Kling、Vidu，其他模型暂不支持。当 ModelName 为 GV 时，如果指定该参数，则需同时指定 FileInfos 作为待生成视频的首帧。当 ModelName 为 Kling 、ModelVersion 为 2.1 并且指定输出分辨率 Resolution 为 1080P 时，才能指定该参数。当 ModelName 为 Vidu、ModelVersion 为 q2-pro、q2-turbo 时，才能指定该参数。</li><li>图片大小需小于5M。</li><li>图片格式的取值为：jpeg，jpg, png, webp。</li></ol>
        /// </summary>
        [JsonProperty("LastFrameFileId")]
        public string LastFrameFileId{ get; set; }

        /// <summary>
        /// <p>用于作为尾帧画面来生成视频的媒体文件 URL。说明：</p><ol><li>只支持模型 GV 、Kling、Vidu，其他模型暂不支持。当 ModelName 为 GV 时，如果指定该参数，则需同时指定 FileInfos 作为待生成视频的首帧。当 ModelName 为 Kling 、ModelVersion 为 2.1 并且指定输出分辨率 Resolution 为 1080P 时，才能指定该参数。当 ModelName 为 Vidu、ModelVersion 为 q2-pro、q2-turbo 时，才能指定该参数。</li><li>图片大小需小于5M。</li><li><ol start="3"><li>图片格式的取值为：jpeg，jpg, png, webp。</li></ol></li></ol>
        /// </summary>
        [JsonProperty("LastFrameUrl")]
        public string LastFrameUrl{ get; set; }

        /// <summary>
        /// <p>生成视频的提示词。当 FileInfos 为空时，此参数必填。<br>示例值：move the picture</p>
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
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

