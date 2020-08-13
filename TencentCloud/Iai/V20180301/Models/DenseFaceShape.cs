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

    public class DenseFaceShape : AbstractModel
    {
        
        /// <summary>
        /// 人脸框左上角横坐标。
        /// </summary>
        [JsonProperty("X")]
        public long? X{ get; set; }

        /// <summary>
        /// 人脸框左上角纵坐标。
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
        /// 描述左侧眼睛轮廓的 XX 点。
        /// </summary>
        [JsonProperty("LeftEye")]
        public Point[] LeftEye{ get; set; }

        /// <summary>
        /// 描述右侧眼睛轮廓的 XX 点。
        /// </summary>
        [JsonProperty("RightEye")]
        public Point[] RightEye{ get; set; }

        /// <summary>
        /// 描述左侧眉毛轮廓的 XX 点。
        /// </summary>
        [JsonProperty("LeftEyeBrow")]
        public Point[] LeftEyeBrow{ get; set; }

        /// <summary>
        /// 描述右侧眉毛轮廓的 XX 点。
        /// </summary>
        [JsonProperty("RightEyeBrow")]
        public Point[] RightEyeBrow{ get; set; }

        /// <summary>
        /// 描述外嘴巴轮廓的 XX 点， 从左侧开始逆时针返回。
        /// </summary>
        [JsonProperty("MouthOutside")]
        public Point[] MouthOutside{ get; set; }

        /// <summary>
        /// 描述内嘴巴轮廓的 XX 点，从左侧开始逆时针返回。
        /// </summary>
        [JsonProperty("MouthInside")]
        public Point[] MouthInside{ get; set; }

        /// <summary>
        /// 描述鼻子轮廓的 XX 点。
        /// </summary>
        [JsonProperty("Nose")]
        public Point[] Nose{ get; set; }

        /// <summary>
        /// 左瞳孔轮廓的 XX 个点。
        /// </summary>
        [JsonProperty("LeftPupil")]
        public Point[] LeftPupil{ get; set; }

        /// <summary>
        /// 右瞳孔轮廓的 XX 个点。
        /// </summary>
        [JsonProperty("RightPupil")]
        public Point[] RightPupil{ get; set; }

        /// <summary>
        /// 中轴线轮廓的 XX 个点。
        /// </summary>
        [JsonProperty("CentralAxis")]
        public Point[] CentralAxis{ get; set; }

        /// <summary>
        /// 下轮廓的 XX 个点。
        /// </summary>
        [JsonProperty("Chin")]
        public Point[] Chin{ get; set; }

        /// <summary>
        /// 左眼袋的 XX 个点。
        /// </summary>
        [JsonProperty("LeftEyeBags")]
        public Point[] LeftEyeBags{ get; set; }

        /// <summary>
        /// 右眼袋的 XX 个点。
        /// </summary>
        [JsonProperty("RightEyeBags")]
        public Point[] RightEyeBags{ get; set; }

        /// <summary>
        /// 额头的 XX 个点。
        /// </summary>
        [JsonProperty("Forehead")]
        public Point[] Forehead{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamArrayObj(map, prefix + "LeftEye.", this.LeftEye);
            this.SetParamArrayObj(map, prefix + "RightEye.", this.RightEye);
            this.SetParamArrayObj(map, prefix + "LeftEyeBrow.", this.LeftEyeBrow);
            this.SetParamArrayObj(map, prefix + "RightEyeBrow.", this.RightEyeBrow);
            this.SetParamArrayObj(map, prefix + "MouthOutside.", this.MouthOutside);
            this.SetParamArrayObj(map, prefix + "MouthInside.", this.MouthInside);
            this.SetParamArrayObj(map, prefix + "Nose.", this.Nose);
            this.SetParamArrayObj(map, prefix + "LeftPupil.", this.LeftPupil);
            this.SetParamArrayObj(map, prefix + "RightPupil.", this.RightPupil);
            this.SetParamArrayObj(map, prefix + "CentralAxis.", this.CentralAxis);
            this.SetParamArrayObj(map, prefix + "Chin.", this.Chin);
            this.SetParamArrayObj(map, prefix + "LeftEyeBags.", this.LeftEyeBags);
            this.SetParamArrayObj(map, prefix + "RightEyeBags.", this.RightEyeBags);
            this.SetParamArrayObj(map, prefix + "Forehead.", this.Forehead);
        }
    }
}

