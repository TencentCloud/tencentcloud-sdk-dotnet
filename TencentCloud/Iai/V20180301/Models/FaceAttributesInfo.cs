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

    public class FaceAttributesInfo : AbstractModel
    {
        
        /// <summary>
        /// 性别[0~49]为女性，[50，100]为男性，越接近0和100表示置信度越高。NeedFaceAttributes 不为 1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 年龄 [0~100]。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 微笑[0(normal，正常)~50(smile，微笑)~100(laugh，大笑)]。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Expression")]
        public long? Expression{ get; set; }

        /// <summary>
        /// 是否有眼镜 [true,false]。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Glass")]
        public bool? Glass{ get; set; }

        /// <summary>
        /// 上下偏移[-30,30]，单位角度。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。 
        /// 建议：人脸入库选择[-10,10]的图片。
        /// </summary>
        [JsonProperty("Pitch")]
        public long? Pitch{ get; set; }

        /// <summary>
        /// 左右偏移[-30,30]，单位角度。 NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。 
        /// 建议：人脸入库选择[-10,10]的图片。
        /// </summary>
        [JsonProperty("Yaw")]
        public long? Yaw{ get; set; }

        /// <summary>
        /// 平面旋转[-180,180]，单位角度。 NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。  
        /// 建议：人脸入库选择[-20,20]的图片。
        /// </summary>
        [JsonProperty("Roll")]
        public long? Roll{ get; set; }

        /// <summary>
        /// 魅力[0~100]。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Beauty")]
        public long? Beauty{ get; set; }

        /// <summary>
        /// 是否有帽子 [true,false]。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hat")]
        public bool? Hat{ get; set; }

        /// <summary>
        /// 是否有口罩 [true,false]。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mask")]
        public bool? Mask{ get; set; }

        /// <summary>
        /// 头发信息，包含头发长度（length）、有无刘海（bang）、头发颜色（color）。NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Hair")]
        public FaceHairAttributesInfo Hair{ get; set; }

        /// <summary>
        /// 双眼是否睁开 [true,false]。只要有超过一只眼睛闭眼，就返回false。 NeedFaceAttributes 不为1 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EyeOpen")]
        public bool? EyeOpen{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Expression", this.Expression);
            this.SetParamSimple(map, prefix + "Glass", this.Glass);
            this.SetParamSimple(map, prefix + "Pitch", this.Pitch);
            this.SetParamSimple(map, prefix + "Yaw", this.Yaw);
            this.SetParamSimple(map, prefix + "Roll", this.Roll);
            this.SetParamSimple(map, prefix + "Beauty", this.Beauty);
            this.SetParamSimple(map, prefix + "Hat", this.Hat);
            this.SetParamSimple(map, prefix + "Mask", this.Mask);
            this.SetParamObj(map, prefix + "Hair.", this.Hair);
            this.SetParamSimple(map, prefix + "EyeOpen", this.EyeOpen);
        }
    }
}

