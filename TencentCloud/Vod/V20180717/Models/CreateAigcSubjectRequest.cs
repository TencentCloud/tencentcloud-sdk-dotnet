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

    public class CreateAigcSubjectRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>点播<a href="https://cloud.tencent.com/document/product/266/14574">应用</a> ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>主体名称。</p>
        /// </summary>
        [JsonProperty("SubjectName")]
        public string SubjectName{ get; set; }

        /// <summary>
        /// <p>主体图片，至少上传 1 张主体图片。* 注1：支持传入图片URL（确保可访问）；* 注2：最多支持输入 3 张图；* 注3：图片支持 png、jpeg、jpg、webp格式；* 注4：图片比例需要小于 1:4 或者 4:1 ；* 注5：图片大小不超过 50 MB；</p>
        /// </summary>
        [JsonProperty("SubjectImages")]
        public string[] SubjectImages{ get; set; }

        /// <summary>
        /// <p>视频参考支持上传 1 个主体视频</p><ul><li>注1：仅参考生viduq2-pro模型支持使用视频主体</li><li>注2：最多支持上传 1个5秒 的视频</li><li>注3：视频支持 mp4、avi、mov格式</li><li>注4：视频像素不能小于 128*128，且比例需要小于1:4或者4:1，且大小不超过100M。</li></ul>
        /// </summary>
        [JsonProperty("SubjectVideos")]
        public string[] SubjectVideos{ get; set; }

        /// <summary>
        /// <p>主体音色Id，该信息仅在创建音视频直出任务时使用</p><ul><li>注1：不传音色id 生成音视频直出任务时，系统会自动推荐音色</li><li>注2：q2-pro不支持使用音色id</li></ul>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>用于去重的识别码，如果三天内曾有过相同的识别码的请求，则本次的请求会返回错误。最长 50 个字符，不带或者带空字符串表示不做去重。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>来源上下文，用于透传用户请求信息，任务完成回调将返回该字段值，最长 1000 个字符。</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>任务的优先级，数值越大优先级越高，取值范围是 -10 到 10，不填代表 0。</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "SubjectName", this.SubjectName);
            this.SetParamArraySimple(map, prefix + "SubjectImages.", this.SubjectImages);
            this.SetParamArraySimple(map, prefix + "SubjectVideos.", this.SubjectVideos);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
        }
    }
}

