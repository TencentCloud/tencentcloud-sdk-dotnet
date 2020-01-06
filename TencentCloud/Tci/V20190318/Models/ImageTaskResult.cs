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

    public class ImageTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 大教室场景学生肢体动作识别信息
        /// </summary>
        [JsonProperty("ActionInfo")]
        public ActionInfo ActionInfo{ get; set; }

        /// <summary>
        /// 属性识别结果
        /// </summary>
        [JsonProperty("FaceAttr")]
        public FaceAttrResult FaceAttr{ get; set; }

        /// <summary>
        /// 表情识别结果
        /// </summary>
        [JsonProperty("FaceExpression")]
        public FaceExpressionResult FaceExpression{ get; set; }

        /// <summary>
        /// 人脸检索结果
        /// </summary>
        [JsonProperty("FaceIdentify")]
        public FaceIdentifyResult FaceIdentify{ get; set; }

        /// <summary>
        /// 人脸检测结果
        /// </summary>
        [JsonProperty("FaceInfo")]
        public FaceInfoResult FaceInfo{ get; set; }

        /// <summary>
        /// 姿势识别结果
        /// </summary>
        [JsonProperty("FacePose")]
        public FacePoseResult FacePose{ get; set; }

        /// <summary>
        /// 动作分类结果
        /// </summary>
        [JsonProperty("Gesture")]
        public GestureResult Gesture{ get; set; }

        /// <summary>
        /// 手势分类结果
        /// </summary>
        [JsonProperty("HandTracking")]
        public HandTrackingResult HandTracking{ get; set; }

        /// <summary>
        /// 光照识别结果
        /// </summary>
        [JsonProperty("Light")]
        public LightResult Light{ get; set; }

        /// <summary>
        /// 学生肢体动作识别结果
        /// </summary>
        [JsonProperty("StudentBodyMovement")]
        public StudentBodyMovementResult StudentBodyMovement{ get; set; }

        /// <summary>
        /// 老师肢体动作识别结果
        /// </summary>
        [JsonProperty("TeacherBodyMovement")]
        public BodyMovementResult TeacherBodyMovement{ get; set; }

        /// <summary>
        /// 教师是否在屏幕内判断结果
        /// </summary>
        [JsonProperty("TeacherOutScreen")]
        public TeacherOutScreenResult TeacherOutScreen{ get; set; }

        /// <summary>
        /// 时间统计结果
        /// </summary>
        [JsonProperty("TimeInfo")]
        public TimeInfoResult TimeInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ActionInfo.", this.ActionInfo);
            this.SetParamObj(map, prefix + "FaceAttr.", this.FaceAttr);
            this.SetParamObj(map, prefix + "FaceExpression.", this.FaceExpression);
            this.SetParamObj(map, prefix + "FaceIdentify.", this.FaceIdentify);
            this.SetParamObj(map, prefix + "FaceInfo.", this.FaceInfo);
            this.SetParamObj(map, prefix + "FacePose.", this.FacePose);
            this.SetParamObj(map, prefix + "Gesture.", this.Gesture);
            this.SetParamObj(map, prefix + "HandTracking.", this.HandTracking);
            this.SetParamObj(map, prefix + "Light.", this.Light);
            this.SetParamObj(map, prefix + "StudentBodyMovement.", this.StudentBodyMovement);
            this.SetParamObj(map, prefix + "TeacherBodyMovement.", this.TeacherBodyMovement);
            this.SetParamObj(map, prefix + "TeacherOutScreen.", this.TeacherOutScreen);
            this.SetParamObj(map, prefix + "TimeInfo.", this.TimeInfo);
        }
    }
}

