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

    public class FaceDetailAttributesInfo : AbstractModel
    {
        
        /// <summary>
        /// 年龄 [0,65]，其中65代表“65岁及以上”。 
        /// FaceAttributesType 不为含Age 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 美丑打分[0,100]。 
        /// FaceAttributesType 不含 Beauty 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Beauty")]
        public long? Beauty{ get; set; }

        /// <summary>
        /// 情绪，可识别自然、高兴、惊讶、生气、悲伤、厌恶、害怕。 
        /// AttributeItem对应的Type为 —— 0：自然，1：高兴，2：惊讶，3：生气，4：悲伤，5：厌恶，6：害怕
        /// FaceAttributesType 不含Emotion 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Emotion")]
        public AttributeItem Emotion{ get; set; }

        /// <summary>
        /// 眼睛相关信息，可识别是否戴眼镜、是否闭眼、是否双眼皮和眼睛大小。 
        /// FaceAttributesType 不含Eye 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Eye")]
        public Eye Eye{ get; set; }

        /// <summary>
        /// 眉毛相关信息，可识别眉毛浓密、弯曲、长短信息。 
        /// FaceAttributesType 不含Eyebrow 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Eyebrow")]
        public Eyebrow Eyebrow{ get; set; }

        /// <summary>
        /// 性别信息。 
        /// AttributeItem对应的Type为 —— 	0：男性，1：女性。
        /// FaceAttributesType 不含Gender 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Gender")]
        public AttributeItem Gender{ get; set; }

        /// <summary>
        /// 头发信息，包含头发长度、有无刘海、头发颜色。 
        /// FaceAttributesType 不含Hair 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Hair")]
        public Hair Hair{ get; set; }

        /// <summary>
        /// 帽子信息，可识别是否佩戴帽子、帽子款式、帽子颜色。 
        /// FaceAttributesType 不含Hat 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Hat")]
        public Hat Hat{ get; set; }

        /// <summary>
        /// 姿态信息，包含人脸的上下偏移、左右偏移、平面旋转信息。 
        /// FaceAttributesType 不含Headpose 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("HeadPose")]
        public HeadPose HeadPose{ get; set; }

        /// <summary>
        /// 口罩佩戴信息。 
        /// AttributeItem对应的Type为 —— 0: 无口罩， 1: 有口罩不遮脸，2: 有口罩遮下巴，3: 有口罩遮嘴，4: 正确佩戴口罩。
        /// FaceAttributesType 不含Mask 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Mask")]
        public AttributeItem Mask{ get; set; }

        /// <summary>
        /// 嘴巴信息，可识别是否张嘴、嘴唇厚度。 
        /// FaceAttributesType 不含 Mouth 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Mouth")]
        public Mouth Mouth{ get; set; }

        /// <summary>
        /// 胡子信息。
        /// AttributeItem对应的Type为 —— 0：无胡子，1：有胡子。 
        /// FaceAttributesType 不含 Moustache 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Moustache")]
        public AttributeItem Moustache{ get; set; }

        /// <summary>
        /// 鼻子信息。 
        /// AttributeItem对应的Type为 —— 0：朝天鼻，1：鹰钩鼻，2：普通，3：圆鼻头
        /// FaceAttributesType 不含 Nose 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Nose")]
        public AttributeItem Nose{ get; set; }

        /// <summary>
        /// 脸型信息。 
        /// AttributeItem对应的Type为 —— 0：方脸，1：三角脸，2：鹅蛋脸，3：心形脸，4：圆脸。
        /// FaceAttributesType 不含 Shape 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Shape")]
        public AttributeItem Shape{ get; set; }

        /// <summary>
        /// 肤色信息。 
        /// AttributeItem对应的Type为 —— 0：黄色皮肤，1：棕色皮肤，2：黑色皮肤，3：白色皮肤。
        /// FaceAttributesType 不含 Skin 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Skin")]
        public AttributeItem Skin{ get; set; }

        /// <summary>
        /// 微笑程度，[0,100]。 
        /// FaceAttributesType 不含 Smile 或检测超过 5 张人脸时，此参数仍返回，但不具备参考意义。
        /// </summary>
        [JsonProperty("Smile")]
        public long? Smile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Beauty", this.Beauty);
            this.SetParamObj(map, prefix + "Emotion.", this.Emotion);
            this.SetParamObj(map, prefix + "Eye.", this.Eye);
            this.SetParamObj(map, prefix + "Eyebrow.", this.Eyebrow);
            this.SetParamObj(map, prefix + "Gender.", this.Gender);
            this.SetParamObj(map, prefix + "Hair.", this.Hair);
            this.SetParamObj(map, prefix + "Hat.", this.Hat);
            this.SetParamObj(map, prefix + "HeadPose.", this.HeadPose);
            this.SetParamObj(map, prefix + "Mask.", this.Mask);
            this.SetParamObj(map, prefix + "Mouth.", this.Mouth);
            this.SetParamObj(map, prefix + "Moustache.", this.Moustache);
            this.SetParamObj(map, prefix + "Nose.", this.Nose);
            this.SetParamObj(map, prefix + "Shape.", this.Shape);
            this.SetParamObj(map, prefix + "Skin.", this.Skin);
            this.SetParamSimple(map, prefix + "Smile", this.Smile);
        }
    }
}

