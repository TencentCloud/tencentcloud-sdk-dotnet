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

    public class AIAssistantRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入分析对象内容，输入数据格式参考FileType参数释义
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 输入分析对象类型，picture_url:图片地址，vod_url:视频地址，live_url：直播地址，audio_url: 音频文件，picture：图片二进制数据的BASE64编码
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 音频源的语言，默认0为英文，1为中文
        /// </summary>
        [JsonProperty("Lang")]
        public long? Lang{ get; set; }

        /// <summary>
        /// 查询人员库列表
        /// </summary>
        [JsonProperty("LibrarySet")]
        public string[] LibrarySet{ get; set; }

        /// <summary>
        /// 视频评估时间，单位秒，点播场景默认值为2小时（无法探测长度时）或完整视频，直播场景默认值为10分钟或直播提前结束
        /// </summary>
        [JsonProperty("MaxVideoDuration")]
        public long? MaxVideoDuration{ get; set; }

        /// <summary>
        /// 标准化模板选择：0：AI助教基础版本，1：AI评教基础版本，2：AI评教标准版本。AI 助教基础版本功能包括：人脸检索、人脸检测、人脸表情识别、学生动作选项，音频信息分析，微笑识别。AI 评教基础版本功能包括：人脸检索、人脸检测、人脸表情识别、音频信息分析。AI 评教标准版功能包括人脸检索、人脸检测、人脸表情识别、手势识别、音频信息分析、音频关键词分析、视频精彩集锦分析。
        /// </summary>
        [JsonProperty("Template")]
        public long? Template{ get; set; }

        /// <summary>
        /// 识别词库名列表，评估过程使用这些词汇库中的词汇进行词汇使用行为分析
        /// </summary>
        [JsonProperty("VocabLibNameList")]
        public string[] VocabLibNameList{ get; set; }

        /// <summary>
        /// 语音编码类型 1:pcm
        /// </summary>
        [JsonProperty("VoiceEncodeType")]
        public long? VoiceEncodeType{ get; set; }

        /// <summary>
        /// 语音文件类型 1:raw, 2:wav, 3:mp3，10:视频（三种音频格式目前仅支持16k采样率16bit）
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
            this.SetParamSimple(map, prefix + "Template", this.Template);
            this.SetParamArraySimple(map, prefix + "VocabLibNameList.", this.VocabLibNameList);
            this.SetParamSimple(map, prefix + "VoiceEncodeType", this.VoiceEncodeType);
            this.SetParamSimple(map, prefix + "VoiceFileType", this.VoiceFileType);
        }
    }
}

