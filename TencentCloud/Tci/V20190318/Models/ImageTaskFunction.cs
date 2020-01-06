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

    public class ImageTaskFunction : AbstractModel
    {
        
        /// <summary>
        /// 大教室场景学生肢体动作识别选项
        /// </summary>
        [JsonProperty("EnableActionClass")]
        public bool? EnableActionClass{ get; set; }

        /// <summary>
        /// 人脸检测选项
        /// </summary>
        [JsonProperty("EnableFaceDetect")]
        public bool? EnableFaceDetect{ get; set; }

        /// <summary>
        /// 人脸表情识别选项
        /// </summary>
        [JsonProperty("EnableFaceExpression")]
        public bool? EnableFaceExpression{ get; set; }

        /// <summary>
        /// 人脸检索选项
        /// </summary>
        [JsonProperty("EnableFaceIdentify")]
        public bool? EnableFaceIdentify{ get; set; }

        /// <summary>
        /// 手势选项
        /// </summary>
        [JsonProperty("EnableGesture")]
        public bool? EnableGesture{ get; set; }

        /// <summary>
        /// 优图手势选项（该功能尚未支持）
        /// </summary>
        [JsonProperty("EnableHandTracking")]
        public bool? EnableHandTracking{ get; set; }

        /// <summary>
        /// 光照选项
        /// </summary>
        [JsonProperty("EnableLightJudge")]
        public bool? EnableLightJudge{ get; set; }

        /// <summary>
        /// 小班课场景学生肢体动作识别选项
        /// </summary>
        [JsonProperty("EnableStudentBodyMovements")]
        public bool? EnableStudentBodyMovements{ get; set; }

        /// <summary>
        /// 教师动作选项（该功能尚未支持）
        /// </summary>
        [JsonProperty("EnableTeacherBodyMovements")]
        public bool? EnableTeacherBodyMovements{ get; set; }

        /// <summary>
        /// 判断老师是否在屏幕中
        /// </summary>
        [JsonProperty("EnableTeacherOutScreen")]
        public bool? EnableTeacherOutScreen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableActionClass", this.EnableActionClass);
            this.SetParamSimple(map, prefix + "EnableFaceDetect", this.EnableFaceDetect);
            this.SetParamSimple(map, prefix + "EnableFaceExpression", this.EnableFaceExpression);
            this.SetParamSimple(map, prefix + "EnableFaceIdentify", this.EnableFaceIdentify);
            this.SetParamSimple(map, prefix + "EnableGesture", this.EnableGesture);
            this.SetParamSimple(map, prefix + "EnableHandTracking", this.EnableHandTracking);
            this.SetParamSimple(map, prefix + "EnableLightJudge", this.EnableLightJudge);
            this.SetParamSimple(map, prefix + "EnableStudentBodyMovements", this.EnableStudentBodyMovements);
            this.SetParamSimple(map, prefix + "EnableTeacherBodyMovements", this.EnableTeacherBodyMovements);
            this.SetParamSimple(map, prefix + "EnableTeacherOutScreen", this.EnableTeacherOutScreen);
        }
    }
}

