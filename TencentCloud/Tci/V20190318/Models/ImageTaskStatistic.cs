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

    public class ImageTaskStatistic : AbstractModel
    {
        
        /// <summary>
        /// 人员检测统计信息
        /// </summary>
        [JsonProperty("FaceDetect")]
        public FaceDetectStatistic[] FaceDetect{ get; set; }

        /// <summary>
        /// 人脸表情统计信息
        /// </summary>
        [JsonProperty("FaceExpression")]
        public FaceExpressStatistic[] FaceExpression{ get; set; }

        /// <summary>
        /// 人脸检索统计信息
        /// </summary>
        [JsonProperty("FaceIdentify")]
        public FaceIdentifyStatistic[] FaceIdentify{ get; set; }

        /// <summary>
        /// 姿势识别统计信息
        /// </summary>
        [JsonProperty("Gesture")]
        public ActionStatistic Gesture{ get; set; }

        /// <summary>
        /// 手势识别统计信息
        /// </summary>
        [JsonProperty("Handtracking")]
        public ActionStatistic Handtracking{ get; set; }

        /// <summary>
        /// 光照统计信息
        /// </summary>
        [JsonProperty("Light")]
        public LightStatistic Light{ get; set; }

        /// <summary>
        /// 学生动作统计信息
        /// </summary>
        [JsonProperty("StudentMovement")]
        public ActionStatistic StudentMovement{ get; set; }

        /// <summary>
        /// 教师动作统计信息
        /// </summary>
        [JsonProperty("TeacherMovement")]
        public ActionStatistic TeacherMovement{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FaceDetect.", this.FaceDetect);
            this.SetParamArrayObj(map, prefix + "FaceExpression.", this.FaceExpression);
            this.SetParamArrayObj(map, prefix + "FaceIdentify.", this.FaceIdentify);
            this.SetParamObj(map, prefix + "Gesture.", this.Gesture);
            this.SetParamObj(map, prefix + "Handtracking.", this.Handtracking);
            this.SetParamObj(map, prefix + "Light.", this.Light);
            this.SetParamObj(map, prefix + "StudentMovement.", this.StudentMovement);
            this.SetParamObj(map, prefix + "TeacherMovement.", this.TeacherMovement);
        }
    }
}

