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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 人脸框左上角横坐标。
        /// 人脸框包含人脸五官位置并在此基础上进行一定的扩展，若人脸框超出图片范围，会导致坐标负值。 
        /// 若需截取完整人脸，可以在完整分completess满足需求的情况下，将负值坐标取0。
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// 人脸框左上角纵坐标。 
        /// 人脸框包含人脸五官位置并在此基础上进行一定的扩展，若人脸框超出图片范围，会导致坐标负值。 
        /// 若需截取完整人脸，可以在完整分completess满足需求的情况下，将负值坐标取0。
        /// </summary>
        [JsonProperty("Y")]
        public long? Y{ get; set; }

        /// <summary>
        /// 人脸框宽度。
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// 人脸框高度。
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 人脸属性信息，包含性别( gender )、年龄( age )、表情( expression )、 
        /// 魅力( beauty )、眼镜( glass )、口罩（mask）、头发（hair）和姿态 (pitch，roll，yaw )。只有当 NeedFaceAttributes 设为 1 时才返回有效信息。
        /// </summary>
        [JsonProperty("FaceAttributesInfo")]
        public FaceAttributesInfo FaceAttributesInfo{ get; set; }

        /// <summary>
        /// 人脸质量信息，包含质量分（score）、模糊分（sharpness）、光照分（brightness）、遮挡分（completeness）。只有当NeedFaceDetection设为1时才返回有效信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FaceQualityInfo")]
        public FaceQualityInfo FaceQualityInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamObj(map, prefix + "FaceAttributesInfo.", this.FaceAttributesInfo);
            this.SetParamObj(map, prefix + "FaceQualityInfo.", this.FaceQualityInfo);
        }
    }
}

