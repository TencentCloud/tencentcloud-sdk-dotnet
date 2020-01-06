/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitPartialBodyClassTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入分析对象内容，输入数据格式参考FileType参数释义
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 输入分析对象类型，picture_url:图片地址，vod_url:视频地址，live_url：直播地址，picture: 图片二进制数据的BASE64编码
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 音频源的语言，默认0为英文，1为中文
        /// </summary>
        [JsonProperty("Lang")]
        public long? Lang{ get; set; }

        /// <summary>
        /// 查询人员库列表，可填写老师的注册照所在人员库
        /// </summary>
        [JsonProperty("LibrarySet")]
        public string[] LibrarySet{ get; set; }

        /// <summary>
        /// 视频评估时间，单位秒，点播场景默认值为2小时（无法探测长度时）或完整视频，直播场景默认值为10分钟或直播提前结束
        /// </summary>
        [JsonProperty("MaxVideoDuration")]
        public long? MaxVideoDuration{ get; set; }

        /// <summary>
        /// 识别词库名列表，这些词汇库用来维护关键词，评估老师授课过程中，对这些关键词的使用情况
        /// </summary>
        [JsonProperty("VocabLibNameList")]
        public string[] VocabLibNameList{ get; set; }

        /// <summary>
        /// 语音编码类型 1:pcm，当FileType为vod_url或live_url时为必填
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public long? VoiceEncodeType{ get; set; }

        /// <summary>
        /// 语音文件类型 10:视频（三种音频格式目前仅支持16k采样率16bit），当FileType为vod_url或live_url时为必填
        /// </summary>
        [JsonProperty("VoiceFileType")]
        public long? VoiceFileType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Lang", this.Lang);
            this.SetParamArraySimple(map, prefix + "LibrarySet.", this.LibrarySet);
            this.SetParamSimple(map, prefix + "MaxVideoDuration", this.MaxVideoDuration);
            this.SetParamArraySimple(map, prefix + "VocabLibNameList.", this.VocabLibNameList);
            this.SetParamSimple(map, prefix + "VoiceEncodeType", this.VoiceEncodeType);
            this.SetParamSimple(map, prefix + "VoiceFileType", this.VoiceFileType);
        }
    }
}

