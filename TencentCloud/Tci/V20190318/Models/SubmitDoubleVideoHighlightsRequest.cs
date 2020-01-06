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

    public class SubmitDoubleVideoHighlightsRequest : AbstractModel
    {
        
        /// <summary>
        /// 学生视频url
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 需要检索的人脸合集库，不在库中的人脸将不参与精彩集锦；目前仅支持输入一个人脸库。
        /// </summary>
        [JsonProperty("LibIds")]
        public string[] LibIds{ get; set; }

        /// <summary>
        /// 详细功能开关配置项
        /// </summary>
        [JsonProperty("Functions")]
        public DoubleVideoFunction Functions{ get; set; }

        /// <summary>
        /// 需要匹配的人员信息列表。
        /// </summary>
        [JsonProperty("PersonInfoList")]
        public PersonInfo[] PersonInfoList{ get; set; }

        /// <summary>
        /// 视频处理的抽帧间隔，单位毫秒。建议留空。
        /// </summary>
        [JsonProperty("FrameInterval")]
        public long? FrameInterval{ get; set; }

        /// <summary>
        /// 旧版本需要匹配的人员信息列表。
        /// </summary>
        [JsonProperty("PersonIds")]
        public string[] PersonIds{ get; set; }

        /// <summary>
        /// 人脸检索的相似度阈值，默认值0.89。建议留空。
        /// </summary>
        [JsonProperty("SimThreshold")]
        public float? SimThreshold{ get; set; }

        /// <summary>
        /// 老师视频url
        /// </summary>
        [JsonProperty("TeacherFileContent")]
        public string TeacherFileContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamArraySimple(map, prefix + "LibIds.", this.LibIds);
            this.SetParamObj(map, prefix + "Functions.", this.Functions);
            this.SetParamArrayObj(map, prefix + "PersonInfoList.", this.PersonInfoList);
            this.SetParamSimple(map, prefix + "FrameInterval", this.FrameInterval);
            this.SetParamArraySimple(map, prefix + "PersonIds.", this.PersonIds);
            this.SetParamSimple(map, prefix + "SimThreshold", this.SimThreshold);
            this.SetParamSimple(map, prefix + "TeacherFileContent", this.TeacherFileContent);
        }
    }
}

